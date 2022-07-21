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
                Libro = database.Libros.First(it => it.CodigoISBN == codigoISBN) ?? throw new LibroNotFoundException()
            };
            return database.Ejemplares.Add(ejemplar).Entity;;
        }




        
        /*
        public List<EjemplarModel> ObtenerEjemplaresPorIdLibro(int libroId)
        {
            return database.Ejemplares.Where(it => it.Libro == database.Libros.FirstOrDefault(lib => lib.Id == libroId)).ToList();
        }
        */
    }
}
