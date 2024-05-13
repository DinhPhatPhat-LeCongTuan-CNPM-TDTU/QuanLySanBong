using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDatSanAccess
    {
        public static DataTable SelectAllPhieuDatSan()
        {
            string query = "Select * from PhieuDatSan";
           return  Connection.selectQuery(query);

        }

        public static DataTable SelectTop1PhieuDatSan()
        {
            string query = @$"Select top 1* from PhieuDatSan
                                ORDER BY CAST(RIGHT(maPhieuDatSan, 8) AS bigint) DESC ";
            return Connection.selectQuery(query);
        }
        public static void AddPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            string query = @$"Insert into PhieuDatSan values (
                            '{phieuDatSan.maPhieuDatSan}',
                            '{phieuDatSan.maKhachHang}',
                            '{phieuDatSan.maQuanLy}',
                            '{phieuDatSan.loaiSan}',
                            '{phieuDatSan.ngayDatSan}',
                            '{phieuDatSan.thoiGianDa}',
                            '{phieuDatSan.thoiGianKetThuc}',
                            '{phieuDatSan.tongTien}',
                            N'{phieuDatSan.tinhTrangXacNhan}',
                            N'{phieuDatSan.tinhTrangThanhToan}'
                            )";
            Connection.actionQuery(query);
        }

        public static DataTable XemLichSuDatSan(string maKhachHang)
        {
            string query = $@"Select maPhieuDatSan as N'Mã phiếu',
                            maQuanLy as N'Mã Quản Lý thu tiền',
                            loaiSan as N'Loại sân',
                            ngayDatSan as N'Ngày đặt sân',
                            thoiGianDa as N'Thời gian đá',
                            thoiGianKetThuc as N'Thời gian kết thúc',
                            tongTien as N'Tổng tiền',
                            tinhTrangXacNhan as N'Tình trạng xác nhận',
                            tinhTrangThanhToan as N'Tình trạng thanh toán'
                            from PhieuDatSan
                            where maKhachHang = '{maKhachHang}'";
                            return Connection.selectQuery(query);
        }


        public static DataTable XemAllLichSuDatSanByNgayDa(DateTime ngayDa)
        {
            string query = $@"Select maPhieuDatSan as N'Mã phiếu',
                            maQuanLy as N'Mã Quản Lý thu tiền',
                            loaiSan as N'Loại sân',
                            ngayDatSan as N'Ngày đặt sân',
                            thoiGianDa as N'Thời gian đá',
                            thoiGianKetThuc as N'Thời gian kết thúc',
                            tongTien as N'Tổng tiền',
                            tinhTrangXacNhan as N'Tình trạng xác nhận',
                            tinhTrangThanhToan as N'Tình trạng thanh toán'
                            from PhieuDatSan where CAST (thoiGianDa as DATE) = '{ngayDa.Date}'
                            ";
            return Connection.selectQuery(query);
        }

        public static void UpdateTongTienPhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            string query = @$"
                            WITH cte AS (
                                SELECT ChiTietPhieuDatSan.maPhieuDatSan, 
                                       ChiTietPhieuDatSan.giaSanTheoPhut * DATEDIFF(minute, PhieuDatSan.thoiGianDa, PhieuDatSan.thoiGianKetThuc) as tien
                                FROM ChiTietPhieuDatSan
                                INNER JOIN PhieuDatSan ON ChiTietPhieuDatSan.maPhieuDatSan = PhieuDatSan.maPhieuDatSan
                                WHERE ChiTietPhieuDatSan.maPhieuDatSan = '{maPhieuDatSan}'
                            )
                            UPDATE PhieuDatSan 
                            SET tongTien = (SELECT SUM(tien) FROM cte)
                            WHERE maPhieuDatSan = '{maPhieuDatSan}'";
                                Connection.actionQuery(query);
        }

        public static void UpdateTinhTrangPhieuDatSan(string maPhieuDatSan,string tinhTrangXacNhan, string tinhTrangThanhToan, string maQuanLyThuTien)
        {
            string query = $"Update PhieuDatSan Set tinhTrangXacNhan = N'{tinhTrangXacNhan}', tinhTrangThanhToan = N'{tinhTrangThanhToan}' where maPhieuDatSan = '{maPhieuDatSan}'";
            Connection.actionQuery(query);
            //
            if (tinhTrangThanhToan.Equals("Đã thanh toán"))
            {
                string query2 = $"Update PhieuDatSan set maQuanLy ='{maQuanLyThuTien}' where maPhieuDatSan = '{maPhieuDatSan}'";
                Connection.actionQuery(query2);
                KhachHangAccess.UpdateSoLanDatSanThanhCong(maPhieuDatSan);
            }
        }

        public static void DeletePhieuDatSanByMaPhieuDatSan(string maPhieuDatSan)
        {
            ChiTietPhieuDatSanAccess.DeleteChiTietPhieuDatSanByMaPhieuDatSan(maPhieuDatSan);
            string query = $"Delete from PhieuDatSan where maPhieuDatSan = '{maPhieuDatSan}'";
            Connection.actionQuery(query);
        }

        public static DataTable ThongKeKinhDoanh(DateTime tu, DateTime den)
        {
            tu = tu.Date;
            den = den.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            string query = @$"Select maPhieuDatSan as N'Mã phiếu đặt sân',loaiSan as N'Loại sân', thoiGianDa N'Thời gian đá', thoiGianKetThuc as N'Thời gian kết thúc', tongTien as N'Giá' from PhieuDatSan where tinhTrangThanhToan = N'Đã thanh toán' and thoiGianDa between '{tu}' and '{den}'";
            return Connection.selectQuery(query);
        }
    }
}
