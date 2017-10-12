using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public class Discman : Reproductor, IReproductor
    {
        private Cancion[] cd;

        public Discman(int volumen, int bateria) : base (bateria, volumen)
        {
            this.cd = new Cancion[0];
        }

        public Cancion[] Insertar
        {
            set
            {
                this.cd = value;
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
            StringBuilder sb = new StringBuilder();
            if (Encendido == false)
                throw new ReproductorExcepcion("El reproductor no está encendido!");
            else if (Bateria == 0)
            {
                Encendido = false;
                throw new ReproductorExcepcion("Se quedó sin pila!");
            }
            else if (cd.Length == 0)
                throw new ReproductorExcepcion("Debe insertar un CD!");
            else
            {
                for (int i = 1; i <= cd.Length; i++)
                {
                    sb.AppendFormat("\nREPRODUCIENDO CANCION {0}: {1}", i, cd[i - 1].Mostrar());
                    Bateria--;
                    if (Bateria == 0)
                    {
                        Encendido = false;
                        throw new ReproductorExcepcion("Se quedó sin pila!");
                    }
                }
            }
            return sb.ToString();
        }

        public String SubirVolumen()
        {
            if (base.Volumen == 10)
                throw new ReproductorExcepcion("El volumen está al máximo!");
            else
                base.Volumen++;

            return "VOLUMEN: " + base.Volumen;
        }

        public String BajarVolumen()
        {
            if (base.Volumen == 0)
                throw new ReproductorExcepcion("El volumen está al mínimo!");
            else
                base.Volumen--;

            return "VOLUMEN: " + base.Volumen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Canciones: ");
            foreach(Cancion c in cd)
            {
                sb.AppendLine(c.Mostrar());
            }
            return sb.ToString();
        }


    }
}
