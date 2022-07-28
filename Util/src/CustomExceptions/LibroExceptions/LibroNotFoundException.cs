namespace Util.src.CustomExceptions.LibroExceptions
{
    public class LibroNotFoundException : Exception
    {
        public LibroNotFoundException(string value) : base($"Libro '{value}' no encontrado") { }
    }
}