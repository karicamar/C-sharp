using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB180072
{
    [Table("StudentiPoruke")]
    public class StudentiPoruke
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public DateTime Vrijeme { get; set; }
        public string  Sadrzaj { get; set; }
        public byte[] Slika { get; set; }

    }
}
