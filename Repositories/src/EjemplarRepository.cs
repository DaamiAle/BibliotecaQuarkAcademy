using Models.src.DatabaseContext;
using Models.src.Entities;

namespace Repositories.src
{
    public class EjemplarRepository
    {
        private readonly ProjectContext database;
        public EjemplarRepository(ProjectContext context)
        {
            database = context;
        }
        public void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            EjemplarModel ejemplar = new()
            {
                NumEdicion = numEdicion,
                Ubicacion = ubicacion,
                Libro = database.Libros.FirstOrDefault(it => it.CodigoISBN == codigoISBN)
            };
            ejemplar = database.Ejemplares.Add(ejemplar).Entity;
            database.SaveChanges();
        }
        public bool ExisteEjemplar(string codigoISBN, int numEdicion)
        {
            return database.Ejemplares.Any(it => it.Libro.CodigoISBN == codigoISBN && it.NumEdicion == numEdicion);
        }
        public List<EjemplarModel> EjemplaresExistentes(string codigoISBN)
        {
            List<EjemplarModel> ejemplares = database.Ejemplares.Where(it => it.Libro.CodigoISBN == codigoISBN).ToList();
            LibroModel libro = database.Libros.FirstOrDefault(lib => lib.CodigoISBN == codigoISBN);
            ejemplares.ForEach(ejem => ejem.Libro = libro);
            return ejemplares;
        }


    }
}
