namespace Util.src.CustomExceptions.LibroExceptions
{
    public class LibroNotFoundException : Exception
    {
        public LibroNotFoundException() : base("Libro no encontrado") { }
    }
}