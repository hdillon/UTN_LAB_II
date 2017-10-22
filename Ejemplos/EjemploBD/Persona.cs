using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBD
{
    public class Persona
    {
        private int id;
        private String nombre;
        private String apellido;

        public Persona(int id, String nombre, String apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

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

        public override string ToString()
        {
            return nombre + " " + apellido;
        }



    }
}
