using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class OTPDangKy : Form
    {
        private Software softwareInstance;
        private DangKy dangkyInstance;
        public OTPDangKy(Software softwareInstance, DangKy dangKyInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
            this.dangkyInstance = dangKyInstance;
            WaitBeforeSendOTP(1000); // Đợi 1 giây để form xác nhận load đầy đủ mới gửi mail, nếu gửi ngay gây lag, form load không đủ trong thời gian đầu
        }     
        private async void WaitBeforeChangeForm(int delayTime)
        {
            await Task.Delay(delayTime);
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }
        private async void WaitBeforeSendOTP(int delayTime)
        {
            await Task.Delay(delayTime);
            OTP_BLL.SendOTP(dangkyInstance.getThongTinDangNhap().email, "Register");
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }

        private void button_XacNhanOTP_Click(object sender, EventArgs e)
        {
            //Đăng ký tài khoản
            if (OTP_BLL.checkOTP(dangkyInstance.getThongTinDangNhap().email, textBox_OTP.Text))
            {
                button_XacNhanOTP.Enabled = false;
                KhachHang_BLL.AddKhachHang(dangkyInstance.getThongTinDangNhap());
                label_ThongBao.Text = "Đăng ký thành công, sẽ sang trang Đăng nhập trong 5 giây";
                WaitBeforeChangeForm(5000);
            }
            else
            {
                label_ThongBao.Text = "Mã OTP nhập vào không hợp lệ, vui lòng kiểm tra OTP đã nhận qua email";
            }

        }
    }
}
