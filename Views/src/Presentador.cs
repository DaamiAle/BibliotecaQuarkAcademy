using Services.src;
using DataObjects.src;
using Util.src.CustomExceptions.LibroExceptions;

namespace Views.src
{
    public class Presentador
    {
        private readonly Models.src.ProjectContext database;
        private readonly LibroService libroService;
        private readonly EjemplarService ejemplarService;
        private readonly SocioService socioService;

        
        public Presentador()
        {
            database = new();
            libroService = new(database);
            ejemplarService = new(database);
            socioService = new(database);
        }

        public void CrearDB()
        {
            database.Database.EnsureCreated();
            database.SaveChanges();
        }

        public LibroDTO ObtenerLibro(string codigoISBN)
        {
            LibroDTO libroDTO = libroService.GetByISBN(codigoISBN);
            if (libroDTO == null)
            {
                throw new LibroNotFoundException();
            }
            else
            {
                libroDTO.EjemplaresDisponibles(new List<EjemplarDTO>());
                ejemplarService.ObtenerEjmplares(libroDTO.CodigoISBN(),libroService).ForEach(it => libroDTO.EjemplaresDisponibles().Add(it));
                
                return libroDTO;
            }
        }
        public void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            ejemplarService.AgregarEjemplar(numEdicion, ubicacion, codigoISBN, libroService);
            database.SaveChanges();
            
        }
        public bool TieneEjemplaresDisponibles(string codigoISBN)
        {
            LibroDTO libroDTO = ObtenerLibro(codigoISBN);
            
            return libroDTO.EjemplaresDisponibles().Count > 0;
        }
    }
}
