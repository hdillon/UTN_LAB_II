using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class TanqueLlenoException : ApplicationException
    {
        public TanqueLlenoException(string mensaje) : base(mensaje)
        {

        }

        public TanqueLlenoException(string mensaje, Exception e) : base(mensaje, e)
        {

        }
    }
}
