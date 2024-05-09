using BLL;
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

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        private Software softwareInstance;
        public DoiMatKhau(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void button_GuiOTP_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text.Trim() == "" || textBox_MatKhauMoi.Text.Trim() == "")
            {
                label_ThongBao.Text = "Không được bỏ trống email và mật khẩu mới";
                ClearThongBao();
                return;
            }

            if (!KhachHang_BLL.checkEmailExist(textBox_Email.Text))
            {
                label_ThongBao.Text = "Email không tồn tại";
                ClearThongBao();
                return;
            }

            label_ThongBao.Text = "Đã gửi OTP qua email, vui lòng kiểm tra";
            textBox_MatKhauMoi.Enabled = false;
            WaitBeforeSentOTP();
        }
        private async void ClearThongBao()
        {
            await Task.Delay(5000);
            label_ThongBao.Text = "";
        }
        private async void WaitBeforeChangeForm(int delayTime)
        {
            await Task.Delay(delayTime);
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }
        private async void WaitBeforeSentOTP()
        {
            await Task.Delay(2000);
            OTP_BLL.SendOTP(textBox_Email.Text, "ChangePassword");
        }
        private void button_XacNhanOTP_Click(object sender, EventArgs e)
        {
            textBox_MatKhauMoi.Enabled = true;
            //Đăng ký tài khoản
            if (OTP_BLL.checkOTP(textBox_Email.Text, textBox_OTP.Text))
            {
                button_XacNhanOTP.Enabled = false;
                if (KhachHang_BLL.DoiMatKhau(textBox_Email.Text, textBox_MatKhauMoi.Text))
                {
                    label_ThongBao.Text = "Đổi mật khẩu thành công, sẽ sang trang Đăng nhập trong 5 giây";
                    WaitBeforeChangeForm(5000);
                }
                else
                {
                    label_ThongBao.Text = "Đã có  lỗi trong quá trình đổi mật khẩu, vui lòng thử  lại";
                }
            }
            else
            {
                label_ThongBao.Text = "Mã OTP nhập vào không hợp lệ, vui lòng kiểm tra OTP đã nhận qua email";
            }
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }
    }
}
