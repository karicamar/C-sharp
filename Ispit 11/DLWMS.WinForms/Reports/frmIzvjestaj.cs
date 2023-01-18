using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB180072;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        KonekcijaNaBazu bp = DLWMSdb.Baza;
        Student odabraniStudent;
        public frmIzvjestaj()
        {
            InitializeComponent();
            
        }
        public frmIzvjestaj(Student student)
        {
            InitializeComponent();
            odabraniStudent = student;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {         
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            var odabranaBaza = bp.StudentiPoruke.Where(x => x.Student.Id == odabraniStudent.Id).ToList();
            var Tabela = new dsIzvjestaj.AtributiDataTable();
            foreach (var sp in odabranaBaza)
            {
                var red = Tabela.NewAtributiRow();
                red.Predmet = sp.Predmet.ToString();
                red.Vrijeme = sp.Vrijeme.Date.ToString();
                red.Sadrzaj = sp.Sadrzaj.ToString();
                red.BrojZnakova = sp.Sadrzaj.Length.ToString();
                red.PosjedujeSliku = sp.Slika != null ? "DA" : "NE";
                Tabela.AddAtributiRow(red);

                
            }
            var parameta = new ReportParameterCollection();
            parameta.Add(new ReportParameter("Student",odabraniStudent.ToString()));
            parameta.Add(new ReportParameter("Ukupno", odabranaBaza.Count().ToString()));
            reportViewer1.LocalReport.SetParameters(parameta);

            var reportdata = new ReportDataSource();
            reportdata.Name = "infoTabela";
            reportdata.Value = Tabela;
            reportViewer1.LocalReport.DataSources.Add(reportdata);
        }
    }
}
