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
    public partial class frmVisualizacionGenero : Form
    {
        public frmVisualizacionGenero()
        {
            InitializeComponent();
        }

        private void frmVisualizacionGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Vector.Indice; i++)
            {
                cmbGenero.Items.Add(Vector.genero[i].Nombre);
            }
            cmbGenero.SelectedIndex = 0;
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 g = cmbGenero.SelectedIndex;
            Int32 contador = 0;
            Int32 p = 0;
            Int32 Promedio = 0;
            Int32 max = 0;
            Int32 min = Vector.matriz[g, 0];
            dgvListar.Rows.Clear();
            for (Int32 i = 0; i < Vector.meses.Length; i++)
            {
                dgvListar.Rows.Add(Vector.meses[i], Vector.matriz[g, i]);
                contador++;
                p = p + Vector.matriz[g, i];
                if (max < Vector.matriz[g, i])
                {
                    max = Vector.matriz[g, i];
                }
                if (min > Vector.matriz[g, i])
                {
                    min = Vector.matriz[g, i];
                }
            }
            Promedio = p / contador;
            lblMayorR.Text = Convert.ToString(max);
            lblMenorR.Text = Convert.ToString(min);
            lblPromedioR.Text = Convert.ToString(Promedio);
            lblTotalR.Text = Convert.ToString(p);
        }
    }
}
