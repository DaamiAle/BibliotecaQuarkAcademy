using Models.src.DatabaseContext;
using Models.src.Entities;
using Util.src.CustomExceptions.SocioExceptions;

namespace Repositories.src
{
    public class SocioRepository
    {
        private readonly ProjectContext database;
        public SocioRepository(ProjectContext context)
        {
            database = context;
        }

        public bool ExisteSocio(int numIdentificacionSocio)
        {
            return database.Socios.Any(it => it.NumIdentificacion == numIdentificacionSocio);
        }
        public SocioModel GetByIdentificacion(int numIdentificacion)
        {
            SocioModel socio = database.Socios.FirstOrDefault(it => it.NumIdentificacion == numIdentificacion) ?? throw new SocioNotFoundException(numIdentificacion);
            socio.Prestamos = database.Prestamos.Where(it => it.Socio.NumIdentificacion == numIdentificacion).ToList();
            return socio;
        }
        public void AddSocio(SocioModel socio)
        {
            database.Socios.Add(socio);
            database.SaveChanges();
        }
    }
}
