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
    public partial class frmListadoGeneral : Form
    {
        public frmListadoGeneral()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvCine.Rows.Clear();
            Int32 contador = 0;
            for (Int32 i = 0; i < Vector.Indice; i++)
            {
                dgvCine.Rows.Add(Vector.genero[i].Codigo, Vector.genero[i].Nombre, Vector.genero[i].Descripcion);
                contador++;
            }
            lblCantidadG.Text = Convert.ToString(contador);
        }

        private void frmListadoGeneral_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#2A0A35");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.White;
            }
            dgvCine.BackgroundColor = ColorTranslator.FromHtml("#2A0A35");
        }
    }
}
