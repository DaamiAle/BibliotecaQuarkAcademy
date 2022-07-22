namespace DataObjects.src
{
    public class EjemplarDTO
    {
        // Atributos
        private LibroDTO libro;
        private int numEdicion;
        private string ubicacion;
        private bool estaPrestado;
        private List<PrestamoDTO> prestamos;


        // Propiedades
        public LibroDTO Libro() => libro;
        public void Libro(LibroDTO value) => libro = value;
        public int NumEdicion() => numEdicion;
        public void NumEdicion(int value) => numEdicion = value;
        public string Ubicacion() => ubicacion;
        public void Ubicacion(string value) => ubicacion = value;
        public bool EstaPrestado() => estaPrestado;
        public void EstaPrestado(bool value) => estaPrestado = value;
        public List<PrestamoDTO> Prestamos() => prestamos;
        public void Prestamos(List<PrestamoDTO> value) => prestamos = value;
    }
}
