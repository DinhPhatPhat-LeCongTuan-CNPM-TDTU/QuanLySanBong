using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL
{
    public class KhachHang_BLL
    {

        public static bool checkLoginValid(string email_soDienThoai, string matKhau)
        {
            return KhachHangAccess.CheckLoginValid(email_soDienThoai, matKhau);

        }

        public static bool checkEmailExist(string email)
        {
            string dieuKien = $"email = '{email}'";
            if (KhachHangAccess.SelectOneKhachHang(dieuKien).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool checkSoDienThoaiExist(string soDienThoai)
        {
            string dieuKien = $"soDienThoai = '{soDienThoai}'";
            if (KhachHangAccess.SelectOneKhachHang(dieuKien).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        //Phương thức thêm khách hàng mới vào database (tạo tài khoản thành công)
        public static void AddKhachHang(KhachHang khachHang)
        {
            khachHang.maKhachHang = autoCreateMaKhachHang();
            KhachHangAccess.AddKhachHang(khachHang);
        }

        //Phương thức trả về mã khách hàng mới tự động
        private static string autoCreateMaKhachHang()
        {
            if (KhachHangAccess.SelectAllKhachHang().Rows.Count == 0)
            {
                return "KH00000000";
            }
            else
            {
                DataTable dataTable = KhachHangAccess.SelectTop1KhachHang();
                string maHienTaiString = dataTable.Rows[0]["maKhachHang"].ToString();
                string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
                int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
                string newMaKhachHang = "KH" + tamSoCuoiIntPlussOne;
                return newMaKhachHang;
            }
        }
    }
}
