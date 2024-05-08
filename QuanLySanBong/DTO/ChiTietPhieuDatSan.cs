using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuDatSan
    {
        private string maPhieuDatSan {  get; set; }
	    private string maSanBong { get; set; }
	    private int donGia { get; set; }

        public ChiTietPhieuDatSan(string maPhieuDatSan, string maSanBong, int donGia)
        {
            this.maPhieuDatSan = maPhieuDatSan;
            this.maSanBong = maSanBong;
            this.donGia = donGia;
        }
    }
}
