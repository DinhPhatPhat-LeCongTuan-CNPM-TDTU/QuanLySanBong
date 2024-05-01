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
                DangNhap dangnhap = new DangNhap(this);
                changePanelShow(dangnhap);
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
    }
}
