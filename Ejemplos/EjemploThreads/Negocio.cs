using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploThreads
{
    public class Negocio
    {
        private List<String> clientes = new List<String>();
        Caja caja1;
        Caja caja2;

        public Negocio(Caja c1, Caja c2)
        {
            clientes = new List<String>();
            caja1 = c1;
            caja2 = c2;
        }

        public Caja Caja1
        {
            get { return caja1; }
        }

        public Caja Caja2
        {
            get { return caja2; }
        }

        public List<String> Clientes
        {
            get { return clientes; }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (String cliente in clientes)
            {
                if (caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                    caja1.FilaClientes.Add(cliente);
                else
                    caja2.FilaClientes.Add(cliente);

                Thread.Sleep(1000);
            }
        }
    }
}

