using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class AutoMovil
    {
        private string descripcion;
        private TanqueDeGasolina tanque;

        private AutoMovil()
        {
            this.tanque = new TanqueDeGasolina(3);
        }

        public AutoMovil(string descripcion):this()
        {
            this.descripcion = descripcion;
        }

        public TanqueDeGasolina Tanque
        {
            get
            {
                return this.tanque;
            }
        }

        public string Acelerar()
        {
            if(tanque.CantidadActual > 0)
            {
                tanque.CantidadActual--;
                return "Acelerando...";
            }
            else
            {
                throw new SinGasolinaException("Gasolina agotada!");
            }
        }

        public int CargarGasolina()
        {
            try
            {
                tanque.Cargar();
            }catch(TanqueLlenoException e)
            {
                throw new Exception("Error al cargar gasolina", e);
            }

            return tanque.CantidadActual;
        }

    }
}
