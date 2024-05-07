namespace GUI
{
    partial class TaiKhoanQuanLy
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
            label_TaiKhoanQuanLy = new Label();
            SuspendLayout();
            // 
            // label_TaiKhoanQuanLy
            // 
            label_TaiKhoanQuanLy.AutoSize = true;
            label_TaiKhoanQuanLy.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TaiKhoanQuanLy.ForeColor = SystemColors.ControlText;
            label_TaiKhoanQuanLy.Location = new Point(278, 27);
            label_TaiKhoanQuanLy.Name = "label_TaiKhoanQuanLy";
            label_TaiKhoanQuanLy.Size = new Size(263, 41);
            label_TaiKhoanQuanLy.TabIndex = 2;
            label_TaiKhoanQuanLy.Text = "Tài khoản quản lý";
            label_TaiKhoanQuanLy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaiKhoanQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 218, 200);
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(label_TaiKhoanQuanLy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiKhoanQuanLy";
            Text = "TaiKhoanQuanLy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TaiKhoanQuanLy;
    }
}