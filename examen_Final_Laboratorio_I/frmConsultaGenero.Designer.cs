namespace examen_Final_Laboratorio_I
{
    partial class frmConsultaGenero
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
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcionR = new System.Windows.Forms.Label();
            this.lblCodigoR = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(116, 12);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(12, 9);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(88, 23);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero: ";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(12, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(88, 23);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion: ";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(88, 23);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionR
            // 
            this.lblDescripcionR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionR.Location = new System.Drawing.Point(94, 91);
            this.lblDescripcionR.Name = "lblDescripcionR";
            this.lblDescripcionR.Size = new System.Drawing.Size(297, 258);
            this.lblDescripcionR.TabIndex = 5;
            this.lblDescripcionR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescripcionR.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodigoR
            // 
            this.lblCodigoR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoR.Location = new System.Drawing.Point(116, 47);
            this.lblCodigoR.Name = "lblCodigoR";
            this.lblCodigoR.Size = new System.Drawing.Size(55, 23);
            this.lblCodigoR.TabIndex = 6;
            this.lblCodigoR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(287, 362);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 411);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCodigoR);
            this.Controls.Add(this.lblDescripcionR);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmConsultaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de datos de un genero";
            this.Load += new System.EventHandler(this.frmConsultaGenero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcionR;
        private System.Windows.Forms.Label lblCodigoR;
        private System.Windows.Forms.Button btnConsultar;
    }
}