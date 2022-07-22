using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.LibroExceptions
{
    public class LibroAlreadyExistException : Exception
    {
        public LibroAlreadyExistException() : base("El libro ya existe") { }
    }
}
