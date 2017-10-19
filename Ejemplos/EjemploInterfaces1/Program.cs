using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializar<Object, Object> ser = new Serializar<object, object>();
            GuardarTexto<String, Object> gt = new GuardarTexto<string, object>();

            Console.WriteLine(gt.Guardar("Sarlanga"));
            Console.WriteLine(ser.Guardar("Sarlanga"));

            Console.WriteLine(gt.Leer());
            Console.WriteLine(ser.Leer());

            Console.ReadKey();
        }
    }
}
