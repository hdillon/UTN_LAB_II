using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace EjemploSerializacion1
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
                sb.AppendLine(l.Mostrar());

            return sb.ToString();
        }

        public bool Serializarse()
        {
            try
            {
                XmlTextWriter escritor = new XmlTextWriter(@AppDomain.CurrentDomain.BaseDirectory + this.nombre, Encoding.UTF8);

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

/*public bool DeSerializarse()
        {
            try
            {
                List<Llamada> auxiliar;
                XmlTextReader lector = new XmlTextReader(@"" + this.RutaDeArchivo);

                XmlSerializer deserializador = new XmlSerializer(typeof(List<Llamada>));

                auxiliar = (List<Llamada>)deserializador.Deserialize(lector);

                lector.Close();
                return true;
            }
            catch (Exception algo)
            {
                throw new CentralitaException("Ocurrió una excepción al intentar deserializar en...\n", "Clase: Centralita\n", "Método: Deserializar\n", algo);
                return false;
            }
        }*/


    }
}
