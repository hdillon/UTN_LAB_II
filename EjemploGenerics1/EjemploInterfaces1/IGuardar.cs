using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces1
{
    public interface IGuardar
    {
        bool Guardar(Object T);

        Object Leer();

    }
}
