using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class QuanLy_BLL
    {
        public static bool checkLoginValid(string email_soDienThoai, string matKhau)
        {
            return QuanLyAccess.CheckLoginValid(email_soDienThoai, matKhau);

        }
    }
}
