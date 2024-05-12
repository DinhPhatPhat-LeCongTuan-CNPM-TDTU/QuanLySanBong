using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class QuanLy_BLL
    {
        public static bool checkLoginValid(string email_soDienThoai, string matKhau)
        {
            return QuanLyAccess.CheckLoginValid(email_soDienThoai, matKhau);

        }

        public static QuanLy SelectOneQuanLyByEmail_SoDienThoai(string email_soDienThoai)
        {
            return QuanLyAccess.SelectOneQuanLyByEmail_SoDienThoai(email_soDienThoai);
        }

        public static QuanLy SelectOneQuanLyByMaPhieuDatSan(string maPhieuDatSan)
        {
            return QuanLyAccess.SelectOneQuanLyByMaPhieuDatSan( maPhieuDatSan);
        }

        public static DataTable SelectAllQuanLy()
        {
            return QuanLyAccess.SelectAllQuanLy();
        }

        public static void DeleteQuanLyByMaQuanLy(string maQuanLy)
        {
            QuanLyAccess.DeleteQuanLyByMaQuanLy(maQuanLy);
        }

        public static void InsertQuanLy(string tenQuanLy, string soDienThoai, string email, string matKhau,bool toanQuyen)
        {
            QuanLyAccess.InsertQuanLy( autoCreateMaQuanLy(), tenQuanLy, soDienThoai, email, matKhau, toanQuyen);
        }
        private static string autoCreateMaQuanLy()
        {
            if (QuanLyAccess.SelectAllQuanLy().Rows.Count == 0)
            {
                return "AD001";
            }
            else
            {
                DataTable dataTable = QuanLyAccess.SelectTop1QuanLy();
                string maHienTaiString = dataTable.Rows[0]["maQuanLy"].ToString();
                string baSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 3).ToString();
                int baSoCuoiIntPlussOne = int.Parse(baSoCuoiString) + 1;
                string newMaQuanLy = "AD" + baSoCuoiIntPlussOne.ToString("D3");
                return newMaQuanLy;
            }
        }

        public static void UpdateQuanLy(string maQuanLy, string tenQuanLy, string matKhau,bool toanQuyen)
        {
            QuanLyAccess.UpdateQuanLy(maQuanLy, tenQuanLy, matKhau, toanQuyen);
        }

    }
}
