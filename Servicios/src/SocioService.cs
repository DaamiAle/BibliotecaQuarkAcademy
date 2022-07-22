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
            return socio.EsVIP ? socio.Prestamos.Count < 3 : socio.Prestamos.Count < 1;
        }
        public void RegistrarSocio(string nombre, string apellido, int numIdentificacion, bool esVIP, int cuotaSocio)
        {
            if (!ExisteSocio(numIdentificacion))
            {
                SocioModel socio = new()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    NumIdentificacion = numIdentificacion,
                    EsVIP = esVIP,
                    CuotaSocio = cuotaSocio
                };
                socioRepository.AddSocio(socio);
            }
        }
    }
}
