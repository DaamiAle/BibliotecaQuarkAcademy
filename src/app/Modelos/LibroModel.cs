
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class LibroModel
    {
        private int id;
        private string nombre;
        private string autor;
        private string codigoISBN;



        public int Id() => id;
        public void Id(int value) => id = value;
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Autor() => autor;
        public void Autor(string value) => autor = value;
        public string CodigoISBN() => codigoISBN;
        public void CodigoISBN(string value) => codigoISBN = value;
    }
}
