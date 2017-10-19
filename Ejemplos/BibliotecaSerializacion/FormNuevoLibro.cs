using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace BibliotecaSerializacion
{
    public partial class FormNuevoLibro : Form
    {
        private Libro libroDelFormulario;

        public Libro LibroDelFormulario
        {
            get { return this.libroDelFormulario; }
            set { this.libroDelFormulario = value; }
        }


        public FormNuevoLibro()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (this.txtTitulo.Text != "" && this.txtAutor.Text != "" && this.txtIsbn.Text != "")
            {
                this.libroDelFormulario = new Libro(this.txtTitulo.Text, this.txtAutor.Text, this.txtIsbn.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
