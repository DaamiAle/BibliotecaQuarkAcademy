

namespace Services
{
    public class EjemplarService
    {
        private EjemplarRepository ejemplarRepository;
        public EjemplarService(ProjectContext context)
        {
            ejemplarRepository = new EjemplarRepository(context);
        }
        public object AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
        }

    }
}
