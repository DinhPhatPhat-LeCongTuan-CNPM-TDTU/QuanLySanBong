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

        public static bool checkLoginValid(string soDienThoai_email, string matKhau)
        {
            return KhachHangAccess.CheckLoginValid(soDienThoai_email, matKhau);

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

        public static KhachHang selectOneKhachHang(string soDienThoai_email)
        {
            string dieuKien = $"email = '{soDienThoai_email}'";
            DataTable dt = KhachHangAccess.SelectOneKhachHang(dieuKien);
            if (dt.Rows.Count > 0) 
            {
                DataRow row = dt.Rows[0];
                string maKhachHang = row["maKhachHang"].ToString();
                string tenKhachHang = row["tenKhachHang"].ToString();
                string soDienThoai = row["soDienThoai"].ToString();
                string email = row["email"].ToString();
                string matKhau = row["matKhau"].ToString();
                string gioiTinh = row["gioiTinh"].ToString();
                DateTime ngaySinh = (DateTime)row["ngaySinh"];
                string diaChi = row["diaChi"].ToString();
                int soLanDatSan = Convert.ToInt32(row["soLanDatSan"]);
                // Khởi tạo đối tượng KhachHang với các giá trị đã trích xuất
                KhachHang khachHang = new KhachHang(maKhachHang, tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan);
                // Trả về đối tượng KhachHang đã khởi tạo
                return khachHang;
            }
            else
            {
                dieuKien = $"soDienThoai = '{soDienThoai_email}'";
                dt = KhachHangAccess.SelectOneKhachHang(dieuKien);
                    DataRow row = dt.Rows[0];
                    string maKhachHang = row["maKhachHang"].ToString();
                    string tenKhachHang = row["tenKhachHang"].ToString();
                    string soDienThoai = row["soDienThoai"].ToString();
                    string email = row["email"].ToString();
                    string matKhau = row["matKhau"].ToString();
                    string gioiTinh = row["gioiTinh"].ToString();
                    DateTime ngaySinh = (DateTime)row["ngaySinh"];
                    string diaChi = row["diaChi"].ToString();
                    int soLanDatSan = Convert.ToInt32(row["soLanDatSan"]);
                    // Khởi tạo đối tượng KhachHang với các giá trị đã trích xuất
                    KhachHang khachHang = new KhachHang(maKhachHang, tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan);
                    // Trả về đối tượng KhachHang đã khởi tạo
                    return khachHang;
            }
            
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
                return "KH10000000";
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
