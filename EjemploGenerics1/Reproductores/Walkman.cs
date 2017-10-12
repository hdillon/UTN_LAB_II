using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public class Walkman : Reproductor, IReproductor
    {
        private Cancion[] cassete;

        public Walkman(int volumen, int bateria) : base (bateria, volumen)
        {
            this.cassete = new Cancion[0];
        }

        public Cancion[] Insertar
        {
            set
            {
                this.cassete = value;
            }
        }


        public void Encender()
        {

        }

        public void Apagar()
        {

        }

        public String Reproducir()
        {
            return "";
        }


        public String SubirVolumen()
        {
            return "";
        }

        public String BajarVolumen()
        {
            return "";
        }

    }
}
