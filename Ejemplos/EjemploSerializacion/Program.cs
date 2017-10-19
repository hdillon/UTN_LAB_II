using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSerializacion1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Biblioteca biblioteca = new Biblioteca("Mi Biblioteca", "Calle falsa 123");
            Libro libro1 = new Libro("El Principito", "Juan Perez", "1234");
            Libro libro2 = new Libro("El Principito", "Juan Perez", "5678");
            Libro libro3 = new Libro("El Principito", "Juan Perez", "9876");

            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            Console.WriteLine(biblioteca.Mostrar());

            biblioteca.Serializarse();

            Console.ReadKey();
        }
    }
}
