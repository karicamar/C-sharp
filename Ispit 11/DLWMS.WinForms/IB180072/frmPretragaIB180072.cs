using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB180072
{
    public partial class frmPretragaIB180072 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmPretragaIB180072()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns=false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void Ucitaj()
        {
            if (cbOcjena.SelectedIndex == -1)
            {
                var lista = _db.StudentiPredmeti.Where(x => x.DatumPolaganja > dateTimePicker1.Value && x.DatumPolaganja < dateTimePicker2.Value).ToList();
                dgvPretraga.DataSource = lista;
            }
            else 
                {
                int ocjena = int.Parse(cbOcjena.Text);
                var lista = _db.StudentiPredmeti.Where(x =>x.Ocjena==ocjena && x.DatumPolaganja > dateTimePicker1.Value && x.DatumPolaganja < dateTimePicker2.Value).ToList();
                dgvPretraga.DataSource = lista;
            }
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                var student = dgvPretraga.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                var forma = new frmPoruke(student);
                forma.Show();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Ucitaj();

        }

        private void cbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();

        }

        private void frmPretragaIB180072_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
