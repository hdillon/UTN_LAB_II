using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces1
{
    class Serializar<S, V> : IGuardar
    {
        public bool Guardar(Object S)
        {
            return true;
        }

        public Object Leer()
        {
            return "Objeto Leído!";
        }

    }
}
