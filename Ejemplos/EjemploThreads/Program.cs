using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploThreads
{

    class Test
    {
        public int[] miArray = new int[100];

        public void miMetodo()
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
        
            }
            Console.WriteLine("Milisegundos transcurridos: " + (DateTime.Now - now).Milliseconds);
        }

        public void llenarArray()
        {
            for(int i = 0; i < miArray.Length; i++)
            {
                miArray[i] = i;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Main Thread Starting");
            //Thread.CurrentThread.Name = "Main ";
            //Test t = new Test();
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio negocio = new Negocio(c1, c2);
            negocio.Clientes.Add("Cliente1");
            negocio.Clientes.Add("Cliente2");
            negocio.Clientes.Add("Cliente3");
            negocio.Clientes.Add("Cliente4");
            negocio.Clientes.Add("Cliente5");
            negocio.Clientes.Add("Cliente6");
            negocio.Clientes.Add("Cliente7");
            negocio.Clientes.Add("Cliente8");


            Thread t1 = new Thread(negocio.AsignarCaja);
            t1.Name = "Negocio ";

            Thread t2 = new Thread(negocio.Caja1.AtenderClientes);
            t2.Name = "Caja1 ";

            Thread t3 = new Thread(negocio.Caja2.AtenderClientes);
            t3.Name = "Caja2 ";

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
  

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("In thread " + Thread.CurrentThread.Name + i);
                Thread.Sleep(500);
                if (i == 1 && t1.IsAlive)
                    t1.Suspend();

                if (i == 5 && t1.IsAlive)
                {
                    t1.Resume();
                    t1.Join();
                }
                    
            }
            Console.WriteLine("Main Thread Terminates");
            */


            Console.Read();
        }
    }
}
