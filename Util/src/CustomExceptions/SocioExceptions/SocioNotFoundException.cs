using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.SocioExceptions
{
    public class SocioNotFoundException : Exception
    {
        public SocioNotFoundException(int numIdentificacion) : base($"No se encontro un socio registrado bajo la identificacion '{numIdentificacion}'.") { }
    }
}
