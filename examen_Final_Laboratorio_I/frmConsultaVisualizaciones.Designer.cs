namespace examen_Final_Laboratorio_I
{
    partial class frmConsultaVisualizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblVisualizaciones = new System.Windows.Forms.Label();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblVisualizacionesR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMeses
            // 
            this.lblMeses.Location = new System.Drawing.Point(12, 47);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(100, 23);
            this.lblMeses.TabIndex = 13;
            this.lblMeses.Text = "Meses:";
            this.lblMeses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisualizaciones
            // 
            this.lblVisualizaciones.Location = new System.Drawing.Point(12, 82);
            this.lblVisualizaciones.Name = "lblVisualizaciones";
            this.lblVisualizaciones.Size = new System.Drawing.Size(100, 23);
            this.lblVisualizaciones.TabIndex = 12;
            this.lblVisualizaciones.Text = "Visualizaciones:";
            this.lblVisualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneros
            // 
            this.lblGeneros.Location = new System.Drawing.Point(12, 12);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(100, 23);
            this.lblGeneros.TabIndex = 11;
            this.lblGeneros.Text = "Generos:";
            this.lblGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(172, 126);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 29);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(139, 49);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(121, 21);
            this.cmbMeses.TabIndex = 8;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(139, 14);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 7;
            // 
            // lblVisualizacionesR
            // 
            this.lblVisualizacionesR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisualizacionesR.Location = new System.Drawing.Point(160, 82);
            this.lblVisualizacionesR.Name = "lblVisualizacionesR";
            this.lblVisualizacionesR.Size = new System.Drawing.Size(100, 23);
            this.lblVisualizacionesR.TabIndex = 14;
            this.lblVisualizacionesR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConsultaVisualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 167);
            this.Controls.Add(this.lblVisualizacionesR);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblVisualizaciones);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmConsultaVisualizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Visualizaciones";
            this.Load += new System.EventHandler(this.frmConsultaVisualizaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblVisualizaciones;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblVisualizacionesR;
    }
}