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
                            maQuanLy as N'Mã Quản Lý xác nhận',
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
    }
}
