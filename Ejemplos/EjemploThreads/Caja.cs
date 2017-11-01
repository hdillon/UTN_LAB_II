using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploThreads
{
    public class Caja
    {
        private List<String> filaClientes;

        public List<String> FilaClientes
        {
            get { return filaClientes; }
        }

        public Caja()
        {
            filaClientes = new List<String>();
        }

        public void AtenderClientes()
        {
            foreach (String unCliente in filaClientes)
            {
                Console.WriteLine("Atendiendo al cliente " + unCliente + " en la " + Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
}
