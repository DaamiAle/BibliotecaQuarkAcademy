using DataObjects.src;
using Models.src;
using Repositories.src;
using Util.src.CustomExceptions.EjemplarExceptions;
using Util.src.CustomExceptions.LibroExceptions;

namespace Services.src
{
    public class EjemplarService
    {
        private readonly EjemplarRepository ejemplarRepository;
        public EjemplarService(ProjectContext context)
        {
            ejemplarRepository = new EjemplarRepository(context);
        }
        public void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN , LibroService libroService)
        {
            LibroModel libroModel = libroService.GetModelByISBN(codigoISBN);
            if (libroModel == null)
            {
                throw new LibroNotFoundException();
            }
            else
            {
                EjemplarModel ejemplarModel = new();
                ejemplarModel.NumEdicion = numEdicion;
                ejemplarModel.Ubicacion = ubicacion;
                ejemplarModel.Libro = libroModel;
                ejemplarModel = ejemplarRepository.AgregarEjemplar(ejemplarModel);
                if (ejemplarModel == null)
                {
                    throw new EjemplarNotCreatedExceptions();
                }
            }
        }

        public List<EjemplarDTO> ObtenerEjmplares(string codigoISBN,LibroService libroService)
        {
            LibroModel libro = libroService.GetModelByISBN(codigoISBN);
            List<EjemplarModel> ejemplares = ejemplarRepository.ObtenerEjemplaresPorIdLibro(libro.Id);
            List<EjemplarDTO> ejemplaresDTO = new();
            ejemplares.ForEach(it => {
                ejemplaresDTO.Add(new EjemplarDTO());
                ejemplaresDTO.Last().NumEdicion(it.NumEdicion);
                ejemplaresDTO.Last().Ubicacion(it.Ubicacion);
            });
            return ejemplaresDTO;

        }
    }
}
