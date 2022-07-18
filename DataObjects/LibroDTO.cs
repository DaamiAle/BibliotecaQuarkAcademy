namespace DataObjects
{
    public class LibroDTO
    {
        // Atributos
        private string nombre;
        private string autor;
        private string codigoISBN;
        private List<EjemplarDTO> ejemplaresDisponibles;

        // Propiedades
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Autor() => autor;
        public void Autor(string value) => autor = value;
        public string CodigoISBN() => codigoISBN;
        public void CodigoISBN(string value) => codigoISBN = value;
        public List<EjemplarDTO> EjemplaresDisponibles() => ejemplaresDisponibles;
        public void EjemplaresDisponibles(List<EjemplarDTO> value) => ejemplaresDisponibles = value;
    }
}
