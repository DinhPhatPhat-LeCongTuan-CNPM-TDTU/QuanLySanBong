using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhachHang_BLL
    {
        
        public static bool checkLoginValid(string email_soDienThoai, string matKhau)
        {
            return KhachHangAccess.CheckLoginValid(email_soDienThoai, matKhau);
                
        }
        
    }
}
