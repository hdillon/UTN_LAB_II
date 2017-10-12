using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    class Program
    {
        static void Main(string[] args)
        {
            Discman discman1 = new Discman(10, 2);
            Reproductor discman2 = new Discman(10, 10);
            IReproductor discman3 = new Discman(20, 20);

            Cancion c1 = new Cancion("Autor1", "Título1");
            Cancion c2 = new Cancion("Autor2", "Título2");
            Cancion c3 = new Cancion("Autor3", "Título3");

            Cancion[] CD = {c1, c2, c3};

            
            discman1.Encender();
            discman1.Insertar = CD;
            //discman2.Insertar = CD;
            discman3.Insertar = CD;

            Console.WriteLine("Discman1: " + discman1.Mostrar());
            Console.WriteLine("Discman2: " + discman2.Mostrar());
            Console.WriteLine("Discman3: " + discman3.Mostrar());

            try
            {
                Console.WriteLine(discman1.Reproducir());
                discman1.SubirVolumen();
            }
            catch(ReproductorExcepcion e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {   
                Console.WriteLine(discman1.Reproducir());
                discman1.SubirVolumen();
            }
            catch (ReproductorExcepcion e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadKey();

        }
    }
}
