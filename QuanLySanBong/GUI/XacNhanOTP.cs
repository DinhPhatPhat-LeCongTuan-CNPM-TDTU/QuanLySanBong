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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class XacNhanOTP : Form
    {
        private Software softwareInstance;
        private DangKy dangkyInstance;
        private string confirmWhat;
        public XacNhanOTP(Software softwareInstance, DangKy dangKyInstance, string confirmWhat)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
            this.dangkyInstance = dangKyInstance;
            this.confirmWhat = confirmWhat;
            OTP_BLL.SendOTP(dangkyInstance.getThongTinDangNhap().email, "Register");
        }     
        private async void WaitBeforeChangeForm(int delayTime)
        {
            await Task.Delay(delayTime);
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(new DangNhap(softwareInstance));
        }

        private void button_XacNhanOTP_Click(object sender, EventArgs e)
        {
            //Đăng ký tài khoản
            if (confirmWhat == "Register")
            {
                if (OTP_BLL.checkOTP(dangkyInstance.getThongTinDangNhap().email, textBox_OTP.Text))
                {
                    softwareInstance.isLoged=true;
                    label_MaOTPKhongHopLe.Text = "Đăng ký thành công, sẽ sang trang Đăng nhập trong 5 giây"; 
                    WaitBeforeChangeForm(5000);

                }
            }
                label_MaOTPKhongHopLe.Visible = true;
        }
    }
}
