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

        public bool ExisteSocio(int numIdentificacionSocio)
        {
            return socioRepository.ExisteSocio(numIdentificacionSocio);
        }

        public bool TieneLimiteDePrestamos(int numIdentificacionSocio)
        {
            SocioModel socio = socioRepository.GetByIdentificacion(numIdentificacionSocio);
            socio.Prestamos = socio.Prestamos.Where(it => it.EstaFinalizado == false).ToList();
            return socio.EsVIP ? socio.Prestamos.Count < 3 : socio.Prestamos.Count < 1;
        }
        public void RegistrarSocio(string nombre, string apellido, int numIdentificacion, bool esVIP, int cuota)
        {
            if (!socioRepository.ExisteSocio(numIdentificacion))
            {
                socioRepository.AddSocio(nombre, apellido, numIdentificacion, esVIP, cuota);
            }
            else
            {
                throw new SocioAlreadyExistsException($"{nombre} {apellido}");
            }
        }

        public SocioDTO ObtenerSocio(int identSocio)
        {
            
            if (!socioRepository.ExisteSocio(identSocio))
            {
                throw new SocioNotFoundException(identSocio);
            }
            else
            {
                SocioModel socio = socioRepository.GetByIdentificacion(identSocio);
                SocioDTO socioDTO = new();
                socioDTO.Nombre(socio.Nombre);
                socioDTO.Apellido(socio.Apellido);
                socioDTO.NumIdentificacion(socio.NumIdentificacion);
                socioDTO.EsVIP(socio.EsVIP);
                socioDTO.CuotaSocio(socio.CuotaSocio);
                return socioDTO;
            }
            
        }
    }
}
