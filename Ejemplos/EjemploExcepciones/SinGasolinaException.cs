using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class SinGasolinaException : ApplicationException
    {
        public SinGasolinaException(string mensaje) : base(mensaje)
        {

        }

        public SinGasolinaException(string mensaje, Exception e) : base(mensaje, e)
        {

        }
    }
}
