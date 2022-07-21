using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.SocioExceptions
{
    public class SocioNotFoundException : Exception
    {
        public SocioNotFoundException() : base("No se encontro un socio registrado bajo esa identificacion.") { }
    }
}
