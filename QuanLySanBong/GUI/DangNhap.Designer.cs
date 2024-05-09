namespace GUI
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label_DangNhap = new Label();
            panel_DangNhap = new Panel();
            button_DoiMatKhau = new Button();
            label_QuenMatKhau = new Label();
            label_ChuaCoTaiKhoan = new Label();
            button_DangKy = new Button();
            pictureBox_Show_Hind_Password = new PictureBox();
            checkBox_DangNhapVoiTuCachQuanLy = new CheckBox();
            button_DangNhap = new Button();
            checkBox_GhiNhoDangNhap = new CheckBox();
            label_MatKhau = new Label();
            label_SoDienThoaiHoacEmail = new Label();
            textBox_MatKhau = new TextBox();
            textBox_SoDienThoai_Email = new TextBox();
            pictureBox_DangNhap = new PictureBox();
            panel_ThongBao = new Panel();
            label_ThongBao = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Show_Hind_Password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DangNhap).BeginInit();
            panel_ThongBao.SuspendLayout();
            SuspendLayout();
            // 
            // label_DangNhap
            // 
            label_DangNhap.AutoSize = true;
            label_DangNhap.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DangNhap.ForeColor = SystemColors.ControlText;
            label_DangNhap.Location = new Point(337, 23);
            label_DangNhap.Name = "label_DangNhap";
            label_DangNhap.Size = new Size(170, 41);
            label_DangNhap.TabIndex = 0;
            label_DangNhap.Text = "Đăng nhập";
            label_DangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_DangNhap
            // 
            panel_DangNhap.BackColor = Color.Transparent;
            panel_DangNhap.BorderStyle = BorderStyle.FixedSingle;
            panel_DangNhap.Controls.Add(button_DoiMatKhau);
            panel_DangNhap.Controls.Add(label_QuenMatKhau);
            panel_DangNhap.Controls.Add(label_ChuaCoTaiKhoan);
            panel_DangNhap.Controls.Add(button_DangKy);
            panel_DangNhap.Controls.Add(pictureBox_Show_Hind_Password);
            panel_DangNhap.Controls.Add(checkBox_DangNhapVoiTuCachQuanLy);
            panel_DangNhap.Controls.Add(button_DangNhap);
            panel_DangNhap.Controls.Add(checkBox_GhiNhoDangNhap);
            panel_DangNhap.Controls.Add(label_MatKhau);
            panel_DangNhap.Controls.Add(label_SoDienThoaiHoacEmail);
            panel_DangNhap.Controls.Add(textBox_MatKhau);
            panel_DangNhap.Controls.Add(textBox_SoDienThoai_Email);
            panel_DangNhap.Location = new Point(141, 98);
            panel_DangNhap.Name = "panel_DangNhap";
            panel_DangNhap.Size = new Size(566, 349);
            panel_DangNhap.TabIndex = 1;
            // 
            // button_DoiMatKhau
            // 
            button_DoiMatKhau.Location = new Point(227, 243);
            button_DoiMatKhau.Name = "button_DoiMatKhau";
            button_DoiMatKhau.Size = new Size(127, 32);
            button_DoiMatKhau.TabIndex = 5;
            button_DoiMatKhau.Text = "Đổi mật khẩu";
            button_DoiMatKhau.UseVisualStyleBackColor = true;
            button_DoiMatKhau.Click += button_DoiMatKhau_Click;
            // 
            // label_QuenMatKhau
            // 
            label_QuenMatKhau.AutoSize = true;
            label_QuenMatKhau.Location = new Point(15, 249);
            label_QuenMatKhau.Name = "label_QuenMatKhau";
            label_QuenMatKhau.Size = new Size(190, 20);
            label_QuenMatKhau.TabIndex = 10;
            label_QuenMatKhau.Text = "Quên-muốn đổi mật khẩu ?";
            // 
            // label_ChuaCoTaiKhoan
            // 
            label_ChuaCoTaiKhoan.AutoSize = true;
            label_ChuaCoTaiKhoan.Location = new Point(70, 307);
            label_ChuaCoTaiKhoan.Name = "label_ChuaCoTaiKhoan";
            label_ChuaCoTaiKhoan.Size = new Size(135, 20);
            label_ChuaCoTaiKhoan.TabIndex = 9;
            label_ChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            // 
            // button_DangKy
            // 
            button_DangKy.Location = new Point(227, 301);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(320, 32);
            button_DangKy.TabIndex = 6;
            button_DangKy.Text = "Đăng ký tài khoản";
            button_DangKy.UseVisualStyleBackColor = true;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // pictureBox_Show_Hind_Password
            // 
            pictureBox_Show_Hind_Password.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Show_Hind_Password.Image = (Image)resources.GetObject("pictureBox_Show_Hind_Password.Image");
            pictureBox_Show_Hind_Password.Location = new Point(516, 77);
            pictureBox_Show_Hind_Password.Name = "pictureBox_Show_Hind_Password";
            pictureBox_Show_Hind_Password.Size = new Size(31, 27);
            pictureBox_Show_Hind_Password.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Show_Hind_Password.TabIndex = 7;
            pictureBox_Show_Hind_Password.TabStop = false;
            pictureBox_Show_Hind_Password.Click += pictureBox_Show_Hind_Password_Click;
            // 
            // checkBox_DangNhapVoiTuCachQuanLy
            // 
            checkBox_DangNhapVoiTuCachQuanLy.Location = new Point(205, 128);
            checkBox_DangNhapVoiTuCachQuanLy.Name = "checkBox_DangNhapVoiTuCachQuanLy";
            checkBox_DangNhapVoiTuCachQuanLy.Size = new Size(281, 56);
            checkBox_DangNhapVoiTuCachQuanLy.TabIndex = 3;
            checkBox_DangNhapVoiTuCachQuanLy.Text = "Đăng nhập với tư cách quản lý (Khách hàng đặt sân không tick vào ô này)";
            checkBox_DangNhapVoiTuCachQuanLy.UseVisualStyleBackColor = true;
            // 
            // button_DangNhap
            // 
            button_DangNhap.BackColor = Color.FromArgb(175, 209, 152);
            button_DangNhap.Location = new Point(15, 190);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(532, 39);
            button_DangNhap.TabIndex = 4;
            button_DangNhap.Text = "Đăng nhập";
            button_DangNhap.UseVisualStyleBackColor = false;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // checkBox_GhiNhoDangNhap
            // 
            checkBox_GhiNhoDangNhap.AutoSize = true;
            checkBox_GhiNhoDangNhap.Checked = true;
            checkBox_GhiNhoDangNhap.CheckState = CheckState.Checked;
            checkBox_GhiNhoDangNhap.Location = new Point(15, 140);
            checkBox_GhiNhoDangNhap.Name = "checkBox_GhiNhoDangNhap";
            checkBox_GhiNhoDangNhap.Size = new Size(157, 24);
            checkBox_GhiNhoDangNhap.TabIndex = 2;
            checkBox_GhiNhoDangNhap.Text = "Ghi nhớ đăng nhập";
            checkBox_GhiNhoDangNhap.UseVisualStyleBackColor = true;
            // 
            // label_MatKhau
            // 
            label_MatKhau.AutoSize = true;
            label_MatKhau.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_MatKhau.Location = new Point(87, 80);
            label_MatKhau.Name = "label_MatKhau";
            label_MatKhau.Size = new Size(76, 21);
            label_MatKhau.TabIndex = 3;
            label_MatKhau.Text = "Mật khẩu";
            // 
            // label_SoDienThoaiHoacEmail
            // 
            label_SoDienThoaiHoacEmail.AutoSize = true;
            label_SoDienThoaiHoacEmail.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SoDienThoaiHoacEmail.Location = new Point(15, 19);
            label_SoDienThoaiHoacEmail.Name = "label_SoDienThoaiHoacEmail";
            label_SoDienThoaiHoacEmail.Size = new Size(179, 21);
            label_SoDienThoaiHoacEmail.TabIndex = 2;
            label_SoDienThoaiHoacEmail.Text = "Số điện thoại hoặc email";
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(205, 77);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(319, 27);
            textBox_MatKhau.TabIndex = 1;
            textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_SoDienThoai_Email
            // 
            textBox_SoDienThoai_Email.Location = new Point(205, 16);
            textBox_SoDienThoai_Email.Name = "textBox_SoDienThoai_Email";
            textBox_SoDienThoai_Email.Size = new Size(342, 27);
            textBox_SoDienThoai_Email.TabIndex = 0;
            // 
            // pictureBox_DangNhap
            // 
            pictureBox_DangNhap.Image = (Image)resources.GetObject("pictureBox_DangNhap.Image");
            pictureBox_DangNhap.Location = new Point(171, 318);
            pictureBox_DangNhap.Name = "pictureBox_DangNhap";
            pictureBox_DangNhap.Size = new Size(495, 412);
            pictureBox_DangNhap.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_DangNhap.TabIndex = 2;
            pictureBox_DangNhap.TabStop = false;
            // 
            // panel_ThongBao
            // 
            panel_ThongBao.Controls.Add(label_ThongBao);
            panel_ThongBao.Location = new Point(141, 67);
            panel_ThongBao.Name = "panel_ThongBao";
            panel_ThongBao.Size = new Size(566, 25);
            panel_ThongBao.TabIndex = 4;
            // 
            // label_ThongBao
            // 
            label_ThongBao.Dock = DockStyle.Fill;
            label_ThongBao.ForeColor = Color.FromArgb(60, 91, 111);
            label_ThongBao.Location = new Point(0, 0);
            label_ThongBao.Name = "label_ThongBao";
            label_ThongBao.Size = new Size(566, 25);
            label_ThongBao.TabIndex = 0;
            label_ThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 230);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(panel_ThongBao);
            Controls.Add(panel_DangNhap);
            Controls.Add(pictureBox_DangNhap);
            Controls.Add(label_DangNhap);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            panel_DangNhap.ResumeLayout(false);
            panel_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Show_Hind_Password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DangNhap).EndInit();
            panel_ThongBao.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_DangNhap;
        private Panel panel_DangNhap;
        private TextBox textBox_SoDienThoai_Email;
        private Label label_MatKhau;
        private Label label_SoDienThoaiHoacEmail;
        private TextBox textBox_MatKhau;
        private PictureBox pictureBox_DangNhap;
        private Button button_DangNhap;
        private CheckBox checkBox_GhiNhoDangNhap;
        private CheckBox checkBox_DangNhapVoiTuCachQuanLy;
        private PictureBox pictureBox_Show_Hind_Password;
        private Label label_ChuaCoTaiKhoan;
        private Button button_DangKy;
        private Panel panel_ThongBao;
        private Label label_ThongBao;
        private Button button_DoiMatKhau;
        private Label label_QuenMatKhau;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}