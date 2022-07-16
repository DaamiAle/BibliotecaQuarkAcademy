
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class SocioModel
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumIdentificacion { get; set; }
        public bool EsVIP { get; set; }
        public int CuotaSocio { get; set; }
        public List<EjemplarModel> EjemplaresRetirados { get; set; }
    }
}
