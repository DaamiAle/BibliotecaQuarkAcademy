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
        /*
        internal LibroModel GetModelByISBN(string codigoISBN)
        {
            LibroModel libroModel = libroReposytory.GetByISBN(codigoISBN);
            if (libroModel.GetType() != typeof(LibroModel))
            {
                throw new LibroNotFoundException();
            }
            else
            {
                return libroModel;
            }
        }

        public LibroDTO GetByISBN(string codigoISBN)
        {
            LibroModel libroModel = GetModelByISBN(codigoISBN);
            LibroDTO libroDTO = new();
            libroDTO.CodigoISBN(libroModel.CodigoISBN);
            libroDTO.Nombre(libroModel.Nombre);
            libroDTO.Autor(libroModel.Autor);
            return libroDTO;
        }

        public LibroModel AgregarLibro(LibroDTO libroDTO)
        {
            LibroModel libroModel = new();
            libroModel.CodigoISBN=libroDTO.CodigoISBN();
            libroModel.Nombre= libroDTO.Nombre();
            libroModel.Autor=libroDTO.Autor();
            return libroReposytory.AgregarLibro(libroModel);
        }
        */
    }
}
