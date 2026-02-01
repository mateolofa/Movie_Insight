using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_Final_Laboratorio_I
{
    public partial class frmAgregarNuevoGenero : Form
    {
        public frmAgregarNuevoGenero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            activar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            activar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            activar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 i = 0;
            if (Vector.Indice < Vector.genero.Length)
            {
                
                while (i < Vector.Indice && Vector.genero[i].Codigo != Convert.ToInt32(txtCodigo.Text))
                {
                    i++;
                }
                if (i == Vector.Indice)
                {
                    Vector.genero[Vector.Indice].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.genero[Vector.Indice].Nombre = txtNombre.Text;
                    Vector.genero[Vector.Indice].Descripcion = txtDescripcion.Text;
                    Vector.Indice++;
                    limpiar();
                    MessageBox.Show(" Genero cargado con exito");
                }
                else
                {
                    MessageBox.Show(" Codigo ya encontrado, por favor ingrese uno nuevo");
                    txtCodigo.Text = "";
                }
            }    
            else
            {
                MessageBox.Show(" Se ha alcanzado la cantidad de generos posibles, reinicie el sistema");
            }
        }

        private void activar()
        {
            if (txtCodigo.Text != "" && txtDescripcion.Text != "" && txtNombre.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }

        private void frmAgregarNuevoGenero_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
            BackColor = ColorTranslator.FromHtml("#2A0A35");
        }
    }
}
