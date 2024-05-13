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
    public partial class TaiKhoanQuanLy : Form
    {
        private Software softwareInstance;
        public TaiKhoanQuanLy(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void TaiKhoanQuanLy_Load(object sender, EventArgs e)
        {
            textBox_Email.Text = softwareInstance.quanLy.email;
            textBox_SoDienThoai.Text = softwareInstance.quanLy.soDienThoai;
            textBox_TenQuanLy.Text = softwareInstance.quanLy.tenQuanLy;
            if (softwareInstance.quanLy.toanQuyen)
            {
                button_DieuChinhGiaSan.Enabled = true;
                button_QuanLyTaiKhoanHeThong.Enabled = true;
                button_ThongKeKinhDoanh.Enabled = true;
            }
            else
            {
                button_DieuChinhGiaSan.Enabled = false;
                button_QuanLyTaiKhoanHeThong.Enabled = false;
                button_ThongKeKinhDoanh.Enabled = false;
            }
        }

        private void button_QuanLyDatSan_Click(object sender, EventArgs e)
        {
            QuanLyDatSan quanLyDatSan = new QuanLyDatSan(softwareInstance);
            quanLyDatSan.Show();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            softwareInstance.DangXuat();
        }

        private void button_QuanLyTaiKhoanHeThong_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanHeThong quanLyTaiKhoanHeThong = new QuanLyTaiKhoanHeThong();
            quanLyTaiKhoanHeThong.Show();
        }

        private void button_DieuChinhGiaSan_Click(object sender, EventArgs e)
        {
            DieuChinhGiaSan dieuChinhGiaSan = new DieuChinhGiaSan();
            dieuChinhGiaSan.Show();
        }

        private void button_ThongKeKinhDoanh_Click(object sender, EventArgs e)
        {
            InAnThongKeKinhDoanh inAnThongKeKinhDoanh = new InAnThongKeKinhDoanh();
            inAnThongKeKinhDoanh.Show();
        }
    }
}
