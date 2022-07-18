using BibliotecaQuarkAcademy;
using Models;

namespace Repositories
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

    }
}
