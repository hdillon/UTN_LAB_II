using System.Text;

namespace EjemploAbstract
{
    public class Arquero : Personaje
    {
        private int cantidadFlechas;

        public Arquero(string nombre, int vida, int cantidadFlechas):base (nombre, vida)
        {
            this.cantidadFlechas = cantidadFlechas;
        }

        public override string Atacar(Personaje objetivo)
        {
            if (cantidadFlechas > 0)
            {
                cantidadFlechas--;
                objetivo.Vida = objetivo.Vida - (int)Arma.Flecha;
                return string.Format("El Arquero {0} lanzó una flecha contra {1}", this.Nombre, objetivo.Nombre);
            }
            else
            {
                return string.Format("El Arquero {0} no tiene flechas para atacar!", this.Nombre);
            }
        }

        public override string protegerse()
        {
            return "";
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Tipo: Arquero");
            sb.AppendLine(string.Format("Cantidad de Flechas: {0}", cantidadFlechas));
            return sb.ToString();
        }
    }
}
