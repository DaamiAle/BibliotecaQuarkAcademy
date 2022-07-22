using Services.src;
using DataObjects.src;
using Models.src.DatabaseContext;
using Util.src.CustomExceptions.PrestamoExceptions;

namespace Views.src
{
    public class Presentador
    {
        private readonly ProjectContext database;
        private readonly LibroService libroService;
        private readonly EjemplarService ejemplarService;
        private readonly SocioService socioService;
        private readonly PrestamoService prestamoService;

        
        public Presentador()
        {
            database = new();
            libroService = new(database);
            ejemplarService = new(database);
            socioService = new(database);
            prestamoService = new(database);
        }


        internal void CrearDB()
        {
            database.Database.EnsureCreated();
            database.SaveChanges();
        }
        internal void PoblarDB()
        {
            try
            {
                #region Registro de socios.
                socioService.RegistrarSocio("Damian", "Bruque", 1,true,0);
                socioService.RegistrarSocio("Juan", "Perez", 2, true, 400);
                socioService.RegistrarSocio("Jose","Trelles", 3,false,200);
                #endregion
                #region Registro de libros.
                libroService.AgregarLibro("aventura001", "Viaje al centro de la tierra", "Julio Verne");
                libroService.AgregarLibro("drama001", "Cuentos de locura, amor y muerte", "Horacio Quiroga");
                libroService.AgregarLibro("fantasia001","Harry Potter y el prisionero de Azcaban", "J.K. Rowlling");
                libroService.AgregarLibro("criminales001", "Crimenes sorprendentes de asesinos en serie","Ricardo Canaletti");
                libroService.AgregarLibro("romance001", "Respirando Amor", "Soledad Simond");
                libroService.AgregarLibro("criminales002", "El asesino hipocondriaco", "Juan Jacinto Muñoz Rengel");
                libroService.AgregarLibro("filosofia001", "¿Para que sive la filosofia?", "Dario Sztajnszrajber");
                #endregion
                #region Registro ejemplares
                AgregarEjemplar(1, "P1E1N3", "criminales001");
                AgregarEjemplar(2, "P1E1N3", "criminales001");
                
                AgregarEjemplar(1, "P3E2N4", "aventura001");
                AgregarEjemplar(2, "P3E2N4", "aventura001");
                AgregarEjemplar(3, "P3E2N4", "aventura001");
                
                AgregarEjemplar(1, "P2E2N4", "drama001");
                AgregarEjemplar(2, "P2E2N4", "drama001");
                AgregarEjemplar(3, "P2E2N4", "drama001");
                
                AgregarEjemplar(1, "P4E3N5", "fantasia001");
                AgregarEjemplar(2, "P4E3N5", "fantasia001");
                #endregion
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }

        internal void DevolverUnEjemplarCualquieraDeUnSocioCualquiera()
        {
            try
            {
                PrestamoDTO prestamo = HistorialPrestamos().FirstOrDefault(it => !it.EstaFinalizado());
                if (prestamo != null)
                {
                    DevolverEjemplar(prestamo.Ejemplar(), prestamo.Socio().NumIdentificacion());
                }
                else
                {
                    MessageBox.Show("No hay prestamos pendientes");
                }
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }

        internal void AgregarLibroConValoresInvalidos()
        {
            try
            {
                libroService.AgregarLibro(null, "", "");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
            try
            {
                libroService.AgregarLibro("codigo ISBN", "nombre", "");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }            
            try
            {
                libroService.AgregarLibro("codigoISBN", "", "");                
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        internal void PrestamosSocioComun()
        {
            try
            {
                PrestarEjemplar("aventura001",3);
                MessageBox.Show("Préstamo realizado con éxito");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        internal void PrestamosSocioVIP()
        {
            try
            {
                PrestarEjemplar("aventura001", 1);
                PrestarEjemplar("fantasia001", 1);
                PrestarEjemplar("aventura001", 1);
                PrestarEjemplar("criminales001", 2);
                MessageBox.Show("Préstamo realizado con éxito");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        
        internal List<EjemplarDTO> EjemplaresDisponiblesDe(string codigoISBN)
        {
            try
            {
                return ejemplarService.EjemplaresDisponiblesDe(codigoISBN);
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return null;
            }
        }
        internal List<PrestamoDTO> HistorialPrestamos()
        {
            try
            {
                return prestamoService.HistorialPrestamos();
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return null;
            }
        }
        

        /// <summary>
        /// Agrega un nuevo ejemlar de un libro a la biblioteca.
        /// </summary>
        /// <param name="numEdicion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="codigoISBN"></param>
        internal void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            try 
            {
                ejemplarService.AgregarEjemplar(numEdicion, ubicacion, codigoISBN);
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        /// <summary>
        /// Devuelve true si el libro tiene ejemplares disponibles y false si no tiene.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        internal bool TieneEjemplaresDisponibles(string codigoISBN)
        {
            try
            {
                return ejemplarService.TieneEjemplaresDisponibles(codigoISBN);
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return false;
            }
        }
        /// <summary>
        /// Devuelve un ejemplar de un libro y lo inhabilita.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        internal EjemplarDTO PrestarEjemplar(string codigoISBN,int numIdentificacionSocio)
        {
            try
            {
                if (TieneEjemplaresDisponibles(codigoISBN) && socioService.ExisteSocio(numIdentificacionSocio) && socioService.TieneLimiteDePrestamos(numIdentificacionSocio))
                {
                    EjemplarDTO ejemplarDTO = prestamoService.PrestarEjemplar(codigoISBN, numIdentificacionSocio);
                    return ejemplarDTO;
                }
                else
                {
                    throw new PrestamoLimitReachedException();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return null;
            }
        }
        /// <summary>
        /// Rehabilita ejemplar para que pueda ser prestado.
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <param name="numIdentificacionSocio"></param>
        internal void DevolverEjemplar(EjemplarDTO ejemplar,int numIdentificacionSocio)
        {
            try
            {
                if (socioService.ExisteSocio(numIdentificacionSocio) && ejemplarService.ExisteEjemplar(ejemplar.Libro().CodigoISBN(), ejemplar.NumEdicion()))
                {
                    prestamoService.DevolverEjemplar(ejemplar.NumEdicion(), ejemplar.Libro().CodigoISBN(), numIdentificacionSocio);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        /// <summary>
        /// Devuele true si el socio puede retirar libros y false si no puede.
        /// </summary>
        /// <param name="numIdentificacionSocio"></param>
        /// <returns></returns>
        internal bool PuedeRetirarLibros(int numIdentificacionSocio)
        {
            try
            {
                return socioService.TieneLimiteDePrestamos(numIdentificacionSocio);
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return false;
            }
        }
    }
}
