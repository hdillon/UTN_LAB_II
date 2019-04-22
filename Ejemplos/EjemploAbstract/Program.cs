using System;

namespace EjemploAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje mago = new Mago("Harry Potter", 100, 70);
            Personaje arquero = new Arquero("Ojo de Halcón", 120, 3);
            Personaje gladiador = new Gladiador("Maximus", 130, Arma.Espada);

            Console.WriteLine(mago.Mostrar());
            Console.WriteLine("*********************");
            Console.WriteLine(arquero.Mostrar());
            Console.WriteLine("*********************");
            Console.WriteLine(gladiador.Mostrar());
            Console.WriteLine("*********************");

            Console.WriteLine(gladiador.Atacar(arquero));
            Console.WriteLine(mago.Atacar(gladiador));

            Console.WriteLine("*********************");
            Console.WriteLine(mago.Mostrar());
            Console.WriteLine("*********************");
            Console.WriteLine(arquero.Mostrar());
            Console.WriteLine("*********************");
            Console.WriteLine(gladiador.Mostrar());

            Console.ReadKey();
        }
    }
}
