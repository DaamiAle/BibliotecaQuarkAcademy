using DataObjects.src;
using Models.src.DatabaseContext;
using Models.src.Entities;
using Repositories.src;

namespace Services.src
{
    public class PrestamoService
    {
        private readonly PrestamoRepository prestamoRepository;
        public PrestamoService(ProjectContext context)
        {
            prestamoRepository = new(context);
        }
        public void CreatePrestamo(string codigoISBN, int numIdentificacionSocio, DateTime dateTime)
        {
            prestamoRepository.CreatePrestamo(codigoISBN, numIdentificacionSocio, dateTime);
        }
        public List<PrestamoDTO> GetAll()
        {
            List<PrestamoModel> prestamos = prestamoRepository.GetAll();
            List<PrestamoDTO> prestamosDTO = new List<PrestamoDTO>();
            prestamos.ForEach(it =>
            {
                prestamosDTO.Add(new PrestamoDTO(it.FechaPrestamo, it.EstaFinalizado, new(), new()));
                prestamosDTO.Last().Ejemplar().NumEdicion(it.Ejemplar.NumEdicion);
                prestamosDTO.Last().Ejemplar().Ubicacion(it.Ejemplar.Ubicacion);
                #region Libro
                prestamosDTO.Last().Ejemplar().Libro(new());
                prestamosDTO.Last().Ejemplar().Libro().CodigoISBN(it.Ejemplar.Libro.CodigoISBN);
                prestamosDTO.Last().Ejemplar().Libro().Nombre(it.Ejemplar.Libro.Nombre);
                prestamosDTO.Last().Ejemplar().Libro().Autor(it.Ejemplar.Libro.Autor);
                #endregion
                #region Socio
                prestamosDTO.Last().Socio().Nombre(it.Socio.Nombre);
                prestamosDTO.Last().Socio().Apellido(it.Socio.Apellido);
                prestamosDTO.Last().Socio().NumIdentificacion(it.Socio.NumIdentificacion);
                prestamosDTO.Last().Socio().EsVIP(it.Socio.EsVIP);
                prestamosDTO.Last().Socio().CuotaSocio(it.Socio.CuotaSocio);
                #endregion
            });
            return prestamosDTO;
        }
    }
}
