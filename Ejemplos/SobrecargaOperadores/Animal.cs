using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    public class Animal
    {
        public string nombre;
        int edad;

        #region Constructores
        public Animal()
        {

        }

        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        #endregion
    }
}
