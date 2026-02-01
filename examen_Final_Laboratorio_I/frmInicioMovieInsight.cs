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
    public partial class frmInicioMovieInsight : Form
    {
        public frmInicioMovieInsight()
        {
            InitializeComponent();
        }
        Random r = new Random();

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.ShowDialog();
        }

        private void cargaAutomaticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 c = 0;
            Int32 f = 0;
            while (f < Vector.genero.Length)
            {
                while (c < Vector.meses.Length)
                {
                    Vector.matriz[f, c] = r.Next(0, 100);
                    c++;
                }
                c = 0;
                f++;
            }
            if (Vector.Indice < Vector.genero.Length)
            {
                Vector.Indice = 0;
                Vector.genero[Vector.Indice].Codigo = 1;
                Vector.genero[Vector.Indice].Nombre = "Accion";
                Vector.genero[Vector.Indice].Descripcion = "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 2;
                Vector.genero[Vector.Indice].Nombre = "Comedia";
                Vector.genero[Vector.Indice].Descripcion = "Películas diseñadas para hacer reír al público con situaciones cómicas y humor. ";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 3;
                Vector.genero[Vector.Indice].Nombre = "Drama";
                Vector.genero[Vector.Indice].Descripcion = "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 4;
                Vector.genero[Vector.Indice].Nombre = "Ciencia ficcion";
                Vector.genero[Vector.Indice].Descripcion = "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 5;
                Vector.genero[Vector.Indice].Nombre = "Romántica";
                Vector.genero[Vector.Indice].Descripcion = "Historias centradas en relaciones amorosas y emociones románticas.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 6;
                Vector.genero[Vector.Indice].Nombre = "Terror";
                Vector.genero[Vector.Indice].Descripcion = "Películas destinadas a asustar o provocar miedo en la audiencia.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 7;
                Vector.genero[Vector.Indice].Nombre = "Fantasia";
                Vector.genero[Vector.Indice].Descripcion = "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 8;
                Vector.genero[Vector.Indice].Nombre = "Misterio";
                Vector.genero[Vector.Indice].Descripcion = "Películas que involucran la resolución de un enigma o crimen.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 9;
                Vector.genero[Vector.Indice].Nombre = "Aventura";
                Vector.genero[Vector.Indice].Descripcion = "Narrativas emocionantes que siguen a los personajes en viajes y desafíos.";
                Vector.Indice++;

                Vector.genero[Vector.Indice].Codigo = 10;
                Vector.genero[Vector.Indice].Nombre = "Animacion";
                Vector.genero[Vector.Indice].Descripcion = "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven.";
                Vector.Indice++;

                MessageBox.Show(" Datos cargados exitosamente");
            }
            else
            {
                MessageBox.Show(" Los datos ya han sido cargados");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarNuevoGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoGenero ventana = new frmAgregarNuevoGenero();
            ventana.ShowDialog();
        }

        private void listadoGeneralDeGenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoGeneral ventana = new frmListadoGeneral();
            ventana.ShowDialog();
        }

        private void consultaDeDatosDeUnGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaGenero v = new frmConsultaGenero();
            v.ShowDialog();
        }

        private void registrarVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistarVisualizaciones v = new frmRegistarVisualizaciones();
            v.ShowDialog();
        }

        private void consultaDeVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVisualizaciones v = new frmConsultaVisualizaciones();
            v.ShowDialog();
        }

        private void visualizacionesDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionMes v = new frmVisualizacionMes();
            v.ShowDialog();
        }

        private void visualizacionesDeUnGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionGenero v = new frmVisualizacionGenero();
            v.ShowDialog();
        }

        private void estadisticaDeVisualizacionesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaMes v = new frmEstadisticaMes();
            v.ShowDialog();
        }

        private void estadisticaDeVisualizacionesPorGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaGenero v = new frmEstadisticaGenero();
            v.ShowDialog();
        }
    }
}
