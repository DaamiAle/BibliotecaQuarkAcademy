using Services.src;
using DataObjects.src;
using Models.src.DatabaseContext;
using Util.src.CustomExceptions.PrestamoExceptions;
using Util.src.CustomExceptions.LibroExceptions;
using Util.src.CustomExceptions.SocioExceptions;
using Util.src.CustomExceptions.EjemplarExceptions;

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


        /*
        internal void PoblarDB()
        {
            try
            {
                #region Registro de socios.
                //socioService.RegistrarSocio("Damian", "Bruque", 1,true,0);
                //socioService.RegistrarSocio("Juan", "Perez", 2, true, 400);
                //socioService.RegistrarSocio("Jose","Trelles", 3,false,200);
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
        */
        /*
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
        */
        /*
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
        */
        /*
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
        }*/
 


        

        /// <summary>
        /// Registra un nuevo socio
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="numIdentificacion"></param>
        /// <param name="esVIP"></param>
        /// <param name="cuotaSocio"></param>
        internal void RegistrarSocio(string nombre, string apellido, string numIdentificacion, bool esVIP, string cuotaSocio)
        {
            try
            {
                int numIdent;
                bool validate;
                int cuota;
                validate = Int32.TryParse(numIdentificacion, out numIdent) ? true : throw new Exception("El DNI es invalido.");
                validate = Int32.TryParse(cuotaSocio, out cuota) ? true : throw new Exception("El valor de cuota es invalido.");
                socioService.RegistrarSocio(nombre,apellido,numIdent,esVIP,cuota);
                MessageBox.Show($"Socio {nombre} registrado exitosamente");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }

        }
        
        /// <summary>
        /// Registra un nuevo libro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="autor"></param>
        /// <param name="codigoISBN"></param>
        /// <exception cref="LibroAlreadyExistException"></exception>
        internal void RegistrarLibro(string nombre, string autor, string codigoISBN)
        {
            try
            {
                libroService.AgregarLibro(codigoISBN, nombre, autor);
                MessageBox.Show($"Libro {nombre} registrado exitosamente");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }

        /// <summary>
        /// Agrega un nuevo ejemplar de un libro
        /// </summary>
        /// <param name="numEdicion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="nombreLibro"></param>
        /// <param name="codigoISBN"></param>
        internal void RegistrarEjemplar(string numEdicion, string ubicacion, string codigoISBN, string nombreLibro) 
        {
            try
            {
                int numEdi;
                bool validate;
                validate = Int32.TryParse(numEdicion, out numEdi) ? true : throw new Exception("El numero de edicion es invalido.");
                if (codigoISBN == null)
                {
                    LibroDTO libro = libroService.BuscarLibro(nombreLibro);
                    ejemplarService.AgregarEjemplar(numEdi, ubicacion, libro.CodigoISBN());
                }
                else
                {
                    validate = libroService.ExiteLibro(codigoISBN) ? true : throw new LibroNotFoundException($"con codigo ISBN {codigoISBN}");
                    ejemplarService.AgregarEjemplar(numEdi, ubicacion, codigoISBN);
                }
                MessageBox.Show("Ejemplar agregado exitosamente");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        

        /// <summary>
        /// Registra el prestamo de un ejemplar de un libro
        /// </summary>
        /// <param name="socioDNI"></param>
        /// <param name="codigoISBN"></param>
        /// <param name="nombreLibro"></param>
        /// <exception cref="LibroNotFoundException"></exception>
        internal void RegistrarPrestamo(string socioDNI, string codigoISBN, string nombreLibro, string numEjemplar)
        {
            try
            {
                int identSocio;
                int numEjemp;
                bool validate;
                validate = Int32.TryParse(socioDNI, out identSocio) ? true : throw new Exception("El DNI es invalido.");
                validate = Int32.TryParse(numEjemplar, out numEjemp) ? true : throw new Exception("El numero de ejemplar es invalido.");
                string codigoISBNFinal = codigoISBN == null ? libroService.BuscarLibro(nombreLibro).CodigoISBN() : codigoISBN;
                SocioDTO socio = socioService.ObtenerSocio(identSocio);
                
                
                List<EjemplarDTO> ejemplares = codigoISBN == null || libroService.ExiteLibro(codigoISBNFinal) ? ejemplarService.EjemplaresExistentesDe(codigoISBNFinal) : throw new LibroNotFoundException(codigoISBNFinal);


                EjemplarDTO ejemplar = ejemplares.FirstOrDefault(it => it.NumEdicion() == numEjemp) ?? throw new EjemplarNotExistException(numEjemp);// : throw new NoEjemplaresAvailablesException();
                ejemplar = PrestarEjemplar(ejemplar, identSocio);
                MessageBox.Show($"Ejemplar de {ejemplar.Libro().Nombre()} prestado exitosamente a {socio.Nombre()}");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }
        
        internal void VerificarDisponibilidadDeEjemplares(string nombreLibro, string codigoISBN)
        {
            try
            {
                bool validate;
                if (codigoISBN == null)
                {
                    LibroDTO libro = libroService.BuscarLibro(nombreLibro);
                    validate = ejemplarService.TieneEjemplaresDisponibles(libro.CodigoISBN()) ? true : throw new NoEjemplaresAvailablesException();
                }
                else
                {
                    validate = libroService.ExiteLibro(codigoISBN) ? true : throw new LibroNotFoundException($"con codigo ISBN {codigoISBN}");
                    validate = ejemplarService.TieneEjemplaresDisponibles(codigoISBN) ? true : throw new NoEjemplaresAvailablesException();
                }
                MessageBox.Show("Hay Ejemplares disponibles");
            }
            catch(NoEjemplaresAvailablesException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }

        /// <summary>
        /// Retorna un ejemplar que se va a prestar de un libro y lo inhabilita.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        private EjemplarDTO PrestarEjemplar(EjemplarDTO ejemplar,int numIdentificacionSocio)
        {
            if (!ejemplar.EstaPrestado()) 
            {
                if (socioService.TieneLimiteDePrestamos(numIdentificacionSocio))
                {
                    EjemplarDTO ejemplarDTO = prestamoService.PrestarEjemplar(ejemplar, numIdentificacionSocio);
                    return ejemplarDTO;
                }
                else
                {
                    throw new PrestamoLimitReachedException();
                }
            }
            else
            {
                throw new EjemplarNotAvailableForLoanException();
            }
        }


        internal void RegistrarDevolucion(string socioDNI, string codigoISBN, string nombreLibro, string numEjemplar)
        {
            try
            {
                int identSocio;
                int numEjemp;
                bool validate;
                validate = Int32.TryParse(socioDNI, out identSocio) ? true : throw new Exception("El DNI es invalido.");
                validate = Int32.TryParse(numEjemplar, out numEjemp) ? true : throw new Exception("El numero de ejemplar es invalido.");
                SocioDTO socio = socioService.ObtenerSocio(identSocio);
                EjemplarDTO ejemplar;
                if (codigoISBN == null)
                {
                    LibroDTO libro = libroService.BuscarLibro(nombreLibro);
                    List<EjemplarDTO> ejemplares = ejemplarService.EjemplaresExistentesDe(libro.CodigoISBN());
                    ejemplar = ejemplares.FirstOrDefault(it => it.NumEdicion() == numEjemp) ?? throw new EjemplarNotExistException(numEjemp);
                    validate = ejemplar.EstaPrestado() ? true : throw new Exception("El ejemplar ya fue devuelto.");
                    DevolverEjemplar(ejemplar, identSocio);
                }
                else
                {
                    List<EjemplarDTO> ejemplares = ejemplarService.EjemplaresExistentesDe(codigoISBN);
                    ejemplar = ejemplares.FirstOrDefault(it => it.NumEdicion() == numEjemp) ?? throw new EjemplarNotExistException(numEjemp);
                    validate = ejemplar.EstaPrestado() ? true : throw new Exception("El ejemplar ya fue devuelto.");
                    DevolverEjemplar(ejemplar, identSocio);
                }
                MessageBox.Show($"Ejemplar de {ejemplar.Libro().Nombre()} devuelto exitosamente");
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }


        /// <summary>
        /// Rehabilita ejemplar para que pueda ser prestado.
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <param name="numIdentificacionSocio"></param>
        private void DevolverEjemplar(EjemplarDTO ejemplar,int numIdentificacionSocio)
        {
            try
            {
                if (ejemplarService.ExisteEjemplar(ejemplar.Libro().CodigoISBN(), ejemplar.NumEdicion()))
                {
                    prestamoService.DevolverEjemplar(ejemplar.NumEdicion(), ejemplar.Libro().CodigoISBN(), numIdentificacionSocio);
                }
                else
                {
                    throw new EjemplarNotExistException(ejemplar.NumEdicion());
                }
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
            }
        }


        
        internal List<PrestamoDTO> ObtenerPrestamos()
        {
            try
            {
                List<PrestamoDTO> prestamos = prestamoService.HistorialPrestamos();
                return prestamos;
            }
            catch (Exception except)
            {
                MessageBox.Show($"Error: {except.Message}");
                return null;
            }
        }
        
    }
}
