namespace GUI
{
    partial class TaiKhoanKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanKhachHang));
            label_TaiKhoanKhachHang = new Label();
            groupBox_ThongTinKhachHang = new GroupBox();
            label_ThongBao = new Label();
            button_LuuThongTin = new Button();
            comboBox_GioiTinh = new ComboBox();
            checkBox_SuaThongTin = new CheckBox();
            dateTimePicker_NgaySinh = new DateTimePicker();
            textBox_SoLanDatSanVaThanhToanThanhCong = new TextBox();
            textBox_DiaChi = new TextBox();
            textBox_Email = new TextBox();
            textBox_SoDienThoai = new TextBox();
            textBox_TenKhachHang = new TextBox();
            label_SoLanDatSanVaThanhToanThanhCong = new Label();
            label_DiaChi = new Label();
            label_NgaySinh = new Label();
            label_GioiTinh = new Label();
            label1 = new Label();
            label_SoDienThoai = new Label();
            label_TenKhachHang = new Label();
            dataGridView_LichSuDatSan = new DataGridView();
            groupBox_XemLichSuDatSan = new GroupBox();
            button_DangXuat = new Button();
            groupBox_ThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LichSuDatSan).BeginInit();
            groupBox_XemLichSuDatSan.SuspendLayout();
            SuspendLayout();
            // 
            // label_TaiKhoanKhachHang
            // 
            label_TaiKhoanKhachHang.AutoSize = true;
            label_TaiKhoanKhachHang.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TaiKhoanKhachHang.ForeColor = SystemColors.ControlText;
            label_TaiKhoanKhachHang.Location = new Point(263, 22);
            label_TaiKhoanKhachHang.Name = "label_TaiKhoanKhachHang";
            label_TaiKhoanKhachHang.Size = new Size(320, 41);
            label_TaiKhoanKhachHang.TabIndex = 1;
            label_TaiKhoanKhachHang.Text = "Tài khoản khách hàng";
            label_TaiKhoanKhachHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_ThongTinKhachHang
            // 
            groupBox_ThongTinKhachHang.Controls.Add(label_ThongBao);
            groupBox_ThongTinKhachHang.Controls.Add(button_LuuThongTin);
            groupBox_ThongTinKhachHang.Controls.Add(comboBox_GioiTinh);
            groupBox_ThongTinKhachHang.Controls.Add(checkBox_SuaThongTin);
            groupBox_ThongTinKhachHang.Controls.Add(dateTimePicker_NgaySinh);
            groupBox_ThongTinKhachHang.Controls.Add(textBox_SoLanDatSanVaThanhToanThanhCong);
            groupBox_ThongTinKhachHang.Controls.Add(textBox_DiaChi);
            groupBox_ThongTinKhachHang.Controls.Add(textBox_Email);
            groupBox_ThongTinKhachHang.Controls.Add(textBox_SoDienThoai);
            groupBox_ThongTinKhachHang.Controls.Add(textBox_TenKhachHang);
            groupBox_ThongTinKhachHang.Controls.Add(label_SoLanDatSanVaThanhToanThanhCong);
            groupBox_ThongTinKhachHang.Controls.Add(label_DiaChi);
            groupBox_ThongTinKhachHang.Controls.Add(label_NgaySinh);
            groupBox_ThongTinKhachHang.Controls.Add(label_GioiTinh);
            groupBox_ThongTinKhachHang.Controls.Add(label1);
            groupBox_ThongTinKhachHang.Controls.Add(label_SoDienThoai);
            groupBox_ThongTinKhachHang.Controls.Add(label_TenKhachHang);
            groupBox_ThongTinKhachHang.Location = new Point(12, 66);
            groupBox_ThongTinKhachHang.Name = "groupBox_ThongTinKhachHang";
            groupBox_ThongTinKhachHang.Size = new Size(826, 218);
            groupBox_ThongTinKhachHang.TabIndex = 2;
            groupBox_ThongTinKhachHang.TabStop = false;
            groupBox_ThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // label_ThongBao
            // 
            label_ThongBao.ForeColor = Color.IndianRed;
            label_ThongBao.Location = new Point(273, 163);
            label_ThongBao.Name = "label_ThongBao";
            label_ThongBao.Size = new Size(260, 44);
            label_ThongBao.TabIndex = 19;
            label_ThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_LuuThongTin
            // 
            button_LuuThongTin.BackColor = Color.Green;
            button_LuuThongTin.ForeColor = SystemColors.ControlLightLight;
            button_LuuThongTin.Location = new Point(680, 163);
            button_LuuThongTin.Name = "button_LuuThongTin";
            button_LuuThongTin.Size = new Size(120, 29);
            button_LuuThongTin.TabIndex = 18;
            button_LuuThongTin.Text = "Lưu thông tin";
            button_LuuThongTin.UseVisualStyleBackColor = false;
            button_LuuThongTin.Visible = false;
            button_LuuThongTin.Click += button_LuuThongTin_Click;
            // 
            // comboBox_GioiTinh
            // 
            comboBox_GioiTinh.Enabled = false;
            comboBox_GioiTinh.FormattingEnabled = true;
            comboBox_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox_GioiTinh.Location = new Point(554, 42);
            comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            comboBox_GioiTinh.Size = new Size(120, 28);
            comboBox_GioiTinh.TabIndex = 17;
            // 
            // checkBox_SuaThongTin
            // 
            checkBox_SuaThongTin.AutoSize = true;
            checkBox_SuaThongTin.Location = new Point(554, 168);
            checkBox_SuaThongTin.Name = "checkBox_SuaThongTin";
            checkBox_SuaThongTin.Size = new Size(120, 24);
            checkBox_SuaThongTin.TabIndex = 16;
            checkBox_SuaThongTin.Text = "Sửa thông tin";
            checkBox_SuaThongTin.UseVisualStyleBackColor = true;
            checkBox_SuaThongTin.CheckedChanged += checkBox_SuaThongTin_CheckedChanged;
            // 
            // dateTimePicker_NgaySinh
            // 
            dateTimePicker_NgaySinh.Enabled = false;
            dateTimePicker_NgaySinh.Location = new Point(554, 84);
            dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            dateTimePicker_NgaySinh.Size = new Size(266, 27);
            dateTimePicker_NgaySinh.TabIndex = 15;
            // 
            // textBox_SoLanDatSanVaThanhToanThanhCong
            // 
            textBox_SoLanDatSanVaThanhToanThanhCong.Enabled = false;
            textBox_SoLanDatSanVaThanhToanThanhCong.Location = new Point(182, 168);
            textBox_SoLanDatSanVaThanhToanThanhCong.Name = "textBox_SoLanDatSanVaThanhToanThanhCong";
            textBox_SoLanDatSanVaThanhToanThanhCong.Size = new Size(85, 27);
            textBox_SoLanDatSanVaThanhToanThanhCong.TabIndex = 14;
            // 
            // textBox_DiaChi
            // 
            textBox_DiaChi.Enabled = false;
            textBox_DiaChi.Location = new Point(554, 123);
            textBox_DiaChi.Name = "textBox_DiaChi";
            textBox_DiaChi.Size = new Size(266, 27);
            textBox_DiaChi.TabIndex = 13;
            // 
            // textBox_Email
            // 
            textBox_Email.Enabled = false;
            textBox_Email.Location = new Point(182, 123);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(269, 27);
            textBox_Email.TabIndex = 10;
            // 
            // textBox_SoDienThoai
            // 
            textBox_SoDienThoai.Enabled = false;
            textBox_SoDienThoai.Location = new Point(182, 82);
            textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            textBox_SoDienThoai.Size = new Size(269, 27);
            textBox_SoDienThoai.TabIndex = 9;
            // 
            // textBox_TenKhachHang
            // 
            textBox_TenKhachHang.Enabled = false;
            textBox_TenKhachHang.Location = new Point(182, 43);
            textBox_TenKhachHang.Name = "textBox_TenKhachHang";
            textBox_TenKhachHang.Size = new Size(269, 27);
            textBox_TenKhachHang.TabIndex = 8;
            // 
            // label_SoLanDatSanVaThanhToanThanhCong
            // 
            label_SoLanDatSanVaThanhToanThanhCong.Location = new Point(5, 155);
            label_SoLanDatSanVaThanhToanThanhCong.Name = "label_SoLanDatSanVaThanhToanThanhCong";
            label_SoLanDatSanVaThanhToanThanhCong.Size = new Size(171, 40);
            label_SoLanDatSanVaThanhToanThanhCong.TabIndex = 7;
            label_SoLanDatSanVaThanhToanThanhCong.Text = "Số lần đặt sân và thanh toán thành công";
            // 
            // label_DiaChi
            // 
            label_DiaChi.AutoSize = true;
            label_DiaChi.Location = new Point(478, 126);
            label_DiaChi.Name = "label_DiaChi";
            label_DiaChi.Size = new Size(55, 20);
            label_DiaChi.TabIndex = 6;
            label_DiaChi.Text = "Địa chỉ";
            // 
            // label_NgaySinh
            // 
            label_NgaySinh.AutoSize = true;
            label_NgaySinh.Location = new Point(459, 89);
            label_NgaySinh.Name = "label_NgaySinh";
            label_NgaySinh.Size = new Size(74, 20);
            label_NgaySinh.TabIndex = 5;
            label_NgaySinh.Text = "Ngày sinh";
            // 
            // label_GioiTinh
            // 
            label_GioiTinh.AutoSize = true;
            label_GioiTinh.Location = new Point(468, 50);
            label_GioiTinh.Name = "label_GioiTinh";
            label_GioiTinh.Size = new Size(65, 20);
            label_GioiTinh.TabIndex = 4;
            label_GioiTinh.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 126);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label_SoDienThoai
            // 
            label_SoDienThoai.AutoSize = true;
            label_SoDienThoai.Location = new Point(40, 89);
            label_SoDienThoai.Name = "label_SoDienThoai";
            label_SoDienThoai.Size = new Size(97, 20);
            label_SoDienThoai.TabIndex = 1;
            label_SoDienThoai.Text = "Số điện thoại";
            // 
            // label_TenKhachHang
            // 
            label_TenKhachHang.AutoSize = true;
            label_TenKhachHang.Location = new Point(26, 50);
            label_TenKhachHang.Name = "label_TenKhachHang";
            label_TenKhachHang.Size = new Size(111, 20);
            label_TenKhachHang.TabIndex = 0;
            label_TenKhachHang.Text = "Tên khách hàng";
            // 
            // dataGridView_LichSuDatSan
            // 
            dataGridView_LichSuDatSan.AllowUserToAddRows = false;
            dataGridView_LichSuDatSan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Teal;
            dataGridView_LichSuDatSan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_LichSuDatSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_LichSuDatSan.BackgroundColor = Color.White;
            dataGridView_LichSuDatSan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_LichSuDatSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_LichSuDatSan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_LichSuDatSan.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_LichSuDatSan.Dock = DockStyle.Fill;
            dataGridView_LichSuDatSan.GridColor = Color.White;
            dataGridView_LichSuDatSan.Location = new Point(3, 23);
            dataGridView_LichSuDatSan.Name = "dataGridView_LichSuDatSan";
            dataGridView_LichSuDatSan.ReadOnly = true;
            dataGridView_LichSuDatSan.RowHeadersWidth = 51;
            dataGridView_LichSuDatSan.Size = new Size(818, 248);
            dataGridView_LichSuDatSan.TabIndex = 15;
            // 
            // groupBox_XemLichSuDatSan
            // 
            groupBox_XemLichSuDatSan.Controls.Add(dataGridView_LichSuDatSan);
            groupBox_XemLichSuDatSan.Location = new Point(14, 319);
            groupBox_XemLichSuDatSan.Name = "groupBox_XemLichSuDatSan";
            groupBox_XemLichSuDatSan.Size = new Size(824, 274);
            groupBox_XemLichSuDatSan.TabIndex = 3;
            groupBox_XemLichSuDatSan.TabStop = false;
            groupBox_XemLichSuDatSan.Text = "Xem lịch sử đặt sân";
            // 
            // button_DangXuat
            // 
            button_DangXuat.BackColor = Color.Snow;
            button_DangXuat.BackgroundImage = (Image)resources.GetObject("button_DangXuat.BackgroundImage");
            button_DangXuat.BackgroundImageLayout = ImageLayout.Zoom;
            button_DangXuat.Location = new Point(788, 31);
            button_DangXuat.Name = "button_DangXuat";
            button_DangXuat.Size = new Size(50, 47);
            button_DangXuat.TabIndex = 12;
            button_DangXuat.UseVisualStyleBackColor = false;
            button_DangXuat.Click += button_DangXuat_Click;
            // 
            // TaiKhoanKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 213);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(button_DangXuat);
            Controls.Add(groupBox_XemLichSuDatSan);
            Controls.Add(groupBox_ThongTinKhachHang);
            Controls.Add(label_TaiKhoanKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiKhoanKhachHang";
            Text = "TaiKhoanKhachHang";
            Load += TaiKhoanKhachHang_Load;
            groupBox_ThongTinKhachHang.ResumeLayout(false);
            groupBox_ThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LichSuDatSan).EndInit();
            groupBox_XemLichSuDatSan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TaiKhoanKhachHang;
        private GroupBox groupBox_ThongTinKhachHang;
        private Label label_TenKhachHang;
        private Label label1;
        private Label label_SoDienThoai;
        private TextBox textBox_SoLanDatSanVaThanhToanThanhCong;
        private TextBox textBox_DiaChi;
        private TextBox textBox_Email;
        private TextBox textBox_SoDienThoai;
        private TextBox textBox_TenKhachHang;
        private Label label_SoLanDatSanVaThanhToanThanhCong;
        private Label label_DiaChi;
        private Label label_NgaySinh;
        private Label label_GioiTinh;
        private DataGridView dataGridView_LichSuDatSan;
        private GroupBox groupBox_XemLichSuDatSan;
        private DateTimePicker dateTimePicker_NgaySinh;
        private CheckBox checkBox_SuaThongTin;
        private ComboBox comboBox_GioiTinh;
        private Button button_LuuThongTin;
        private Label label_ThongBao;
        private Button button_DangXuat;
    }
}