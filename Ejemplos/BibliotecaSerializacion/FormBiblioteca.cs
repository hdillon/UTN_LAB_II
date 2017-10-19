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
    public partial class FormBiblioteca : Form
    {
        private Biblioteca miBiblioteca;

        public Biblioteca MiBiblioteca
        {
            get
            {
                return miBiblioteca;
            }
            set
            {
                miBiblioteca = value;
            }
        }

        public FormBiblioteca()
        {
            InitializeComponent();
            miBiblioteca = new Biblioteca("Mi Biblioteca", "Av. Mitre 750");
        }

        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            this.Text = miBiblioteca.Nombre + " - " + miBiblioteca.Direccion;
            this.CargarListBox();
        }

        protected void CargarListBox()
        {
            if (this.miBiblioteca.Libros != null)
            {
                foreach (Libro unLibro in this.miBiblioteca.Libros)
                {
                    this.listBoxLibros.Items.Add(unLibro.ToString());
                }
            }
        }
        
        private void Serializar_Click(object sender, EventArgs e)
        {
            this.miBiblioteca.Serializar();
        }

        private void Deserializar_Click(object sender, EventArgs e)
        {
            this.listBoxLibros.Items.Clear();
            this.miBiblioteca.Deserializar();
            CargarListBox();
        }

        
    }
}
