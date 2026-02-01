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
    public partial class frmVisualizacionMes : Form
    {
        public frmVisualizacionMes()
        {
            InitializeComponent();
        }

        private void frmVisualizacionMes_Load(object sender, EventArgs e)
        {
            cmbMeses.Items.Clear();
            for (Int32 i = 0; i < Vector.meses.Length; i++)
            {
                cmbMeses.Items.Add(Vector.meses[i]);
            }
            cmbMeses.SelectedIndex = 0;
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 m = cmbMeses.SelectedIndex;
            Int32 contador = 0;
            Int32 p = 0;
            Int32 Promedio = 0;
            Int32 max = 0;
            Int32 min = Vector.matriz[0, m];
            dgvListar.Rows.Clear();
            for (Int32 i = 0; i < Vector.Indice; i++)
            {
                dgvListar.Rows.Add(Vector.genero[i].Nombre, Vector.matriz[i, m]);
                contador++;
                p = p + Vector.matriz[i, m];
                if (max < Vector.matriz[i, m])
                {
                    max = Vector.matriz[i, m];
                }
                if (min > Vector.matriz[i, m])
                {
                    min = Vector.matriz[i, m];
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
