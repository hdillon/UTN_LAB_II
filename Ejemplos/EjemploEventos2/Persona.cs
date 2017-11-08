using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos2
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private String nombre;
        private String apellido;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public String Mostrar()
        {
            return "Nombre: " + nombre + " - Apellido: " + apellido;
        }
    }
}
