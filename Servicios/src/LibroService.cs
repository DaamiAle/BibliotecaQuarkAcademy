using DataObjects.src;
using Repositories.src;
using Util.src.CustomExceptions.LibroExceptions;
using Models.src.DatabaseContext;
using Models.src.Entities;

namespace Services.src
{
    public class LibroService
    {
        private LibroRepository libroReposytory;

        public LibroService(ProjectContext context)
        {
            libroReposytory = new LibroRepository(context);
        }

        public void AgregarLibro(string codigoISBN, string nombre, string autor)
        {
            if (!ExiteLibro(codigoISBN))
            {
                if (codigoISBN == null || codigoISBN.Length == 0)
                {
                    throw new LibroInvalidCreationException("codigoISBN");
                }
                if (nombre == null || nombre.Length == 0)
                {
                    throw new LibroInvalidCreationException("nombre");
                }
                if (autor == null || autor.Length == 0)
                {
                    throw new LibroInvalidCreationException("autor");
                }
                LibroModel libro = new()
                {
                    Nombre = nombre,
                    Autor = autor,
                    CodigoISBN = codigoISBN
                };
                libroReposytory.AddLibro(libro);
            }
            
        }
        public bool ExiteLibro(string codigoISBN)
        {
            return libroReposytory.ExisteLibro(codigoISBN);
        }

    }
}
