using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.src.CustomExceptions.PrestamoExceptions
{
    public class PrestamoLimitReachedException : Exception
    {
        public PrestamoLimitReachedException() : base("No se pudo realizar el préstamo.El socio a alcanzado el limite") { }
    }
}
