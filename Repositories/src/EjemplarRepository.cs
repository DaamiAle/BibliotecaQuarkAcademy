using Models.src;

namespace Repositories.src
{
    public class EjemplarRepository
    {
        private readonly ProjectContext database;
        public EjemplarRepository(ProjectContext context)
        {
            database = context;
        }
        public EjemplarModel AgregarEjemplar(EjemplarModel ejemplar)
        {
            return database.Ejemplares.Add(ejemplar).Entity;
        }

        public List<EjemplarModel> ObtenerEjemplaresPorIdLibro(int libroId)
        {
            return database.Ejemplares.Where(it => it.Libro == database.Libros.FirstOrDefault(lib => lib.Id == libroId)).ToList();
        }
    }
}
