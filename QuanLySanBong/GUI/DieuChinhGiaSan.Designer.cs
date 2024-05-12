namespace GUI
{
    partial class DieuChinhGiaSan
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
            label_DieuChinhGiaSan = new Label();
            groupBox_DanhSachSanBong = new GroupBox();
            dataGridView_DanhSachSanBong = new DataGridView();
            groupBox_ThongTinSanBong = new GroupBox();
            button_CapNhatGiaSan = new Button();
            textBox_GiaSanTrenPhut = new TextBox();
            label_GiaSanTrenPhut = new Label();
            textBox_Ma = new TextBox();
            label_MaSan = new Label();
            textBox_Ten = new TextBox();
            label_TenSan = new Label();
            groupBox_DanhSachSanBong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachSanBong).BeginInit();
            groupBox_ThongTinSanBong.SuspendLayout();
            SuspendLayout();
            // 
            // label_DieuChinhGiaSan
            // 
            label_DieuChinhGiaSan.AutoSize = true;
            label_DieuChinhGiaSan.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DieuChinhGiaSan.ForeColor = SystemColors.ControlText;
            label_DieuChinhGiaSan.Location = new Point(390, 9);
            label_DieuChinhGiaSan.Name = "label_DieuChinhGiaSan";
            label_DieuChinhGiaSan.Size = new Size(273, 41);
            label_DieuChinhGiaSan.TabIndex = 5;
            label_DieuChinhGiaSan.Text = "Điều chỉnh giá sân";
            label_DieuChinhGiaSan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_DanhSachSanBong
            // 
            groupBox_DanhSachSanBong.Controls.Add(dataGridView_DanhSachSanBong);
            groupBox_DanhSachSanBong.Dock = DockStyle.Bottom;
            groupBox_DanhSachSanBong.Location = new Point(0, 274);
            groupBox_DanhSachSanBong.Name = "groupBox_DanhSachSanBong";
            groupBox_DanhSachSanBong.Size = new Size(1062, 399);
            groupBox_DanhSachSanBong.TabIndex = 21;
            groupBox_DanhSachSanBong.TabStop = false;
            groupBox_DanhSachSanBong.Text = "Danh sách sân bóng";
            // 
            // dataGridView_DanhSachSanBong
            // 
            dataGridView_DanhSachSanBong.AllowUserToAddRows = false;
            dataGridView_DanhSachSanBong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Teal;
            dataGridView_DanhSachSanBong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DanhSachSanBong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DanhSachSanBong.BackgroundColor = Color.White;
            dataGridView_DanhSachSanBong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_DanhSachSanBong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DanhSachSanBong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Calibri", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_DanhSachSanBong.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DanhSachSanBong.Dock = DockStyle.Fill;
            dataGridView_DanhSachSanBong.GridColor = Color.White;
            dataGridView_DanhSachSanBong.Location = new Point(3, 23);
            dataGridView_DanhSachSanBong.Name = "dataGridView_DanhSachSanBong";
            dataGridView_DanhSachSanBong.ReadOnly = true;
            dataGridView_DanhSachSanBong.RowHeadersWidth = 51;
            dataGridView_DanhSachSanBong.Size = new Size(1056, 373);
            dataGridView_DanhSachSanBong.TabIndex = 16;
            dataGridView_DanhSachSanBong.CellClick += dataGridView_DanhSachSanBong_CellClick;
            // 
            // groupBox_ThongTinSanBong
            // 
            groupBox_ThongTinSanBong.Controls.Add(button_CapNhatGiaSan);
            groupBox_ThongTinSanBong.Controls.Add(textBox_GiaSanTrenPhut);
            groupBox_ThongTinSanBong.Controls.Add(label_GiaSanTrenPhut);
            groupBox_ThongTinSanBong.Controls.Add(textBox_Ma);
            groupBox_ThongTinSanBong.Controls.Add(label_MaSan);
            groupBox_ThongTinSanBong.Controls.Add(textBox_Ten);
            groupBox_ThongTinSanBong.Controls.Add(label_TenSan);
            groupBox_ThongTinSanBong.Location = new Point(148, 80);
            groupBox_ThongTinSanBong.Name = "groupBox_ThongTinSanBong";
            groupBox_ThongTinSanBong.Size = new Size(766, 177);
            groupBox_ThongTinSanBong.TabIndex = 20;
            groupBox_ThongTinSanBong.TabStop = false;
            groupBox_ThongTinSanBong.Text = "Thông tin sân bóng";
            // 
            // button_CapNhatGiaSan
            // 
            button_CapNhatGiaSan.BackColor = Color.FromArgb(122, 178, 178);
            button_CapNhatGiaSan.Enabled = false;
            button_CapNhatGiaSan.ForeColor = Color.Snow;
            button_CapNhatGiaSan.Location = new Point(396, 109);
            button_CapNhatGiaSan.Name = "button_CapNhatGiaSan";
            button_CapNhatGiaSan.Size = new Size(310, 30);
            button_CapNhatGiaSan.TabIndex = 28;
            button_CapNhatGiaSan.Text = "Cập nhật giá sân";
            button_CapNhatGiaSan.UseVisualStyleBackColor = false;
            button_CapNhatGiaSan.Click += button_CapNhatGiaSan_Click;
            // 
            // textBox_GiaSanTrenPhut
            // 
            textBox_GiaSanTrenPhut.Location = new Point(545, 47);
            textBox_GiaSanTrenPhut.Name = "textBox_GiaSanTrenPhut";
            textBox_GiaSanTrenPhut.PlaceholderText = "Giá sân/phút";
            textBox_GiaSanTrenPhut.Size = new Size(161, 27);
            textBox_GiaSanTrenPhut.TabIndex = 20;
            // 
            // label_GiaSanTrenPhut
            // 
            label_GiaSanTrenPhut.AutoSize = true;
            label_GiaSanTrenPhut.Location = new Point(396, 50);
            label_GiaSanTrenPhut.Name = "label_GiaSanTrenPhut";
            label_GiaSanTrenPhut.Size = new Size(133, 20);
            label_GiaSanTrenPhut.TabIndex = 19;
            label_GiaSanTrenPhut.Text = "Giá sân trên 1 phút";
            // 
            // textBox_Ma
            // 
            textBox_Ma.Enabled = false;
            textBox_Ma.Location = new Point(148, 47);
            textBox_Ma.Name = "textBox_Ma";
            textBox_Ma.Size = new Size(197, 27);
            textBox_Ma.TabIndex = 18;
            // 
            // label_MaSan
            // 
            label_MaSan.AutoSize = true;
            label_MaSan.Enabled = false;
            label_MaSan.Location = new Point(50, 54);
            label_MaSan.Name = "label_MaSan";
            label_MaSan.Size = new Size(56, 20);
            label_MaSan.TabIndex = 17;
            label_MaSan.Text = "Mã sân";
            // 
            // textBox_Ten
            // 
            textBox_Ten.Enabled = false;
            textBox_Ten.Location = new Point(148, 112);
            textBox_Ten.Name = "textBox_Ten";
            textBox_Ten.Size = new Size(197, 27);
            textBox_Ten.TabIndex = 14;
            // 
            // label_TenSan
            // 
            label_TenSan.AutoSize = true;
            label_TenSan.Enabled = false;
            label_TenSan.Location = new Point(50, 119);
            label_TenSan.Name = "label_TenSan";
            label_TenSan.Size = new Size(58, 20);
            label_TenSan.TabIndex = 11;
            label_TenSan.Text = "Tên sân";
            // 
            // DieuChinhGiaSan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1062, 673);
            Controls.Add(groupBox_ThongTinSanBong);
            Controls.Add(groupBox_DanhSachSanBong);
            Controls.Add(label_DieuChinhGiaSan);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DieuChinhGiaSan";
            Text = "DieuChinhGiaSan";
            Load += DieuChinhGiaSan_Load;
            groupBox_DanhSachSanBong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DanhSachSanBong).EndInit();
            groupBox_ThongTinSanBong.ResumeLayout(false);
            groupBox_ThongTinSanBong.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_DieuChinhGiaSan;
        private GroupBox groupBox_DanhSachSanBong;
        private DataGridView dataGridView_DanhSachSanBong;
        private GroupBox groupBox_ThongTinSanBong;
        private ComboBox comboBox_ToanQuyen;
        private Label label_ToanQuyen;
        private TextBox textBox_GiaSanTrenPhut;
        private Label label_GiaSanTrenPhut;
        private TextBox textBox_Ma;
        private Label label_MaSan;
        private TextBox textBox_Ten;
        private Label label_TenSan;
        private Button button_CapNhatGiaSan;
    }
}