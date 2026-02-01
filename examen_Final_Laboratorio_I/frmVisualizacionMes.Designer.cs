namespace examen_Final_Laboratorio_I
{
    partial class frmVisualizacionMes
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
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalR = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromedioR = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lblMayorR = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMenorR = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.Location = new System.Drawing.Point(12, 9);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(100, 23);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes:";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(118, 12);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(121, 21);
            this.cmbMeses.TabIndex = 1;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvListar.Location = new System.Drawing.Point(12, 50);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(332, 150);
            this.dgvListar.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(12, 219);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Visualizaciones:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalR
            // 
            this.lblTotalR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalR.Location = new System.Drawing.Point(139, 219);
            this.lblTotalR.Name = "lblTotalR";
            this.lblTotalR.Size = new System.Drawing.Size(100, 23);
            this.lblTotalR.TabIndex = 4;
            this.lblTotalR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(12, 262);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "Promedio:";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedioR
            // 
            this.lblPromedioR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioR.Location = new System.Drawing.Point(139, 262);
            this.lblPromedioR.Name = "lblPromedioR";
            this.lblPromedioR.Size = new System.Drawing.Size(100, 23);
            this.lblPromedioR.TabIndex = 6;
            this.lblPromedioR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxima
            // 
            this.lblMaxima.Location = new System.Drawing.Point(12, 305);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(121, 23);
            this.lblMaxima.TabIndex = 7;
            this.lblMaxima.Text = "Mayor Visualizaciones";
            this.lblMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayorR
            // 
            this.lblMayorR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorR.Location = new System.Drawing.Point(139, 305);
            this.lblMayorR.Name = "lblMayorR";
            this.lblMayorR.Size = new System.Drawing.Size(100, 23);
            this.lblMayorR.TabIndex = 8;
            this.lblMayorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(256, 340);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 33);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(12, 348);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(121, 23);
            this.lblMenor.TabIndex = 10;
            this.lblMenor.Text = "Menor Visualizaciones";
            this.lblMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenorR
            // 
            this.lblMenorR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorR.Location = new System.Drawing.Point(139, 348);
            this.lblMenorR.Name = "lblMenorR";
            this.lblMenorR.Size = new System.Drawing.Size(100, 23);
            this.lblMenorR.TabIndex = 11;
            this.lblMenorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Genero";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // frmVisualizacionMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 391);
            this.Controls.Add(this.lblMenorR);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMayorR);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblPromedioR);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalR);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.lblMes);
            this.Name = "frmVisualizacionMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion en un mes";
            this.Load += new System.EventHandler(this.frmVisualizacionMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalR;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPromedioR;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblMayorR;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMenorR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}