using DTO;
using System.Drawing;
namespace GUI
{
    public partial class Software : Form
    {
        public bool isLoged = false;
        public bool isAdmin = false;
        private string childFormNow = "";
        public KhachHang khachHang;
        public QuanLy quanLy;
        public Software()
        {
            InitializeComponent();
            changePanelShow(new TrangChu(this));
        }

        private void button_TrangChu_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = ColorTranslator.FromHtml("#F5EFE6");
            button.ForeColor = Color.Black;
        }

        private void button_TrangChu_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;

        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            if (childFormNow == "TaiKhoan")
            {
                return;
            }
            if (isLoged == false)
            {
                childFormNow = "DangNhap";
                DangNhap dangnhap = new DangNhap(this);
                changePanelShow(dangnhap);
            }
            else
            {
                if (isAdmin)
                {
                    changePanelShow(new TaiKhoanQuanLy(this));
                }
                else
                {
                    changePanelShow(new TaiKhoanKhachHang(this));
                }
                childFormNow = "TaiKhoan";
            }
        }

        public void changePanelShow(Form formToShow)
        {
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(formToShow);
            formToShow.Show();
        }


        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            if (childFormNow == "TrangChu")
            {
                return;
            }
            childFormNow = "TrangChu";
            changePanelShow(new TrangChu(this));
        }

        private void button_DatSan_Click(object sender, EventArgs e)
        {
            if (childFormNow == "DatSan")
            {
                return;
            }
            else
            {
                childFormNow = "DatSan";
                changePanelShow(new DatSan(this));
            }
        }

        public void DangXuat()
        {
            isLoged = false;
            isAdmin = false;
            childFormNow = "";
            khachHang = null;
            quanLy = null;
            changePanelShow(new DangNhap(this));
        }   
    }
}
