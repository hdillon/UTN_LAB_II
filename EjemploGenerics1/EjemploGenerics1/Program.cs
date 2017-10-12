using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenerics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(100);
            Recibo r1 = new Recibo(200);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad = contabilidad + f1;
            contabilidad = contabilidad + r1;

            Console.WriteLine("\n Egresos:");
            foreach(Factura f in contabilidad.Egresos)
            {
                Console.WriteLine(f.Numero);
            }

            Console.WriteLine("\n\n Ingresos:");
            foreach (Recibo r in contabilidad.Ingresos)
            {
                Console.WriteLine(r.Numero);
            }

            Console.ReadKey();

        }
    }
}
