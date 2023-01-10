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
    public partial class frmPoruke : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        StudentiPredmeti _student;
        public frmPoruke(StudentiPredmeti student)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
            _student = student;
        }

        private void frmPoruke_Load(object sender, EventArgs e)
        {
            lbltekst.Text="Zapis za ovog:"+_student.Student.ToString();
            Ucitaj();

        }

        private void Ucitaj()
        {
            this.Text = "Nesot nesto "+ _db.StudentiPoruke.Where(x=>x.Student.Id==_student.Student.Id).Count();
            dgvPoruke.DataSource = _db.StudentiPoruke.Where(x => x.Student.Id == _student.Student.Id).ToList();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var novaforma = new frmNovaPoruka(_student.Student);
            Hide();
            novaforma.ShowDialog();
            Show();
            Ucitaj();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {   if (MessageBox.Show("DA li ste sigurno", "upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var brisi = dgvPoruke.Rows[e.RowIndex].DataBoundItem as StudentiPoruke;
                    _db.StudentiPoruke.Remove(brisi);
                    _db.SaveChanges();
                }
            }
                Ucitaj();
        }
    }
}
