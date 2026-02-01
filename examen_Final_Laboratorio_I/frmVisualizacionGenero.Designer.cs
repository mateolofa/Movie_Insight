namespace examen_Final_Laboratorio_I
{
    partial class frmVisualizacionGenero
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
            this.lblMenorR = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblMayorR = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lblPromedioR = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalR = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenorR
            // 
            this.lblMenorR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorR.Location = new System.Drawing.Point(139, 350);
            this.lblMenorR.Name = "lblMenorR";
            this.lblMenorR.Size = new System.Drawing.Size(100, 23);
            this.lblMenorR.TabIndex = 23;
            this.lblMenorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(12, 350);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(121, 23);
            this.lblMenor.TabIndex = 22;
            this.lblMenor.Text = "Menor Visualizaciones";
            this.lblMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(256, 342);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 33);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblMayorR
            // 
            this.lblMayorR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorR.Location = new System.Drawing.Point(139, 307);
            this.lblMayorR.Name = "lblMayorR";
            this.lblMayorR.Size = new System.Drawing.Size(100, 23);
            this.lblMayorR.TabIndex = 20;
            this.lblMayorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxima
            // 
            this.lblMaxima.Location = new System.Drawing.Point(12, 307);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(121, 23);
            this.lblMaxima.TabIndex = 19;
            this.lblMaxima.Text = "Mayor Visualizaciones";
            this.lblMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedioR
            // 
            this.lblPromedioR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioR.Location = new System.Drawing.Point(139, 264);
            this.lblPromedioR.Name = "lblPromedioR";
            this.lblPromedioR.Size = new System.Drawing.Size(100, 23);
            this.lblPromedioR.TabIndex = 18;
            this.lblPromedioR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(12, 264);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio:";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalR
            // 
            this.lblTotalR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalR.Location = new System.Drawing.Point(139, 221);
            this.lblTotalR.Name = "lblTotalR";
            this.lblTotalR.Size = new System.Drawing.Size(100, 23);
            this.lblTotalR.TabIndex = 16;
            this.lblTotalR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(12, 221);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 23);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total Visualizaciones:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvListar.Location = new System.Drawing.Point(12, 52);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(332, 150);
            this.dgvListar.TabIndex = 14;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(118, 14);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 13;
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(12, 11);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 23);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero:";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Meses";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // frmVisualizacionGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 392);
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
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblGenero);
            this.Name = "frmVisualizacionGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion de un genero";
            this.Load += new System.EventHandler(this.frmVisualizacionGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenorR;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblMayorR;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblPromedioR;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalR;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}