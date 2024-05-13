namespace GUI
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            button_DangNhap = new Button();
            panel_OTP = new Panel();
            textBox_MatKhauMoi = new TextBox();
            label_NhapMatKhau = new Label();
            button_GuiOTP = new Button();
            textBox_Email = new TextBox();
            label_NhapEmail = new Label();
            label_ThongBao = new Label();
            button_XacNhanOTP = new Button();
            textBox_OTP = new TextBox();
            label_NhapMaOTP = new Label();
            label_DoiMatKhau = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel_OTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button_DangNhap
            // 
            button_DangNhap.Location = new Point(18, 36);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(150, 43);
            button_DangNhap.TabIndex = 6;
            button_DangNhap.Text = "Quay về đăng nhập";
            button_DangNhap.UseVisualStyleBackColor = true;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // panel_OTP
            // 
            panel_OTP.BorderStyle = BorderStyle.FixedSingle;
            panel_OTP.Controls.Add(textBox_MatKhauMoi);
            panel_OTP.Controls.Add(label_NhapMatKhau);
            panel_OTP.Controls.Add(button_GuiOTP);
            panel_OTP.Controls.Add(textBox_Email);
            panel_OTP.Controls.Add(label_NhapEmail);
            panel_OTP.Controls.Add(label_ThongBao);
            panel_OTP.Controls.Add(button_XacNhanOTP);
            panel_OTP.Controls.Add(textBox_OTP);
            panel_OTP.Controls.Add(label_NhapMaOTP);
            panel_OTP.Location = new Point(196, 154);
            panel_OTP.Name = "panel_OTP";
            panel_OTP.Size = new Size(456, 426);
            panel_OTP.TabIndex = 11;
            // 
            // textBox_MatKhauMoi
            // 
            textBox_MatKhauMoi.Location = new Point(62, 162);
            textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            textBox_MatKhauMoi.PlaceholderText = "Mật khẩu mới";
            textBox_MatKhauMoi.Size = new Size(333, 27);
            textBox_MatKhauMoi.TabIndex = 1;
            // 
            // label_NhapMatKhau
            // 
            label_NhapMatKhau.Location = new Point(131, 123);
            label_NhapMatKhau.Name = "label_NhapMatKhau";
            label_NhapMatKhau.Size = new Size(195, 36);
            label_NhapMatKhau.TabIndex = 29;
            label_NhapMatKhau.Text = "Nhập mật khẩu mới";
            label_NhapMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_GuiOTP
            // 
            button_GuiOTP.BackColor = Color.FromArgb(175, 209, 152);
            button_GuiOTP.Location = new Point(145, 206);
            button_GuiOTP.Name = "button_GuiOTP";
            button_GuiOTP.Size = new Size(153, 43);
            button_GuiOTP.TabIndex = 2;
            button_GuiOTP.Text = "Gửi OTP đến email";
            button_GuiOTP.UseVisualStyleBackColor = false;
            button_GuiOTP.Click += button_GuiOTP_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(62, 82);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.PlaceholderText = "Email";
            textBox_Email.Size = new Size(333, 27);
            textBox_Email.TabIndex = 0;
            // 
            // label_NhapEmail
            // 
            label_NhapEmail.Location = new Point(131, 18);
            label_NhapEmail.Name = "label_NhapEmail";
            label_NhapEmail.Size = new Size(195, 61);
            label_NhapEmail.TabIndex = 26;
            label_NhapEmail.Text = "Nhập email cho tài khoản muốn đổi mật khẩu";
            label_NhapEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_ThongBao
            // 
            label_ThongBao.ForeColor = Color.DarkCyan;
            label_ThongBao.Location = new Point(19, 262);
            label_ThongBao.Name = "label_ThongBao";
            label_ThongBao.Size = new Size(413, 20);
            label_ThongBao.TabIndex = 25;
            label_ThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_XacNhanOTP
            // 
            button_XacNhanOTP.BackColor = Color.FromArgb(175, 209, 152);
            button_XacNhanOTP.Location = new Point(19, 358);
            button_XacNhanOTP.Name = "button_XacNhanOTP";
            button_XacNhanOTP.Size = new Size(413, 43);
            button_XacNhanOTP.TabIndex = 4;
            button_XacNhanOTP.Text = "Xác nhận OTP";
            button_XacNhanOTP.UseVisualStyleBackColor = false;
            button_XacNhanOTP.Click += button_XacNhanOTP_Click;
            // 
            // textBox_OTP
            // 
            textBox_OTP.Location = new Point(208, 309);
            textBox_OTP.Name = "textBox_OTP";
            textBox_OTP.Size = new Size(169, 27);
            textBox_OTP.TabIndex = 3;
            // 
            // label_NhapMaOTP
            // 
            label_NhapMaOTP.Location = new Point(28, 305);
            label_NhapMaOTP.Name = "label_NhapMaOTP";
            label_NhapMaOTP.Size = new Size(158, 50);
            label_NhapMaOTP.TabIndex = 24;
            label_NhapMaOTP.Text = "Nhập mã OTP 6 chữ số đã gửi qua Email";
            // 
            // label_DoiMatKhau
            // 
            label_DoiMatKhau.AutoSize = true;
            label_DoiMatKhau.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DoiMatKhau.ForeColor = SystemColors.ControlText;
            label_DoiMatKhau.Location = new Point(315, 38);
            label_DoiMatKhau.Name = "label_DoiMatKhau";
            label_DoiMatKhau.Size = new Size(208, 41);
            label_DoiMatKhau.TabIndex = 10;
            label_DoiMatKhau.Text = "Đổi mật khẩu";
            label_DoiMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(662, 453);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 453);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 185);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button_DangNhap);
            Controls.Add(panel_OTP);
            Controls.Add(label_DoiMatKhau);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            panel_OTP.ResumeLayout(false);
            panel_OTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_DangNhap;
        private Panel panel_OTP;
        private Button button_GuiOTP;
        private TextBox textBox_Email;
        private Label label_NhapEmail;
        private Label label_ThongBao;
        private Button button_XacNhanOTP;
        private TextBox textBox_OTP;
        private Label label_NhapMaOTP;
        private Label label_DoiMatKhau;
        private Label label_NhapMatKhau;
        private PictureBox pictureBox1;
        private TextBox textBox_MatKhauMoi;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}