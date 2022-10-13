﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOManager
    {
        private ADOOperator adoOperator;
        private ADOSinhVien sinhVien;
        private ADOLopHoc lopHoc;
        private ADOGiangVien giangVien;

        public ADOSinhVien SinhVien { get => sinhVien; }
        public ADOGiangVien GiangVien { get => giangVien; }
        public ADOLopHoc LopHoc { get => lopHoc; }
        

        public ADOManager(string connectionString)
        {
            adoOperator = new ADOOperator(connectionString);
            sinhVien = new ADOSinhVien(adoOperator);
            giangVien = new ADOGiangVien(adoOperator);
            lopHoc = new ADOLopHoc(adoOperator);
        }
    }
}
