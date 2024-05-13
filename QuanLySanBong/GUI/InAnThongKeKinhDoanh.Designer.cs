namespace GUI
{
    partial class InAnThongKeKinhDoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InAnThongKeKinhDoanh));
            label_SanBongTriHai = new Label();
            label_ThongKeKinhDoanh = new Label();
            dateTimePicker_Tu = new DateTimePicker();
            label_Tu = new Label();
            label_Den = new Label();
            dateTimePicker_Den = new DateTimePicker();
            dataGridView_ThongKeKinhDoanh = new DataGridView();
            textBox_TongTien = new TextBox();
            label_TongTien = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            textBox_SoLanDatSan = new TextBox();
            label_SoLanDatSan = new Label();
            button_InThongKe = new Button();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ThongKeKinhDoanh).BeginInit();
            SuspendLayout();
            // 
            // label_SanBongTriHai
            // 
            label_SanBongTriHai.AutoSize = true;
            label_SanBongTriHai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_SanBongTriHai.Location = new Point(303, 9);
            label_SanBongTriHai.Name = "label_SanBongTriHai";
            label_SanBongTriHai.Size = new Size(191, 31);
            label_SanBongTriHai.TabIndex = 0;
            label_SanBongTriHai.Text = "Sân bóng Trí Hải";
            // 
            // label_ThongKeKinhDoanh
            // 
            label_ThongKeKinhDoanh.AutoSize = true;
            label_ThongKeKinhDoanh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_ThongKeKinhDoanh.Location = new Point(303, 58);
            label_ThongKeKinhDoanh.Name = "label_ThongKeKinhDoanh";
            label_ThongKeKinhDoanh.Size = new Size(192, 25);
            label_ThongKeKinhDoanh.TabIndex = 1;
            label_ThongKeKinhDoanh.Text = "Thống kê kinh doanh";
            // 
            // dateTimePicker_Tu
            // 
            dateTimePicker_Tu.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Tu.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Tu.Location = new Point(218, 118);
            dateTimePicker_Tu.Name = "dateTimePicker_Tu";
            dateTimePicker_Tu.Size = new Size(149, 27);
            dateTimePicker_Tu.TabIndex = 0;
            dateTimePicker_Tu.ValueChanged += dateTimePicker_Tu_ValueChanged;
            // 
            // label_Tu
            // 
            label_Tu.AutoSize = true;
            label_Tu.Location = new Point(186, 123);
            label_Tu.Name = "label_Tu";
            label_Tu.Size = new Size(26, 20);
            label_Tu.TabIndex = 4;
            label_Tu.Text = "Từ";
            // 
            // label_Den
            // 
            label_Den.AutoSize = true;
            label_Den.Location = new Point(421, 123);
            label_Den.Name = "label_Den";
            label_Den.Size = new Size(36, 20);
            label_Den.TabIndex = 5;
            label_Den.Text = "Đến";
            // 
            // dateTimePicker_Den
            // 
            dateTimePicker_Den.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Den.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Den.Location = new Point(463, 118);
            dateTimePicker_Den.Name = "dateTimePicker_Den";
            dateTimePicker_Den.Size = new Size(149, 27);
            dateTimePicker_Den.TabIndex = 1;
            dateTimePicker_Den.ValueChanged += dateTimePicker_Den_ValueChanged;
            // 
            // dataGridView_ThongKeKinhDoanh
            // 
            dataGridView_ThongKeKinhDoanh.AllowUserToAddRows = false;
            dataGridView_ThongKeKinhDoanh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Teal;
            dataGridView_ThongKeKinhDoanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_ThongKeKinhDoanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ThongKeKinhDoanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_ThongKeKinhDoanh.BackgroundColor = Color.White;
            dataGridView_ThongKeKinhDoanh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_ThongKeKinhDoanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_ThongKeKinhDoanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_ThongKeKinhDoanh.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_ThongKeKinhDoanh.Dock = DockStyle.Bottom;
            dataGridView_ThongKeKinhDoanh.GridColor = Color.White;
            dataGridView_ThongKeKinhDoanh.Location = new Point(0, 333);
            dataGridView_ThongKeKinhDoanh.Name = "dataGridView_ThongKeKinhDoanh";
            dataGridView_ThongKeKinhDoanh.ReadOnly = true;
            dataGridView_ThongKeKinhDoanh.RowHeadersWidth = 51;
            dataGridView_ThongKeKinhDoanh.Size = new Size(776, 722);
            dataGridView_ThongKeKinhDoanh.TabIndex = 17;
            // 
            // textBox_TongTien
            // 
            textBox_TongTien.Enabled = false;
            textBox_TongTien.Location = new Point(218, 172);
            textBox_TongTien.Name = "textBox_TongTien";
            textBox_TongTien.Size = new Size(394, 27);
            textBox_TongTien.TabIndex = 2;
            // 
            // label_TongTien
            // 
            label_TongTien.AutoSize = true;
            label_TongTien.Location = new Point(128, 179);
            label_TongTien.Name = "label_TongTien";
            label_TongTien.Size = new Size(72, 20);
            label_TongTien.TabIndex = 19;
            label_TongTien.Text = "Tổng tiền";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // textBox_SoLanDatSan
            // 
            textBox_SoLanDatSan.Enabled = false;
            textBox_SoLanDatSan.Location = new Point(218, 223);
            textBox_SoLanDatSan.Name = "textBox_SoLanDatSan";
            textBox_SoLanDatSan.Size = new Size(149, 27);
            textBox_SoLanDatSan.TabIndex = 3;
            // 
            // label_SoLanDatSan
            // 
            label_SoLanDatSan.AutoSize = true;
            label_SoLanDatSan.Location = new Point(110, 230);
            label_SoLanDatSan.Name = "label_SoLanDatSan";
            label_SoLanDatSan.Size = new Size(102, 20);
            label_SoLanDatSan.TabIndex = 21;
            label_SoLanDatSan.Text = "Số lần đặt sân";
            // 
            // button_InThongKe
            // 
            button_InThongKe.BackColor = Color.FromArgb(122, 178, 178);
            button_InThongKe.ForeColor = Color.Snow;
            button_InThongKe.Location = new Point(421, 223);
            button_InThongKe.Name = "button_InThongKe";
            button_InThongKe.Size = new Size(191, 32);
            button_InThongKe.TabIndex = 4;
            button_InThongKe.Text = "In thống kê";
            button_InThongKe.UseVisualStyleBackColor = false;
            button_InThongKe.Click += button_InThongKe_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // InAnThongKeKinhDoanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(776, 1055);
            Controls.Add(button_InThongKe);
            Controls.Add(label_SoLanDatSan);
            Controls.Add(textBox_SoLanDatSan);
            Controls.Add(label_TongTien);
            Controls.Add(textBox_TongTien);
            Controls.Add(dataGridView_ThongKeKinhDoanh);
            Controls.Add(dateTimePicker_Den);
            Controls.Add(label_Den);
            Controls.Add(label_Tu);
            Controls.Add(dateTimePicker_Tu);
            Controls.Add(label_ThongKeKinhDoanh);
            Controls.Add(label_SanBongTriHai);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InAnThongKeKinhDoanh";
            Text = "InAnThongKeKinhDoanh";
            ((System.ComponentModel.ISupportInitialize)dataGridView_ThongKeKinhDoanh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_SanBongTriHai;
        private Label label_ThongKeKinhDoanh;
        private DateTimePicker dateTimePicker_Tu;
        private Label label_Tu;
        private Label label_Den;
        private DateTimePicker dateTimePicker_Den;
        private DataGridView dataGridView_ThongKeKinhDoanh;
        private TextBox textBox_TongTien;
        private Label label_TongTien;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox textBox_SoLanDatSan;
        private Label label_SoLanDatSan;
        private Button button_InThongKe;
        private PrintDialog printDialog1;
    }
}