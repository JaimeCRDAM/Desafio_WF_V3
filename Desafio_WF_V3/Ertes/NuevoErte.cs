using Desafio_WF_V3.Administrar.Empresas_folder;
using Desafio_WF_V3.DB;
using Desafio_WF_V3.Utils;
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
    public partial class NuevoErte : Form
    {
        public NuevoErte()
        {
            InitializeComponent();
            var comboItems = new List<ComboItem>();
            using (bd_ertesEntities db = new bd_ertesEntities())
            {

                var sqlErtes = db.ERTES.Where(x => !x.Fecha_fin.HasValue).Select(x => x.EMPRESA1.Cif).ToList();
                var sqlEmpresas = db.EMPRESAS.Where(x => !sqlErtes.Contains(x.Cif)).Select(x => new { x.Nombre , x.Cif}).ToList();
                foreach (var item in sqlEmpresas)
                {
                    var comboItem = new ComboItem();
                    comboItem.Text = item.Nombre;
                    comboItem.Value= item.Cif;
                    comboItems.Add(comboItem);
                }
            }
            CBSector.Items.AddRange(comboItems.ToArray());
            CBSector.SelectedIndex = 0;
        }

        private void BTNVolverModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNAceptarModificar_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var erte = new ERTE();
                var nombre = CBSector.SelectedItem.ToString();
                erte.Empresa = db.EMPRESAS.Where(x => x.Nombre == nombre).Select(x => x.Nombre).ToList()[0];
                erte.EMPRESA1 = db.EMPRESAS.Where(x => x.Nombre == nombre).Select(x => x).ToList()[0];
                erte.Fecha_inicio = DateTime.Now;
                db.ERTES.Add(erte);
                db.SaveChanges();
            }
        }
    }
}
