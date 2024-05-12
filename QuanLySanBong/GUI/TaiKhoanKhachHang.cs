using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TaiKhoanKhachHang : Form
    {
        private Software softwareInstance;
        public TaiKhoanKhachHang(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
            XemLichSuDatSan();
        }

        private void TaiKhoanKhachHang_Load(object sender, EventArgs e)
        {
            textBox_TenKhachHang.Text = softwareInstance.khachHang.tenKhachHang;
            textBox_SoDienThoai.Text = softwareInstance.khachHang.soDienThoai;
            textBox_Email.Text = softwareInstance.khachHang.email;
            textBox_DiaChi.Text = softwareInstance.khachHang.diaChi;
            dateTimePicker_NgaySinh.Value = softwareInstance.khachHang.ngaySinh;
            comboBox_GioiTinh.Text = softwareInstance.khachHang.gioiTinh;
            textBox_SoLanDatSanVaThanhToanThanhCong.Text = softwareInstance.khachHang.soLanDatSan.ToString();
        }

        private void checkBox_SuaThongTin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SuaThongTin.Checked)
            {
                button_LuuThongTin.Visible = true;
                textBox_TenKhachHang.Enabled = true;
                textBox_DiaChi.Enabled = true;
                dateTimePicker_NgaySinh.Enabled = true;
                comboBox_GioiTinh.Enabled = true;
            }
            else
            {
                button_LuuThongTin.Visible = false;
                textBox_TenKhachHang.Enabled = false;
                textBox_DiaChi.Enabled = false;
                dateTimePicker_NgaySinh.Enabled = false;
                comboBox_GioiTinh.Enabled = false;
            }
        }

        private void XemLichSuDatSan()
        {
            string maKhachHang = softwareInstance.khachHang.maKhachHang;
            dataGridView_LichSuDatSan.DataSource = PhieuDatSan_BLL.XemLichSuDatSan(maKhachHang);
        }

        private void button_LuuThongTin_Click(object sender, EventArgs e)
        {
            if (textBox_TenKhachHang.Text.Trim() == "")
            {
                label_ThongBao.Text = "Tên khách hàng không bỏ trống";
                ClearThongBao();
                return;
            }

            if((textBox_DiaChi.Text + textBox_TenKhachHang.Text).Contains('\''))
            {
                label_ThongBao.Text = "Thông tin không được chứa ký tự đặc biệt: \'";
                ClearThongBao();
                return;
            }

            //Cập nhập CSDL bảng KhachHang
            if (KhachHang_BLL.UpdateKhachHang(softwareInstance.khachHang.maKhachHang, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, dateTimePicker_NgaySinh.Value, textBox_DiaChi.Text))
            {
                label_ThongBao.Text = "Cập nhật thông tin thành công";
                softwareInstance.khachHang.tenKhachHang = textBox_TenKhachHang.Text;
                softwareInstance.khachHang.gioiTinh = comboBox_GioiTinh.Text;
                softwareInstance.khachHang.ngaySinh = dateTimePicker_NgaySinh.Value;
                softwareInstance.khachHang.diaChi = textBox_DiaChi.Text;
                softwareInstance.changePanelShow(this);
                checkBox_SuaThongTin.Checked = false;
                ClearThongBao();
                return;
            }
            else
            {
                label_ThongBao.Text = "Lỗi cập nhật";
                ClearThongBao();
            }
        }

        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            label_ThongBao.Text = "";
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            softwareInstance.DangXuat();
        }
    }
}
