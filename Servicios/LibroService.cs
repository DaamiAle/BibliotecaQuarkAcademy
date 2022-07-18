using BibliotecaQuarkAcademy.src.app.Repositorios;
using BibliotecaQuarkAcademy.src.app.DataObjects;
using BibliotecaQuarkAcademy.src.app.Modelos;

namespace Services
{
    public class LibroService
    {
        private LibroRepository libroReposytory;
        public LibroService(ProjectContext context)
        {
            libroReposytory = new LibroRepository(context);
        }
        internal LibroModel GetModelByISBN(string codigoISBN)
        {
            return libroReposytory.GetByISBN(codigoISBN);
        }

        public LibroDTO GetByISBN(string codigoISBN)
        {
            LibroDTO libroDTO = null;
            LibroModel libroModel = libroReposytory.GetByISBN(codigoISBN);
            if (libroModel != null)
            {
                libroDTO = new();
                libroDTO.CodigoISBN(libroModel.CodigoISBN);
                libroDTO.Nombre(libroModel.Nombre);
                libroDTO.Autor(libroModel.Autor);
            }
            return libroDTO;
        }
    }
}
