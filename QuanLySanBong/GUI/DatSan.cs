using BLL;
using DTO;
using System;
using System.Collections;
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
    public partial class DatSan : Form
    {
        private Software softwareInstance;
        public DatSan(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }

        private void comboBox_LoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LoaiSan.SelectedIndex == 0)
            {
                comboBox_ChonSan.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    comboBox_ChonSan.Items.Add("Sân " + i.ToString());
                }
                comboBox_ChonSan.SelectedIndex = 0;
            }
            if (comboBox_LoaiSan.SelectedIndex == 1)
            {
                comboBox_ChonSan.Items.Clear();
                for (int i = 1; i <= 12; i += 3)
                {
                    comboBox_ChonSan.Items.Add("Sân " + i + "-" + (i + 1) + "-" + (i + 2));
                }
                comboBox_ChonSan.SelectedIndex = 0;
            }
            if (comboBox_LoaiSan.SelectedIndex == 2)
            {
                comboBox_ChonSan.Items.Clear();
                comboBox_ChonSan.Items.Add("Sân 4-5-6-7-8-9-10-11-12");
                comboBox_ChonSan.SelectedIndex = 0;
            }
        }

        private void comboBox_ChonSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(label_San1);
            arrayList.Add(label_San2);
            arrayList.Add(label_San3);
            arrayList.Add(label_San4);
            arrayList.Add(label_San5);
            arrayList.Add(label_San6);
            arrayList.Add(label_San7);
            arrayList.Add(label_San8);
            arrayList.Add(label_San9);
            arrayList.Add(label_San10);
            arrayList.Add(label_San11);
            arrayList.Add(label_San12);

            foreach (Label label in arrayList)
            {
                label.ForeColor = Color.White;
            }

            if (comboBox_LoaiSan.SelectedIndex == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (comboBox_ChonSan.SelectedIndex == i)
                    {
                        ((Label)arrayList[i]).ForeColor = Color.Red; break;
                    }
                }
            }
            if (comboBox_LoaiSan.SelectedIndex == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox_ChonSan.SelectedIndex == i)
                    {
                        ((Label)arrayList[i * 3]).ForeColor = Color.Red;
                        ((Label)arrayList[i * 3 + 1]).ForeColor = Color.Red;
                        ((Label)arrayList[i * 3 + 2]).ForeColor = Color.Red;
                    }
                }
            }
            if (comboBox_LoaiSan.SelectedIndex == 2)
            {
                for (int i = 3; i < 12; i++)
                {
                    ((Label)arrayList[i]).ForeColor = Color.Red;
                }
            }
        }

        private void button_DatSan_Click(object sender, EventArgs e)
        {
            if (comboBox_LoaiSan.SelectedIndex == -1 || comboBox_GioDa.SelectedIndex ==-1 || comboBox_SoPhutDa.SelectedIndex== -1 || comboBox_ChonSan.SelectedIndex== -1)
            {
                label_ThongBao.Text = "Bạn chưa nhập đủ thông tin đặt sân";
                return;
            }
            string maPhieuDatSan = "";
            string maKhachHang = softwareInstance.khachHang.maKhachHang;
            string maQuanLy = "";
            int loaiSan = Convert.ToInt32(comboBox_LoaiSan.SelectedItem);
            DateTime ngayDatSan = DateTime.Now;
            DateTime ngayDa = dateTimePicker_NgayDa.Value;
            string[] gioPhut = comboBox_GioDa.SelectedItem.ToString().Split(':');
            int gio = int.Parse(gioPhut[0]);
            int phut = int.Parse(gioPhut[1]);
            ngayDa = ngayDa.AddHours(gio).AddMinutes(phut);
            int phutDa = Convert.ToInt32(comboBox_SoPhutDa.SelectedItem);
            int tongTien = 0;
            PhieuDatSan phieuDatSan = new PhieuDatSan(maPhieuDatSan,maKhachHang,maQuanLy,loaiSan,ngayDatSan,ngayDa,phutDa,tongTien);
            string maPhieuDatSan_ChiTietPhieuDatSan = PhieuDatSan_BLL.AddPhieuDatSan(phieuDatSan);
            ChiTietPhieuDatSan_BLL.AddChiTietPhieuDatSan(maPhieuDatSan_ChiTietPhieuDatSan, comboBox_ChonSan.SelectedItem.ToString());
            label_ThongBao.Text = "Đặt sân thành công, bạn có thể xem lại phiếu đặt sân trong mục Tài Khoản";
        }
    }
}
