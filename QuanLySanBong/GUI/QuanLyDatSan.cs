using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyDatSan : Form
    {
        private Software softwareInstance;
        public QuanLyDatSan(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void QuanLyDatSan_Load(object sender, EventArgs e)
        {
            //Chinh dataSource san duoc dat
            comboBox_TinhTrangThanhToanFill.SelectedIndex = 0;
            comboBox_TinhTrangXacNhanFill.SelectedIndex = 0;
            FillDatagridview();
        }

        private void FillDatagridview()
        {
            DataTable dt = PhieuDatSan_BLL.XemAllLichSuDatSanByNgayDa(dateTimePicker_ChonNgayDaFill.Value);
            var filteredData = dt.AsEnumerable();
            string tinhTrangThanhToan = comboBox_TinhTrangThanhToanFill.Text;
            string tinhTrangXacNhan = comboBox_TinhTrangXacNhanFill.Text;

            if (tinhTrangThanhToan != "Tất cả")
            {
                filteredData = filteredData.Where(row => row.Field<string>("Tình trạng thanh toán") == tinhTrangThanhToan);
            }

            if (tinhTrangXacNhan != "Tất cả")
            {
                filteredData = filteredData.Where(row => row.Field<string>("Tình trạng xác nhận") == tinhTrangXacNhan);
            }
            if (filteredData.Any())
            {
                DataTable source = filteredData.CopyToDataTable();
                dataGridView_SanDuocDat.DataSource = source;
                return;
            }
            else
            {
                dataGridView_SanDuocDat.DataSource = null;
            }
        }

        private void dateTimePicker_ChonNgayDa_ValueChanged(object sender, EventArgs e)
        {
            FillDatagridview();
        }

        private void comboBox_TinhTrangXacNhanFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagridview();
        }

        private void comboBox_TinhTrangThanhToanFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagridview();
        }

        private void dataGridView_SanDuocDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    DataGridViewRow selectedRow = dataGridView_SanDuocDat.Rows[e.RowIndex];
                    // Gọi phương thức xử lý dữ liệu với dòng được chọn
                    string maPhieuDatSan = selectedRow.Cells[0].Value.ToString();
                    string tenKhachHang = KhachHang_BLL.SelectOneKhachHangByMaPhieuDatSan(maPhieuDatSan).tenKhachHang;
                    string soDienThoai = KhachHang_BLL.SelectOneKhachHangByMaPhieuDatSan(maPhieuDatSan).soDienThoai;
                    string tenThuNgan = QuanLy_BLL.SelectOneQuanLyByMaPhieuDatSan(maPhieuDatSan).tenQuanLy;
                    string loaiSan = selectedRow.Cells[2].Value.ToString();
                    string ngayDatSan = selectedRow.Cells[3].Value.ToString();
                    string thoiGianDa = selectedRow.Cells[4].Value.ToString();
                    string thoiGianKetThuc = selectedRow.Cells[5].Value.ToString();
                    string tongTien = selectedRow.Cells[6].Value.ToString();
                    string tinhTrangXacNhan = selectedRow.Cells[7].Value.ToString();
                    string tinhTrangThanhToan = selectedRow.Cells[8].Value.ToString();
                    textBox_MaPhieuDatSan.Text = maPhieuDatSan;
                    textBox_LoaiSan.Text = loaiSan;
                    textBox_TenKhachHang.Text = tenKhachHang;
                    textBox_SoDienThoai.Text = soDienThoai;
                    textBox_TenThuNgan.Text = tenThuNgan;
                    textBox_ThoiGianDa.Text = thoiGianDa;
                    textBox_ThoiGianKetThuc.Text = thoiGianKetThuc;
                    textBox_NgayDatSan.Text = ngayDatSan;
                    textBox_TongTien.Text = tongTien;
                    comboBox_TinhTrangXacNhan.SelectedIndex = tinhTrangXacNhan.Equals("Chưa xác nhận") ? 0 : 1;
                    comboBox_TinhTrangThanhToan.SelectedIndex = tinhTrangThanhToan.Equals("Chưa thanh toán") ? 0 : 1;
                    comboBox_TinhTrangXacNhan.SelectedValue = tinhTrangXacNhan;
                    textBox_TenSan.Text = ChiTietPhieuDatSan_BLL.SelectTenSanBongByMaPhieuDatSan(maPhieuDatSan);

                    comboBox_TinhTrangXacNhan.Enabled = tinhTrangXacNhan.Equals("Đã xác nhận") ? false : true;
                    comboBox_TinhTrangThanhToan.Enabled = tinhTrangThanhToan.Equals("Đã thanh toán") ? false : true;

                    button_XoaDatSan.Enabled = comboBox_TinhTrangThanhToan.Enabled;


                }
            }
        }

        private void button_LuuThongTinDatSan_Click(object sender, EventArgs e)
        {
            string maQuanLyThuTien = softwareInstance.quanLy.maQuanLy;
            if (textBox_MaPhieuDatSan.Text != "")
            {
                PhieuDatSan_BLL.UpdateTinhTrangPhieuDatSan(textBox_MaPhieuDatSan.Text, comboBox_TinhTrangXacNhan.Text, comboBox_TinhTrangThanhToan.Text, maQuanLyThuTien);
            }
        }

        private void button_XoaDatSan_Click(object sender, EventArgs e)
        {
            string maPhieuDatSan = textBox_MaPhieuDatSan.Text;
            if(maPhieuDatSan!= "")
            {
                DialogResult dialogResult= MessageBox.Show("Xóa phiếu đặt sân", $"Quản lý có chắc muốn xóa phiếu đặt sân '{maPhieuDatSan}'", MessageBoxButtons.YesNo);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    PhieuDatSan_BLL.DeletePhieuDatSanByMaPhieuDatSan(maPhieuDatSan);
                    FillDatagridview();
                }
            }

        }
    }
}
