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
    public partial class TaiKhoanKhachHang : Form
    {
        private Software softwareInstance;
        public TaiKhoanKhachHang(Software softwareInstance)
        {
            InitializeComponent();
            this.softwareInstance = softwareInstance;
        }
    }
}
