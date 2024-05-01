using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class DangNhap : Form
    {
        private Software softwareInstance;
        private bool isShowingPassword = false;
        public DangNhap(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string soDienThoai_Email = textBox_SoDienThoai_Email.Text;
            string matKhau = textBox_MatKhau.Text;

            
            if (soDienThoai_Email.Trim() == "" || matKhau.Trim() == "")
            {
                label_LoiDangNhap.Text = "Vui lòng điền đầy đủ thông tin đăng nhập";
                ClearLoiDangNhap();
                return;
            }

            else if (soDienThoai_Email.Contains('\'') || matKhau.Contains('\''))
            {
                label_LoiDangNhap.Text = "Thông tin đăng nhập chứa  ký tự không hợp lệ";
                ClearLoiDangNhap();
                return;
            }


            if (checkBox_DangNhapVoiTuCachQuanLy.Checked)
            {
                if (QuanLy_BLL.checkLoginValid(soDienThoai_Email, matKhau))
                {
                    label_LoiDangNhap.Text = "Đăng nhâp với tư cách quản lý thành công";
                    ClearLoiDangNhap();
                }
                else
                {
                    label_LoiDangNhap.Text = "Thông tin đăng nhập không hợp lệ";
                    ClearLoiDangNhap();
                }
                return;
            }

            else
            {
                if (KhachHang_BLL.checkLoginValid(soDienThoai_Email, matKhau))
                {
                    label_LoiDangNhap.Text = "Đăng nhâp với tư cách khách hàng thành công";
                    ClearLoiDangNhap();
                }
                else
                {
                    label_LoiDangNhap.Text = "Thông tin đăng nhập không hợp lệ";
                    ClearLoiDangNhap();
                }
                return;
            }

        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy(softwareInstance);
            softwareInstance.changePanelShow(dangKy);
        }

        private async void ClearLoiDangNhap()
        {
            await Task.Delay(5000);
            label_LoiDangNhap.Text = "";
        }

        private void pictureBox_Show_Hind_Password_Click(object sender, EventArgs e)
        {
            if (isShowingPassword == false)
            {
                textBox_MatKhau.UseSystemPasswordChar = false;
                isShowingPassword = true;
            }
            else
            {
                textBox_MatKhau.UseSystemPasswordChar = true;
                isShowingPassword = false;
            }

        }
    }
}
