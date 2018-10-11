using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMovil auto = new AutoMovil("Auto");

            try
            {
                Console.WriteLine("Gasolina actual: " + auto.CargarGasolina());
                Console.WriteLine("Gasolina actual: " + auto.CargarGasolina());
                Console.WriteLine("Gasolina actual: " + auto.CargarGasolina());
                Console.WriteLine("Gasolina actual: " + auto.CargarGasolina());
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                    Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("***FIN CARGAR GASOLINA***");
            }

            try
            {
                Console.WriteLine(auto.Acelerar());
                Console.WriteLine(auto.Acelerar());
                Console.WriteLine(auto.Acelerar());
                Console.WriteLine(auto.Acelerar());
                Console.WriteLine(auto.Acelerar());//no se llega a ejecutar
            }
            catch (SinGasolinaException e1)
            {
                Console.WriteLine("Problemas de gasolina: " + e1.Message);
            }
            catch(Exception e2)
            {
                Console.WriteLine("Exception: " + e2.Message);
            }
            finally
            {
                Console.WriteLine("***FIN ACELERAR***");
            }
            


            Console.ReadKey();
        }
    }
}
