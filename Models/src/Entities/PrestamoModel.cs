namespace Models.src.Entities
{
    public class PrestamoModel
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EjemplarModel Ejemplar { get; set; }
        public SocioModel Socio { get; set; }
    }
}
