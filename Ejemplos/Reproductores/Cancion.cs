using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductores
{
    public class Cancion
    {
        private String autor;
        private String titulo;

        public String Autor
        {
            get
            {
                return autor;
            }
        }

        public String Titulo
        {
            get
            {
                return titulo;
            }
        }

        public Cancion(String autor, String titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        public String Mostrar()
        {
            return "Autor: " + autor + " Título: " + titulo; 
        }
    }
}
