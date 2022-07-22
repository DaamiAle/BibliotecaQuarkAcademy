namespace Models.src.Entities
{
    public class EjemplarModel
    {
        // Propiedades
        public int Id { get; set; }
        public LibroModel Libro { get; set; }
        public int NumEdicion { get; set; }
        public string Ubicacion { get; set; }
        public bool EstaPrestado { get; set; }
        public List<PrestamoModel> Prestamos { get; set; }
    }
}
