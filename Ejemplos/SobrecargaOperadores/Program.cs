using System;

namespace SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos 2 instancias, una de Persona y otra de Animal
            Persona unaPersona = new Persona("Juan", "Perez", 25);
            Animal unAnimal = new Animal("Firulais", 5);

            //Invocamos al operador ++ sobrecargado en persona para incrementar su edad en 1 (26)
            unaPersona = unaPersona++;

            //Le sumamos 10 años más invocando a la sobrecarga del operador + (36)
            unaPersona = unaPersona + 10;

            //Invocamos a la sobrecarga implícita de Persona para convertirla en string
            string datosPersona = unaPersona;

            //Mostramos el resultado de la conversión implícita a string
            Console.WriteLine(datosPersona);
            Console.WriteLine();

            //invocamos a la sobrecarga del operador == en Persona para comparar una instancia de Persona con una de Animal
            if (unaPersona == unAnimal)
                Console.WriteLine("unaPersona y unAnimal son iguales!");
            else
                Console.WriteLine("unaPersona y unAnimal son distintos!");
            Console.WriteLine();
            //invocamos al operador Explicit de Persona que nos permite castear una instancia de tipo Persona a una de tipo Animal
            Animal otroAnimal = (Animal)unaPersona;

            if (unaPersona == otroAnimal)
                Console.WriteLine("unaPersona y otroAnimal son iguales!");
            else
                Console.WriteLine("unaPersona y otroAnimal son distintos!");

            Console.ReadKey();
        }
    }
}
