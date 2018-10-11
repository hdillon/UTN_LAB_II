using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSemaforo
{
    public class Calle
    {
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Calle()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public static Calle operator +(Calle c, Vehiculo v)
        {
            c.vehiculos.Add(v);
            return c;
        }
    }
}
