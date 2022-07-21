

namespace DataObjects.src
{
    public class PrestamoDTO
    {
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private EjemplarDTO ejemplar;
        private SocioDTO socio;

        public DateTime FechaPrestamo() => fechaPrestamo;
        public void FechaPrestamo(DateTime value) => fechaPrestamo = value;
        public DateTime FechaDevolucion() => fechaDevolucion;
        public void FechaDevolucion(DateTime value) => fechaDevolucion = value;
        public EjemplarDTO Ejemplar() => ejemplar;
        public void Ejemplar(EjemplarDTO value) => ejemplar = value;
        public SocioDTO Socio() => socio;
        public void Socio(SocioDTO value) => socio = value;
    }
}
