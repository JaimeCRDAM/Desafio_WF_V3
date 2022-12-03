using Desafio_WF_V3.Administrar.Empleados;
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

namespace Desafio_WF_V3.Ertes
{
    public partial class Ertes : Form
    {
        public Ertes()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var sqlErtes = db.ERTES.Select(x => x.EMPRESA1.Cif).ToList();
                var sqlEmpresas = db.ERTES.Select(x => new { x.Empresa, x.EMPRESA1.Cif, x.EMPRESA1.Sector, Empleados = x.EMPRESA1.EMPLEADOS.Select(y => y.Empresa == x.EMPRESA1.Cif).Count(y => y), x.Fecha_inicio, x.Fecha_fin }).ToList();
                DGVErte.DataSource = sqlEmpresas;
            }

        }

        private void BTNNuevoErte_Click(object sender, EventArgs e)
        {
            Form modEmpresas = new NuevoErte();
            modEmpresas.ShowDialog();
        }

        private void BTNFinErte_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var cifSelected = DGVErte.SelectedRows[0].Cells[1].Value.ToString();
                var ak = db.ERTES.Select(x => x.Fecha_fin).ToList()[0];
                var sqlErtes = db.ERTES.Where(x => x.EMPRESA1.Cif == cifSelected && x.Fecha_fin == null).Select(x => x).ToList()[0];
                sqlErtes.Fecha_fin = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}
