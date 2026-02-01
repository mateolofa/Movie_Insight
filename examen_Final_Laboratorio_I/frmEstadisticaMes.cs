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
    public partial class frmEstadisticaMes : Form
    {
        public frmEstadisticaMes()
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
            dgvMeses.Rows.Clear();
            while (c < Vector.meses.Length) 
            {  
                while(f < Vector.Indice)
                {
                    p = p + Vector.matriz[f, c];
                    contador++;
                    if (max < Vector.matriz[f, c])
                    {
                        max = Vector.matriz[f, c];
                        m = f;
                    }
                    if (min > Vector.matriz[f, c])
                    {
                        min = Vector.matriz[f, c];
                        mi = f;
                    }
                    f++;
                }
                f = 0;
                Promedio = p / contador;
                dgvMeses.Rows.Add(Vector.meses[c], p, Promedio, Vector.genero[m].Nombre, Vector.genero[mi].Nombre);
                p = 0;
                Promedio = 0;
                contador = 0;
                max = 0;
                min = Vector.matriz[0 , c];
                c++;
            }
        }

        private void frmEstadisticaMes_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
            dgvMeses.BackgroundColor = ColorTranslator.FromHtml("#2A0A35");

        }
    }
}
