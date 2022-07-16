
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class LibroModel
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string CodigoISBN { get; set; }
        public List<EjemplarModel> EjemplaresDisponibles { get; set; }
    }
}
