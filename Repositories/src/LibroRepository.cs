using Models.src.DatabaseContext;
using Models.src.Entities;
using Util.src.CustomExceptions.LibroExceptions;

namespace Repositories.src
{
    public class LibroRepository
    {
        private readonly ProjectContext database;
        public LibroRepository(ProjectContext context)
        {
            database = context;
        }
        public void AddLibro(LibroModel libro)
        {
            libro = database.Libros.Add(libro).Entity;
            database.SaveChanges();
        }
        public bool ExisteLibro(string codigoISBN)
        {
            return database.Libros.Any(it => it.CodigoISBN == codigoISBN);
        }
    }
}
