using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Libro
    {
        private String titulo;
        private String autor;
        private String isbn;

        public Libro(String titulo, String autor, String isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
        }

        public Libro()
        {
        }

        public String Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public String Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public String Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Título: " + titulo);
            sb.Append(" - Autor: " + autor);
            sb.Append(" - ISBN: " + isbn);

            return sb.ToString();
        }

    }
}
