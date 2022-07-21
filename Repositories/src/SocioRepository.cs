using Models.src.DatabaseContext;
using Models.src.Entities;

namespace Repositories.src
{
    public class SocioRepository
    {
        private readonly ProjectContext database;
        public SocioRepository(ProjectContext context)
        {
            database = context;
        }
        public SocioModel AgregarSocio(string nombre, string apellido, int numIdentificacion, bool esVIP, int cuotaSocio)
        {
            SocioModel socio = new()
            {
                Nombre = nombre,
                Apellido = apellido,
                NumIdentificacion = numIdentificacion,
                EsVIP = esVIP,
                CuotaSocio = cuotaSocio
            };
            socio = database.Socios.Add(socio).Entity;
            database.SaveChanges();
            return socio;
        }




        
        public SocioModel GetByIdentificacion(int numIdentificacion)
        {
            SocioModel socio = database.Socios.FirstOrDefault(it => it.NumIdentificacion == numIdentificacion);
            /*
            socio.EjemplaresRetirados = database.Ejemplares.Where(it => it.SocioPoseedor.NumIdentificacion == numIdentificacion).ToList();
            socio.EjemplaresRetirados.ForEach(ejemplar =>
            {
                ejemplar.Libro = database.Libros.First(libro => libro.Id == ejemplar.Libro.Id);
            });
            */
            return socio;
        }
        
    }
}
