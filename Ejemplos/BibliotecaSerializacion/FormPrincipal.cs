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
    public partial class FormPrincipal : Form
    {
        private List<Libro> listaLibros;

        public List<Libro> ListaLibros
        {
            get { return this.listaLibros; }
            set { this.listaLibros = value; }
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.ListaLibros = new List<Libro>();
            this.IsMdiContainer = true;
        }

        private void mostrarBiblioteca_Click(object sender, EventArgs e)
        {
            FormBiblioteca formBiblioteca = new FormBiblioteca();
            //grilla.StartPosition = FormStartPosition.CenterParent;
            //grilla.MdiParent = this;
            //grilla.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //grilla.Dock = DockStyle.Fill;
            //grilla.Show();


            formBiblioteca.StartPosition = FormStartPosition.CenterScreen;
            if (this.listaLibros != null)
            {
                formBiblioteca.MiBiblioteca.Libros = this.listaLibros;
                formBiblioteca.Show();
            }
        }

        private void agregarLibro_Click(object sender, EventArgs e)
        {
            FormNuevoLibro formNuevoLibro = new FormNuevoLibro();
            formNuevoLibro.StartPosition = FormStartPosition.CenterParent;

            if (formNuevoLibro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.listaLibros.Add(formNuevoLibro.LibroDelFormulario);
            }
        }

        
    }
}
