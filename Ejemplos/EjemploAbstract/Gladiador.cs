using System.Text;

namespace EjemploAbstract
{
    public class Gladiador : Personaje
    {
        private Arma arma;

        public Gladiador(string nombre, int vida, Arma arma): base(nombre, vida)
        {
            this.arma = arma;
        }

        public override string Atacar(Personaje objetivo)
        {

            objetivo.Vida = objetivo.Vida - (int)arma;
            return string.Format("El Gladiador {0} atacó con su {1} a {2}", this.Nombre, this.arma, objetivo.Nombre);
        }

        public override string protegerse()
        {
            return "";
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Tipo: Gladiador");
            sb.AppendLine(string.Format("Arma: {0}", arma));
            return sb.ToString();
        }
    }
}
