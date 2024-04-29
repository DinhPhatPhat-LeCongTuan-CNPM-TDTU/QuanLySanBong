namespace GUI
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            panel_DangNhap = new Panel();
            label_DaCoTaiKhoan = new Label();
            button_DangNhap = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label_TenKhachHang = new Label();
            textBox_MatKhau = new TextBox();
            textBox_TenKhachHang = new TextBox();
            label_DangKy = new Label();
            label_SoDienThoai = new Label();
            textBox1 = new TextBox();
            label_Email = new Label();
            textBox2 = new TextBox();
            label_XacNhanMatKhau = new Label();
            textBox_XacNhanMatKhau = new TextBox();
            pictureBox2 = new PictureBox();
            button_DangKy = new Button();
            pictureBox_DangKy = new PictureBox();
            panel_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DangKy).BeginInit();
            SuspendLayout();
            // 
            // panel_DangNhap
            // 
            panel_DangNhap.BackColor = Color.Transparent;
            panel_DangNhap.BorderStyle = BorderStyle.FixedSingle;
            panel_DangNhap.Controls.Add(pictureBox2);
            panel_DangNhap.Controls.Add(label_XacNhanMatKhau);
            panel_DangNhap.Controls.Add(textBox_XacNhanMatKhau);
            panel_DangNhap.Controls.Add(label_Email);
            panel_DangNhap.Controls.Add(textBox2);
            panel_DangNhap.Controls.Add(label_SoDienThoai);
            panel_DangNhap.Controls.Add(textBox1);
            panel_DangNhap.Controls.Add(label_DaCoTaiKhoan);
            panel_DangNhap.Controls.Add(button_DangNhap);
            panel_DangNhap.Controls.Add(pictureBox1);
            panel_DangNhap.Controls.Add(button_DangKy);
            panel_DangNhap.Controls.Add(label1);
            panel_DangNhap.Controls.Add(label_TenKhachHang);
            panel_DangNhap.Controls.Add(textBox_MatKhau);
            panel_DangNhap.Controls.Add(textBox_TenKhachHang);
            panel_DangNhap.Location = new Point(104, 103);
            panel_DangNhap.Name = "panel_DangNhap";
            panel_DangNhap.Size = new Size(582, 409);
            panel_DangNhap.TabIndex = 4;
            panel_DangNhap.Paint += panel_DangNhap_Paint;
            // 
            // label_DaCoTaiKhoan
            // 
            label_DaCoTaiKhoan.AutoSize = true;
            label_DaCoTaiKhoan.Location = new Point(19, 345);
            label_DaCoTaiKhoan.Name = "label_DaCoTaiKhoan";
            label_DaCoTaiKhoan.Size = new Size(120, 20);
            label_DaCoTaiKhoan.TabIndex = 9;
            label_DaCoTaiKhoan.Text = "Đã có tài khoản?";
            // 
            // button_DangNhap
            // 
            button_DangNhap.Location = new Point(160, 333);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(391, 32);
            button_DangNhap.TabIndex = 8;
            button_DangNhap.Text = "Đăng nhập";
            button_DangNhap.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(513, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 166);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 3;
            label1.Text = "Mật khẩu";
            // 
            // label_TenKhachHang
            // 
            label_TenKhachHang.AutoSize = true;
            label_TenKhachHang.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_TenKhachHang.Location = new Point(3, 22);
            label_TenKhachHang.Name = "label_TenKhachHang";
            label_TenKhachHang.Size = new Size(117, 21);
            label_TenKhachHang.TabIndex = 2;
            label_TenKhachHang.Text = "Tên khách hàng";
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(138, 163);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(378, 27);
            textBox_MatKhau.TabIndex = 1;
            // 
            // textBox_TenKhachHang
            // 
            textBox_TenKhachHang.Location = new Point(138, 16);
            textBox_TenKhachHang.Name = "textBox_TenKhachHang";
            textBox_TenKhachHang.Size = new Size(406, 27);
            textBox_TenKhachHang.TabIndex = 0;
            // 
            // label_DangKy
            // 
            label_DangKy.AutoSize = true;
            label_DangKy.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DangKy.ForeColor = SystemColors.ControlText;
            label_DangKy.Location = new Point(340, 31);
            label_DangKy.Name = "label_DangKy";
            label_DangKy.Size = new Size(131, 41);
            label_DangKy.TabIndex = 3;
            label_DangKy.Text = "Đăng ký";
            label_DangKy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_SoDienThoai
            // 
            label_SoDienThoai.AutoSize = true;
            label_SoDienThoai.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SoDienThoai.Location = new Point(19, 70);
            label_SoDienThoai.Name = "label_SoDienThoai";
            label_SoDienThoai.Size = new Size(101, 21);
            label_SoDienThoai.TabIndex = 11;
            label_SoDienThoai.Text = "Số điện thoại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 27);
            textBox1.TabIndex = 10;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Email.Location = new Point(73, 114);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(47, 21);
            label_Email.TabIndex = 13;
            label_Email.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 27);
            textBox2.TabIndex = 12;
            // 
            // label_XacNhanMatKhau
            // 
            label_XacNhanMatKhau.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_XacNhanMatKhau.Location = new Point(44, 207);
            label_XacNhanMatKhau.Name = "label_XacNhanMatKhau";
            label_XacNhanMatKhau.Size = new Size(76, 47);
            label_XacNhanMatKhau.TabIndex = 22;
            label_XacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // textBox_XacNhanMatKhau
            // 
            textBox_XacNhanMatKhau.Location = new Point(138, 219);
            textBox_XacNhanMatKhau.Name = "textBox_XacNhanMatKhau";
            textBox_XacNhanMatKhau.PasswordChar = '*';
            textBox_XacNhanMatKhau.Size = new Size(378, 27);
            textBox_XacNhanMatKhau.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(513, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // button_DangKy
            // 
            button_DangKy.Location = new Point(19, 271);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(532, 39);
            button_DangKy.TabIndex = 5;
            button_DangKy.Text = "Đăng ký";
            button_DangKy.UseVisualStyleBackColor = true;
            // 
            // pictureBox_DangKy
            // 
            pictureBox_DangKy.Image = (Image)resources.GetObject("pictureBox_DangKy.Image");
            pictureBox_DangKy.Location = new Point(676, 103);
            pictureBox_DangKy.Name = "pictureBox_DangKy";
            pictureBox_DangKy.Size = new Size(201, 409);
            pictureBox_DangKy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_DangKy.TabIndex = 5;
            pictureBox_DangKy.TabStop = false;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 230);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(pictureBox_DangKy);
            Controls.Add(panel_DangNhap);
            Controls.Add(label_DangKy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangKy";
            panel_DangNhap.ResumeLayout(false);
            panel_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DangKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_DangNhap;
        private Label label_DaCoTaiKhoan;
        private Button button_DangNhap;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label_TenKhachHang;
        private TextBox textBox_MatKhau;
        private TextBox textBox_TenKhachHang;
        private Label label_DangKy;
        private Label label_SoDienThoai;
        private TextBox textBox1;
        private Label label_Email;
        private TextBox textBox2;
        private Label label_XacNhanMatKhau;
        private TextBox textBox_XacNhanMatKhau;
        private PictureBox pictureBox2;
        private Button button_DangKy;
        private PictureBox pictureBox_DangKy;
    }
}