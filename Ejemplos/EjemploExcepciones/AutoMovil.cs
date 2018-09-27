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

        public AutoMovil(string descripcion)
        {
            this.descripcion = descripcion;
            this.tanque = new TanqueDeGasolina(3);
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
