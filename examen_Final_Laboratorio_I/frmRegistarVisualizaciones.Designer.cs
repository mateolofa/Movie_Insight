namespace examen_Final_Laboratorio_I
{
    partial class frmRegistarVisualizaciones
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.txtVisualizaciones = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.lblVisualizaciones = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(118, 12);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(118, 47);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(121, 21);
            this.cmbMeses.TabIndex = 1;
            // 
            // txtVisualizaciones
            // 
            this.txtVisualizaciones.Location = new System.Drawing.Point(118, 82);
            this.txtVisualizaciones.Name = "txtVisualizaciones";
            this.txtVisualizaciones.Size = new System.Drawing.Size(121, 20);
            this.txtVisualizaciones.TabIndex = 2;
            this.txtVisualizaciones.TextChanged += new System.EventHandler(this.txtVisualizaciones_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Location = new System.Drawing.Point(151, 122);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 29);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblGeneros
            // 
            this.lblGeneros.Location = new System.Drawing.Point(12, 10);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(100, 23);
            this.lblGeneros.TabIndex = 4;
            this.lblGeneros.Text = "Generos:";
            this.lblGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisualizaciones
            // 
            this.lblVisualizaciones.Location = new System.Drawing.Point(12, 80);
            this.lblVisualizaciones.Name = "lblVisualizaciones";
            this.lblVisualizaciones.Size = new System.Drawing.Size(100, 23);
            this.lblVisualizaciones.TabIndex = 5;
            this.lblVisualizaciones.Text = "Visualizaciones:";
            this.lblVisualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeses
            // 
            this.lblMeses.Location = new System.Drawing.Point(12, 45);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(100, 23);
            this.lblMeses.TabIndex = 6;
            this.lblMeses.Text = "Meses:";
            this.lblMeses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistarVisualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 161);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblVisualizaciones);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtVisualizaciones);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmRegistarVisualizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Visualizaciones";
            this.Load += new System.EventHandler(this.frmRegistarVisualizaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.TextBox txtVisualizaciones;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Label lblVisualizaciones;
        private System.Windows.Forms.Label lblMeses;
    }
}