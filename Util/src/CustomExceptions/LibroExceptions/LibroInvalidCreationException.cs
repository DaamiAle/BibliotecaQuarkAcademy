using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.LibroExceptions
{
    public class LibroInvalidCreationException : Exception
    {
        public LibroInvalidCreationException(string invalidField) : base($"No se puede crear libro. El valor de '{invalidField}' no es un valor valido.") { }
    }
}
