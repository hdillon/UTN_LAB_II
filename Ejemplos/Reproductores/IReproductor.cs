using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public interface IReproductor
    {

        int Bateria
        {
            get;
            set;
        }

        Cancion[] Insertar
        {
            set;
        }

        void Encender();

        void Apagar();

        String Reproducir();

        String SubirVolumen();

        String BajarVolumen();

        String Mostrar();

        String QueSoy();
    }
}
