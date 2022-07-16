
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class SocioModel
    {
        // Atributos
        protected int id;
        protected string nombre;
        protected string apellido;
        protected int numIdentificacion;
        protected EjemplarModel[] ejemplaresRetirados;
        

        // Propiedades
        public int Id() => id;

        public void Id(int value) => id = value;
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Apellido() => apellido;
        public void Apellido(string value) => apellido = value;
        public int NumIdentificacion() => numIdentificacion;
        public void NumIdentificacion(int value) => numIdentificacion = value;
        public EjemplarModel[] EjemplaresRetirados() => ejemplaresRetirados;
        public void EjemplaresRetirados(EjemplarModel[] value) => ejemplaresRetirados = value;
        public virtual int MaxEjempRetirados() => 1;
    }
}
