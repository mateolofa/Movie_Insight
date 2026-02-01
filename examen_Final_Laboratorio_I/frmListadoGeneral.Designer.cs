namespace examen_Final_Laboratorio_I
{
    partial class frmListadoGeneral
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
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadG = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCine
            // 
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCine.Location = new System.Drawing.Point(12, 12);
            this.dgvCine.Name = "dgvCine";
            this.dgvCine.Size = new System.Drawing.Size(434, 234);
            this.dgvCine.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.Width = 88;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(12, 264);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(145, 23);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad de generos:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadG
            // 
            this.lblCantidadG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadG.Location = new System.Drawing.Point(163, 264);
            this.lblCantidadG.Name = "lblCantidadG";
            this.lblCantidadG.Size = new System.Drawing.Size(66, 23);
            this.lblCantidadG.TabIndex = 2;
            this.lblCantidadG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(337, 264);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(109, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListadoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 312);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblCantidadG);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvCine);
            this.Name = "frmListadoGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado general de generos";
            this.Load += new System.EventHandler(this.frmListadoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCine;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadG;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}