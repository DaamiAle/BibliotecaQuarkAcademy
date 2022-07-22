using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.SocioExceptions
{
    public class SocioAlreadyExistsException : Exception
    {
        public SocioAlreadyExistsException() : base("El socio ya esta registrado") { }
    }
}
