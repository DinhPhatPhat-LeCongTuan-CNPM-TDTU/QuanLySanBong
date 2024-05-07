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
            label_TaiKhoanKhachHang = new Label();
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
            // TaiKhoanKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 213);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(label_TaiKhoanKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiKhoanKhachHang";
            Text = "TaiKhoanKhachHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TaiKhoanKhachHang;
    }
}