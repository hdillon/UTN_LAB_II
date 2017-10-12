using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenerics1
{
    public class Documento
    {
        private int numero;

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public Documento()
        {
        
        }

        public Documento(int numero)
        {
            this.numero = numero;
        }

    }
}
