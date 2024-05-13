namespace GUI
{
    partial class QuanLyDatSan
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label_QuanLyDatSan = new Label();
            dateTimePicker_ChonNgayDaFill = new DateTimePicker();
            label_ChonNgayDa = new Label();
            groupBox_SanDuocDat = new GroupBox();
            dataGridView_SanDuocDat = new DataGridView();
            comboBox_TinhTrangXacNhanFill = new ComboBox();
            label_TinhTrangXacNhanFill = new Label();
            label_TinhTrangThanhToanFill = new Label();
            groupBox1 = new GroupBox();
            comboBox_TinhTrangThanhToanFill = new ComboBox();
            groupBox_ThongTinDatSan = new GroupBox();
            textBox_TenThuNgan = new TextBox();
            label_ThuNgan = new Label();
            textBox_SoDienThoai = new TextBox();
            label_SoDienThoai = new Label();
            textBox_NgayDatSan = new TextBox();
            label2 = new Label();
            label_TinhTrangThanhToan = new Label();
            comboBox_TinhTrangThanhToan = new ComboBox();
            textBox_ThoiGianDa = new TextBox();
            label_ThoiGianDa = new Label();
            comboBox_TinhTrangXacNhan = new ComboBox();
            textBox_TongTien = new TextBox();
            label_Gia = new Label();
            textBox_ThoiGianKetThuc = new TextBox();
            label_ThoiGianKetThuc = new Label();
            label_NgayDatSan = new Label();
            textBox_TenSan = new TextBox();
            label_TenSan = new Label();
            textBox_TenKhachHang = new TextBox();
            label_TenKhachHang = new Label();
            textBox_LoaiSan = new TextBox();
            label1 = new Label();
            label_MaPhieuDatSan = new Label();
            textBox_MaPhieuDatSan = new TextBox();
            button_LuuThongTinDatSan = new Button();
            button_XoaDatSan = new Button();
            groupBox_SanDuocDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanDuocDat).BeginInit();
            groupBox1.SuspendLayout();
            groupBox_ThongTinDatSan.SuspendLayout();
            SuspendLayout();
            // 
            // label_QuanLyDatSan
            // 
            label_QuanLyDatSan.AutoSize = true;
            label_QuanLyDatSan.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuanLyDatSan.ForeColor = SystemColors.ControlText;
            label_QuanLyDatSan.Location = new Point(418, 9);
            label_QuanLyDatSan.Name = "label_QuanLyDatSan";
            label_QuanLyDatSan.Size = new Size(239, 41);
            label_QuanLyDatSan.TabIndex = 3;
            label_QuanLyDatSan.Text = "Quản lý đặt sân";
            label_QuanLyDatSan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_ChonNgayDaFill
            // 
            dateTimePicker_ChonNgayDaFill.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_ChonNgayDaFill.Format = DateTimePickerFormat.Custom;
            dateTimePicker_ChonNgayDaFill.Location = new Point(180, 35);
            dateTimePicker_ChonNgayDaFill.Name = "dateTimePicker_ChonNgayDaFill";
            dateTimePicker_ChonNgayDaFill.Size = new Size(164, 27);
            dateTimePicker_ChonNgayDaFill.TabIndex = 0;
            dateTimePicker_ChonNgayDaFill.ValueChanged += dateTimePicker_ChonNgayDa_ValueChanged;
            // 
            // label_ChonNgayDa
            // 
            label_ChonNgayDa.AutoSize = true;
            label_ChonNgayDa.Location = new Point(14, 40);
            label_ChonNgayDa.Name = "label_ChonNgayDa";
            label_ChonNgayDa.Size = new Size(100, 20);
            label_ChonNgayDa.TabIndex = 5;
            label_ChonNgayDa.Text = "Chọn ngày đá";
            // 
            // groupBox_SanDuocDat
            // 
            groupBox_SanDuocDat.Controls.Add(dataGridView_SanDuocDat);
            groupBox_SanDuocDat.Location = new Point(5, 344);
            groupBox_SanDuocDat.Name = "groupBox_SanDuocDat";
            groupBox_SanDuocDat.Size = new Size(1054, 317);
            groupBox_SanDuocDat.TabIndex = 6;
            groupBox_SanDuocDat.TabStop = false;
            groupBox_SanDuocDat.Text = "Sân được đặt";
            // 
            // dataGridView_SanDuocDat
            // 
            dataGridView_SanDuocDat.AllowUserToAddRows = false;
            dataGridView_SanDuocDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FloralWhite;
            dataGridViewCellStyle4.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Teal;
            dataGridView_SanDuocDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_SanDuocDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_SanDuocDat.BackgroundColor = Color.White;
            dataGridView_SanDuocDat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView_SanDuocDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_SanDuocDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView_SanDuocDat.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_SanDuocDat.Dock = DockStyle.Fill;
            dataGridView_SanDuocDat.GridColor = Color.White;
            dataGridView_SanDuocDat.Location = new Point(3, 23);
            dataGridView_SanDuocDat.Name = "dataGridView_SanDuocDat";
            dataGridView_SanDuocDat.ReadOnly = true;
            dataGridView_SanDuocDat.RowHeadersWidth = 51;
            dataGridView_SanDuocDat.Size = new Size(1048, 291);
            dataGridView_SanDuocDat.TabIndex = 16;
            dataGridView_SanDuocDat.CellClick += dataGridView_SanDuocDat_CellClick;
            // 
            // comboBox_TinhTrangXacNhanFill
            // 
            comboBox_TinhTrangXacNhanFill.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TinhTrangXacNhanFill.FormattingEnabled = true;
            comboBox_TinhTrangXacNhanFill.Items.AddRange(new object[] { "Tất cả", "Đã xác nhận", "Chưa xác nhận" });
            comboBox_TinhTrangXacNhanFill.Location = new Point(180, 87);
            comboBox_TinhTrangXacNhanFill.Name = "comboBox_TinhTrangXacNhanFill";
            comboBox_TinhTrangXacNhanFill.Size = new Size(164, 28);
            comboBox_TinhTrangXacNhanFill.TabIndex = 1;
            comboBox_TinhTrangXacNhanFill.SelectedIndexChanged += comboBox_TinhTrangXacNhanFill_SelectedIndexChanged;
            // 
            // label_TinhTrangXacNhanFill
            // 
            label_TinhTrangXacNhanFill.AutoSize = true;
            label_TinhTrangXacNhanFill.Location = new Point(14, 95);
            label_TinhTrangXacNhanFill.Name = "label_TinhTrangXacNhanFill";
            label_TinhTrangXacNhanFill.Size = new Size(138, 20);
            label_TinhTrangXacNhanFill.TabIndex = 8;
            label_TinhTrangXacNhanFill.Text = "Tình trạng xác nhận";
            // 
            // label_TinhTrangThanhToanFill
            // 
            label_TinhTrangThanhToanFill.AutoSize = true;
            label_TinhTrangThanhToanFill.Location = new Point(14, 155);
            label_TinhTrangThanhToanFill.Name = "label_TinhTrangThanhToanFill";
            label_TinhTrangThanhToanFill.Size = new Size(151, 20);
            label_TinhTrangThanhToanFill.TabIndex = 10;
            label_TinhTrangThanhToanFill.Text = "Tình trạng thanh toán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_TinhTrangThanhToanFill);
            groupBox1.Controls.Add(comboBox_TinhTrangXacNhanFill);
            groupBox1.Controls.Add(dateTimePicker_ChonNgayDaFill);
            groupBox1.Controls.Add(label_ChonNgayDa);
            groupBox1.Controls.Add(label_TinhTrangXacNhanFill);
            groupBox1.Controls.Add(label_TinhTrangThanhToanFill);
            groupBox1.Location = new Point(8, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 202);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc đặt sân";
            // 
            // comboBox_TinhTrangThanhToanFill
            // 
            comboBox_TinhTrangThanhToanFill.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TinhTrangThanhToanFill.FormattingEnabled = true;
            comboBox_TinhTrangThanhToanFill.Items.AddRange(new object[] { "Tất cả", "Chưa thanh toán", "Đã thanh toán" });
            comboBox_TinhTrangThanhToanFill.Location = new Point(179, 147);
            comboBox_TinhTrangThanhToanFill.Name = "comboBox_TinhTrangThanhToanFill";
            comboBox_TinhTrangThanhToanFill.Size = new Size(165, 28);
            comboBox_TinhTrangThanhToanFill.TabIndex = 2;
            comboBox_TinhTrangThanhToanFill.SelectedIndexChanged += comboBox_TinhTrangThanhToanFill_SelectedIndexChanged;
            // 
            // groupBox_ThongTinDatSan
            // 
            groupBox_ThongTinDatSan.Controls.Add(textBox_TenThuNgan);
            groupBox_ThongTinDatSan.Controls.Add(label_ThuNgan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_SoDienThoai);
            groupBox_ThongTinDatSan.Controls.Add(label_SoDienThoai);
            groupBox_ThongTinDatSan.Controls.Add(textBox_NgayDatSan);
            groupBox_ThongTinDatSan.Controls.Add(label2);
            groupBox_ThongTinDatSan.Controls.Add(label_TinhTrangThanhToan);
            groupBox_ThongTinDatSan.Controls.Add(comboBox_TinhTrangThanhToan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_ThoiGianDa);
            groupBox_ThongTinDatSan.Controls.Add(label_ThoiGianDa);
            groupBox_ThongTinDatSan.Controls.Add(comboBox_TinhTrangXacNhan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_TongTien);
            groupBox_ThongTinDatSan.Controls.Add(label_Gia);
            groupBox_ThongTinDatSan.Controls.Add(textBox_ThoiGianKetThuc);
            groupBox_ThongTinDatSan.Controls.Add(label_ThoiGianKetThuc);
            groupBox_ThongTinDatSan.Controls.Add(label_NgayDatSan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_TenSan);
            groupBox_ThongTinDatSan.Controls.Add(label_TenSan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_TenKhachHang);
            groupBox_ThongTinDatSan.Controls.Add(label_TenKhachHang);
            groupBox_ThongTinDatSan.Controls.Add(textBox_LoaiSan);
            groupBox_ThongTinDatSan.Controls.Add(label1);
            groupBox_ThongTinDatSan.Controls.Add(label_MaPhieuDatSan);
            groupBox_ThongTinDatSan.Controls.Add(textBox_MaPhieuDatSan);
            groupBox_ThongTinDatSan.Location = new Point(367, 62);
            groupBox_ThongTinDatSan.Name = "groupBox_ThongTinDatSan";
            groupBox_ThongTinDatSan.Size = new Size(683, 276);
            groupBox_ThongTinDatSan.TabIndex = 15;
            groupBox_ThongTinDatSan.TabStop = false;
            groupBox_ThongTinDatSan.Text = "Thông tin đặt sân";
            // 
            // textBox_TenThuNgan
            // 
            textBox_TenThuNgan.Enabled = false;
            textBox_TenThuNgan.Location = new Point(454, 70);
            textBox_TenThuNgan.Name = "textBox_TenThuNgan";
            textBox_TenThuNgan.Size = new Size(181, 27);
            textBox_TenThuNgan.TabIndex = 10;
            // 
            // label_ThuNgan
            // 
            label_ThuNgan.AutoSize = true;
            label_ThuNgan.Location = new Point(318, 73);
            label_ThuNgan.Name = "label_ThuNgan";
            label_ThuNgan.Size = new Size(94, 20);
            label_ThuNgan.TabIndex = 23;
            label_ThuNgan.Text = "Tên thu ngân";
            // 
            // textBox_SoDienThoai
            // 
            textBox_SoDienThoai.Enabled = false;
            textBox_SoDienThoai.Location = new Point(135, 110);
            textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            textBox_SoDienThoai.Size = new Size(164, 27);
            textBox_SoDienThoai.TabIndex = 5;
            // 
            // label_SoDienThoai
            // 
            label_SoDienThoai.AutoSize = true;
            label_SoDienThoai.Location = new Point(6, 117);
            label_SoDienThoai.Name = "label_SoDienThoai";
            label_SoDienThoai.Size = new Size(97, 20);
            label_SoDienThoai.TabIndex = 21;
            label_SoDienThoai.Text = "Số điện thoại";
            // 
            // textBox_NgayDatSan
            // 
            textBox_NgayDatSan.Enabled = false;
            textBox_NgayDatSan.Location = new Point(454, 110);
            textBox_NgayDatSan.Name = "textBox_NgayDatSan";
            textBox_NgayDatSan.Size = new Size(181, 27);
            textBox_NgayDatSan.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 240);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 19;
            label2.Text = "Xác nhận";
            // 
            // label_TinhTrangThanhToan
            // 
            label_TinhTrangThanhToan.AutoSize = true;
            label_TinhTrangThanhToan.Location = new Point(318, 234);
            label_TinhTrangThanhToan.Name = "label_TinhTrangThanhToan";
            label_TinhTrangThanhToan.Size = new Size(83, 20);
            label_TinhTrangThanhToan.TabIndex = 18;
            label_TinhTrangThanhToan.Text = "Thanh toán";
            // 
            // comboBox_TinhTrangThanhToan
            // 
            comboBox_TinhTrangThanhToan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TinhTrangThanhToan.FormattingEnabled = true;
            comboBox_TinhTrangThanhToan.Items.AddRange(new object[] { "Chưa thanh toán", "Đã thanh toán" });
            comboBox_TinhTrangThanhToan.Location = new Point(454, 232);
            comboBox_TinhTrangThanhToan.Name = "comboBox_TinhTrangThanhToan";
            comboBox_TinhTrangThanhToan.Size = new Size(181, 28);
            comboBox_TinhTrangThanhToan.TabIndex = 14;
            // 
            // textBox_ThoiGianDa
            // 
            textBox_ThoiGianDa.Enabled = false;
            textBox_ThoiGianDa.Location = new Point(135, 152);
            textBox_ThoiGianDa.Name = "textBox_ThoiGianDa";
            textBox_ThoiGianDa.Size = new Size(164, 27);
            textBox_ThoiGianDa.TabIndex = 6;
            // 
            // label_ThoiGianDa
            // 
            label_ThoiGianDa.AutoSize = true;
            label_ThoiGianDa.Location = new Point(6, 155);
            label_ThoiGianDa.Name = "label_ThoiGianDa";
            label_ThoiGianDa.Size = new Size(92, 20);
            label_ThoiGianDa.TabIndex = 12;
            label_ThoiGianDa.Text = "Thời gian đá";
            // 
            // comboBox_TinhTrangXacNhan
            // 
            comboBox_TinhTrangXacNhan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TinhTrangXacNhan.FormattingEnabled = true;
            comboBox_TinhTrangXacNhan.Items.AddRange(new object[] { "Chưa xác nhận", "Đã xác nhận" });
            comboBox_TinhTrangXacNhan.Location = new Point(135, 231);
            comboBox_TinhTrangXacNhan.Name = "comboBox_TinhTrangXacNhan";
            comboBox_TinhTrangXacNhan.Size = new Size(164, 28);
            comboBox_TinhTrangXacNhan.TabIndex = 8;
            // 
            // textBox_TongTien
            // 
            textBox_TongTien.Enabled = false;
            textBox_TongTien.Location = new Point(135, 193);
            textBox_TongTien.Name = "textBox_TongTien";
            textBox_TongTien.Size = new Size(164, 27);
            textBox_TongTien.TabIndex = 7;
            // 
            // label_Gia
            // 
            label_Gia.AutoSize = true;
            label_Gia.Location = new Point(6, 200);
            label_Gia.Name = "label_Gia";
            label_Gia.Size = new Size(72, 20);
            label_Gia.TabIndex = 8;
            label_Gia.Text = "Tổng tiền";
            // 
            // textBox_ThoiGianKetThuc
            // 
            textBox_ThoiGianKetThuc.Enabled = false;
            textBox_ThoiGianKetThuc.Location = new Point(454, 152);
            textBox_ThoiGianKetThuc.Name = "textBox_ThoiGianKetThuc";
            textBox_ThoiGianKetThuc.Size = new Size(181, 27);
            textBox_ThoiGianKetThuc.TabIndex = 12;
            // 
            // label_ThoiGianKetThuc
            // 
            label_ThoiGianKetThuc.AutoSize = true;
            label_ThoiGianKetThuc.Location = new Point(318, 158);
            label_ThoiGianKetThuc.Name = "label_ThoiGianKetThuc";
            label_ThoiGianKetThuc.Size = new Size(127, 20);
            label_ThoiGianKetThuc.TabIndex = 14;
            label_ThoiGianKetThuc.Text = "Thời gian kết thúc";
            // 
            // label_NgayDatSan
            // 
            label_NgayDatSan.AutoSize = true;
            label_NgayDatSan.Location = new Point(318, 116);
            label_NgayDatSan.Name = "label_NgayDatSan";
            label_NgayDatSan.Size = new Size(96, 20);
            label_NgayDatSan.TabIndex = 11;
            label_NgayDatSan.Text = "Ngày đặt sân";
            // 
            // textBox_TenSan
            // 
            textBox_TenSan.Enabled = false;
            textBox_TenSan.Location = new Point(454, 196);
            textBox_TenSan.Name = "textBox_TenSan";
            textBox_TenSan.Size = new Size(181, 27);
            textBox_TenSan.TabIndex = 13;
            // 
            // label_TenSan
            // 
            label_TenSan.AutoSize = true;
            label_TenSan.Location = new Point(318, 198);
            label_TenSan.Name = "label_TenSan";
            label_TenSan.Size = new Size(58, 20);
            label_TenSan.TabIndex = 6;
            label_TenSan.Text = "Tên sân";
            // 
            // textBox_TenKhachHang
            // 
            textBox_TenKhachHang.Enabled = false;
            textBox_TenKhachHang.Location = new Point(135, 70);
            textBox_TenKhachHang.Name = "textBox_TenKhachHang";
            textBox_TenKhachHang.Size = new Size(164, 27);
            textBox_TenKhachHang.TabIndex = 4;
            // 
            // label_TenKhachHang
            // 
            label_TenKhachHang.AutoSize = true;
            label_TenKhachHang.Location = new Point(6, 74);
            label_TenKhachHang.Name = "label_TenKhachHang";
            label_TenKhachHang.Size = new Size(111, 20);
            label_TenKhachHang.TabIndex = 4;
            label_TenKhachHang.Text = "Tên khách hàng";
            // 
            // textBox_LoaiSan
            // 
            textBox_LoaiSan.Enabled = false;
            textBox_LoaiSan.Location = new Point(454, 26);
            textBox_LoaiSan.Name = "textBox_LoaiSan";
            textBox_LoaiSan.Size = new Size(181, 27);
            textBox_LoaiSan.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Loại sân";
            // 
            // label_MaPhieuDatSan
            // 
            label_MaPhieuDatSan.AutoSize = true;
            label_MaPhieuDatSan.Location = new Point(6, 35);
            label_MaPhieuDatSan.Name = "label_MaPhieuDatSan";
            label_MaPhieuDatSan.Size = new Size(123, 20);
            label_MaPhieuDatSan.TabIndex = 1;
            label_MaPhieuDatSan.Text = "Mã phiếu đặt sân";
            // 
            // textBox_MaPhieuDatSan
            // 
            textBox_MaPhieuDatSan.Enabled = false;
            textBox_MaPhieuDatSan.Location = new Point(135, 28);
            textBox_MaPhieuDatSan.Name = "textBox_MaPhieuDatSan";
            textBox_MaPhieuDatSan.Size = new Size(164, 27);
            textBox_MaPhieuDatSan.TabIndex = 3;
            // 
            // button_LuuThongTinDatSan
            // 
            button_LuuThongTinDatSan.BackColor = Color.FromArgb(148, 137, 121);
            button_LuuThongTinDatSan.ForeColor = Color.Snow;
            button_LuuThongTinDatSan.Location = new Point(756, 34);
            button_LuuThongTinDatSan.Name = "button_LuuThongTinDatSan";
            button_LuuThongTinDatSan.Size = new Size(167, 35);
            button_LuuThongTinDatSan.TabIndex = 15;
            button_LuuThongTinDatSan.Text = "Lưu thông tin đặt sân";
            button_LuuThongTinDatSan.UseVisualStyleBackColor = false;
            button_LuuThongTinDatSan.Click += button_LuuThongTinDatSan_Click;
            // 
            // button_XoaDatSan
            // 
            button_XoaDatSan.BackColor = Color.FromArgb(148, 137, 121);
            button_XoaDatSan.ForeColor = Color.Snow;
            button_XoaDatSan.Location = new Point(957, 34);
            button_XoaDatSan.Name = "button_XoaDatSan";
            button_XoaDatSan.Size = new Size(99, 35);
            button_XoaDatSan.TabIndex = 16;
            button_XoaDatSan.Text = "Xóa đặt sân";
            button_XoaDatSan.UseVisualStyleBackColor = false;
            button_XoaDatSan.Click += button_XoaDatSan_Click;
            // 
            // QuanLyDatSan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1062, 673);
            Controls.Add(button_XoaDatSan);
            Controls.Add(button_LuuThongTinDatSan);
            Controls.Add(groupBox_ThongTinDatSan);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_SanDuocDat);
            Controls.Add(label_QuanLyDatSan);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1080, 720);
            MinimumSize = new Size(1080, 720);
            Name = "QuanLyDatSan";
            Text = "My Football Pitch - Sân bóng Trí Hải";
            Load += QuanLyDatSan_Load;
            groupBox_SanDuocDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanDuocDat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_ThongTinDatSan.ResumeLayout(false);
            groupBox_ThongTinDatSan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_QuanLyDatSan;
        private DateTimePicker dateTimePicker_ChonNgayDaFill;
        private Label label_ChonNgayDa;
        private GroupBox groupBox_SanDuocDat;
        private DataGridView dataGridView_SanDuocDat;
        private ComboBox comboBox_TinhTrangXacNhanFill;
        private Label label_TinhTrangXacNhanFill;
        private Label label_TinhTrangThanhToanFill;
        private GroupBox groupBox1;
        private GroupBox groupBox_ThongTinDatSan;
        private Label label_MaPhieuDatSan;
        private TextBox textBox_MaPhieuDatSan;
        private TextBox textBox_LoaiSan;
        private Label label1;
        private TextBox textBox_TenKhachHang;
        private Label label_TenKhachHang;
        private Label label_TenSan;
        private TextBox textBox_TenSan;
        private TextBox textBox_TongTien;
        private Label label_Gia;
        private Label label_ThoiGianDa;
        private Label label_NgayDatSan;
        private TextBox textBox_ThoiGianKetThuc;
        private Label label_ThoiGianKetThuc;
        private TextBox textBox_ThoiGianDa;
        private ComboBox comboBox_TinhTrangXacNhan;
        private Label label2;
        private Label label_TinhTrangThanhToan;
        private ComboBox comboBox_TinhTrangThanhToan;
        private ComboBox comboBox_TinhTrangThanhToanFill;
        private TextBox textBox_NgayDatSan;
        private Button button_LuuThongTinDatSan;
        private Button button_XoaDatSan;
        private TextBox textBox_SoDienThoai;
        private Label label_SoDienThoai;
        private Label label_ThuNgan;
        private TextBox textBox_TenThuNgan;
    }
}