﻿using Models.src.DatabaseContext;
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
        public PrestamoModel CreatePrestamo(string codigoISBN, int numIdentificacionSocio)
        {
            LibroModel libro = database.Libros.FirstOrDefault(lib => lib.CodigoISBN == codigoISBN) ?? throw new LibroNotFoundException(codigoISBN);
            PrestamoModel prestamo = new()
            {
                Ejemplar = database.Ejemplares.FirstOrDefault(ejem => ejem.Libro.CodigoISBN == codigoISBN && !ejem.EstaPrestado ) ?? throw new NoEjemplaresAvailablesException(),
                Socio = database.Socios.FirstOrDefault(soc => soc.NumIdentificacion == numIdentificacionSocio) ?? throw new SocioNotFoundException(numIdentificacionSocio),
                FechaPrestamo = DateTime.Now,
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
            List<PrestamoModel> prestamos = database.Prestamos.ToList();
            prestamos.ForEach(it => 
            {
                it.Ejemplar = database.Ejemplares.FirstOrDefault(ejem => ejem.Id == it.Ejemplar.Id);
                it.Socio = database.Socios.FirstOrDefault(soc => soc.NumIdentificacion == it.Socio.NumIdentificacion);
            });

            return prestamos;
            
        }

        public bool ExistePrestamoPendiente(int numEdicion, string codigoISBN, int numIdentificacionSocio)
        {
            return database.Prestamos.FirstOrDefault(prestamo => prestamo.Ejemplar.Libro.CodigoISBN == codigoISBN && prestamo.Ejemplar.NumEdicion == numEdicion && prestamo.Socio.NumIdentificacion == numIdentificacionSocio && !prestamo.EstaFinalizado) != null;
        }
    }
}
