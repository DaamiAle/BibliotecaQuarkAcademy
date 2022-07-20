using Microsoft.EntityFrameworkCore;
using Models.src;

namespace Repositories.src
{
    public class LibroRepository
    {
        private readonly ProjectContext database;
        public LibroRepository(ProjectContext context)
        {
            database = context;
        }
        public LibroModel GetByISBN(string codigoISBN)
        {
            return database.Libros.FirstOrDefault(l => l.CodigoISBN == codigoISBN);
        }

        public LibroModel AgregarLibro(LibroModel libro)
        {
            LibroModel libroModel = database.Libros.Add(libro).Entity;
            database.SaveChanges();
            return libroModel;
        }
    }
}
