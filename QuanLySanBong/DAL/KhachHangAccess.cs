using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhachHangAccess
    {
        public static DataTable SelectOneKhachHang(string dieuKien)
        {
            string query = @$"Select * from KhachHang where ({dieuKien}) ";
            return Connection.selectQuery(query);
        }

        public static bool CheckLoginValid(string email_soDienThoai, string matKhau)
        {
            string query = $@"Select * from KhachHang 
                            where (soDienThoai = '{email_soDienThoai}' and matKhau = '{matKhau}')";
            
            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang soDienThoai hop le
                return true;
            }

            query = $@"Select * from KhachHang where ( email = '{email_soDienThoai}' and
                             matKhau = '{matKhau}')";
            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang email hop le
                return true;
            }
            return false;
        }

        public static void AddKhachHang(KhachHang khachHang)
        {
            string query = $@"Insert into KhachHang values (
            {khachHang.maKhachHang},
            {khachHang.tenKhachHang},
            {khachHang.soDienThoai},
            {khachHang.email},
            {khachHang.matKhau},
            {khachHang.gioiTinh},
            {khachHang.ngaySinh},
            {khachHang.diaChi},
            {khachHang.soLanDatSan})";
            Connection.actionQuery(query);
        }
    }
}
