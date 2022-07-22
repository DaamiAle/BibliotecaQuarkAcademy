using DataObjects.src;
using Models.src.DatabaseContext;
using Models.src.Entities;
using Repositories.src;
using Util.src.CustomExceptions.PrestamoExceptions;

namespace Services.src
{
    public class PrestamoService
    {
        private readonly PrestamoRepository prestamoRepository;
        public PrestamoService(ProjectContext context)
        {
            prestamoRepository = new(context);
        }
        public EjemplarDTO PrestarEjemplar(string codigoISBN, int numIdentificacionSocio)
        {
            PrestamoModel prestamoModel = prestamoRepository.CreatePrestamo(codigoISBN, numIdentificacionSocio);
            
            EjemplarDTO ejemplarDTO = new();
            ejemplarDTO.EstaPrestado(true);
            ejemplarDTO.NumEdicion(prestamoModel.Ejemplar.NumEdicion);
            ejemplarDTO.Ubicacion(prestamoModel.Ejemplar.Ubicacion);
            ejemplarDTO.Libro(new());
            ejemplarDTO.Libro().CodigoISBN(prestamoModel.Ejemplar.Libro.CodigoISBN);
            ejemplarDTO.Libro().Nombre(prestamoModel.Ejemplar.Libro.Nombre);
            ejemplarDTO.Libro().Autor(prestamoModel.Ejemplar.Libro.Autor);
            return ejemplarDTO;
        }
        public void DevolverEjemplar(int numEdicion, string codigoISBN, int numIdentificacionSocio)
        {
            if (!prestamoRepository.ExistePrestamoPendiente(numEdicion, codigoISBN, numIdentificacionSocio))
            {
                throw new PrestamoNotFoundException(codigoISBN,numIdentificacionSocio);
            }
            prestamoRepository.DevolverEjemplar(numEdicion, codigoISBN, numIdentificacionSocio);
        }

        public List<PrestamoDTO> HistorialPrestamos()
        {
            List<PrestamoModel> prestamos = prestamoRepository.GetPrestamos();
            List<PrestamoDTO> prestamosDTO = new List<PrestamoDTO>();
            prestamos.ForEach(it =>
            {
                prestamosDTO.Add(new PrestamoDTO(it.FechaPrestamo, it.EstaFinalizado, new(), new()));
                
                prestamosDTO.Last().Ejemplar().NumEdicion(it.Ejemplar.NumEdicion);//
                prestamosDTO.Last().Ejemplar().Ubicacion(it.Ejemplar.Ubicacion);
                prestamosDTO.Last().Ejemplar().Libro(new());
                prestamosDTO.Last().Ejemplar().Libro().CodigoISBN(it.Ejemplar.Libro.CodigoISBN);
                prestamosDTO.Last().Ejemplar().Libro().Nombre(it.Ejemplar.Libro.Nombre);
                prestamosDTO.Last().Ejemplar().Libro().Autor(it.Ejemplar.Libro.Autor);
                prestamosDTO.Last().Socio().Nombre(it.Socio.Nombre);
                prestamosDTO.Last().Socio().Apellido(it.Socio.Apellido);
                prestamosDTO.Last().Socio().NumIdentificacion(it.Socio.NumIdentificacion);
                prestamosDTO.Last().Socio().EsVIP(it.Socio.EsVIP);
                prestamosDTO.Last().Socio().CuotaSocio(it.Socio.CuotaSocio);
            });
            return prestamosDTO;
        }
    }
}
