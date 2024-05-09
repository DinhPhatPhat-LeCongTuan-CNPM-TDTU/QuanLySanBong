namespace GUI
{
    partial class XemKhungGioBiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemKhungGioBiDat));
            button_DatSan = new Button();
            groupBox_DanhSachSanBiDat = new GroupBox();
            dataGridView_DanhSachSanBiDat = new DataGridView();
            dateTimePicker_NgayXemLichSanBiDat = new DateTimePicker();
            label_ChonNgay = new Label();
            pictureBox1 = new PictureBox();
            groupBox_DanhSachSanBiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachSanBiDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_DatSan
            // 
            button_DatSan.Location = new Point(24, 26);
            button_DatSan.Name = "button_DatSan";
            button_DatSan.Size = new Size(145, 35);
            button_DatSan.TabIndex = 0;
            button_DatSan.Text = "Quay về đặt sân";
            button_DatSan.UseVisualStyleBackColor = true;
            button_DatSan.Click += button_DatSan_Click;
            // 
            // groupBox_DanhSachSanBiDat
            // 
            groupBox_DanhSachSanBiDat.Controls.Add(dataGridView_DanhSachSanBiDat);
            groupBox_DanhSachSanBiDat.Dock = DockStyle.Bottom;
            groupBox_DanhSachSanBiDat.Location = new Point(0, 215);
            groupBox_DanhSachSanBiDat.Name = "groupBox_DanhSachSanBiDat";
            groupBox_DanhSachSanBiDat.Size = new Size(850, 410);
            groupBox_DanhSachSanBiDat.TabIndex = 1;
            groupBox_DanhSachSanBiDat.TabStop = false;
            groupBox_DanhSachSanBiDat.Text = "Danh sách sân bị đặt";
            // 
            // dataGridView_DanhSachSanBiDat
            // 
            dataGridView_DanhSachSanBiDat.AllowUserToAddRows = false;
            dataGridView_DanhSachSanBiDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Teal;
            dataGridView_DanhSachSanBiDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DanhSachSanBiDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DanhSachSanBiDat.BackgroundColor = Color.White;
            dataGridView_DanhSachSanBiDat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_DanhSachSanBiDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DanhSachSanBiDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_DanhSachSanBiDat.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DanhSachSanBiDat.Dock = DockStyle.Fill;
            dataGridView_DanhSachSanBiDat.GridColor = Color.White;
            dataGridView_DanhSachSanBiDat.Location = new Point(3, 23);
            dataGridView_DanhSachSanBiDat.Name = "dataGridView_DanhSachSanBiDat";
            dataGridView_DanhSachSanBiDat.ReadOnly = true;
            dataGridView_DanhSachSanBiDat.RowHeadersWidth = 51;
            dataGridView_DanhSachSanBiDat.Size = new Size(844, 384);
            dataGridView_DanhSachSanBiDat.TabIndex = 0;
            // 
            // dateTimePicker_NgayXemLichSanBiDat
            // 
            dateTimePicker_NgayXemLichSanBiDat.CalendarTitleBackColor = SystemColors.ActiveBorder;
            dateTimePicker_NgayXemLichSanBiDat.Format = DateTimePickerFormat.Short;
            dateTimePicker_NgayXemLichSanBiDat.Location = new Point(178, 142);
            dateTimePicker_NgayXemLichSanBiDat.Name = "dateTimePicker_NgayXemLichSanBiDat";
            dateTimePicker_NgayXemLichSanBiDat.Size = new Size(145, 27);
            dateTimePicker_NgayXemLichSanBiDat.TabIndex = 2;
            dateTimePicker_NgayXemLichSanBiDat.ValueChanged += dateTimePicker_NgayXemLichSanBiDat_ValueChanged;
            // 
            // label_ChonNgay
            // 
            label_ChonNgay.BackColor = Color.Green;
            label_ChonNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ChonNgay.ForeColor = Color.Snow;
            label_ChonNgay.Location = new Point(6, 142);
            label_ChonNgay.Name = "label_ChonNgay";
            label_ChonNgay.Size = new Size(166, 48);
            label_ChonNgay.TabIndex = 3;
            label_ChonNgay.Text = "Chọn ngày muốn xem lịch sân bị đặt";
            label_ChonNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-30, -486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1440, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // XemKhungGioBiDat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(label_ChonNgay);
            Controls.Add(dateTimePicker_NgayXemLichSanBiDat);
            Controls.Add(groupBox_DanhSachSanBiDat);
            Controls.Add(button_DatSan);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "XemKhungGioBiDat";
            Text = "XemKhungGioBiDat";
            groupBox_DanhSachSanBiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachSanBiDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_DatSan;
        private GroupBox groupBox_DanhSachSanBiDat;
        private DataGridView dataGridView_DanhSachSanBiDat;
        private DateTimePicker dateTimePicker_NgayXemLichSanBiDat;
        private Label label_ChonNgay;
        private PictureBox pictureBox1;
    }
}