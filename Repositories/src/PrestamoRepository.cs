using Models.src.DatabaseContext;
using Models.src.Entities;
using Util.src.CustomExceptions.EjemplarExceptions;
using Util.src.CustomExceptions.LibroExceptions;
using Util.src.CustomExceptions.SocioExceptions;
using Microsoft.EntityFrameworkCore;

namespace Repositories.src
{
    public class PrestamoRepository
    {
        private readonly ProjectContext database;
        public PrestamoRepository(ProjectContext context)
        {
            database = context;
        }
        public PrestamoModel CreatePrestamo(EjemplarModel ejemplarModel, int numIdentificacionSocio)
        {
            PrestamoModel prestamo = new()
            {
                Ejemplar = database.Ejemplares.FirstOrDefault(ejem => ejem.Ubicacion == ejemplarModel.Ubicacion && ejem.NumEdicion == ejemplarModel.NumEdicion),
                Socio = database.Socios.FirstOrDefault(soc => soc.NumIdentificacion == numIdentificacionSocio),
                FechaPrestamo = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                EstaFinalizado = false
            };
            prestamo = database.Prestamos.Add(prestamo).Entity;
            database.SaveChanges();
            EjemplarModel ejemplar = prestamo.Ejemplar;
            ejemplar.EstaPrestado = true;
            database.Ejemplares.Update(ejemplar);
            database.SaveChanges();
            return prestamo;
        }
        public void DevolverEjemplar(int numEdicion, string codigoISBN, int numIdentificacionSocio)
        {
            PrestamoModel prestamo = database.Prestamos.FirstOrDefault(prest => prest.Ejemplar.Libro.CodigoISBN == codigoISBN && prest.Ejemplar.NumEdicion == numEdicion && prest.Socio.NumIdentificacion == numIdentificacionSocio && !prest.EstaFinalizado);
            prestamo.EstaFinalizado = true;
            database.Prestamos.Update(prestamo);
            EjemplarModel ejemplar = database.Ejemplares.FirstOrDefault(ejem => ejem.Libro.CodigoISBN == codigoISBN && ejem.NumEdicion == numEdicion);
            ejemplar.EstaPrestado = false;
            database.Ejemplares.Update(ejemplar);
            database.SaveChanges();
        }
        public List<PrestamoModel> GetPrestamos()
        {
            List<PrestamoModel> prestamosModels =   database.Prestamos.FromSqlRaw   ("SELECT Prestamos.*    FROM Socios,Prestamos,Ejemplares,Libros WHERE Prestamos.EjemplarId = Ejemplares.Id AND Prestamos.SocioId = Socios.Id AND Ejemplares.LibroId = Libros.Id ").ToList();
            List<EjemplarModel> ejemplaresModels =  database.Ejemplares.FromSqlRaw  ("SELECT Ejemplares.*   FROM Socios,Prestamos,Ejemplares,Libros WHERE Prestamos.EjemplarId = Ejemplares.Id AND Prestamos.SocioId = Socios.Id AND Ejemplares.LibroId = Libros.Id ").ToList();
            List<SocioModel> sociosModels =         database.Socios.FromSqlRaw      ("SELECT Socios.*       FROM Socios,Prestamos,Ejemplares,Libros WHERE Prestamos.EjemplarId = Ejemplares.Id AND Prestamos.SocioId = Socios.Id AND Ejemplares.LibroId = Libros.Id ").ToList();
            List<LibroModel> libroModels =          database.Libros.FromSqlRaw      ("SELECT Libros.*       FROM Socios,Prestamos,Ejemplares,Libros WHERE Prestamos.EjemplarId = Ejemplares.Id AND Prestamos.SocioId = Socios.Id AND Ejemplares.LibroId = Libros.Id ").ToList();
            for (int i = 0; i < prestamosModels.Count; i++)
            {
                prestamosModels[i].Ejemplar = ejemplaresModels[i];
                prestamosModels[i].Socio = sociosModels[i];
                prestamosModels[i].Ejemplar.Libro = libroModels[i];
            }
            return prestamosModels;
        }
        public bool ExistePrestamoPendiente(int numEdicion, string codigoISBN, int numIdentificacionSocio)
        {
            return database.Prestamos.FirstOrDefault(prestamo => prestamo.Ejemplar.Libro.CodigoISBN == codigoISBN && prestamo.Ejemplar.NumEdicion == numEdicion && prestamo.Socio.NumIdentificacion == numIdentificacionSocio && !prestamo.EstaFinalizado) != null;
        }
    }
}
