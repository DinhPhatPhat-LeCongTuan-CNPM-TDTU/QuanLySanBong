using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLy
    {
        public string maQuanLy { get; set; }
        public string tenQuanLy { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string matKhau { get; set; }
        public bool toanQuyen { get; set; }

        public QuanLy(string maQuanLy, string tenQuanLy, string soDienThoai, string email, string matKhau, bool toanQuyen) 
        {
            this.maQuanLy = maQuanLy;
            this.tenQuanLy = tenQuanLy;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.matKhau = matKhau;
            this.toanQuyen = toanQuyen;
        }
    }
}
