using DataObjects.src;
using Models.src.DatabaseContext;
using Models.src.Entities;
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

        public void AgregarEjemplar(int numEdicion, string ubicacion, string codigoISBN)
        {
            if (!ejemplarRepository.ExisteEjemplar(codigoISBN, numEdicion))
            {
                ejemplarRepository.AgregarEjemplar(numEdicion, ubicacion, codigoISBN);
            }
        }

        public bool TieneEjemplaresDisponibles(string codigoISBN)
        {
            return ejemplarRepository.EjemplaresDisponibles(codigoISBN).Count > 0;
        }

        public bool ExisteEjemplar(string codigoISBN, int numEdicion)
        {
            return ejemplarRepository.ExisteEjemplar(codigoISBN, numEdicion);
        }

        public List<EjemplarDTO> EjemplaresDisponiblesDe(string codigoISBN)
        {
            List<EjemplarModel> ejemplaresModel = ejemplarRepository.EjemplaresDisponibles(codigoISBN);
            List<EjemplarDTO> ejemplaresDTO = new List<EjemplarDTO>();
            ejemplaresModel.ForEach(eModel =>
            {
                ejemplaresDTO.Add(new());
                ejemplaresDTO.Last().NumEdicion(eModel.NumEdicion);
                ejemplaresDTO.Last().Ubicacion(eModel.Ubicacion);
                ejemplaresDTO.Last().EstaPrestado(eModel.EstaPrestado);
                ejemplaresDTO.Last().Libro(new());
                ejemplaresDTO.Last().Libro().CodigoISBN(eModel.Libro.CodigoISBN);
                ejemplaresDTO.Last().Libro().Nombre(eModel.Libro.Nombre);
                ejemplaresDTO.Last().Libro().Autor(eModel.Libro.Autor);
            });
            return ejemplaresDTO;
        }

    }
}
