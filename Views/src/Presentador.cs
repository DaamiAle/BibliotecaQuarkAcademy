using Services.src;
using DataObjects.src;
using Util.src.CustomExceptions.LibroExceptions;
using Util.src.CustomExceptions.SocioExceptions;
using Models.src.DatabaseContext;

namespace Views.src
{
    public class Presentador
    {
        private readonly ProjectContext database;
        private readonly LibroService libroService;
        private readonly EjemplarService ejemplarService;
        private readonly SocioService socioService;

        
        public Presentador()
        {
            database = new();
            libroService = new(database);
            ejemplarService = new(database);
            socioService = new(database);
        }
        public void CrearDB()
        {
            database.Database.EnsureCreated();
            database.SaveChanges();
        }

        
        /*

        /// <summary>
        /// Retorna un libro segun su codigo ISBN. Si no se encuentra devuelve una excepcion.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        /// <exception cref="LibroNotFoundException"></exception>
        public LibroDTO ObtenerLibro(string codigoISBN)
        {
            LibroDTO libroDTO = libroService.GetByISBN(codigoISBN);
            if (libroDTO == null)
            {
                throw new LibroNotFoundException();
            }
            else
            {
                libroDTO.EjemplaresDisponibles(new List<EjemplarDTO>());
                ejemplarService.ObtenerEjmplares(libroDTO.CodigoISBN(),libroService).ForEach(it => libroDTO.EjemplaresDisponibles().Add(it));
                
                return libroDTO;
            }
        }
        /// <summary>
        /// Agrega un nuevo ejemlar de un libro a la biblioteca.
        /// </summary>
        /// <param name="numEdicion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="codigoISBN"></param>
        public void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            ejemplarService.AgregarEjemplar(numEdicion, ubicacion, codigoISBN, libroService);
            database.SaveChanges();
            
        }
        /// <summary>
        /// Retorna true si hay ejemplares disponibles en la biblioteca y false si no los hay.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        public bool TieneEjemplaresDisponibles(string codigoISBN)
        {
            return ObtenerLibro(codigoISBN).EjemplaresDisponibles().FindAll(it => it.SocioPoseedor() == null).Count > 0;
        }
        /// <summary>
        /// Retorna el ejemplar prestado o null si no hay ejemplares disponibles para prestar.
        /// </summary>
        /// <param name="codigoISBN"></param>
        /// <returns></returns>
        /*public EjemplarDTO PrestarEjemplarDe(string codigoISBN,int numIdentificacionSocio)
        {
            if (PuedeRetirarLibro(numIdentificacionSocio))
                {
                }
            
            /*
        if (TieneEjemplaresDisponibles(codigoISBN))
        {
            List<EjemplarDTO> ejemplaresDisponibles = ejemplarService.ObtenerEjmplares(codigoISBN, libroService).FindAll(it => it.SocioPoseedor() == null);
            if (PuedeRetirarLibro(numIdentificacionSocio))
            {
                EjemplarDTO ejemplar = ejemplarService.PrestarEjemplar(ejemplaresDisponibles.First(),socioDTO);
                database.SaveChanges();
            }

            return ejemplar;
        }
        else
        {
            return null;
        }
        }


        
        public bool PuedeRetirarLibro(int numIdentificacionSocio)
        {
            SocioDTO socioDTO = socioService.GetByNumIdentificacion(numIdentificacionSocio);
            return socioDTO.EsVIP() ? socioDTO.EjemplaresRetirados().Count < 3 : socioDTO.EjemplaresRetirados().Count == 0;
        }
        */
        
        
    }
}
