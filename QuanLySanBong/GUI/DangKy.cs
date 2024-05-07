using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI
{
    public partial class DangKy : Form
    {
        private Software softwareInstance;
        public DangKy(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        public KhachHang getThongTinDangNhap()
        {
            return new KhachHang(textBox_TenKhachHang.Text, textBox_SoDienThoai.Text, textBox_Email.Text, textBox_MatKhau.Text);
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap(softwareInstance);
            softwareInstance.changePanelShow(dangNhap);
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tenKhachHang = textBox_TenKhachHang.Text;
            string soDienThoai = textBox_SoDienThoai.Text;
            string email = textBox_Email.Text;
            string matKhau = textBox_MatKhau.Text;
            string xacNhanMatKhau = textBox_XacNhanMatKhau.Text;

            if (string.IsNullOrEmpty(tenKhachHang) ||
                string.IsNullOrEmpty(soDienThoai) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(xacNhanMatKhau))
            {
                label_ThongBao.Text = "Vui lòng điền đầy đủ thông tin đăng ký";
                ClearThongBao();
                return;
            }

            if (!CheckEmailValid(email))
            {
                label_ThongBao.Text = "Định dạng email không hợp lệ";
                ClearThongBao();
                return;
            }


            if (KhachHang_BLL.checkEmailExist(email))
            {
                label_ThongBao.Text = "Email đã tồn tại";
                ClearThongBao();
                return;
            }
            if (KhachHang_BLL.checkSoDienThoaiExist(soDienThoai))
            {
                label_ThongBao.Text = "Số điện thoại đã tồn tại";
                ClearThongBao();
                return;
            }


            OTPDangKy xacNhanOTP = new OTPDangKy(softwareInstance,this);
            softwareInstance.changePanelShow(xacNhanOTP);
            //Gửi OTP cho mail đăng ký bằng mail dinhtainang@gmail.com


        }

        private bool CheckEmailValid(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            label_ThongBao.Text = "";
        }

        private void pictureBox_Show_Hind_Password_Click(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = textBox_MatKhau.PasswordChar == '\0' ? true : false;
        }

        private void pictureBox_Show_Hind_Password2_Click(object sender, EventArgs e)
        {
             textBox_XacNhanMatKhau.UseSystemPasswordChar = textBox_XacNhanMatKhau.PasswordChar == '\0' ? true : false;
        }
    }
}
