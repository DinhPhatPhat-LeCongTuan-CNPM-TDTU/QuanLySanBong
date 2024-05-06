using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public string maKhachHang { get; set; }
        public string tenKhachHang { get; set; }
		public string soDienThoai { get; set; }
		public string email { get; set; }
		public string matKhau { get; set; }
		public string gioiTinh { get; set; }
		public DateTime ngaySinh { get; set; }
		public string diaChi { get; set; }
		public int soLanDatSan { get; set; }

		public KhachHang(string maKhachHang, string tenKhachHang, string soDienThoai, string email, string matKhau)
		{
			this.maKhachHang = maKhachHang;
			this.tenKhachHang = tenKhachHang;
			this.soDienThoai = soDienThoai;
			this.email = email;
			this.matKhau = matKhau;
			this.soLanDatSan = 0;
			this.gioiTinh = "";
			this.ngaySinh = new DateTime(2000, 1, 1);
			this.diaChi = "";
		}
        public KhachHang(string tenKhachHang, string soDienThoai, string email, string matKhau)
        {
			this.maKhachHang = "";
            this.tenKhachHang = tenKhachHang;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.matKhau = matKhau;
            this.soLanDatSan = 0;
			this.gioiTinh = "";
            this.ngaySinh = new DateTime(2000, 1, 1);
			this.diaChi = "";
        }
    }
}
