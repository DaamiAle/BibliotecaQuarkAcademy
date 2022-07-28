namespace Models.src.Entities
{
    public class PrestamoModel
    {
        public int Id { get; set; }
        public DateOnly FechaPrestamo { get; set; }
        public bool EstaFinalizado { get; set; }
        public EjemplarModel Ejemplar { get; set; }
        public SocioModel Socio { get; set; }
    }
}
