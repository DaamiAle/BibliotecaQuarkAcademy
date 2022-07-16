
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class Socio
    {
        private int id;
        private string nombre;
        private string apellido;
        private int numIdentificacion;

        public int Id() => id;
        public void Id(int value) => id = value;
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Apellido() => apellido;
        public void Apellido(string value) => apellido = value;
        public int NumIdentificacion() => numIdentificacion;
        public void NumIdentificacion(int value) => numIdentificacion = value;
    }
}
