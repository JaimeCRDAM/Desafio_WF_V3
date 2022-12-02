using Desafio_WF_V3.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_WF_V3.Administrar.Empresas_folder
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();

            RefreshDGV();
        }

        private void BTNAnadir_Click(object sender, EventArgs e)
        {
            Form modEmpresas = new ModificarAñadirEmpresas();
            modEmpresas.ShowDialog();
            RefreshDGV();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DGVEmpresas.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una fila antes de intentar modificarla");
                return;
            }
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var empresaNombre = DGVEmpresas.SelectedRows[0].Cells[0].Value.ToString();
                var empresa = db.EMPRESAS.Select(x => x).Where(x => x.Nombre == empresaNombre).ToList();
                Form modEmpresas = new ModificarAñadirEmpresas(empresa[0]);
                modEmpresas.ShowDialog();
                RefreshDGV();
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (DGVEmpresas.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar");
                return;
            }
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var empresaCif = DGVEmpresas.SelectedRows[0].Cells[2].Value.ToString();
                var empresa = db.EMPRESAS.Select(x => x).Where(x => x.Cif == empresaCif).ToList()[0];
                DialogResult eliminar = MessageBox.Show("Desea eliminar la empresa seleccionada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    db.EMPRESAS.Remove(empresa);
                    db.SaveChanges();
                    RefreshDGV();
                }
            }
        }

        private void RefreshDGV()
        {
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var empresas = db.EMPRESAS.Select(x => new { x.Nombre, x.Sector, x.Cif }).ToList();
                DGVEmpresas.DataSource = empresas;
                foreach (DataGridViewColumn item in DGVEmpresas.Columns)
                {
                    item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
