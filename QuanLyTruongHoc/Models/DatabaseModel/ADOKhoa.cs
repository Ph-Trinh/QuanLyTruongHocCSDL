using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOKhoa : IADOObject
    {
        private ADOOperator adoOperator;

        public ADOKhoa(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }

        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.Insert_KHOA";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ten_khoa", (obj as Khoa).TenKhoa);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "dbo.Delete_KHOA";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_khoa", (obj as Khoa).MaKhoa);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from dbo.GetKhoa(@ma_khoa)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_khoa", (obj as Khoa).MaKhoa);
            return adoOperator.ExecuteQuery(query, parameters);
        }

        public DataTable Load()
        {
            string query = "select * from dbo.GetAllKhoa()";
            return adoOperator.ExecuteQuery(query);
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "dbo.Update_KHOA";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@ma_khoa", (obj as Khoa).MaKhoa);
            parameters[1] = new SqlParameter("@ten_khoa", (obj as Khoa).TenKhoa);
            parameters[2] = new SqlParameter("@da_xoa", (obj as Khoa).DaXoa);
            return adoOperator.ExecuteProcedure(query, parameters);
        }
    }
}
