namespace DataObjects
{
    public class EjemplarDTO
    {
        // Atributos
        private LibroDTO libro;
        private int numEdicion;
        private string ubicacion;

        // Propiedades
        public LibroDTO Libro() => libro;
        public void Libro(LibroDTO value) => libro = value;
        public int NumEdicion() => numEdicion;
        public void NumEdicion(int value) => numEdicion = value;
        public string Ubicacion() => ubicacion;
        public void Ubicacion(string value) => ubicacion = value;
    }
}
