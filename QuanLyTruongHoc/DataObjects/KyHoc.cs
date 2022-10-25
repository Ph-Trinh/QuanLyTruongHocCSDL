using QuanLyTruongHoc.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.DataObjects
{
    internal class KyHoc : IObject 
    {
        [DataName("id_ky_hoc")]
        [DisplayName("Mã Kỳ Học")]
        [Required]
        public int MaKyHoc { get; set; }

        [DataName("nam_hoc")]
        [DisplayName("Năm Học")]
        [Required]
        public int NamHoc { get; set; }

        [DataName("ky_hoc")]
        [DisplayName("Kỳ Học")]
        [Required]
        public int kyHoc { get; set; }

        [DataName("hoc_phi")]
        [DisplayName("Học Phí")]
        [Required]
        public decimal HocPhi { get; set; }
    }
}
