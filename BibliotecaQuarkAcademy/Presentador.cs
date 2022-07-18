using Services;

namespace BibliotecaQuarkAcademy
{
    public class Presentador
    {
        private readonly ProjectContext database;
        private readonly LibroService libroService;
        private readonly EjemplarService ejemplarService;
        private readonly SocioService socioService;
        public Presentador()
        {
            database = new ProjectContext();
            libroService = new LibroService(database);
            ejemplarService = new EjemplarService(database);
            //socioService = new SocioService(database);
        }
        public void CrearDB()
        {
            database.Database.EnsureCreated();
            database.SaveChanges();
        }
        public bool AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            /*
            ejemplarService.AgregarEjemplar();
            // reemplaar opor llamada service
            /*
            var ejemplar = new EjemplarModel();
            ejemplar.Libro = libro;
            ejemplar.NumEdicion = numEdicion;
            ejemplar.Ubicacion = ubicacion;
            database.Ejemplares.Add(ejemplar);
            database.SaveChanges();
            */
            var ejemplar = ejemplarService.AgregarEjemplar(numEdicion, ubicacion, libroService.GetByISBN(codigoISBN));
            if (ejemplar == null)
            {
                return false;
            }
            else
            {
                database.SaveChanges();
                return true;
            }
        }
    }
}
