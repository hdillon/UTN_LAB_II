using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploBD
{
    public partial class Form1 : Form
    {
        private List<Persona> listaPersonas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPersonas = new List<Persona>();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                listaPersonas = PersonaDAO.Leer();
                CargarListBox();
            }
            catch(Exception ex)
            {   
                MessageBox.Show("Error al leer de la base! " + ex.Message);
            }
            
        }

        private void CargarListBox()
        {
            if(listaPersonas != null)
            {
                this.lstPersonas.Items.Clear();
                foreach (Persona unaPersona in listaPersonas)
                {
                    this.lstPersonas.Items.Add(unaPersona.ToString());
                }
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(lstPersonas.SelectedIndex.ToString());
            txtNombre.Text = listaPersonas[lstPersonas.SelectedIndex].Nombre;
            txtApellido.Text = listaPersonas[lstPersonas.SelectedIndex].Apellido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona(txtNombre.Text, txtApellido.Text);
                PersonaDAO.Guardar(p);
            }catch(Exception ex)
            {
                MessageBox.Show("Error al insertar " + ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = listaPersonas[lstPersonas.SelectedIndex];
                PersonaDAO.Borrar(p.ID);
            }catch(Exception ex)
            {
                MessageBox.Show("Error al intentar borrar " + ex);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = listaPersonas[lstPersonas.SelectedIndex];
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                PersonaDAO.Modificar(p);
            }catch(Exception ex)
            {
                MessageBox.Show("Error al modificar " + ex.Message);
            }
        }
    }
}
