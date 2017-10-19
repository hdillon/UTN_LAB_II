using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces1
{
    class GuardarTexto<T, V> : IGuardar
    {
        public bool Guardar(Object T)
        {
            return true;
        }

        public Object Leer()
        {
            return "Texto Leído!";
        }
    }
}
