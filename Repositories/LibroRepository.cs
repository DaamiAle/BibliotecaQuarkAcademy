using BibliotecaQuarkAcademy.src.app.Modelos;

namespace Repositories
{
    public class LibroRepository
    {
        private ProjectContext database;
        public LibroRepository(ProjectContext context)
        {
            database = context;
        }
        public LibroModel GetByISBN(string codigoISBN)
        {
            return database.Libros.FirstOrDefault(l => l.CodigoISBN == codigoISBN);
        }

    }
}
