using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.EjemplarExceptions
{
    public class EjemplarAlreadyExistException : Exception
    {
        public EjemplarAlreadyExistException(string ejemplar) : base($"El ejemplar {ejemplar} ya existe") { }
    }
}
