using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEventos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnManejadorClick.Click += new EventHandler(AgregarManejadores);
            btnManejadorDobleClick.Click += new EventHandler(AgregarManejadores);
            btnMouseHover.Click += new EventHandler(AgregarManejadores);
            btnRemover.Click += new EventHandler(AgregarManejadores);
        }

        private void AgregarManejadores(object boton, EventArgs e)
        {
            if ((Button)boton == this.btnManejadorClick)
                txtTexto.Click += new EventHandler(ManejadorClick);
            else if ((Button)boton == this.btnManejadorDobleClick)
                txtTexto.DoubleClick += new EventHandler(ManejadorDobleClick);
            else if ((Button)boton == this.btnMouseHover)
                txtTexto.MouseHover += new EventHandler(ManejadorMouseHover);
            else if ((Button)boton == this.btnRemover)
            {
                txtTexto.Click -= new EventHandler(ManejadorClick);
                txtTexto.DoubleClick -= new EventHandler(ManejadorDobleClick);
                txtTexto.MouseHover -= new EventHandler(ManejadorMouseHover);
                txtTexto.ClearUndo();
            }
        }

        private void ManejadorClick(object sender, EventArgs e)
        {
            txtTexto.BackColor = Color.Green;
        }

        private void ManejadorDobleClick(object sender, EventArgs e)
        {
            txtTexto.Text = txtTexto.Text.ToUpper();
        }

        private void ManejadorMouseHover(object sender, EventArgs e)
        {
            txtTexto.BackColor = Color.Red;
        }

    }
}
