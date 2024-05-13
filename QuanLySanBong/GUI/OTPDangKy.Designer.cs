namespace GUI
{
    partial class OTPDangKy
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
            label_XacNhanOTP = new Label();
            panel_OTP = new Panel();
            label_ThongBao = new Label();
            button_XacNhanOTP = new Button();
            textBox_OTP = new TextBox();
            label_NhapMaOTP = new Label();
            button_DangKy = new Button();
            panel_OTP.SuspendLayout();
            SuspendLayout();
            // 
            // label_XacNhanOTP
            // 
            label_XacNhanOTP.AutoSize = true;
            label_XacNhanOTP.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_XacNhanOTP.ForeColor = SystemColors.ControlText;
            label_XacNhanOTP.Location = new Point(309, 24);
            label_XacNhanOTP.Name = "label_XacNhanOTP";
            label_XacNhanOTP.Size = new Size(212, 41);
            label_XacNhanOTP.TabIndex = 4;
            label_XacNhanOTP.Text = "Xác nhận OTP";
            label_XacNhanOTP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_OTP
            // 
            panel_OTP.BorderStyle = BorderStyle.FixedSingle;
            panel_OTP.Controls.Add(label_ThongBao);
            panel_OTP.Controls.Add(button_XacNhanOTP);
            panel_OTP.Controls.Add(textBox_OTP);
            panel_OTP.Controls.Add(label_NhapMaOTP);
            panel_OTP.Location = new Point(190, 140);
            panel_OTP.Name = "panel_OTP";
            panel_OTP.Size = new Size(456, 213);
            panel_OTP.TabIndex = 8;
            // 
            // label_ThongBao
            // 
            label_ThongBao.ForeColor = Color.DarkCyan;
            label_ThongBao.Location = new Point(19, 18);
            label_ThongBao.Name = "label_ThongBao";
            label_ThongBao.Size = new Size(413, 20);
            label_ThongBao.TabIndex = 25;
            label_ThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_XacNhanOTP
            // 
            button_XacNhanOTP.BackColor = Color.FromArgb(175, 209, 152);
            button_XacNhanOTP.Location = new Point(19, 120);
            button_XacNhanOTP.Name = "button_XacNhanOTP";
            button_XacNhanOTP.Size = new Size(413, 43);
            button_XacNhanOTP.TabIndex = 1;
            button_XacNhanOTP.Text = "Xác nhận OTP";
            button_XacNhanOTP.UseVisualStyleBackColor = false;
            button_XacNhanOTP.Click += button_XacNhanOTP_Click;
            // 
            // textBox_OTP
            // 
            textBox_OTP.Location = new Point(301, 66);
            textBox_OTP.Name = "textBox_OTP";
            textBox_OTP.Size = new Size(131, 27);
            textBox_OTP.TabIndex = 0;
            // 
            // label_NhapMaOTP
            // 
            label_NhapMaOTP.AutoSize = true;
            label_NhapMaOTP.Location = new Point(19, 66);
            label_NhapMaOTP.Name = "label_NhapMaOTP";
            label_NhapMaOTP.Size = new Size(276, 20);
            label_NhapMaOTP.TabIndex = 24;
            label_NhapMaOTP.Text = "Nhập mã OTP 6 chữ số đã gửi qua Email";
            // 
            // button_DangKy
            // 
            button_DangKy.Location = new Point(12, 22);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(131, 43);
            button_DangKy.TabIndex = 9;
            button_DangKy.Text = "Quay về đăng ký";
            button_DangKy.UseVisualStyleBackColor = true;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // OTPDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 230);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(button_DangKy);
            Controls.Add(panel_OTP);
            Controls.Add(label_XacNhanOTP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OTPDangKy";
            panel_OTP.ResumeLayout(false);
            panel_OTP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_XacNhanOTP;
        private Panel panel_OTP;
        private Label label_ThongBao;
        private Button button_XacNhanOTP;
        private TextBox textBox_OTP;
        private Label label_NhapMaOTP;
        private Button button_DangKy;
    }
}