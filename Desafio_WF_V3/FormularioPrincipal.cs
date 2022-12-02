using Desafio_WF_V3.Administrar.Empresas_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_WF_V3
{
    public partial class FormularioPrincipal : Form
    {
        Form currentForm;
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CambiarMdiHijo<T>(T form) where T : Form
        {
            Form oldForm = currentForm;
            currentForm = form;
            currentForm.MdiParent = this; //802, 452
            Size = new Size(currentForm.Width+12, currentForm.Height + 35);
            form.Show();
            if (oldForm != null) oldForm.Close();
        }
        private void MenuCambiar(Form form)
        {
            Form futureForm = form;
            if (currentForm == null)
            {
                CambiarMdiHijo<Form>(futureForm);
                return;
            }
            if (currentForm.GetType() != futureForm.GetType())
            {
                DialogResult eliminar = MessageBox.Show("Desea Cerrar el formulario actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    CambiarMdiHijo<Form>(futureForm);
                }
            }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCambiar(new Empresas());
        }
    }
}
