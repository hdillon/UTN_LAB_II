using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido)
        {
            this.edad = edad;
        }
        #endregion

        #region Operadores
        //Ejemplo operador unario ++
        public static Persona operator ++(Persona unaPersona)
        {
            unaPersona.edad = unaPersona.edad + 1;
            return unaPersona;
        }

        //Ejemplo operador binario +
        public static Persona operator +(Persona unaPersona, int años)
        {
            unaPersona.edad = unaPersona.edad + años;
            return unaPersona;
        }

        //Ejemplo operador binario -
        public static Persona operator -(Persona unaPersona, int años)
        {
            if(años <= unaPersona.edad)
            {
                unaPersona.edad = unaPersona.edad - años;
            }
            
            return unaPersona;
        }

        //Ejemplo operdor de comparación
        public static bool operator ==(Persona unaPersona, Animal unAnimal)
        {
            return unaPersona.nombre == unAnimal.nombre;
        }

        //Sobrecarga obligatoria por haber sobrecargado el operador ==
        public static bool operator !=(Persona unaPersona, Animal unAnimal)
        {
            return unaPersona != unAnimal;
        }

        //Ejemplo operador explicit para poder castear una instancia de persona a string
        public static implicit operator string(Persona unaPersona)
        {
            return string.Format("Nombre: {0} - Apellido: {1} - Edad: {2}", unaPersona.nombre, unaPersona.apellido, unaPersona.edad);
        }

        //Ejemplo operador explicit para poder castear una instancia de Persona a Animal
        public static explicit operator Animal(Persona unaPersona)
        {
            return new Animal(unaPersona.nombre, unaPersona.edad);
        }
        #endregion
    }
}
