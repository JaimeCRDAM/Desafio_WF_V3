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

namespace Desafio_WF_V3.Administrar.Empresas_folder
{
    public partial class ModificarAñadirEmpresas : Form
    {
        public ModificarAñadirEmpresas(EMPRESA empresa)
        {
            InitializeComponent();
            TBCif.Text = empresa.Cif;
            TBCif.Enabled = false;
            TBDomicilio.Text = empresa.Domicilio;
            TBNombre.Text = empresa.Nombre;
            CBSector.Items.AddRange(GetAllSectores().ToArray());
            CBSector.SelectedIndex = empresa.Sector-1;
        }

        public ModificarAñadirEmpresas()
        {
            InitializeComponent();
            CBSector.Items.AddRange(GetAllSectores().ToArray());
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<ComboItem> GetAllSectores()
        {
            var listaSectores = new List<ComboItem>();
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                foreach (SECTORE item in db.SECTORES)
                {
                    var comboItem = new ComboItem();
                    comboItem.Text = item.Descripcion;
                    comboItem.Value = item.Id_sector;
                    listaSectores.Add(comboItem);
                }
            }
            return listaSectores;
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            var empresa = new EMPRESA();
            if (!string.IsNullOrEmpty(TBCif.Text))
            {
                empresa.Cif = TBCif.Text.ToString();
            }
            if (!string.IsNullOrEmpty(TBDomicilio.Text))
            {
                empresa.Domicilio = TBDomicilio.Text.ToString();
            }
            if (!string.IsNullOrEmpty(TBNombre.Text))
            {
                empresa.Nombre = TBNombre.Text.ToString();
            }
            empresa.Sector = (int)((ComboItem)CBSector.SelectedItem).Value;
            using (bd_ertesEntities db = new bd_ertesEntities())
            {
                var isCifTaken = db.EMPRESAS.Select(x => x.Cif).Where(x => x == empresa.Cif).Any();
                if (!isCifTaken)
                {
                    db.EMPRESAS.Add(empresa);
                    db.SaveChanges();
                    this.Close();
                    return;
                }
                MessageBox.Show("Ya existe una empresa con ese CIF");
            }
        }
    }
}
