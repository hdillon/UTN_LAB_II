using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenerics1
{
    public class Recibo : Documento
    {

        public Recibo() : this (0)
        {

        }

        public Recibo(int numero) : base(numero)
        {

        }
    }
}
