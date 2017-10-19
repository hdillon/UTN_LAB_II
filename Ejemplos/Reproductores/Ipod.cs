using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public class Ipod : Reproductor, IReproductor
    {
        private List<Cancion> canciones;
        private int memoria;

        public Ipod(int volumen, int bateria) : base (bateria, volumen)
        {
            this.canciones = new List<Cancion>();
        }

        public Cancion[] Insertar
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Encender()
        {
            base.Encendido = true;
        }

        public void Apagar()
        {
            base.Encendido = false;
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

        public String QueSoy()
        {
            return "Soy Ipod";
        }

    }
}
