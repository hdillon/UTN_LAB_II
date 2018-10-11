using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EntidadesSemaforo
{
    public class Semaforo
    {
        private colores color;

        public Semaforo()
        {
            color = colores.ROJO;
        }

        public void CambiarAVerde()
        {
            while (this.color != colores.VERDE)
            {
                Thread.Sleep(2000);
                if (this.color == colores.ROJO)
                    this.color = colores.AMARILLO;
                else
                    this.color = colores.VERDE;
                    //this.InformarEstado(this, new EventArgs());
            }
        }

        public void CambiarARojo()
        {
            while (this.color != colores.ROJO)
            {
                Thread.Sleep(2000);
                if (this.color == colores.VERDE)
                    this.color = colores.AMARILLO;
                else
                    this.color = colores.ROJO;
                //this.InformarEstado(this, new EventArgs());
            }
        }
    }
}
