namespace Desafio_WF_V3.Administrar.Empleados
{
    partial class Empleados
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.bd_ertesDataSet = new Desafio_WF_V3.bd_ertesDataSet();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSTableAdapter = new Desafio_WF_V3.bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter();
            this.tableAdapterManager = new Desafio_WF_V3.bd_ertesDataSetTableAdapters.TableAdapterManager();
            this.eMPLEADOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPLEADOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.BTNFoto = new System.Windows.Forms.Button();
            this.dniMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ertesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).BeginInit();
            this.eMPLEADOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(27, 61);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(27, 113);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 139);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(27, 165);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 9;
            domicilioLabel.Text = "Domicilio:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(27, 191);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 13;
            empresaLabel.Text = "Empresa:";
            // 
            // bd_ertesDataSet
            // 
            this.bd_ertesDataSet.DataSetName = "bd_ertesDataSet";
            this.bd_ertesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.bd_ertesDataSet;
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLEADOSTableAdapter = this.eMPLEADOSTableAdapter;
            this.tableAdapterManager.EMPRESASTableAdapter = null;
            this.tableAdapterManager.ERTESTableAdapter = null;
            this.tableAdapterManager.SECTORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Desafio_WF_V3.bd_ertesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLEADOSBindingNavigator
            // 
            this.eMPLEADOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLEADOSBindingNavigator.BindingSource = this.eMPLEADOSBindingSource;
            this.eMPLEADOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLEADOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLEADOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eMPLEADOSBindingNavigatorSaveItem});
            this.eMPLEADOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLEADOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLEADOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLEADOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLEADOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLEADOSBindingNavigator.Name = "eMPLEADOSBindingNavigator";
            this.eMPLEADOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLEADOSBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.eMPLEADOSBindingNavigator.TabIndex = 0;
            this.eMPLEADOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eMPLEADOSBindingNavigatorSaveItem
            // 
            this.eMPLEADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLEADOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLEADOSBindingNavigatorSaveItem.Image")));
            this.eMPLEADOSBindingNavigatorSaveItem.Name = "eMPLEADOSBindingNavigatorSaveItem";
            this.eMPLEADOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLEADOSBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPLEADOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLEADOSBindingNavigatorSaveItem_Click_1);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(85, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(196, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(85, 110);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(196, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(85, 162);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(196, 20);
            this.domicilioTextBox.TabIndex = 10;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eMPLEADOSBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(312, 58);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(296, 146);
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Empresa", true));
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(85, 188);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(196, 21);
            this.empresaComboBox.TabIndex = 14;
            // 
            // BTNFoto
            // 
            this.BTNFoto.Location = new System.Drawing.Point(422, 229);
            this.BTNFoto.Name = "BTNFoto";
            this.BTNFoto.Size = new System.Drawing.Size(75, 23);
            this.BTNFoto.TabIndex = 15;
            this.BTNFoto.Text = "Cambiar foto";
            this.BTNFoto.UseVisualStyleBackColor = true;
            // 
            // dniMaskedTextBox
            // 
            this.dniMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Dni", true));
            this.dniMaskedTextBox.Location = new System.Drawing.Point(85, 58);
            this.dniMaskedTextBox.Name = "dniMaskedTextBox";
            this.dniMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniMaskedTextBox.TabIndex = 16;
            // 
            // emailMaskedTextBox
            // 
            this.emailMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Email", true));
            this.emailMaskedTextBox.Location = new System.Drawing.Point(85, 136);
            this.emailMaskedTextBox.Name = "emailMaskedTextBox";
            this.emailMaskedTextBox.Size = new System.Drawing.Size(196, 20);
            this.emailMaskedTextBox.TabIndex = 17;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 272);
            this.Controls.Add(this.emailMaskedTextBox);
            this.Controls.Add(this.dniMaskedTextBox);
            this.Controls.Add(this.BTNFoto);
            this.Controls.Add(dniLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaComboBox);
            this.Controls.Add(this.eMPLEADOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ertesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).EndInit();
            this.eMPLEADOSBindingNavigator.ResumeLayout(false);
            this.eMPLEADOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_ertesDataSet bd_ertesDataSet;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private bd_ertesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLEADOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLEADOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Button BTNFoto;
        private System.Windows.Forms.MaskedTextBox dniMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox emailMaskedTextBox;
    }
}