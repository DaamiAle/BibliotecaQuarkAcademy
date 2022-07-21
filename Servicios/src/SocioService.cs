using DataObjects.src;
using Models.src.DatabaseContext;
using Models.src.Entities;
using Repositories.src;
using Util.src.CustomExceptions.SocioExceptions;

namespace Services.src
{
    public class SocioService
    {
        private SocioRepository socioRepository;

        public SocioService(ProjectContext context)
        {
            socioRepository = new(context);
        }
        /*
        
        public SocioModel GetSocioModelByIdentificacion(int numIdentificacion) {
            SocioModel socioModel = socioRepository.GetByIdentificacion(numIdentificacion);
            if (socioModel.GetType() == typeof(SocioModel))
            {
                return socioModel;
            }
            else
            {
                throw new SocioNotFoundException();
            }
        }
        public SocioDTO GetByNumIdentificacion(int numIdentificacionSocio)
        {
            SocioModel socioModel = GetSocioModelByIdentificacion(numIdentificacionSocio);
            SocioDTO socioDTO = new();
            socioDTO.Nombre(socioModel.Nombre);
            socioDTO.Apellido(socioModel.Apellido);
            socioDTO.NumIdentificacion(socioModel.NumIdentificacion);
            socioDTO.EsVIP(socioModel.EsVIP);
            socioDTO.CuotaSocio(socioModel.CuotaSocio);
            socioDTO.EjemplaresRetirados(new());
            socioModel.EjemplaresRetirados.ForEach(ejemplarM =>
            { 
                socioDTO.EjemplaresRetirados().Add(new ());
                socioDTO.EjemplaresRetirados().Last().NumEdicion(ejemplarM.NumEdicion);
                socioDTO.EjemplaresRetirados().Last().Ubicacion(ejemplarM.Ubicacion);
                socioDTO.EjemplaresRetirados().Last().Libro(new());
                socioDTO.EjemplaresRetirados().Last().Libro().CodigoISBN(ejemplarM.Libro.CodigoISBN);
                socioDTO.EjemplaresRetirados().Last().Libro().Nombre(ejemplarM.Libro.Nombre);
                socioDTO.EjemplaresRetirados().Last().Libro().Autor(ejemplarM.Libro.Autor);
            });
            return socioDTO;
        }
        */
    }
}
