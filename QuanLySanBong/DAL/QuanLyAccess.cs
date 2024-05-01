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
        public static DataTable SelectOneQuanLy(QuanLy quanLy)
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
    }
}
