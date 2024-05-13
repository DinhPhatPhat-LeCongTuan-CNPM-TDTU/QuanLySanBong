namespace GUI
{
    partial class TaiKhoanQuanLy
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
            label_TaiKhoanQuanLy = new Label();
            groupBox_ThongTinQuanLy = new GroupBox();
            textBox_Email = new TextBox();
            textBox_SoDienThoai = new TextBox();
            textBox_TenQuanLy = new TextBox();
            label1 = new Label();
            label_SoDienThoai = new Label();
            label_TenQuanLy = new Label();
            button_QuanLyDatSan = new Button();
            button_QuanLyTaiKhoanHeThong = new Button();
            button_DieuChinhGiaSan = new Button();
            button_ThongKeKinhDoanh = new Button();
            button_DangXuat = new Button();
            groupBox_ThongTinQuanLy.SuspendLayout();
            SuspendLayout();
            // 
            // label_TaiKhoanQuanLy
            // 
            label_TaiKhoanQuanLy.AutoSize = true;
            label_TaiKhoanQuanLy.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TaiKhoanQuanLy.ForeColor = SystemColors.ControlText;
            label_TaiKhoanQuanLy.Location = new Point(287, 27);
            label_TaiKhoanQuanLy.Name = "label_TaiKhoanQuanLy";
            label_TaiKhoanQuanLy.Size = new Size(263, 41);
            label_TaiKhoanQuanLy.TabIndex = 2;
            label_TaiKhoanQuanLy.Text = "Tài khoản quản lý";
            label_TaiKhoanQuanLy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_ThongTinQuanLy
            // 
            groupBox_ThongTinQuanLy.Controls.Add(textBox_Email);
            groupBox_ThongTinQuanLy.Controls.Add(textBox_SoDienThoai);
            groupBox_ThongTinQuanLy.Controls.Add(textBox_TenQuanLy);
            groupBox_ThongTinQuanLy.Controls.Add(label1);
            groupBox_ThongTinQuanLy.Controls.Add(label_SoDienThoai);
            groupBox_ThongTinQuanLy.Controls.Add(label_TenQuanLy);
            groupBox_ThongTinQuanLy.Location = new Point(170, 86);
            groupBox_ThongTinQuanLy.Name = "groupBox_ThongTinQuanLy";
            groupBox_ThongTinQuanLy.Size = new Size(500, 226);
            groupBox_ThongTinQuanLy.TabIndex = 3;
            groupBox_ThongTinQuanLy.TabStop = false;
            groupBox_ThongTinQuanLy.Text = "Thông tin quản lý";
            // 
            // textBox_Email
            // 
            textBox_Email.Enabled = false;
            textBox_Email.Location = new Point(117, 167);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(269, 27);
            textBox_Email.TabIndex = 2;
            textBox_Email.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_SoDienThoai
            // 
            textBox_SoDienThoai.Enabled = false;
            textBox_SoDienThoai.Location = new Point(117, 110);
            textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            textBox_SoDienThoai.Size = new Size(269, 27);
            textBox_SoDienThoai.TabIndex = 1;
            textBox_SoDienThoai.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_TenQuanLy
            // 
            textBox_TenQuanLy.Enabled = false;
            textBox_TenQuanLy.Location = new Point(117, 43);
            textBox_TenQuanLy.Name = "textBox_TenQuanLy";
            textBox_TenQuanLy.Size = new Size(269, 27);
            textBox_TenQuanLy.TabIndex = 0;
            textBox_TenQuanLy.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 144);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label_SoDienThoai
            // 
            label_SoDienThoai.AutoSize = true;
            label_SoDienThoai.Location = new Point(199, 87);
            label_SoDienThoai.Name = "label_SoDienThoai";
            label_SoDienThoai.Size = new Size(97, 20);
            label_SoDienThoai.TabIndex = 1;
            label_SoDienThoai.Text = "Số điện thoại";
            // 
            // label_TenQuanLy
            // 
            label_TenQuanLy.AutoSize = true;
            label_TenQuanLy.Location = new Point(199, 23);
            label_TenQuanLy.Name = "label_TenQuanLy";
            label_TenQuanLy.Size = new Size(84, 20);
            label_TenQuanLy.TabIndex = 0;
            label_TenQuanLy.Text = "Tên quản lý";
            // 
            // button_QuanLyDatSan
            // 
            button_QuanLyDatSan.BackColor = Color.FromArgb(60, 91, 111);
            button_QuanLyDatSan.ForeColor = Color.Snow;
            button_QuanLyDatSan.Location = new Point(342, 336);
            button_QuanLyDatSan.Name = "button_QuanLyDatSan";
            button_QuanLyDatSan.Size = new Size(153, 51);
            button_QuanLyDatSan.TabIndex = 3;
            button_QuanLyDatSan.Text = "Quản lý đặt sân";
            button_QuanLyDatSan.UseVisualStyleBackColor = false;
            button_QuanLyDatSan.Click += button_QuanLyDatSan_Click;
            // 
            // button_QuanLyTaiKhoanHeThong
            // 
            button_QuanLyTaiKhoanHeThong.BackColor = Color.FromArgb(60, 91, 111);
            button_QuanLyTaiKhoanHeThong.Enabled = false;
            button_QuanLyTaiKhoanHeThong.ForeColor = Color.Snow;
            button_QuanLyTaiKhoanHeThong.Location = new Point(342, 403);
            button_QuanLyTaiKhoanHeThong.Name = "button_QuanLyTaiKhoanHeThong";
            button_QuanLyTaiKhoanHeThong.Size = new Size(153, 51);
            button_QuanLyTaiKhoanHeThong.TabIndex = 4;
            button_QuanLyTaiKhoanHeThong.Text = "Quản lý tài khoản hệ thống";
            button_QuanLyTaiKhoanHeThong.UseVisualStyleBackColor = false;
            button_QuanLyTaiKhoanHeThong.Click += button_QuanLyTaiKhoanHeThong_Click;
            // 
            // button_DieuChinhGiaSan
            // 
            button_DieuChinhGiaSan.BackColor = Color.FromArgb(60, 91, 111);
            button_DieuChinhGiaSan.Enabled = false;
            button_DieuChinhGiaSan.ForeColor = Color.Snow;
            button_DieuChinhGiaSan.Location = new Point(342, 471);
            button_DieuChinhGiaSan.Name = "button_DieuChinhGiaSan";
            button_DieuChinhGiaSan.Size = new Size(153, 51);
            button_DieuChinhGiaSan.TabIndex = 5;
            button_DieuChinhGiaSan.Text = "Điều chỉnh giá sân";
            button_DieuChinhGiaSan.UseVisualStyleBackColor = false;
            button_DieuChinhGiaSan.Click += button_DieuChinhGiaSan_Click;
            // 
            // button_ThongKeKinhDoanh
            // 
            button_ThongKeKinhDoanh.BackColor = Color.FromArgb(60, 91, 111);
            button_ThongKeKinhDoanh.Enabled = false;
            button_ThongKeKinhDoanh.ForeColor = Color.Snow;
            button_ThongKeKinhDoanh.Location = new Point(342, 539);
            button_ThongKeKinhDoanh.Name = "button_ThongKeKinhDoanh";
            button_ThongKeKinhDoanh.Size = new Size(153, 51);
            button_ThongKeKinhDoanh.TabIndex = 6;
            button_ThongKeKinhDoanh.Text = "Thống kê kinh doanh";
            button_ThongKeKinhDoanh.UseVisualStyleBackColor = false;
            button_ThongKeKinhDoanh.Click += button_ThongKeKinhDoanh_Click;
            // 
            // button_DangXuat
            // 
            button_DangXuat.BackColor = Color.FromArgb(60, 91, 111);
            button_DangXuat.ForeColor = Color.Snow;
            button_DangXuat.Location = new Point(728, 12);
            button_DangXuat.Name = "button_DangXuat";
            button_DangXuat.Size = new Size(110, 32);
            button_DangXuat.TabIndex = 7;
            button_DangXuat.Text = "Đăng xuất";
            button_DangXuat.UseVisualStyleBackColor = false;
            button_DangXuat.Click += button_DangXuat_Click;
            // 
            // TaiKhoanQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(button_DangXuat);
            Controls.Add(button_ThongKeKinhDoanh);
            Controls.Add(button_DieuChinhGiaSan);
            Controls.Add(button_QuanLyTaiKhoanHeThong);
            Controls.Add(button_QuanLyDatSan);
            Controls.Add(groupBox_ThongTinQuanLy);
            Controls.Add(label_TaiKhoanQuanLy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiKhoanQuanLy";
            Text = "TaiKhoanQuanLy";
            Load += TaiKhoanQuanLy_Load;
            groupBox_ThongTinQuanLy.ResumeLayout(false);
            groupBox_ThongTinQuanLy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TaiKhoanQuanLy;
        private GroupBox groupBox_ThongTinQuanLy;
        private TextBox textBox_Email;
        private TextBox textBox_SoDienThoai;
        private TextBox textBox_TenQuanLy;
        private Label label1;
        private Label label_SoDienThoai;
        private Label label_TenQuanLy;
        private Button button_QuanLyDatSan;
        private Button button_QuanLyTaiKhoanHeThong;
        private Button button_DieuChinhGiaSan;
        private Button button_ThongKeKinhDoanh;
        private Button button_DangXuat;
    }
}