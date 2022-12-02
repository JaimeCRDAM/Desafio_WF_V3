using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_WF_V3.Administrar.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void eMPLEADOSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            DialogResult guardar = MessageBox.Show("Desea guardar el empleado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (guardar == DialogResult.Yes)
            {
                this.Validate();
                this.eMPLEADOSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd_ertesDataSet);
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_ertesDataSet.EMPLEADOS' table. You can move, or remove it, as needed.
            this.eMPLEADOSTableAdapter.Fill(this.bd_ertesDataSet.EMPLEADOS);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
