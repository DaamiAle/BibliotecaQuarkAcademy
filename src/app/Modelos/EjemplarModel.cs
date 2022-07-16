
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class EjemplarModel
    {
        // Atributos
        private int id;
        private LibroModel libro;
        private int numEdicion;
        private string ubicacion;

        // Propiedades
        public int Id() => id;
        public void Id(int value) => id = value;
        public LibroModel Libro() => libro;
        public void Libro(LibroModel value) => libro = value;
        public int NumEdicion() => numEdicion;
        public void NumEdicion(int value) => numEdicion = value;
        public string Ubicacion() => ubicacion;
        public void Ubicacion(string value) => ubicacion = value;
    }
}
