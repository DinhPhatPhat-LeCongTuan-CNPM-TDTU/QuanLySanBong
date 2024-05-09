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
    public partial class XemKhungGioBiDat : Form
    {
        private Software softwareInstance;
        private DatSan datSanInstance;
        public XemKhungGioBiDat(Software softwareInstance, DatSan datSanInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
            this.datSanInstance = datSanInstance;
            LoadXemLichSanBiDat();
        }

        private void button_DatSan_Click(object sender, EventArgs e)
        {
            softwareInstance.changePanelShow(datSanInstance);
        }

        private void dateTimePicker_NgayXemLichSanBiDat_ValueChanged(object sender, EventArgs e)
        {
            LoadXemLichSanBiDat();
        }

        private void LoadXemLichSanBiDat()
        {
            DateTime ngayXemLichSanBiDat = dateTimePicker_NgayXemLichSanBiDat.Value;
            DataTable dtsource = ChiTietPhieuDatSan_BLL.XemLichSanBiDat(ngayXemLichSanBiDat);
            dataGridView_DanhSachSanBiDat.DataSource = dtsource;
            dataGridView_DanhSachSanBiDat.Show();
        }
    }
}
