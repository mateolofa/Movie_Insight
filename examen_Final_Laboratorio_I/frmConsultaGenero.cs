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
    public partial class frmConsultaGenero : Form
    {
        public frmConsultaGenero()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Vector.Indice; i++)
            {
                cmbGenero.Items.Add(Vector.genero[i].Nombre);
            }
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 g = cmbGenero.SelectedIndex;
            lblCodigoR.Text = Convert.ToString(Vector.genero[g].Codigo);
            lblDescripcionR.Text = Vector.genero[g].Descripcion;
        }
    }
}
