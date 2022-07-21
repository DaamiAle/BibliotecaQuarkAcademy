namespace DataObjects.src
{
    public class EjemplarDTO
    {
        // Atributos
        private LibroDTO libro;
        private int numEdicion;
        private string ubicacion;
        private PrestamoDTO prestamo;


        // Propiedades
        public LibroDTO Libro() => libro;
        public void Libro(LibroDTO value) => libro = value;
        public int NumEdicion() => numEdicion;
        public void NumEdicion(int value) => numEdicion = value;
        public string Ubicacion() => ubicacion;
        public void Ubicacion(string value) => ubicacion = value;
        public PrestamoDTO EstaPrestado() => prestamo;
        public void EstaPrestado(PrestamoDTO value) => prestamo = value;
    }
}
