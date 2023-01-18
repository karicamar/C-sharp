using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
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
    public partial class frmNovaPoruka : Form
    {
        Student _student;
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmNovaPoruka(Student student)
        {
            InitializeComponent();
            _student = student;
        }
        

        private void frmNovaPoruka_Load(object sender, EventArgs e)
        {
            cbPredmet.DataSource=_db.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {  
            if (Validator.ValidirajKontrolu(txtSadrzaj, errorProvider1, Poruke.ObaveznaVrijednost)&&
                Validator.ValidirajKontrolu(cbPredmet,errorProvider1,Poruke.ObaveznaVrijednost))
            {
                var poruka = new StudentiPoruke()
                {
                    Student = _student,
                    Predmet = cbPredmet.SelectedItem as Predmet,
                    Vrijeme = DateTime.Now,
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = (pbSlika.Image != null ? ImageHelper.FromImageToByte(pbSlika.Image) : null)
                };
                _db.StudentiPoruke.Add(poruka);
                _db.SaveChanges();
                MessageBox.Show("Uspjesno ste dodali poruku za odabranog studenta!");
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
