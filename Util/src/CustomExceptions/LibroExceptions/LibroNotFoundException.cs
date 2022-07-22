namespace Util.src.CustomExceptions.LibroExceptions
{
    public class LibroNotFoundException : Exception
    {
        public LibroNotFoundException(string codigoISBN) : base($"Libro {codigoISBN} no encontrado") { }
    }
}