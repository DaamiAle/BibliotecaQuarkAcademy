

namespace DataObjects.src
{
    public class PrestamoDTO
    {
        private DateOnly fechaPrestamo;
        private bool estaFinalizado;
        private EjemplarDTO ejemplar;
        private SocioDTO socio;

        public DateOnly FechaPrestamo() => fechaPrestamo;
        public void FechaPrestamo(DateOnly value) => fechaPrestamo = value;
        public bool EstaFinalizado() => estaFinalizado;
        public void EstaFinalizado(bool value) => estaFinalizado = value;
        public EjemplarDTO Ejemplar() => ejemplar;
        public void Ejemplar(EjemplarDTO value) => ejemplar = value;
        public SocioDTO Socio() => socio;
        public void Socio(SocioDTO value) => socio = value;

        public PrestamoDTO(DateOnly fechaPrestamo, bool estaFinalizado, EjemplarDTO ejemplar, SocioDTO socio)
        {
            this.fechaPrestamo = fechaPrestamo;
            this.estaFinalizado = estaFinalizado;
            this.ejemplar = ejemplar;
            this.socio = socio;
        }
    }
}
