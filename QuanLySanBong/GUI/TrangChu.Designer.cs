namespace GUI
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel1 = new Panel();
            groupBox_ThongTinSan = new GroupBox();
            label_GioThieu1 = new Label();
            label_Quote = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox_San1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox_ThongTinSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_San1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(245, 239, 230);
            panel1.Controls.Add(groupBox_ThongTinSan);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox_San1);
            panel1.Location = new Point(1, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 547);
            panel1.TabIndex = 4;
            // 
            // groupBox_ThongTinSan
            // 
            groupBox_ThongTinSan.BackgroundImageLayout = ImageLayout.None;
            groupBox_ThongTinSan.Controls.Add(label_GioThieu1);
            groupBox_ThongTinSan.Controls.Add(label_Quote);
            groupBox_ThongTinSan.Controls.Add(label1);
            groupBox_ThongTinSan.FlatStyle = FlatStyle.System;
            groupBox_ThongTinSan.Location = new Point(3, 3);
            groupBox_ThongTinSan.Name = "groupBox_ThongTinSan";
            groupBox_ThongTinSan.Size = new Size(493, 341);
            groupBox_ThongTinSan.TabIndex = 8;
            groupBox_ThongTinSan.TabStop = false;
            groupBox_ThongTinSan.Text = "Thông tin";
            // 
            // label_GioThieu1
            // 
            label_GioThieu1.BackColor = Color.FromArgb(79, 111, 82);
            label_GioThieu1.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_GioThieu1.ForeColor = Color.White;
            label_GioThieu1.Location = new Point(16, 36);
            label_GioThieu1.Name = "label_GioThieu1";
            label_GioThieu1.Size = new Size(470, 35);
            label_GioThieu1.TabIndex = 1;
            label_GioThieu1.Text = "204A Mai Chí Thọ, An Phú, Quận 2, TP Hồ Chí Minh ";
            label_GioThieu1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Quote
            // 
            label_Quote.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_Quote.ForeColor = Color.FromArgb(79, 111, 82);
            label_Quote.Location = new Point(16, 98);
            label_Quote.Name = "label_Quote";
            label_Quote.Size = new Size(470, 120);
            label_Quote.TabIndex = 2;
            label_Quote.Text = "\"Thi đấu giao hữu khi ông mặt trời đã đi ngủ.\r\nTập luyện siêng năng khi ông vẫn chưa dậy.\"\r\n\r\nSân mở cửa 24/24\r\n";
            label_Quote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(79, 111, 82);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 239, 230);
            label1.Location = new Point(16, 233);
            label1.Name = "label1";
            label1.Size = new Size(470, 82);
            label1.TabIndex = 3;
            label1.Text = "-12 sân 5vs5\r\n-4 sân 7vs7\r\n-1 sân 11vs11\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox_San1
            // 
            pictureBox_San1.Image = (Image)resources.GetObject("pictureBox_San1.Image");
            pictureBox_San1.Location = new Point(519, 3);
            pictureBox_San1.Name = "pictureBox_San1";
            pictureBox_San1.Size = new Size(307, 341);
            pictureBox_San1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_San1.TabIndex = 0;
            pictureBox_San1.TabStop = false;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 230);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrangChu";
            Text = "TrangChu";
            panel1.ResumeLayout(false);
            groupBox_ThongTinSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_San1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label_GioThieu1;
        private PictureBox pictureBox_San1;
        private Label label1;
        private Label label_Quote;
        private PictureBox pictureBox1;
        private GroupBox groupBox_ThongTinSan;
    }
}