namespace Desafio_WF_V3.Administrar.Empresas_folder
{
    partial class Empresas
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
            this.DGVEmpresas = new System.Windows.Forms.DataGridView();
            this.BTNAnadir = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVEmpresas
            // 
            this.DGVEmpresas.AllowUserToAddRows = false;
            this.DGVEmpresas.AllowUserToDeleteRows = false;
            this.DGVEmpresas.AllowUserToResizeColumns = false;
            this.DGVEmpresas.AllowUserToResizeRows = false;
            this.DGVEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpresas.Location = new System.Drawing.Point(12, 12);
            this.DGVEmpresas.MultiSelect = false;
            this.DGVEmpresas.Name = "DGVEmpresas";
            this.DGVEmpresas.ReadOnly = true;
            this.DGVEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEmpresas.Size = new System.Drawing.Size(776, 357);
            this.DGVEmpresas.TabIndex = 0;
            // 
            // BTNAnadir
            // 
            this.BTNAnadir.Location = new System.Drawing.Point(12, 415);
            this.BTNAnadir.Name = "BTNAnadir";
            this.BTNAnadir.Size = new System.Drawing.Size(75, 23);
            this.BTNAnadir.TabIndex = 1;
            this.BTNAnadir.Text = "Añadir";
            this.BTNAnadir.UseVisualStyleBackColor = true;
            this.BTNAnadir.Click += new System.EventHandler(this.BTNAnadir_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(360, 415);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 2;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(713, 415);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 3;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNAnadir);
            this.Controls.Add(this.DGVEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVEmpresas;
        private System.Windows.Forms.Button BTNAnadir;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNEliminar;
    }
}