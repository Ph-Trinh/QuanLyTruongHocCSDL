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
    internal class Khoa : IObject
    {
        [DataName("ma_khoa")]
        [DisplayName("Mã Khoa")]
        [Required]
        public int MaKhoa { get; set; }

        [DataName("ten_khoa")]
        [DisplayName("Tên Khoa")]
        [Required]
        public string TenKhoa { get; set; }

        [DataName("da_xoa")]
        [DisplayName("Đã Xóa")]
        [Required]
        public bool DaXoa { get; set; }

        public override string ToString()
        {
            return $"Khoa ma so {MaKhoa} co ten la {TenKhoa}, tinh trang: {DaXoa}";
        }
    }
}
