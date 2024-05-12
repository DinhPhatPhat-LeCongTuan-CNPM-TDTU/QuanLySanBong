using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuDatSan_BLL
    {
        public static void AddChiTietPhieuDatSan(string maPhieuDatSan, List<int> list)
        {
            foreach (int haiSoCuoiMaSanBong in list)
            {
                ChiTietPhieuDatSanAccess.FindSanBongToAddChiTietPhieuDatSan(maPhieuDatSan, haiSoCuoiMaSanBong);
            }
        }
        public static bool CheckTrungGioDa(DateTime thoiGianDa, DateTime thoiGianKetThuc, List<int> list)
        {
            return ChiTietPhieuDatSanAccess.CheckTrungGioDa(thoiGianDa, thoiGianKetThuc, list);
        }

        public static DataTable XemLichSanBiDat(DateTime ngayXemLichSanBiDat)
        {
            return ChiTietPhieuDatSanAccess.XemLichSanBiDat(ngayXemLichSanBiDat);
        }

        public static string SelectTenSanBongByMaPhieuDatSan(string maPhieuDatSan)
        {
            DataTable dt = ChiTietPhieuDatSanAccess.SelectSanBongByMaPhieuDatSan(maPhieuDatSan);

            string tenSan = "";
            foreach (DataRow dr in dt.Rows)
            {
                tenSan += dr[1]+ " ";
            }
            return tenSan.Trim();
        }

    }
}
