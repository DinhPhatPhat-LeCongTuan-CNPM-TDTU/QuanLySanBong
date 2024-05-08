using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatSan
    {
		public string maPhieuDatSan {  get; set; }
        public string maKhachHang { get; set; }
        public string maQuanLy { get; set; }
        public int loaiSan { get; set; }
        public DateTime ngayDatSan { get; set; }
        public DateTime ngayDa { get; set; }
        public int phutDa { get; set; }
        public int tongTien { get; set; }
        public string tinhTrangXacNhan { get; set; }
        public string tinhTrangThanhToan { get; set; }

        public PhieuDatSan(string maPhieuDatSan, string maKhachHang, string maQuanLy,
            int loaiSan, DateTime ngayDatSan, DateTime ngayDa,
            int phutDa, int tongTien)
        {
            this.maPhieuDatSan = maPhieuDatSan;
            this.maKhachHang = maKhachHang;
            this.maQuanLy = maQuanLy;
            this.loaiSan = loaiSan;
            this.ngayDatSan = ngayDatSan;
            this.ngayDa = ngayDa;
            this.phutDa = phutDa;
            this.tongTien = tongTien;
            this.tinhTrangXacNhan = "Chưa xác nhận";
            this.tinhTrangThanhToan = "Chưa thanh toán";
        }
    }
}
