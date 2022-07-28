using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.EjemplarExceptions
{
    public class EjemplarNotAvailableForLoanException : Exception
    {
        public EjemplarNotAvailableForLoanException() : base(" Ejemplar no disponible para prestamo") { }
    }
}
