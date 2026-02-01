namespace examen_Final_Laboratorio_I
{
    partial class frmInicioMovieInsight
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAutomaticaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeGenerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosDeUnGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVisualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVisualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizacionesDeUnMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesDeUnGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.generosToolStripMenuItem,
            this.visualizacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cargaAutomaticaDeDatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cargaAutomaticaDeDatosToolStripMenuItem
            // 
            this.cargaAutomaticaDeDatosToolStripMenuItem.Name = "cargaAutomaticaDeDatosToolStripMenuItem";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cargaAutomaticaDeDatosToolStripMenuItem.Text = "Carga automatica de datos...";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cargaAutomaticaDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoGeneroToolStripMenuItem,
            this.listadoGeneralDeGenerosToolStripMenuItem,
            this.consultaDeDatosDeUnGeneroToolStripMenuItem});
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.generosToolStripMenuItem.Text = "Generos";
            // 
            // agregarNuevoGeneroToolStripMenuItem
            // 
            this.agregarNuevoGeneroToolStripMenuItem.Name = "agregarNuevoGeneroToolStripMenuItem";
            this.agregarNuevoGeneroToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.agregarNuevoGeneroToolStripMenuItem.Text = "Agregar nuevo genero...";
            this.agregarNuevoGeneroToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoGeneroToolStripMenuItem_Click);
            // 
            // listadoGeneralDeGenerosToolStripMenuItem
            // 
            this.listadoGeneralDeGenerosToolStripMenuItem.Name = "listadoGeneralDeGenerosToolStripMenuItem";
            this.listadoGeneralDeGenerosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.listadoGeneralDeGenerosToolStripMenuItem.Text = "Listado general de generos...";
            this.listadoGeneralDeGenerosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeGenerosToolStripMenuItem_Click);
            // 
            // consultaDeDatosDeUnGeneroToolStripMenuItem
            // 
            this.consultaDeDatosDeUnGeneroToolStripMenuItem.Name = "consultaDeDatosDeUnGeneroToolStripMenuItem";
            this.consultaDeDatosDeUnGeneroToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.consultaDeDatosDeUnGeneroToolStripMenuItem.Text = "Consulta de datos de un genero...";
            this.consultaDeDatosDeUnGeneroToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosDeUnGeneroToolStripMenuItem_Click);
            // 
            // visualizacionesToolStripMenuItem
            // 
            this.visualizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVisualizacionesToolStripMenuItem,
            this.consultaDeVisualizacionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.visualizacionesDeUnMesToolStripMenuItem,
            this.visualizacionesDeUnGeneroToolStripMenuItem,
            this.toolStripMenuItem3,
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem,
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem});
            this.visualizacionesToolStripMenuItem.Name = "visualizacionesToolStripMenuItem";
            this.visualizacionesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.visualizacionesToolStripMenuItem.Text = "Visualizaciones";
            // 
            // registrarVisualizacionesToolStripMenuItem
            // 
            this.registrarVisualizacionesToolStripMenuItem.Name = "registrarVisualizacionesToolStripMenuItem";
            this.registrarVisualizacionesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.registrarVisualizacionesToolStripMenuItem.Text = "Registrar visualizacion...";
            this.registrarVisualizacionesToolStripMenuItem.Click += new System.EventHandler(this.registrarVisualizacionesToolStripMenuItem_Click);
            // 
            // consultaDeVisualizacionesToolStripMenuItem
            // 
            this.consultaDeVisualizacionesToolStripMenuItem.Name = "consultaDeVisualizacionesToolStripMenuItem";
            this.consultaDeVisualizacionesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.consultaDeVisualizacionesToolStripMenuItem.Text = "Consulta de visualizaciones...";
            this.consultaDeVisualizacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVisualizacionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(293, 6);
            // 
            // visualizacionesDeUnMesToolStripMenuItem
            // 
            this.visualizacionesDeUnMesToolStripMenuItem.Name = "visualizacionesDeUnMesToolStripMenuItem";
            this.visualizacionesDeUnMesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.visualizacionesDeUnMesToolStripMenuItem.Text = "Visualizaciones de un mes...";
            this.visualizacionesDeUnMesToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnMesToolStripMenuItem_Click);
            // 
            // visualizacionesDeUnGeneroToolStripMenuItem
            // 
            this.visualizacionesDeUnGeneroToolStripMenuItem.Name = "visualizacionesDeUnGeneroToolStripMenuItem";
            this.visualizacionesDeUnGeneroToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.visualizacionesDeUnGeneroToolStripMenuItem.Text = "Visualizaciones de un genero...";
            this.visualizacionesDeUnGeneroToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnGeneroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(293, 6);
            // 
            // estadisticaDeVisualizacionesPorMesToolStripMenuItem
            // 
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem.Name = "estadisticaDeVisualizacionesPorMesToolStripMenuItem";
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem.Text = "Estadistica de visualizaciones por mes...";
            this.estadisticaDeVisualizacionesPorMesToolStripMenuItem.Click += new System.EventHandler(this.estadisticaDeVisualizacionesPorMesToolStripMenuItem_Click);
            // 
            // estadisticaDeVisualizacionesPorGeneroToolStripMenuItem
            // 
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem.Name = "estadisticaDeVisualizacionesPorGeneroToolStripMenuItem";
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem.Text = "Estadistica de visualizaciones por genero...";
            this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem.Click += new System.EventHandler(this.estadisticaDeVisualizacionesPorGeneroToolStripMenuItem_Click);
            // 
            // frmInicioMovieInsight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.BackgroundImage = global::examen_Final_Laboratorio_I.Properties.Resources.ChatGPT_Image_29_nov_2025__09_45_16_a_m_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicioMovieInsight";
            this.Text = "Movie Insight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAutomaticaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeGenerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosDeUnGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVisualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVisualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estadisticaDeVisualizacionesPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaDeVisualizacionesPorGeneroToolStripMenuItem;
    }
}

