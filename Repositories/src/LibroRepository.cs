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
        public LibroModel AgregarLibro(string nombre, string autor, string codigoISBN)
        {
            LibroModel libro= new()
            {
                Nombre = nombre,
                Autor = autor,
                CodigoISBN = codigoISBN
            };
            libro = database.Libros.Add(libro).Entity;
            database.SaveChanges();
            return libro;
        }


        


        public LibroModel GetByISBN(string codigoISBN)
        {
            LibroModel libro = database.Libros.First(lib => lib.CodigoISBN == codigoISBN) ?? throw new LibroNotFoundException();
            libro.EjemplaresDisponibles = database.Ejemplares.Where(ejemplar => ejemplar.Libro.CodigoISBN == codigoISBN).ToList();
            
            return libro;
        }
    }
}
