using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.PrestamoExceptions
{
    public class PrestamoNotFoundException : Exception
    {
        public PrestamoNotFoundException(string codigoISBN, int socio) : base($"No se encontro ningun prestamos del {codigoISBN} por parte del socio {socio}") { }
    }
}
