using System.Text;

namespace EjemploAbstract
{
    public class Mago : Personaje
    {
        private int energia;

        public Mago(string nombre, int vida, int energia):base (nombre, vida)
        {
            this.energia = energia;
        }

        public override string Atacar(Personaje objetivo)
        {
            if (energia > 3)
            {
                energia -= 3;
                objetivo.Vida = objetivo.Vida - 3;
                return string.Format("El Mago {0} utilizó un hechizo contra {1}", this.Nombre, objetivo.Nombre);
            }
            else
            {
                return string.Format("El Mago {0} no tiene energía para atacar!", this.Nombre);
            }
        }

        public override string protegerse()
        {
            return "";
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Tipo: Mago");
            sb.AppendLine(string.Format("Energia: {0}", this.energia));

            return sb.ToString();
        }
    }
}
