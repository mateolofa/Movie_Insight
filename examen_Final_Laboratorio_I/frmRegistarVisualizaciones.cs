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
    public partial class frmRegistarVisualizaciones : Form
    {
        public frmRegistarVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmRegistarVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            cmbMeses.Items.Clear();
            for(Int32 i = 0; i < Vector.Indice; i++)
            {
                cmbGenero.Items.Add(Vector.genero[i].Nombre);
            }
            for (Int32 i = 0; i < Vector.meses.Length; i++)
            {
                cmbMeses.Items.Add(Vector.meses[i]);
            }
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 suma = Convert.ToInt32(txtVisualizaciones.Text);
            Int32 g = cmbGenero.SelectedIndex; 
            Int32 m = cmbMeses.SelectedIndex;
            Vector.matriz[g,m] = Vector.matriz[g,m] + suma;
            MessageBox.Show(" Visualizaciones agregadas");
            txtVisualizaciones.Text = "";

        }

        private void txtVisualizaciones_TextChanged(object sender, EventArgs e)
        {
            if(txtVisualizaciones.Text != "")
            {
                btnCargar.Enabled = true;
            }
        }
    }
}
