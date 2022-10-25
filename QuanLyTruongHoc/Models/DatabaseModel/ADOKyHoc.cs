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
    internal class ADOKyHoc : IADOObject
    {
        private ADOOperator adoOperator;

        public ADOKyHoc(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }

        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.Insert_KYHOC";
            SqlParameter[] parameters = new SqlParameter[3];
            //parameters[0] = new SqlParameter("@id_ky_hoc", (obj as KyHoc).MaKyHoc);
            parameters[0] = new SqlParameter("@nam_hoc", (obj as KyHoc).NamHoc);
            parameters[1] = new SqlParameter("@ky_hoc", (obj as KyHoc).kyHoc);
            parameters[2] = new SqlParameter("@hoc_phi", (obj as KyHoc).HocPhi);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from dbo.GetKyHoc(@id_ky_hoc)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id_ky_hoc", (obj as KyHoc).MaKyHoc);
            return adoOperator.ExecuteQuery(query, parameters);
        }

        public DataTable Load()
        {
            string query = "select * from dbo.GetAllKyHoc()";
            return adoOperator.ExecuteQuery(query);
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "dbo.Update_KYHOC";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id_ky_hoc", (obj as KyHoc).MaKyHoc);
            parameters[1] = new SqlParameter("@nam_hoc", (obj as KyHoc).NamHoc);
            parameters[2] = new SqlParameter("@ky_hoc", (obj as KyHoc).kyHoc);
            parameters[3] = new SqlParameter("@hoc_phi", (obj as KyHoc).HocPhi);
            return adoOperator.ExecuteProcedure(query, parameters);
        }
    }
}
