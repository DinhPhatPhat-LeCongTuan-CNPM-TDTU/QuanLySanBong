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

        public DangNhap(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
            textBox_SoDienThoai_Email.Text = Properties.Settings.Default.soDienThoai_Email;
            textBox_MatKhau.Text = Properties.Settings.Default.matKhau;
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string soDienThoai_Email = textBox_SoDienThoai_Email.Text;
            string matKhau = textBox_MatKhau.Text;


            if (soDienThoai_Email.Trim() == "" || matKhau.Trim() == "")
            {
                label_ThongBao.Text = "Vui lòng điền đầy đủ thông tin đăng nhập";
                ClearThongBao();
                return;
            }

            else if (soDienThoai_Email.Contains('\'') || matKhau.Contains('\''))
            {
                label_ThongBao.Text = "Thông tin đăng nhập chứa ký tự không hợp lệ";
                ClearThongBao();
                return;
            }


            if (checkBox_DangNhapVoiTuCachQuanLy.Checked)
            {
                if (QuanLy_BLL.checkLoginValid(soDienThoai_Email, matKhau))
                {
                    if (checkBox_GhiNhoDangNhap.Checked)
                    {
                        Properties.Settings.Default.soDienThoai_Email = soDienThoai_Email;
                        Properties.Settings.Default.matKhau = matKhau;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.soDienThoai_Email = "";
                        Properties.Settings.Default.matKhau = "";
                        Properties.Settings.Default.Save();
                    }
                    //Đăng nhập với tư cách quản lý thành công
                    softwareInstance.isLoged = true;
                    softwareInstance.isAdmin = true;
                    softwareInstance.quanLy = QuanLy_BLL.SelectOneQuanLyByEmail_SoDienThoai(soDienThoai_Email);
                    softwareInstance.changePanelShow(new TaiKhoanQuanLy(softwareInstance));

                }
                else
                {
                    label_ThongBao.Text = "Thông tin đăng nhập không hợp lệ";
                    ClearThongBao();

                }
                return;
            }

            else
            {
                if (KhachHang_BLL.checkLoginValid(soDienThoai_Email, matKhau))
                {
                    if (checkBox_GhiNhoDangNhap.Checked)
                    {
                        Properties.Settings.Default.soDienThoai_Email = soDienThoai_Email;
                        Properties.Settings.Default.matKhau = matKhau;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.soDienThoai_Email = "";
                        Properties.Settings.Default.matKhau = "";
                        Properties.Settings.Default.Save();
                    }
                    //Đăng nhập với tư cách khách hàng thành công
                    label_ThongBao.Text = "Đăng nhâp với tư cách khách hàng thành công";
                    softwareInstance.isLoged = true;
                    softwareInstance.khachHang = KhachHang_BLL.selectOneKhachHang(soDienThoai_Email);
                    softwareInstance.changePanelShow(new TaiKhoanKhachHang(softwareInstance));
                }
                else
                {
                    label_ThongBao.Text = "Thông tin đăng nhập không hợp lệ";
                    ClearThongBao();
                }
                return;
            }

        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy(softwareInstance);
            softwareInstance.changePanelShow(dangKy);
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

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(new DoiMatKhau(softwareInstance));
        }
    }
}
