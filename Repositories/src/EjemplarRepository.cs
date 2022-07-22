using Models.src.DatabaseContext;
using Models.src.Entities;
using Util.src.CustomExceptions.LibroExceptions;

namespace Repositories.src
{
    public class EjemplarRepository
    {
        private readonly ProjectContext database;
        public EjemplarRepository(ProjectContext context)
        {
            database = context;
        }
        public EjemplarModel AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            EjemplarModel ejemplar = new() 
            {
                NumEdicion = numEdicion,
                Ubicacion = ubicacion,
                Libro = database.Libros.FirstOrDefault(it => it.CodigoISBN == codigoISBN) ?? throw new LibroNotFoundException(codigoISBN)
            };
            ejemplar = database.Ejemplares.Add(ejemplar).Entity;
            database.SaveChanges();
            return ejemplar;
        }

        public bool ExisteEjemplar(string codigoISBN, int numEdicion)
        {
            return database.Ejemplares.Any(it => it.Libro.CodigoISBN == codigoISBN && it.NumEdicion == numEdicion);
        }

        public List<EjemplarModel> EjemplaresDisponibles(string codigoISBN)
        {
            List<EjemplarModel> ejemplares = database.Libros.Any(it => it.CodigoISBN == codigoISBN) ? database.Ejemplares.Where(it => it.Libro.CodigoISBN == codigoISBN && !it.EstaPrestado).ToList() : throw new LibroNotFoundException(codigoISBN);
            ejemplares.ForEach(ejem => ejem.Libro = database.Libros.FirstOrDefault(lib => lib.CodigoISBN == codigoISBN));
            return ejemplares;
        }





        /*
        public List<EjemplarModel> ObtenerEjemplaresPorIdLibro(int libroId)
        {
            return database.Ejemplares.Where(it => it.Libro == database.Libros.FirstOrDefault(lib => lib.Id == libroId)).ToList();
        }
        */
    }
}
