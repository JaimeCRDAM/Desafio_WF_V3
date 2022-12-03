namespace Desafio_WF_V3.Ertes
{
    partial class NuevoErte
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
            this.BTNVolverModificar = new System.Windows.Forms.Button();
            this.BTNAceptarModificar = new System.Windows.Forms.Button();
            this.CBSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNVolverModificar
            // 
            this.BTNVolverModificar.Location = new System.Drawing.Point(134, 65);
            this.BTNVolverModificar.Name = "BTNVolverModificar";
            this.BTNVolverModificar.Size = new System.Drawing.Size(64, 20);
            this.BTNVolverModificar.TabIndex = 15;
            this.BTNVolverModificar.Text = "Volver";
            this.BTNVolverModificar.UseVisualStyleBackColor = true;
            this.BTNVolverModificar.Click += new System.EventHandler(this.BTNVolverModificar_Click);
            // 
            // BTNAceptarModificar
            // 
            this.BTNAceptarModificar.Location = new System.Drawing.Point(20, 65);
            this.BTNAceptarModificar.Name = "BTNAceptarModificar";
            this.BTNAceptarModificar.Size = new System.Drawing.Size(64, 20);
            this.BTNAceptarModificar.TabIndex = 14;
            this.BTNAceptarModificar.Text = "Aceptar";
            this.BTNAceptarModificar.UseVisualStyleBackColor = true;
            this.BTNAceptarModificar.Click += new System.EventHandler(this.BTNAceptarModificar_Click);
            // 
            // CBSector
            // 
            this.CBSector.FormattingEnabled = true;
            this.CBSector.Location = new System.Drawing.Point(112, 19);
            this.CBSector.Name = "CBSector";
            this.CBSector.Size = new System.Drawing.Size(86, 21);
            this.CBSector.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empresas:";
            // 
            // NuevoErte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(221, 109);
            this.Controls.Add(this.BTNVolverModificar);
            this.Controls.Add(this.BTNAceptarModificar);
            this.Controls.Add(this.CBSector);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoErte";
            this.Text = "NuevoErte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVolverModificar;
        private System.Windows.Forms.Button BTNAceptarModificar;
        private System.Windows.Forms.ComboBox CBSector;
        private System.Windows.Forms.Label label2;
    }
}