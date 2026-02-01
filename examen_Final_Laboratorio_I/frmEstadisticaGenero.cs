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
    public partial class frmEstadisticaGenero : Form
    {
        public frmEstadisticaGenero()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 c = 0;
            Int32 f = 0;
            Int32 contador = 0;
            Int32 p = 0;
            Int32 Promedio = 0;
            Int32 max = 0;
            Int32 min = Vector.matriz[0, 0];
            Int32 m = 0;
            Int32 mi = 0;
            dgvGenero.Rows.Clear();
            while (f < Vector.Indice)
            {
                while (c < Vector.meses.Length)
                {
                    p = p + Vector.matriz[f, c];
                    contador++;
                    if (max < Vector.matriz[f, c])
                    {
                        max = Vector.matriz[f, c];
                        m = c;
                    }
                    if (min > Vector.matriz[f, c])
                    {
                        min = Vector.matriz[f, c];
                        mi = c;
                    }
                    c++;
                }
                c = 0;
                Promedio = p / contador;
                dgvGenero.Rows.Add(Vector.genero[f].Nombre, p, Promedio, Vector.meses[m], Vector.meses[mi]);
                p = 0;
                Promedio = 0;
                contador = 0;
                max = 0;
                min = Vector.matriz[f, 0];
                f++;
            }
        }

        private void frmEstadisticaGenero_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
            dgvGenero.BackgroundColor = ColorTranslator.FromHtml("#2A0A35");
        }
    }
}
