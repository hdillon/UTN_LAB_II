using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEventos2
{
    public partial class FormPersona : Form
    {
        private Persona personaDelFormulario;
        private event DelegadoString Notificar;

        public FormPersona()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            if (personaDelFormulario == null)
            {
                personaDelFormulario = new Persona(this.txtNombre.Text, this.txtApellido.Text);
                this.btnFormulario.Text = "Actualizar";
                this.Notificar("Se ha creado la persona!");
            }
            else
            {
                if(personaDelFormulario.Nombre != this.txtNombre.Text)
                {
                    personaDelFormulario.Nombre = this.txtNombre.Text;
                    this.Notificar("Se ha actualizado el nombre!");
                }
                if (personaDelFormulario.Apellido != this.txtApellido.Text)
                {
                    personaDelFormulario.Apellido = this.txtApellido.Text;
                    this.Notificar("Se ha actualizado el apellido!");
                }
                this.Notificar(personaDelFormulario.Mostrar());
            }
        }

        public static void NotificarCambio(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

        
    }
}
