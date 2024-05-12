using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhachHangAccess
    {
        public static DataTable SelectOneKhachHang(string dieuKien)
        {
            string query = @$"Select * from KhachHang where ({dieuKien}) ";
            return Connection.selectQuery(query);
        }

        public static DataTable SelectTop1KhachHang()
        {
            string query = @$"Select top 1* from KhachHang
                                ORDER BY CAST(RIGHT(maKhachHang, 8) AS bigint) DESC ";
            return Connection.selectQuery(query);
        }

        public static DataTable SelectAllKhachHang()
        {
            string query = "Select * from KhachHang";
            return Connection.selectQuery(query);
        }

        public static bool CheckLoginValid(string soDienThoai_email, string matKhau)
        {
            string query = $@"Select * from KhachHang 
                            where (soDienThoai = '{soDienThoai_email}' and matKhau = '{matKhau}')";
            
            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang soDienThoai hop le
                return true;
            }

            query = $@"Select * from KhachHang where ( email = '{soDienThoai_email}' and
                             matKhau = '{matKhau}')";
            if (Connection.selectQuery(query).Rows.Count > 0)
            {
                //Thong tin dang nhap bang email hop le
                return true;
            }
            return false;
        }

        public static void AddKhachHang(KhachHang khachHang)
        {
            string query = $@"Insert into KhachHang values (
            '{khachHang.maKhachHang}',
            '{khachHang.tenKhachHang}',
            '{khachHang.soDienThoai}',
            '{khachHang.email}',
            '{khachHang.matKhau}',
            '{khachHang.gioiTinh}',
            '{khachHang.ngaySinh}',
            '{khachHang.diaChi}',
            {khachHang.soLanDatSan})";
            Connection.actionQuery(query);
        }

        public static bool UpdateKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            try
            {
                string query = $"Update KhachHang set tenKhachHang = '{tenKhachHang}', gioiTinh = N'{gioiTinh}', ngaySinh= '{ngaySinh}', diaChi= N'{diaChi}' where maKhachHang = '{maKhachHang}'";
                Connection.actionQuery(query);
                return true;
            }
            catch { return false; }

        }

        public static bool DoiMatKhau(string email, string matKhauMoi)
        {
            try
            {
                string query = $"Update KhachHang set matKhau = '{matKhauMoi}' where email = '{email}'";
                return true;
            }
            catch { return false; }
        }

        public static KhachHang SelectOneKhachHangByMaKhachHang(string maKhachHang)
        {
            try
            {
                string query = $"Select * from KhachHang where MaKhachHang = '{maKhachHang}'";
                DataTable dt = Connection.selectQuery(query);
                string tenKhachHang = dt.Rows[0]["tenKhachHang"].ToString();
                string email = dt.Rows[0]["email"].ToString();
                string soDienThoai = dt.Rows[0]["soDienThoai"].ToString();
                string matKhau = dt.Rows[0]["matKhau"].ToString();
                string gioiTinh = dt.Rows[0]["gioiTinh"].ToString();
                DateTime ngaySinh = DateTime.Parse(dt.Rows[0]["ngaySinh"].ToString());
                string diaChi = dt.Rows[0]["diaChi"].ToString();
                int soLanDatSan = int.Parse(dt.Rows[0]["soLanDatSan"].ToString());

                KhachHang khachHang = new KhachHang(maKhachHang,tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan);
                return khachHang;               
            }
            catch
            {
                return null;
            }
        }

        public static KhachHang SelectOneKhachHangByMaPhieuDatSan(string maPhieuDatSan)
        {
            try
            {
                string query = $"Select * from KhachHang where MaKhachHang IN ( Select MaKhachHang from PhieuDatSan where MaPhieuDatSan = '{maPhieuDatSan}')";
                DataTable dt = Connection.selectQuery(query);
                string maKhachHang = dt.Rows[0]["maKhachHang"].ToString();
                string tenKhachHang = dt.Rows[0]["tenKhachHang"].ToString();
                string email = dt.Rows[0]["email"].ToString();
                string soDienThoai = dt.Rows[0]["soDienThoai"].ToString();
                string matKhau = dt.Rows[0]["matKhau"].ToString();
                string gioiTinh = dt.Rows[0]["gioiTinh"].ToString();
                DateTime ngaySinh = DateTime.Parse(dt.Rows[0]["ngaySinh"].ToString());
                string diaChi = dt.Rows[0]["diaChi"].ToString();
                int soLanDatSan = int.Parse(dt.Rows[0]["soLanDatSan"].ToString());

                KhachHang khachHang = new KhachHang(maKhachHang, tenKhachHang, soDienThoai, email, matKhau, gioiTinh, ngaySinh, diaChi, soLanDatSan);
                return khachHang;
            }
            catch
            {
                return null;
            }
        }

        public static void UpdateSoLanDatSanThanhCong(string maPhieuDatSan)
        {
            string query = "UPDATE KhachHang SET soLanDatSan = (SELECT COUNT(maKhachHang) FROM PhieuDatSan WHERE TinhTrangThanhToan = N'Đã thanh toán' AND PhieuDatSan.maKhachHang = KhachHang.maKhachHang)";
            Connection.actionQuery(query);
        }

        public static void DeleteKhachHangByMaKhachHang(string maKhachHang)
        {
            string query1 = $"Delete from ChiTietPhieuDatSan where maPhieuDatSan in (select maPhieuDatSan from PhieuDatSan where maKhachhang = '{maKhachHang}')";
            Connection.actionQuery(query1);
            string query2 = $"Delete from PhieuDatSan where maKhachHang = '{maKhachHang}'";
            Connection.actionQuery(query2);
            string query3 = $"Delete from KhachHang where maKhachHang = '{maKhachHang}'";
            Connection.actionQuery(query3);
        }
    }
}
