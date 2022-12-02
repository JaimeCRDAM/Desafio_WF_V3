namespace Desafio_WF_V3.Administrar.Empresas_folder
{
    partial class ModificarAñadirEmpresas
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
            this.CBSector = new System.Windows.Forms.ComboBox();
            this.BTNVolver = new System.Windows.Forms.Button();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.TBCif = new System.Windows.Forms.TextBox();
            this.TBDomicilio = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBSector
            // 
            this.CBSector.FormattingEnabled = true;
            this.CBSector.Location = new System.Drawing.Point(103, 125);
            this.CBSector.Name = "CBSector";
            this.CBSector.Size = new System.Drawing.Size(102, 21);
            this.CBSector.TabIndex = 23;
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(130, 177);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 22;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Location = new System.Drawing.Point(14, 177);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNAceptar.TabIndex = 21;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // TBCif
            // 
            this.TBCif.Location = new System.Drawing.Point(105, 24);
            this.TBCif.Name = "TBCif";
            this.TBCif.Size = new System.Drawing.Size(100, 20);
            this.TBCif.TabIndex = 20;
            // 
            // TBDomicilio
            // 
            this.TBDomicilio.Location = new System.Drawing.Point(105, 92);
            this.TBDomicilio.Name = "TBDomicilio";
            this.TBDomicilio.Size = new System.Drawing.Size(100, 20);
            this.TBDomicilio.TabIndex = 19;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(105, 59);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 128);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label7.Size = new System.Drawing.Size(54, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "SECTOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "DOMICILIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label5.Size = new System.Drawing.Size(57, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label1.Size = new System.Drawing.Size(26, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "CIF:";
            // 
            // ModificarAñadirEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 210);
            this.Controls.Add(this.CBSector);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.TBCif);
            this.Controls.Add(this.TBDomicilio);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAñadirEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAñadirEmpresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSector;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.TextBox TBCif;
        private System.Windows.Forms.TextBox TBDomicilio;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}