using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.EjemplarExceptions
{
    public class NoEjemplaresAvailablesException : Exception
    {
        public NoEjemplaresAvailablesException() : base("No hay ejemplares disponibles para este libro.") { }
    }
}
