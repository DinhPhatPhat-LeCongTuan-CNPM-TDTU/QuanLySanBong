using System.Drawing;
namespace GUI
{
    public partial class Software : Form
    {
        public bool isLoged = false;
        private Dictionary<Form, Dictionary<string, object>> formStates = new Dictionary<Form, Dictionary<string, object>>();
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

        private void Software_SizeChanged(object sender, EventArgs e)
        {
            //Khi form chính thay đổi kích thước, panel chứa form con cũng thay đổi kích thước
            int newPanelWidth = (int)this.Width / (1080/850);
            int newPanelHeight = (int)this.Height / (720/625);
            panel_Container.Size = new Size(newPanelWidth, newPanelHeight);

        }
    }
}
