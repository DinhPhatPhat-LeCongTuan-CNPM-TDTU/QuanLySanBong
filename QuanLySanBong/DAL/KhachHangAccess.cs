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
        public static DataTable SelectOneKhachHang(KhachHang khachHang)
        {
            string query = @$"Select * from KhachHang where maKhachHang = {khachHang.maKhachHang} ";
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
    }
}
