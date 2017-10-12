using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public class Reproductor
    {
        int bateria;
        int volumen;
        bool encendido;

        public Reproductor(int bateria, int volumen)
        {
            this.bateria = bateria;
            this.volumen = volumen;
            this.encendido = false;
        }

        #region PROPIEDADES
        public int Bateria
        {
            get
            {
                return bateria;
            }
            set
            {
                bateria = value;
            }
        }

        public int Volumen
        {
            get
            {
                return volumen;
            }

            set
            {
                volumen = value;
            }
        }

        public bool Encendido
        {
            get
            {
                return encendido;
            }

            set
            {
                encendido = value;
            }
        }
        #endregion

        public String Mostrar()
        {
            StringBuilder sb = new StringBuilder("Bateria: " + bateria);
            sb.AppendLine(" Volumen: " + volumen);
            return sb.ToString();
        }




    }
}
