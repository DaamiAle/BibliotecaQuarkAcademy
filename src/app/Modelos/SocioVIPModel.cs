
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class SocioVIPModel : SocioModel
    {
        // Atributos
        private int cuotaSocio = 0;

        // Propiedades
        public int CuotaSocio() => cuotaSocio;
        public void CuotaSocio(int value) => cuotaSocio = value;
        public override int MaxEjempRetirados() => 3;
    }
}
