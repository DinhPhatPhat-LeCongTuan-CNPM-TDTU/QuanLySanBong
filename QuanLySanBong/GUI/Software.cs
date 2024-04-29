using System.Drawing;
namespace GUI
{
    public partial class Software : Form
    {
        private bool isLoged = false;
        public Software()
        {
            InitializeComponent();
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
            if (isLoged == false)
            {
                DangNhap dangnhap = new DangNhap();
                dangnhap.TopLevel = false; //TopLevel = false giúp form không được xem là form độc lập
                dangnhap.Dock = DockStyle.Fill; 
                panel_Container.Controls.Add(dangnhap);
                dangnhap.Show();
            }
        }
    }
}
