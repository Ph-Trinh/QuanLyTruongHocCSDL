using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers;
using System;
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

        private ADOKhoa khoa;
        private ADOKyHoc kyhoc;

        public ADOKhoa Khoa { get => khoa; }
        public ADOKyHoc KyHoc { get => kyhoc; }


        private ADODiem diem;

        private ADODangNhap dangNhap;

        public ADOSinhVien SinhVien { get => sinhVien; }
        public ADOGiangVien GiangVien { get => giangVien; }
        public ADOLopHoc LopHoc { get => lopHoc; }
        public ADODiem Diem { get => diem; }
        public ADODangNhap DangNhap { get => dangNhap; }

        public ADOManager(string connectionString)
        {
            adoOperator = new ADOOperator(connectionString);
            sinhVien = new ADOSinhVien(adoOperator);
            giangVien = new ADOGiangVien(adoOperator);
            diem = new ADODiem(adoOperator);
            lopHoc = new ADOLopHoc(adoOperator);
            khoa = new ADOKhoa(adoOperator);
            kyhoc = new ADOKyHoc(adoOperator);
            dangNhap = new ADODangNhap(adoOperator);
        }

        private Login login = null;
        
        public Login CurrentLogin { get => login; }

        public bool CheckDangNhap(Login login)
        {
            int result = dangNhap.CheckDangNhap(login);
            if (result != -1)
            {
                this.login = login;
                this.login.id = result;
                return true;
            }
            else
                return false;
            
        }

        public bool DangXuat()
        {
            this.login = null;
            return true;
        }

        public bool CheckIfLogin()
        {
            if (login != null) return true;
            return false;
        }

        public VAITRO VaiTroHienTai()
        {
            if(login == null)
            {
                throw new Exception("Chua dang nhap vao he thong");
            }
            return login.vaiTro;
        }

        public int GetId()
        {
            if (login == null)
            {
                throw new Exception("Chua dang nhap vao he thong");
            }
            return login.id;
        }
    }
}
