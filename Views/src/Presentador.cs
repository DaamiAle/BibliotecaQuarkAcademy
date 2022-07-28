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
                ;
                string codigoISBNFinal = codigoISBN == null ? libroService.BuscarLibro(nombreLibro).CodigoISBN() : codigoISBN;
                List<EjemplarDTO> ejemplares = codigoISBN == null || libroService.ExiteLibro(codigoISBNFinal) ? ejemplarService.EjemplaresExistentesDe(codigoISBNFinal) : throw new LibroNotFoundException(codigoISBNFinal);
                validate = ejemplarService.TieneEjemplaresDisponibles(codigoISBNFinal) ? true : throw new NoEjemplaresAvailablesException();
                string mensaje = $"Hay Ejemplares disponibles de {ejemplares[0].Libro().Nombre()}:\n";
                foreach (EjemplarDTO ejemplar in ejemplares)
                {
                    if (!ejemplar.EstaPrestado())
                    {
                        mensaje += $" Ejemplar N°: {ejemplar.NumEdicion()} - Ubicacion: {ejemplar.Ubicacion()}\n";
                    }
                }
                MessageBox.Show(mensaje);
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
