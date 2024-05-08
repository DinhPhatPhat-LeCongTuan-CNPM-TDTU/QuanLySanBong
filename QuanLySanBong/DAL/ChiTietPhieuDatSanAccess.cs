using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuDatSanAccess
    {
        public static void AddChiTietPhieuDatSan(ChiTietPhieuDatSan chiTietPhieuDatSan)
        {
            string query = @$"Insert into ChiTietPhieuDatSan values(
                            '{chiTietPhieuDatSan.maPhieuDatSan}',
                            '{chiTietPhieuDatSan.maSanBong}',
                            '{chiTietPhieuDatSan.donGia}'
                            )";
            Connection.actionQuery(query);
        }

        public static void FindSanBongToAddChiTietPhieuDatSan(string maPhieuDatSan,int haiSoCuoiMaSanBong)
        {
            string maSanBong = "SB"+haiSoCuoiMaSanBong.ToString("D2");
            string query = $@"Insert into ChiTietPhieuDatSan values ('{maPhieuDatSan}','{maSanBong}',{2000})";
            Connection.actionQuery(query);
        }
    }
}
