using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class TanqueDeGasolina
    {
        private int capacidadMáxima;
        private int cantidadActual;

        public TanqueDeGasolina(int capacidadMáxima)
        {
            this.capacidadMáxima = capacidadMáxima;
            this.cantidadActual = 0;
        }

        public int CantidadActual
        {
            get
            {
                return cantidadActual;
            }
            set
            {
                cantidadActual = value;
            }
        }

        public void Cargar()
        {
            if(cantidadActual == capacidadMáxima)
            {
                throw new TanqueLlenoException("El tanque ya está lleno!");
            }

            cantidadActual++;
        }
    }
}
