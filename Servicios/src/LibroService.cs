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
                LibroModel libro = new()
                {
                    Nombre = nombre,
                    Autor = autor,
                    CodigoISBN = codigoISBN
                };
                libroReposytory.AddLibro(libro);
            }
            else
            {
                throw new LibroAlreadyExistException(nombre);
            }
        }
        public bool ExiteLibro(string codigoISBN)
        {
            return libroReposytory.ExisteLibro(codigoISBN);
        }

        public LibroDTO BuscarLibro(string nombreLibro)
        {
            LibroModel libro = libroReposytory.ObtenerLibro(nombreLibro);
            if (libro == null)
            {
                throw new LibroNotFoundException(nombreLibro);
            }
            else
            {
                LibroDTO libroDTO = new();
                libroDTO.Nombre(libro.Nombre);
                libroDTO.Autor(libro.Autor);
                libroDTO.CodigoISBN(libro.CodigoISBN);
                return libroDTO;
            }
        }
    }
}
