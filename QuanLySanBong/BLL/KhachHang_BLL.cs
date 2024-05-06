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
        /*public static void AddKhachHang(KhachHang khachHang)
        {
            khachHang.
        }*/
    }
}
