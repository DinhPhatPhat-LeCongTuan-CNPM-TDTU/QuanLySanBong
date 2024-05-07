namespace GUI
{
    partial class Software
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Software));
            panel_Top = new Panel();
            label_Top = new Label();
            pictureBox_Menu = new PictureBox();
            flowLayoutPanel_Left = new FlowLayoutPanel();
            panel_TrangChu = new Panel();
            button_TrangChu = new Button();
            pictureBox_TrangChu = new PictureBox();
            panel_DatSan = new Panel();
            button_DatSan = new Button();
            pictureBox_DatSan = new PictureBox();
            panel_TaiKhoan = new Panel();
            button_TaiKhoan = new Button();
            pictureBox_TaiKhoan = new PictureBox();
            panel_HuongDanSuDung = new Panel();
            button_HuongDanSuDung = new Button();
            pictureBox_HuongDanSuDung = new PictureBox();
            panel_Container = new Panel();
            panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).BeginInit();
            flowLayoutPanel_Left.SuspendLayout();
            panel_TrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TrangChu).BeginInit();
            panel_DatSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DatSan).BeginInit();
            panel_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TaiKhoan).BeginInit();
            panel_HuongDanSuDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_HuongDanSuDung).BeginInit();
            SuspendLayout();
            // 
            // panel_Top
            // 
            panel_Top.BackColor = Color.FromArgb(79, 111, 82);
            panel_Top.Controls.Add(label_Top);
            panel_Top.Controls.Add(pictureBox_Menu);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(0, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(1062, 49);
            panel_Top.TabIndex = 1;
            // 
            // label_Top
            // 
            label_Top.AutoSize = true;
            label_Top.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Top.Location = new Point(71, 9);
            label_Top.Name = "label_Top";
            label_Top.Size = new Size(202, 28);
            label_Top.TabIndex = 1;
            label_Top.Text = "MY FOOTBALL FIELD";
            // 
            // pictureBox_Menu
            // 
            pictureBox_Menu.Image = (Image)resources.GetObject("pictureBox_Menu.Image");
            pictureBox_Menu.InitialImage = (Image)resources.GetObject("pictureBox_Menu.InitialImage");
            pictureBox_Menu.Location = new Point(12, 3);
            pictureBox_Menu.Name = "pictureBox_Menu";
            pictureBox_Menu.Size = new Size(39, 41);
            pictureBox_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Menu.TabIndex = 0;
            pictureBox_Menu.TabStop = false;
            // 
            // flowLayoutPanel_Left
            // 
            flowLayoutPanel_Left.BackColor = Color.FromArgb(232, 223, 202);
            flowLayoutPanel_Left.Controls.Add(panel_TrangChu);
            flowLayoutPanel_Left.Controls.Add(panel_DatSan);
            flowLayoutPanel_Left.Controls.Add(panel_TaiKhoan);
            flowLayoutPanel_Left.Controls.Add(panel_HuongDanSuDung);
            flowLayoutPanel_Left.Dock = DockStyle.Left;
            flowLayoutPanel_Left.Location = new Point(0, 49);
            flowLayoutPanel_Left.Name = "flowLayoutPanel_Left";
            flowLayoutPanel_Left.Size = new Size(213, 624);
            flowLayoutPanel_Left.TabIndex = 2;
            // 
            // panel_TrangChu
            // 
            panel_TrangChu.BackColor = Color.FromArgb(79, 111, 82);
            panel_TrangChu.Controls.Add(button_TrangChu);
            panel_TrangChu.Controls.Add(pictureBox_TrangChu);
            panel_TrangChu.Location = new Point(3, 3);
            panel_TrangChu.Name = "panel_TrangChu";
            panel_TrangChu.Size = new Size(206, 47);
            panel_TrangChu.TabIndex = 10;
            // 
            // button_TrangChu
            // 
            button_TrangChu.BackColor = Color.Transparent;
            button_TrangChu.BackgroundImage = (Image)resources.GetObject("button_TrangChu.BackgroundImage");
            button_TrangChu.FlatStyle = FlatStyle.Flat;
            button_TrangChu.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TrangChu.ForeColor = Color.White;
            button_TrangChu.Location = new Point(65, 0);
            button_TrangChu.Name = "button_TrangChu";
            button_TrangChu.Size = new Size(141, 47);
            button_TrangChu.TabIndex = 5;
            button_TrangChu.Text = "Trang Chủ";
            button_TrangChu.UseVisualStyleBackColor = false;
            button_TrangChu.Click += button_TrangChu_Click;
            button_TrangChu.MouseEnter += button_TrangChu_MouseEnter;
            button_TrangChu.MouseLeave += button_TrangChu_MouseLeave;
            // 
            // pictureBox_TrangChu
            // 
            pictureBox_TrangChu.Image = (Image)resources.GetObject("pictureBox_TrangChu.Image");
            pictureBox_TrangChu.Location = new Point(0, 0);
            pictureBox_TrangChu.Name = "pictureBox_TrangChu";
            pictureBox_TrangChu.Size = new Size(68, 47);
            pictureBox_TrangChu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_TrangChu.TabIndex = 9;
            pictureBox_TrangChu.TabStop = false;
            // 
            // panel_DatSan
            // 
            panel_DatSan.BackColor = Color.FromArgb(79, 111, 82);
            panel_DatSan.Controls.Add(button_DatSan);
            panel_DatSan.Controls.Add(pictureBox_DatSan);
            panel_DatSan.Location = new Point(3, 56);
            panel_DatSan.Name = "panel_DatSan";
            panel_DatSan.Size = new Size(206, 47);
            panel_DatSan.TabIndex = 11;
            // 
            // button_DatSan
            // 
            button_DatSan.BackColor = Color.Transparent;
            button_DatSan.FlatStyle = FlatStyle.Flat;
            button_DatSan.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_DatSan.ForeColor = Color.White;
            button_DatSan.Location = new Point(65, 0);
            button_DatSan.Name = "button_DatSan";
            button_DatSan.Size = new Size(141, 47);
            button_DatSan.TabIndex = 5;
            button_DatSan.Text = "Đặt Sân";
            button_DatSan.UseVisualStyleBackColor = false;
            button_DatSan.Click += button_DatSan_Click;
            button_DatSan.MouseEnter += button_TrangChu_MouseEnter;
            button_DatSan.MouseLeave += button_TrangChu_MouseLeave;
            // 
            // pictureBox_DatSan
            // 
            pictureBox_DatSan.Image = (Image)resources.GetObject("pictureBox_DatSan.Image");
            pictureBox_DatSan.Location = new Point(0, 0);
            pictureBox_DatSan.Name = "pictureBox_DatSan";
            pictureBox_DatSan.Size = new Size(68, 47);
            pictureBox_DatSan.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_DatSan.TabIndex = 9;
            pictureBox_DatSan.TabStop = false;
            // 
            // panel_TaiKhoan
            // 
            panel_TaiKhoan.BackColor = Color.FromArgb(79, 111, 82);
            panel_TaiKhoan.Controls.Add(button_TaiKhoan);
            panel_TaiKhoan.Controls.Add(pictureBox_TaiKhoan);
            panel_TaiKhoan.Location = new Point(3, 109);
            panel_TaiKhoan.Name = "panel_TaiKhoan";
            panel_TaiKhoan.Size = new Size(206, 47);
            panel_TaiKhoan.TabIndex = 12;
            // 
            // button_TaiKhoan
            // 
            button_TaiKhoan.BackColor = Color.Transparent;
            button_TaiKhoan.FlatStyle = FlatStyle.Flat;
            button_TaiKhoan.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TaiKhoan.ForeColor = Color.White;
            button_TaiKhoan.Location = new Point(65, 0);
            button_TaiKhoan.Name = "button_TaiKhoan";
            button_TaiKhoan.Size = new Size(141, 47);
            button_TaiKhoan.TabIndex = 5;
            button_TaiKhoan.Text = "Tài Khoản";
            button_TaiKhoan.UseVisualStyleBackColor = false;
            button_TaiKhoan.Click += button_TaiKhoan_Click;
            button_TaiKhoan.MouseEnter += button_TrangChu_MouseEnter;
            button_TaiKhoan.MouseLeave += button_TrangChu_MouseLeave;
            // 
            // pictureBox_TaiKhoan
            // 
            pictureBox_TaiKhoan.Image = (Image)resources.GetObject("pictureBox_TaiKhoan.Image");
            pictureBox_TaiKhoan.Location = new Point(0, 0);
            pictureBox_TaiKhoan.Name = "pictureBox_TaiKhoan";
            pictureBox_TaiKhoan.Size = new Size(68, 47);
            pictureBox_TaiKhoan.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_TaiKhoan.TabIndex = 9;
            pictureBox_TaiKhoan.TabStop = false;
            // 
            // panel_HuongDanSuDung
            // 
            panel_HuongDanSuDung.BackColor = Color.FromArgb(79, 111, 82);
            panel_HuongDanSuDung.Controls.Add(button_HuongDanSuDung);
            panel_HuongDanSuDung.Controls.Add(pictureBox_HuongDanSuDung);
            panel_HuongDanSuDung.Location = new Point(3, 162);
            panel_HuongDanSuDung.Name = "panel_HuongDanSuDung";
            panel_HuongDanSuDung.Size = new Size(206, 47);
            panel_HuongDanSuDung.TabIndex = 13;
            // 
            // button_HuongDanSuDung
            // 
            button_HuongDanSuDung.BackColor = Color.Transparent;
            button_HuongDanSuDung.FlatStyle = FlatStyle.Flat;
            button_HuongDanSuDung.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_HuongDanSuDung.ForeColor = Color.White;
            button_HuongDanSuDung.Location = new Point(65, 0);
            button_HuongDanSuDung.Name = "button_HuongDanSuDung";
            button_HuongDanSuDung.Size = new Size(141, 47);
            button_HuongDanSuDung.TabIndex = 5;
            button_HuongDanSuDung.Text = "Hướng Dẫn Sử Dụng";
            button_HuongDanSuDung.UseVisualStyleBackColor = false;
            button_HuongDanSuDung.MouseEnter += button_TrangChu_MouseEnter;
            button_HuongDanSuDung.MouseLeave += button_TrangChu_MouseLeave;
            // 
            // pictureBox_HuongDanSuDung
            // 
            pictureBox_HuongDanSuDung.Image = (Image)resources.GetObject("pictureBox_HuongDanSuDung.Image");
            pictureBox_HuongDanSuDung.Location = new Point(0, 0);
            pictureBox_HuongDanSuDung.Name = "pictureBox_HuongDanSuDung";
            pictureBox_HuongDanSuDung.Size = new Size(68, 47);
            pictureBox_HuongDanSuDung.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_HuongDanSuDung.TabIndex = 9;
            pictureBox_HuongDanSuDung.TabStop = false;
            // 
            // panel_Container
            // 
            panel_Container.Location = new Point(215, 49);
            panel_Container.Name = "panel_Container";
            panel_Container.Size = new Size(850, 625);
            panel_Container.TabIndex = 3;
            // 
            // Software
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(panel_Container);
            Controls.Add(flowLayoutPanel_Left);
            Controls.Add(panel_Top);
            MinimumSize = new Size(1080, 720);
            Name = "Software";
            Text = "My Football Field- Quản lý sân bóng";
            SizeChanged += Software_SizeChanged;
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).EndInit();
            flowLayoutPanel_Left.ResumeLayout(false);
            panel_TrangChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_TrangChu).EndInit();
            panel_DatSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_DatSan).EndInit();
            panel_TaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_TaiKhoan).EndInit();
            panel_HuongDanSuDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_HuongDanSuDung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_DangNhap;
        private Panel panel_Top;
        private PictureBox pictureBox_Menu;
        private Label label_Top;
        private FlowLayoutPanel flowLayoutPanel_Left;
        private Panel panel_TrangChu;
        private Button button_TrangChu;
        private PictureBox pictureBox_TrangChu;
        private Panel panel_DatSan;
        private Button button_DatSan;
        private PictureBox pictureBox_DatSan;
        private Panel panel_TaiKhoan;
        private Button button_TaiKhoan;
        private PictureBox pictureBox_TaiKhoan;
        private Panel panel_HuongDanSuDung;
        private Button button_HuongDanSuDung;
        private PictureBox pictureBox_HuongDanSuDung;
        public Panel panel_Container;
    }
}
