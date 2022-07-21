using Models.src.DatabaseContext;
using Models.src.Entities;
using Util.src.CustomExceptions.EjemplarExceptions;
using Util.src.CustomExceptions.LibroExceptions;
using Util.src.CustomExceptions.SocioExceptions;

namespace Repositories.src
{
    public class PrestamoRepository
    {
        private readonly ProjectContext database;
        public PrestamoRepository(ProjectContext context)
        {
            database = context;
        }
        public PrestamoModel CreatePrestamo(string codigoISBN, int numIdentificacionSocio, DateTime dateTime)
        {
            LibroModel libro = database.Libros.First(lib => lib.CodigoISBN == codigoISBN) ?? throw new LibroNotFoundException();
            PrestamoModel prestamo = new()
            {
                Ejemplar = database.Ejemplares.First(ejem => ejem.Libro.CodigoISBN == codigoISBN && ejem.Prestamo == null) ?? throw new NoEjemplaresAvailablesException(),
                Socio = database.Socios.First(soc => soc.NumIdentificacion == numIdentificacionSocio) ?? throw new SocioNotFoundException(),
                FechaPrestamo = dateTime,
                EstaFinalizado = false
            };
            prestamo = database.Prestamos.Add(prestamo).Entity;
            database.SaveChanges();
            return prestamo;
        }




        
        public List<PrestamoModel> GetAll()
        {
            return database.Prestamos.ToList();
        }
    }
}
