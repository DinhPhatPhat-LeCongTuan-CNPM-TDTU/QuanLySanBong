namespace GUI
{
    partial class DatSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatSan));
            label_DatSan = new Label();
            groupBox_DatSan = new GroupBox();
            comboBox1 = new ComboBox();
            label_GioDa = new Label();
            comboBox3 = new ComboBox();
            label_ChonSan = new Label();
            button_KhungGioDaBiDat = new Button();
            comboBox_LoaiSan = new ComboBox();
            label_LoaiSan = new Label();
            comboBox_DaTrong = new ComboBox();
            label_DaTrong = new Label();
            dateTimePicker_NgayDa = new DateTimePicker();
            label_NgayDa = new Label();
            pictureBox_DaBong = new PictureBox();
            pictureBox1 = new PictureBox();
            button_DatSan = new Button();
            label_ThongBao = new Label();
            groupBox_DatSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DaBong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_DatSan
            // 
            label_DatSan.AutoSize = true;
            label_DatSan.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DatSan.ForeColor = SystemColors.ButtonFace;
            label_DatSan.Location = new Point(354, 26);
            label_DatSan.Name = "label_DatSan";
            label_DatSan.Size = new Size(126, 41);
            label_DatSan.TabIndex = 4;
            label_DatSan.Text = "Đặt sân";
            label_DatSan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_DatSan
            // 
            groupBox_DatSan.BackColor = Color.Transparent;
            groupBox_DatSan.Controls.Add(label_ThongBao);
            groupBox_DatSan.Controls.Add(button_DatSan);
            groupBox_DatSan.Controls.Add(comboBox1);
            groupBox_DatSan.Controls.Add(label_GioDa);
            groupBox_DatSan.Controls.Add(comboBox3);
            groupBox_DatSan.Controls.Add(label_ChonSan);
            groupBox_DatSan.Controls.Add(button_KhungGioDaBiDat);
            groupBox_DatSan.Controls.Add(comboBox_LoaiSan);
            groupBox_DatSan.Controls.Add(label_LoaiSan);
            groupBox_DatSan.Controls.Add(comboBox_DaTrong);
            groupBox_DatSan.Controls.Add(label_DaTrong);
            groupBox_DatSan.Controls.Add(dateTimePicker_NgayDa);
            groupBox_DatSan.Controls.Add(label_NgayDa);
            groupBox_DatSan.Controls.Add(pictureBox1);
            groupBox_DatSan.Location = new Point(291, 104);
            groupBox_DatSan.Name = "groupBox_DatSan";
            groupBox_DatSan.Size = new Size(495, 442);
            groupBox_DatSan.TabIndex = 5;
            groupBox_DatSan.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
            comboBox1.Location = new Point(164, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 7;
            // 
            // label_GioDa
            // 
            label_GioDa.AutoSize = true;
            label_GioDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_GioDa.ForeColor = Color.White;
            label_GioDa.Location = new Point(52, 148);
            label_GioDa.Name = "label_GioDa";
            label_GioDa.Size = new Size(70, 28);
            label_GioDa.TabIndex = 8;
            label_GioDa.Text = "Giờ đá";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(164, 241);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(125, 28);
            comboBox3.TabIndex = 6;
            // 
            // label_ChonSan
            // 
            label_ChonSan.AutoSize = true;
            label_ChonSan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ChonSan.ForeColor = Color.White;
            label_ChonSan.Location = new Point(52, 241);
            label_ChonSan.Name = "label_ChonSan";
            label_ChonSan.Size = new Size(92, 28);
            label_ChonSan.TabIndex = 5;
            label_ChonSan.Text = "Chọn sân";
            // 
            // button_KhungGioDaBiDat
            // 
            button_KhungGioDaBiDat.Location = new Point(327, 54);
            button_KhungGioDaBiDat.Name = "button_KhungGioDaBiDat";
            button_KhungGioDaBiDat.Size = new Size(118, 76);
            button_KhungGioDaBiDat.TabIndex = 4;
            button_KhungGioDaBiDat.Text = "Xem khung giờ đã bị đặt";
            button_KhungGioDaBiDat.UseVisualStyleBackColor = true;
            // 
            // comboBox_LoaiSan
            // 
            comboBox_LoaiSan.FormattingEnabled = true;
            comboBox_LoaiSan.Items.AddRange(new object[] { "Sân 5vs5", "Sân 7vs7", "Sân 11vs11" });
            comboBox_LoaiSan.Location = new Point(164, 54);
            comboBox_LoaiSan.Name = "comboBox_LoaiSan";
            comboBox_LoaiSan.Size = new Size(125, 28);
            comboBox_LoaiSan.TabIndex = 1;
            // 
            // label_LoaiSan
            // 
            label_LoaiSan.AutoSize = true;
            label_LoaiSan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_LoaiSan.ForeColor = Color.White;
            label_LoaiSan.Location = new Point(52, 54);
            label_LoaiSan.Name = "label_LoaiSan";
            label_LoaiSan.Size = new Size(82, 28);
            label_LoaiSan.TabIndex = 3;
            label_LoaiSan.Text = "Loại sân";
            // 
            // comboBox_DaTrong
            // 
            comboBox_DaTrong.FormattingEnabled = true;
            comboBox_DaTrong.Items.AddRange(new object[] { "30 phút", "60 phút", "90 phút" });
            comboBox_DaTrong.Location = new Point(164, 192);
            comboBox_DaTrong.Name = "comboBox_DaTrong";
            comboBox_DaTrong.Size = new Size(125, 28);
            comboBox_DaTrong.TabIndex = 2;
            // 
            // label_DaTrong
            // 
            label_DaTrong.AutoSize = true;
            label_DaTrong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_DaTrong.ForeColor = Color.White;
            label_DaTrong.Location = new Point(52, 192);
            label_DaTrong.Name = "label_DaTrong";
            label_DaTrong.Size = new Size(90, 28);
            label_DaTrong.TabIndex = 2;
            label_DaTrong.Text = "Đá trong";
            // 
            // dateTimePicker_NgayDa
            // 
            dateTimePicker_NgayDa.Format = DateTimePickerFormat.Short;
            dateTimePicker_NgayDa.Location = new Point(164, 103);
            dateTimePicker_NgayDa.Name = "dateTimePicker_NgayDa";
            dateTimePicker_NgayDa.Size = new Size(125, 27);
            dateTimePicker_NgayDa.TabIndex = 1;
            // 
            // label_NgayDa
            // 
            label_NgayDa.AutoSize = true;
            label_NgayDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_NgayDa.ForeColor = Color.White;
            label_NgayDa.Location = new Point(52, 102);
            label_NgayDa.Name = "label_NgayDa";
            label_NgayDa.Size = new Size(86, 28);
            label_NgayDa.TabIndex = 0;
            label_NgayDa.Text = "Ngày đá";
            // 
            // pictureBox_DaBong
            // 
            pictureBox_DaBong.Image = (Image)resources.GetObject("pictureBox_DaBong.Image");
            pictureBox_DaBong.Location = new Point(53, 115);
            pictureBox_DaBong.Name = "pictureBox_DaBong";
            pictureBox_DaBong.Size = new Size(221, 431);
            pictureBox_DaBong.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DaBong.TabIndex = 6;
            pictureBox_DaBong.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button_DatSan
            // 
            button_DatSan.BackColor = Color.FromArgb(26, 77, 46);
            button_DatSan.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_DatSan.ForeColor = Color.Snow;
            button_DatSan.Location = new Point(46, 302);
            button_DatSan.Name = "button_DatSan";
            button_DatSan.Size = new Size(391, 65);
            button_DatSan.TabIndex = 9;
            button_DatSan.Text = "Đặt sân";
            button_DatSan.UseVisualStyleBackColor = false;
            // 
            // label_ThongBao
            // 
            label_ThongBao.ForeColor = Color.Red;
            label_ThongBao.Location = new Point(46, 401);
            label_ThongBao.Name = "label_ThongBao";
            label_ThongBao.Size = new Size(391, 25);
            label_ThongBao.TabIndex = 10;
            label_ThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DatSan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 111, 82);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(pictureBox_DaBong);
            Controls.Add(groupBox_DatSan);
            Controls.Add(label_DatSan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatSan";
            Text = "DatSan";
            groupBox_DatSan.ResumeLayout(false);
            groupBox_DatSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DaBong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_DatSan;
        private GroupBox groupBox_DatSan;
        private Label label_DaTrong;
        private DateTimePicker dateTimePicker_NgayDa;
        private Label label_NgayDa;
        private ComboBox comboBox_LoaiSan;
        private Label label_LoaiSan;
        private ComboBox comboBox_DaTrong;
        private Label label_ChonSan;
        private Button button_KhungGioDaBiDat;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label label_GioDa;
        private PictureBox pictureBox_DaBong;
        private PictureBox pictureBox1;
        private Label label_ThongBao;
        private Button button_DatSan;
    }
}