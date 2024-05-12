using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyAccess
    {

        public static DataTable SelectAllQuanLy()
        {
            string query = $"Select * from QuanLy";
            return Connection.selectQuery(query) ;
        }
        public static DataTable SelectOneQuanLyByMaQuanLy(QuanLy quanLy)
        {
            string query = @$"Select * from QuanLy where maQuanLy = {quanLy.maQuanLy} ";
            return Connection.selectQuery(query);
        }

        public static bool CheckLoginValid(string email_soDienThoai, string matKhau)
        {
            string query = $@"Select * from QuanLy
                            where (soDienThoai = '{email_soDienThoai}' and matKhau = '{matKhau}')";

            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang soDienThoai hop le
                return true;
            }

            query = $@"Select * from QuanLy where ( email = '{email_soDienThoai}' and
                             matKhau = '{matKhau}')";
            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang email hop le
                return true;
            }
            return false;
        }

        public static QuanLy SelectOneQuanLyByEmail_SoDienThoai(string email_soDienThoai)
        {
            string query = $"Select * from QuanLy where email = '{email_soDienThoai}'";
            DataTable dt = Connection.selectQuery(query);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string maQuanLy = row["maQuanLy"].ToString();
                    string tenQuanLy = row["tenQuanLy"].ToString();
                    string soDienThoai = row["soDienThoai"].ToString();
                    string email = row["email"].ToString();
                    string matKhau = row["matKhau"].ToString();
                    bool toanQuyen = Convert.ToBoolean(row["toanQuyen"]);

                    QuanLy quanLy = new QuanLy(maQuanLy, tenQuanLy, soDienThoai, email, matKhau, toanQuyen);
                    return quanLy;
                }
                else
                {
                    query = $"Select * from QuanLy where soDienThoai = '{email_soDienThoai}'";
                    dt = Connection.selectQuery(query);
                    DataRow row = dt.Rows[0];
                    string maQuanLy = row["maQuanLy"].ToString();
                    string tenQuanLy = row["tenQuanLy"].ToString();
                    string soDienThoai = row["soDienThoai"].ToString();
                    string email = row["email"].ToString();
                    string matKhau = row["matKhau"].ToString();
                    bool toanQuyen = Convert.ToBoolean(row["toanQuyen"]);
                    QuanLy quanLy = new QuanLy(maQuanLy, tenQuanLy, soDienThoai, email, matKhau, toanQuyen);
                    return quanLy;

                }
            }
            catch
            {
                return null;
            }
            
        }

        public static QuanLy SelectOneQuanLyByMaPhieuDatSan(string maPhieuDatSan)
        {
            string query = $"Select * from QuanLy where maQuanLy in (Select maQuanLy from PhieuDatSan where maPhieuDatSan = '{maPhieuDatSan}')";
            DataTable dt = Connection.selectQuery(query);
            DataRow row = dt.Rows[0];
            QuanLy quanLy = new QuanLy(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), Convert.ToBoolean(row["toanQuyen"]));
            return quanLy;
        }

        public static void DeleteQuanLyByMaQuanLy(string maQuanLy)
        {
            string query1 = $"Update PhieuDatSan Set maQuanLy = '\"AD001\"' where maQuanLy = '{maQuanLy}'";
            Connection.actionQuery(query1);
            string query2 = $"Delete from QuanLy where maQuanLy = '{maQuanLy}'";
            Connection.actionQuery(query2);
        }

        public static void InsertQuanLy(string maQuanLy,string tenQuanLy, string soDienThoai, string email, string matKhau, bool toanQuyen)
        {
            string query = $"Insert into QuanLy values ('{maQuanLy}', N'{tenQuanLy}', '{soDienThoai}','{email}','{matKhau}',{(toanQuyen ? 1 : 0)} )";
            Connection.actionQuery(query );
        }

        public static DataTable SelectTop1QuanLy()
        {
            string query = @$"Select top 1* from QuanLy
                                ORDER BY CAST(RIGHT(maQuanLy, 3) AS bigint) DESC ";
            return Connection.selectQuery(query);
        }

        public static void UpdateQuanLy(string maQuanLy, string tenQuanLy, string matKhau, bool toanQuyen)
        {
            try
            {
                string query = $"Update QuanLy Set tenQuanLy = N'{tenQuanLy}', matKhau = '{matKhau}', toanQuyen = {(toanQuyen ? 1 : 0)} where maQuanLy = '{maQuanLy}'";
                Connection.actionQuery(query);
            }
            catch
            {
                return;
            }
        }

    }
}
