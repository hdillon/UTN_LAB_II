using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    class ReproductorExcepcion : Exception
    {
        public ReproductorExcepcion(String mensaje) : base(mensaje)
        {
        }
    }
}
