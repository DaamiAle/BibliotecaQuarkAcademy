using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.SocioExceptions
{
    public class SocioAlreadyExistsException : Exception
    {
        public SocioAlreadyExistsException(string value) : base($"El socio '{value}' ya esta registrado") { }
    }
}
