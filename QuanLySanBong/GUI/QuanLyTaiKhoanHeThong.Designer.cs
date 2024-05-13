namespace GUI
{
    partial class QuanLyTaiKhoanHeThong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label_QuanLyTaiKhoan = new Label();
            button_TaiKhoanQuanLy = new Button();
            button_TaiKhoanKhachHang = new Button();
            groupBox_ThongTinTaiKhoan = new GroupBox();
            label_NgaySinh = new Label();
            comboBox_GioiTinh = new ComboBox();
            dateTimePicker_NgaySinh = new DateTimePicker();
            textBox_SoLanDatSan = new TextBox();
            label_SoLanDatSan = new Label();
            comboBox_ToanQuyen = new ComboBox();
            label_ToanQuyen = new Label();
            textBox_DiaChi = new TextBox();
            label_DiaChi = new Label();
            label_GioiTinh = new Label();
            textBox_MatKhau = new TextBox();
            label_MatKhau = new Label();
            textBox_Ma = new TextBox();
            label_Ma = new Label();
            textBox_Email = new TextBox();
            textBox_SoDienThoai = new TextBox();
            textBox_Ten = new TextBox();
            label1 = new Label();
            label_SoDienThoai = new Label();
            label_Ten = new Label();
            groupBox_DanhSachTaiKhoan = new GroupBox();
            dataGridView_DanhSachTaiKhoan = new DataGridView();
            textBox_TenMuonTim = new TextBox();
            button_TimTheoTen = new Button();
            button_HienTatCa = new Button();
            button_Xoa = new Button();
            button_ThemQuanLy = new Button();
            button_SuaTaiKhoan = new Button();
            button_LuuThem = new Button();
            groupBox_ThongTinTaiKhoan.SuspendLayout();
            groupBox_DanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // label_QuanLyTaiKhoan
            // 
            label_QuanLyTaiKhoan.AutoSize = true;
            label_QuanLyTaiKhoan.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuanLyTaiKhoan.ForeColor = SystemColors.ControlText;
            label_QuanLyTaiKhoan.Location = new Point(398, 9);
            label_QuanLyTaiKhoan.Name = "label_QuanLyTaiKhoan";
            label_QuanLyTaiKhoan.Size = new Size(266, 41);
            label_QuanLyTaiKhoan.TabIndex = 4;
            label_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            label_QuanLyTaiKhoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_TaiKhoanQuanLy
            // 
            button_TaiKhoanQuanLy.BackColor = Color.FromArgb(77, 134, 156);
            button_TaiKhoanQuanLy.ForeColor = Color.Snow;
            button_TaiKhoanQuanLy.Location = new Point(23, 161);
            button_TaiKhoanQuanLy.Name = "button_TaiKhoanQuanLy";
            button_TaiKhoanQuanLy.Size = new Size(167, 51);
            button_TaiKhoanQuanLy.TabIndex = 1;
            button_TaiKhoanQuanLy.Text = "Tài khoản quản lý";
            button_TaiKhoanQuanLy.UseVisualStyleBackColor = false;
            button_TaiKhoanQuanLy.Click += button_TaiKhoanQuanLy_Click;
            // 
            // button_TaiKhoanKhachHang
            // 
            button_TaiKhoanKhachHang.BackColor = Color.FromArgb(77, 134, 156);
            button_TaiKhoanKhachHang.ForeColor = Color.Snow;
            button_TaiKhoanKhachHang.Location = new Point(23, 82);
            button_TaiKhoanKhachHang.Name = "button_TaiKhoanKhachHang";
            button_TaiKhoanKhachHang.Size = new Size(167, 55);
            button_TaiKhoanKhachHang.TabIndex = 0;
            button_TaiKhoanKhachHang.Text = "Tài khoản khách hàng";
            button_TaiKhoanKhachHang.UseVisualStyleBackColor = false;
            button_TaiKhoanKhachHang.Click += button_TaiKhoanKhachHang_Click;
            // 
            // groupBox_ThongTinTaiKhoan
            // 
            groupBox_ThongTinTaiKhoan.Controls.Add(label_NgaySinh);
            groupBox_ThongTinTaiKhoan.Controls.Add(comboBox_GioiTinh);
            groupBox_ThongTinTaiKhoan.Controls.Add(dateTimePicker_NgaySinh);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_SoLanDatSan);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_SoLanDatSan);
            groupBox_ThongTinTaiKhoan.Controls.Add(comboBox_ToanQuyen);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_ToanQuyen);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_DiaChi);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_DiaChi);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_GioiTinh);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_MatKhau);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_MatKhau);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_Ma);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_Ma);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_Email);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_SoDienThoai);
            groupBox_ThongTinTaiKhoan.Controls.Add(textBox_Ten);
            groupBox_ThongTinTaiKhoan.Controls.Add(label1);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_SoDienThoai);
            groupBox_ThongTinTaiKhoan.Controls.Add(label_Ten);
            groupBox_ThongTinTaiKhoan.Location = new Point(232, 70);
            groupBox_ThongTinTaiKhoan.Name = "groupBox_ThongTinTaiKhoan";
            groupBox_ThongTinTaiKhoan.Size = new Size(766, 278);
            groupBox_ThongTinTaiKhoan.TabIndex = 19;
            groupBox_ThongTinTaiKhoan.TabStop = false;
            groupBox_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // label_NgaySinh
            // 
            label_NgaySinh.AutoSize = true;
            label_NgaySinh.Location = new Point(399, 165);
            label_NgaySinh.Name = "label_NgaySinh";
            label_NgaySinh.Size = new Size(74, 20);
            label_NgaySinh.TabIndex = 31;
            label_NgaySinh.Text = "Ngày sinh";
            // 
            // comboBox_GioiTinh
            // 
            comboBox_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_GioiTinh.FormattingEnabled = true;
            comboBox_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox_GioiTinh.Location = new Point(183, 159);
            comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            comboBox_GioiTinh.Size = new Size(197, 28);
            comboBox_GioiTinh.TabIndex = 8;
            // 
            // dateTimePicker_NgaySinh
            // 
            dateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_NgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NgaySinh.Location = new Point(533, 161);
            dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            dateTimePicker_NgaySinh.Size = new Size(192, 27);
            dateTimePicker_NgaySinh.TabIndex = 13;
            // 
            // textBox_SoLanDatSan
            // 
            textBox_SoLanDatSan.Enabled = false;
            textBox_SoLanDatSan.Location = new Point(533, 204);
            textBox_SoLanDatSan.Name = "textBox_SoLanDatSan";
            textBox_SoLanDatSan.Size = new Size(192, 27);
            textBox_SoLanDatSan.TabIndex = 14;
            // 
            // label_SoLanDatSan
            // 
            label_SoLanDatSan.AutoSize = true;
            label_SoLanDatSan.Location = new Point(400, 206);
            label_SoLanDatSan.Name = "label_SoLanDatSan";
            label_SoLanDatSan.Size = new Size(102, 20);
            label_SoLanDatSan.TabIndex = 27;
            label_SoLanDatSan.Text = "Số lần đặt sân";
            // 
            // comboBox_ToanQuyen
            // 
            comboBox_ToanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ToanQuyen.FormattingEnabled = true;
            comboBox_ToanQuyen.Items.AddRange(new object[] { "Không", "Có" });
            comboBox_ToanQuyen.Location = new Point(533, 40);
            comboBox_ToanQuyen.Name = "comboBox_ToanQuyen";
            comboBox_ToanQuyen.Size = new Size(192, 28);
            comboBox_ToanQuyen.TabIndex = 10;
            // 
            // label_ToanQuyen
            // 
            label_ToanQuyen.AutoSize = true;
            label_ToanQuyen.Location = new Point(399, 47);
            label_ToanQuyen.Name = "label_ToanQuyen";
            label_ToanQuyen.Size = new Size(85, 20);
            label_ToanQuyen.TabIndex = 21;
            label_ToanQuyen.Text = "Toàn quyền";
            // 
            // textBox_DiaChi
            // 
            textBox_DiaChi.Location = new Point(183, 203);
            textBox_DiaChi.Name = "textBox_DiaChi";
            textBox_DiaChi.Size = new Size(197, 27);
            textBox_DiaChi.TabIndex = 9;
            // 
            // label_DiaChi
            // 
            label_DiaChi.AutoSize = true;
            label_DiaChi.Location = new Point(41, 210);
            label_DiaChi.Name = "label_DiaChi";
            label_DiaChi.Size = new Size(55, 20);
            label_DiaChi.TabIndex = 25;
            label_DiaChi.Text = "Địa chỉ";
            // 
            // label_GioiTinh
            // 
            label_GioiTinh.AutoSize = true;
            label_GioiTinh.Location = new Point(41, 167);
            label_GioiTinh.Name = "label_GioiTinh";
            label_GioiTinh.Size = new Size(65, 20);
            label_GioiTinh.TabIndex = 23;
            label_GioiTinh.Text = "Giới tính";
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(533, 80);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(192, 27);
            textBox_MatKhau.TabIndex = 11;
            // 
            // label_MatKhau
            // 
            label_MatKhau.AutoSize = true;
            label_MatKhau.Location = new Point(399, 86);
            label_MatKhau.Name = "label_MatKhau";
            label_MatKhau.Size = new Size(70, 20);
            label_MatKhau.TabIndex = 19;
            label_MatKhau.Text = "Mật khẩu";
            // 
            // textBox_Ma
            // 
            textBox_Ma.Enabled = false;
            textBox_Ma.Location = new Point(183, 40);
            textBox_Ma.Name = "textBox_Ma";
            textBox_Ma.Size = new Size(197, 27);
            textBox_Ma.TabIndex = 5;
            // 
            // label_Ma
            // 
            label_Ma.AutoSize = true;
            label_Ma.Location = new Point(41, 47);
            label_Ma.Name = "label_Ma";
            label_Ma.Size = new Size(30, 20);
            label_Ma.TabIndex = 17;
            label_Ma.Text = "Mã";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(533, 119);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(192, 27);
            textBox_Email.TabIndex = 12;
            // 
            // textBox_SoDienThoai
            // 
            textBox_SoDienThoai.Location = new Point(183, 118);
            textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            textBox_SoDienThoai.Size = new Size(197, 27);
            textBox_SoDienThoai.TabIndex = 7;
            // 
            // textBox_Ten
            // 
            textBox_Ten.Location = new Point(183, 79);
            textBox_Ten.Name = "textBox_Ten";
            textBox_Ten.Size = new Size(197, 27);
            textBox_Ten.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 121);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // label_SoDienThoai
            // 
            label_SoDienThoai.AutoSize = true;
            label_SoDienThoai.Location = new Point(41, 125);
            label_SoDienThoai.Name = "label_SoDienThoai";
            label_SoDienThoai.Size = new Size(97, 20);
            label_SoDienThoai.TabIndex = 12;
            label_SoDienThoai.Text = "Số điện thoại";
            // 
            // label_Ten
            // 
            label_Ten.AutoSize = true;
            label_Ten.Location = new Point(41, 86);
            label_Ten.Name = "label_Ten";
            label_Ten.Size = new Size(32, 20);
            label_Ten.TabIndex = 11;
            label_Ten.Text = "Tên";
            // 
            // groupBox_DanhSachTaiKhoan
            // 
            groupBox_DanhSachTaiKhoan.Controls.Add(dataGridView_DanhSachTaiKhoan);
            groupBox_DanhSachTaiKhoan.Dock = DockStyle.Bottom;
            groupBox_DanhSachTaiKhoan.Location = new Point(0, 401);
            groupBox_DanhSachTaiKhoan.Name = "groupBox_DanhSachTaiKhoan";
            groupBox_DanhSachTaiKhoan.Size = new Size(1062, 452);
            groupBox_DanhSachTaiKhoan.TabIndex = 20;
            groupBox_DanhSachTaiKhoan.TabStop = false;
            groupBox_DanhSachTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // dataGridView_DanhSachTaiKhoan
            // 
            dataGridView_DanhSachTaiKhoan.AllowUserToAddRows = false;
            dataGridView_DanhSachTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Teal;
            dataGridView_DanhSachTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DanhSachTaiKhoan.BackgroundColor = Color.White;
            dataGridView_DanhSachTaiKhoan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_DanhSachTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DanhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_DanhSachTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DanhSachTaiKhoan.Dock = DockStyle.Fill;
            dataGridView_DanhSachTaiKhoan.GridColor = Color.White;
            dataGridView_DanhSachTaiKhoan.Location = new Point(3, 23);
            dataGridView_DanhSachTaiKhoan.Name = "dataGridView_DanhSachTaiKhoan";
            dataGridView_DanhSachTaiKhoan.ReadOnly = true;
            dataGridView_DanhSachTaiKhoan.RowHeadersWidth = 51;
            dataGridView_DanhSachTaiKhoan.Size = new Size(1056, 426);
            dataGridView_DanhSachTaiKhoan.TabIndex = 16;
            dataGridView_DanhSachTaiKhoan.CellClick += dataGridView_DanhSachTaiKhoan_CellClick;
            // 
            // textBox_TenMuonTim
            // 
            textBox_TenMuonTim.Location = new Point(23, 235);
            textBox_TenMuonTim.Name = "textBox_TenMuonTim";
            textBox_TenMuonTim.PlaceholderText = "Nhập tên muốn tìm";
            textBox_TenMuonTim.Size = new Size(167, 27);
            textBox_TenMuonTim.TabIndex = 2;
            textBox_TenMuonTim.TextAlign = HorizontalAlignment.Center;
            // 
            // button_TimTheoTen
            // 
            button_TimTheoTen.BackColor = Color.FromArgb(122, 178, 178);
            button_TimTheoTen.ForeColor = Color.Snow;
            button_TimTheoTen.Location = new Point(50, 268);
            button_TimTheoTen.Name = "button_TimTheoTen";
            button_TimTheoTen.Size = new Size(115, 29);
            button_TimTheoTen.TabIndex = 3;
            button_TimTheoTen.Text = "Tìm theo tên";
            button_TimTheoTen.UseVisualStyleBackColor = false;
            button_TimTheoTen.Click += button_TimTheoTen_Click;
            // 
            // button_HienTatCa
            // 
            button_HienTatCa.BackColor = Color.FromArgb(122, 178, 178);
            button_HienTatCa.ForeColor = Color.Snow;
            button_HienTatCa.Location = new Point(50, 303);
            button_HienTatCa.Name = "button_HienTatCa";
            button_HienTatCa.Size = new Size(115, 29);
            button_HienTatCa.TabIndex = 4;
            button_HienTatCa.Text = "Hiện tất cả";
            button_HienTatCa.UseVisualStyleBackColor = false;
            button_HienTatCa.Click += button_HienTatCa_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.FromArgb(122, 178, 178);
            button_Xoa.ForeColor = Color.Snow;
            button_Xoa.Location = new Point(292, 365);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(146, 30);
            button_Xoa.TabIndex = 15;
            button_Xoa.Text = "Xóa tài khoản";
            button_Xoa.UseVisualStyleBackColor = false;
            button_Xoa.Visible = false;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_ThemQuanLy
            // 
            button_ThemQuanLy.BackColor = Color.FromArgb(122, 178, 178);
            button_ThemQuanLy.ForeColor = Color.Snow;
            button_ThemQuanLy.Location = new Point(661, 365);
            button_ThemQuanLy.Name = "button_ThemQuanLy";
            button_ThemQuanLy.Size = new Size(151, 30);
            button_ThemQuanLy.TabIndex = 17;
            button_ThemQuanLy.Text = "Thêm quản lý";
            button_ThemQuanLy.UseVisualStyleBackColor = false;
            button_ThemQuanLy.Visible = false;
            button_ThemQuanLy.Click += button_ThemQuanLy_Click;
            // 
            // button_SuaTaiKhoan
            // 
            button_SuaTaiKhoan.BackColor = Color.FromArgb(122, 178, 178);
            button_SuaTaiKhoan.ForeColor = Color.Snow;
            button_SuaTaiKhoan.Location = new Point(474, 365);
            button_SuaTaiKhoan.Name = "button_SuaTaiKhoan";
            button_SuaTaiKhoan.Size = new Size(149, 30);
            button_SuaTaiKhoan.TabIndex = 16;
            button_SuaTaiKhoan.Text = "Sửa tài khoản";
            button_SuaTaiKhoan.UseVisualStyleBackColor = false;
            button_SuaTaiKhoan.Visible = false;
            button_SuaTaiKhoan.Click += button_SuaTaiKhoan_Click;
            // 
            // button_LuuThem
            // 
            button_LuuThem.BackColor = Color.FromArgb(122, 178, 178);
            button_LuuThem.ForeColor = Color.Snow;
            button_LuuThem.Location = new Point(847, 365);
            button_LuuThem.Name = "button_LuuThem";
            button_LuuThem.Size = new Size(151, 30);
            button_LuuThem.TabIndex = 18;
            button_LuuThem.Text = "Lưu thêm";
            button_LuuThem.UseVisualStyleBackColor = false;
            button_LuuThem.Visible = false;
            button_LuuThem.Click += button_LuuThem_Click;
            // 
            // QuanLyTaiKhoanHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1062, 853);
            Controls.Add(button_LuuThem);
            Controls.Add(button_SuaTaiKhoan);
            Controls.Add(button_ThemQuanLy);
            Controls.Add(button_Xoa);
            Controls.Add(groupBox_ThongTinTaiKhoan);
            Controls.Add(button_HienTatCa);
            Controls.Add(button_TimTheoTen);
            Controls.Add(textBox_TenMuonTim);
            Controls.Add(groupBox_DanhSachTaiKhoan);
            Controls.Add(button_TaiKhoanKhachHang);
            Controls.Add(button_TaiKhoanQuanLy);
            Controls.Add(label_QuanLyTaiKhoan);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "QuanLyTaiKhoanHeThong";
            Text = "My Football Pitch - Sân bóng Trí Hải";
            groupBox_ThongTinTaiKhoan.ResumeLayout(false);
            groupBox_ThongTinTaiKhoan.PerformLayout();
            groupBox_DanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_QuanLyTaiKhoan;
        private Button button_TaiKhoanQuanLy;
        private Button button_TaiKhoanKhachHang;
        private GroupBox groupBox_ThongTinTaiKhoan;
        private GroupBox groupBox_DanhSachTaiKhoan;
        private DataGridView dataGridView_DanhSachTaiKhoan;
        private TextBox textBox_Email;
        private TextBox textBox_SoDienThoai;
        private TextBox textBox_Ten;
        private Label label1;
        private Label label_SoDienThoai;
        private Label label_Ten;
        private TextBox textBox_Ma;
        private Label label_Ma;
        private Label label_MatKhau;
        private ComboBox comboBox_ToanQuyen;
        private Label label_ToanQuyen;
        private TextBox textBox_MatKhau;
        private TextBox textBox_SoLanDatSan;
        private Label label_SoLanDatSan;
        private TextBox textBox_DiaChi;
        private Label label_DiaChi;
        private Label label_GioiTinh;
        private DateTimePicker dateTimePicker_NgaySinh;
        private ComboBox comboBox_GioiTinh;
        private Label label_NgaySinh;
        private TextBox textBox_TenMuonTim;
        private Button button_TimTheoTen;
        private Button button_HienTatCa;
        private Button button_Xoa;
        private Button button_ThemQuanLy;
        private Button button_SuaTaiKhoan;
        private Button button_LuuThem;
    }
}