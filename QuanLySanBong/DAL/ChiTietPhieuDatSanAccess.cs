using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public static bool CheckTrungGioDa(DateTime thoiGianDa, DateTime thoiGianKetThuc, List<int> list)
        {
            List<string> danhSachSanBong = new List<string>();
            foreach (int num in list)
            {
                danhSachSanBong.Add("SB"+num.ToString("D2"));
            }

            foreach (string maSanBong in danhSachSanBong)
            {
                string query = $@"SELECT COUNT(*) 
                             FROM ChiTietPhieuDatSan 
                             INNER JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPhieuDatSan = PhieuDatSan.maPhieuDatSan 
                             WHERE maSanBong = '{maSanBong}' 
                             AND ((thoiGianDa <= '{thoiGianDa}' AND thoiGianKetThuc > '{thoiGianKetThuc}') 
                             OR (thoiGianDa < '{thoiGianKetThuc}' AND thoiGianKetThuc >= '{thoiGianKetThuc}') 
                             OR ('{thoiGianDa}' <= thoiGianDa AND '{thoiGianKetThuc}' > thoiGianDa) 
                             OR ('{thoiGianDa}' < thoiGianKetThuc AND '{thoiGianKetThuc}' >= thoiGianKetThuc))";
                if (Connection.countQuery(query) > 0)
                {
                    return true;
                }
            }
            return false; // Không có sân bóng nào được đặt trùng thời gian           
        }

        public static DataTable XemLichSanBiDat(DateTime ngayXemLichSanBiDat)
        {
            string query = $@"SELECT SanBong.tenSanBong as N'Tên Sân', PhieuDatSan.thoiGianDa as N'Bắt đầu đá', PhieuDatSan.thoiGianKetThuc as N'Hết giờ'
                FROM ChiTietPhieuDatSan
                INNER JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPhieuDatSan = PhieuDatSan.maPhieuDatSan
                INNER JOIN SanBong ON ChiTietPhieuDatSan.maSanBong = SanBong.maSanBong
                WHERE CAST(PhieuDatSan.ngayDatSan AS DATE) = '{ngayXemLichSanBiDat.ToString("yyyy-MM-dd")}'";
            return Connection.selectQuery(query);

        }
    }
}
