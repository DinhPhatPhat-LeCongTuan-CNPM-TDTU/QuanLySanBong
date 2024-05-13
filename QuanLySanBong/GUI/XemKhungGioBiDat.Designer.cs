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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemKhungGioBiDat));
            button_DatSan = new Button();
            groupBox_DanhSachSanBiDat = new GroupBox();
            dataGridView_DanhSachSanBiDat = new DataGridView();
            dateTimePicker_NgayXemLichSanBiDat = new DateTimePicker();
            button_XemGiaSan = new Button();
            button_XemSanBiDat = new Button();
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
            button_DatSan.TabIndex = 5;
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
            // 
            // dataGridView_DanhSachSanBiDat
            // 
            dataGridView_DanhSachSanBiDat.AllowUserToAddRows = false;
            dataGridView_DanhSachSanBiDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FloralWhite;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Teal;
            dataGridView_DanhSachSanBiDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_DanhSachSanBiDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DanhSachSanBiDat.BackgroundColor = Color.White;
            dataGridView_DanhSachSanBiDat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView_DanhSachSanBiDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_DanhSachSanBiDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView_DanhSachSanBiDat.DefaultCellStyle = dataGridViewCellStyle6;
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
            dateTimePicker_NgayXemLichSanBiDat.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_NgayXemLichSanBiDat.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NgayXemLichSanBiDat.Location = new Point(549, 67);
            dateTimePicker_NgayXemLichSanBiDat.Name = "dateTimePicker_NgayXemLichSanBiDat";
            dateTimePicker_NgayXemLichSanBiDat.Size = new Size(145, 27);
            dateTimePicker_NgayXemLichSanBiDat.TabIndex = 2;
            dateTimePicker_NgayXemLichSanBiDat.ValueChanged += dateTimePicker_NgayXemLichSanBiDat_ValueChanged;
            // 
            // button_XemGiaSan
            // 
            button_XemGiaSan.BackColor = Color.FromArgb(175, 209, 152);
            button_XemGiaSan.ForeColor = Color.Black;
            button_XemGiaSan.Location = new Point(360, 26);
            button_XemGiaSan.Name = "button_XemGiaSan";
            button_XemGiaSan.Size = new Size(145, 35);
            button_XemGiaSan.TabIndex = 0;
            button_XemGiaSan.Text = "Xem giá sân";
            button_XemGiaSan.UseVisualStyleBackColor = false;
            button_XemGiaSan.Click += button_XemGiaSan_Click;
            // 
            // button_XemSanBiDat
            // 
            button_XemSanBiDat.BackColor = Color.FromArgb(175, 209, 152);
            button_XemSanBiDat.ForeColor = Color.Black;
            button_XemSanBiDat.Location = new Point(549, 26);
            button_XemSanBiDat.Name = "button_XemSanBiDat";
            button_XemSanBiDat.Size = new Size(145, 35);
            button_XemSanBiDat.TabIndex = 1;
            button_XemSanBiDat.Text = "Xem sân bị đặt";
            button_XemSanBiDat.UseVisualStyleBackColor = false;
            button_XemSanBiDat.Click += button_XemSanBiDat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-534, -551);
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
            Controls.Add(button_XemSanBiDat);
            Controls.Add(button_XemGiaSan);
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
        private Button button_XemGiaSan;
        private Button button_XemSanBiDat;
        private PictureBox pictureBox1;
    }
}