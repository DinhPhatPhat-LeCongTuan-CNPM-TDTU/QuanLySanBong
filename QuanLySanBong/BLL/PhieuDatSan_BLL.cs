using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDatSan_BLL
    {
        public static string AddPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            phieuDatSan.maPhieuDatSan = autoCreateMaPhieuDatSan();
            PhieuDatSanAccess.AddPhieuDatSan(phieuDatSan);
            return phieuDatSan.maPhieuDatSan;
        }

        private static string autoCreateMaPhieuDatSan()
        {
            if (PhieuDatSanAccess.SelectAllPhieuDatSan().Rows.Count == 0)
            {
                return "DS00000000";
            }
            else
            {
                DataTable dataTable = PhieuDatSanAccess.SelectTop1PhieuDatSan();
                string maHienTaiString = dataTable.Rows[0]["maPhieuDatSan"].ToString();
                string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
                int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
                string newPhieuDatSan = "DS" + tamSoCuoiIntPlussOne.ToString("D8");
                return newPhieuDatSan;
            }
        }

        public static DataTable XemLichSuDatSan(string maKhachHang)
        {
            return PhieuDatSanAccess.XemLichSuDatSan(maKhachHang);
        }
        public static DataTable XemAllLichSuDatSanByNgayDa(DateTime ngayDa)
        {
            return PhieuDatSanAccess.XemAllLichSuDatSanByNgayDa(ngayDa);
        }

        public static void UpdateTinhTrangPhieuDatSan(string maPhieuDatSan, string tinhTrangXacNhan, string tinhTrangThanhToan, string maQuanLyThuTien)
        {
            PhieuDatSanAccess.UpdateTinhTrangPhieuDatSan(maPhieuDatSan,tinhTrangXacNhan, tinhTrangThanhToan, maQuanLyThuTien);
        }

        public static void DeletePhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            PhieuDatSanAccess.DeletePhieuDatSanByMaPhieuDatSan(maPhieuDatSan);
        }
    }
}
