using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace MiBiblioteca
{
    [Serializable]
    public class Biblioteca
    {
        private String nombre;
        private String direccion;
        private List<Libro> libros;

        public Biblioteca(String nombre, String direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            libros = new List<Libro>();
        }

        public Biblioteca()
        {
        }

        public String Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value; 
            }
        }

        public String Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public List<Libro> Libros
        {
            get
            {
                return libros;
            }

            set
            {
                libros = value;
            }
        }

        public void AgregarLibro(Libro l)
        {
            this.libros.Add(l);
        }

        public String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Direccion: " + direccion);
            sb.AppendLine("Libros: ");

            foreach(Libro l in libros)
                sb.AppendLine(l.ToString());

            return sb.ToString();
        }

        public bool Serializar()
        {
            try
            {
                XmlTextWriter escritor = new XmlTextWriter(@AppDomain.CurrentDomain.BaseDirectory + this.nombre + ".xml", Encoding.UTF8);

                XmlSerializer serializador = new XmlSerializer(typeof(List<Libro>));
                serializador.Serialize(escritor, this.libros);

                escritor.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Deserializar()
        {
            try
            {
                XmlTextReader lector = new XmlTextReader(@AppDomain.CurrentDomain.BaseDirectory + this.nombre + ".xml");

                XmlSerializer deserializador = new XmlSerializer(typeof(List<Libro>));

                this.libros = (List<Libro>)deserializador.Deserialize(lector);

                lector.Close();
                return true;
            }
            catch (Exception e)
            {
                //throw new BibliotecaException("Ocurrió una excepción al intentar deserializar en...\n", "Clase: Biblioteca\n", "Método: Deserializar\n", e);
                return false;
            }
        }


    }
}
