using System.Text;

namespace EjemploAbstract
{
    public enum Arma
    {
        Espada = 10,
        Flecha = 6,
        Cuchillo = 5,
        Palo = 3
    }

    public abstract class Personaje
    {
        #region Atributos
        private string nombre;
        private int cantidadDeVida;
        #endregion

        #region Constructores
        public Personaje(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }
        #endregion

        #region Propiedades
        public string Nombre {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }

        }

        public int Vida
        {
            get
            {
                return cantidadDeVida;
            }
            set
            {
                cantidadDeVida = value;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Atacar recibe un personeja como parámetro y le resta una cantidad de vida dependiendo el tipo de personaje que esté atacando
        /// </summary>
        /// <param name="objetivo"></param>
        /// <returns></returns>
        public abstract string Atacar(Personaje objetivo);

        public abstract string protegerse();

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre: {0}", this.nombre));
            sb.AppendLine(string.Format("Vida: {0}", this.cantidadDeVida));

            return sb.ToString();
        }
        #endregion
    }
}
