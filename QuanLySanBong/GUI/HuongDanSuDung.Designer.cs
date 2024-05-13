namespace GUI
{
    partial class HuongDanSuDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuongDanSuDung));
            label_HuongDanSuDung = new Label();
            richTextBox_HuongDanSuDung = new RichTextBox();
            SuspendLayout();
            // 
            // label_HuongDanSuDung
            // 
            label_HuongDanSuDung.AutoSize = true;
            label_HuongDanSuDung.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HuongDanSuDung.ForeColor = SystemColors.ControlText;
            label_HuongDanSuDung.Location = new Point(273, 9);
            label_HuongDanSuDung.Name = "label_HuongDanSuDung";
            label_HuongDanSuDung.Size = new Size(300, 41);
            label_HuongDanSuDung.TabIndex = 2;
            label_HuongDanSuDung.Text = "Hướng dẫn sử dụng";
            label_HuongDanSuDung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox_HuongDanSuDung
            // 
            richTextBox_HuongDanSuDung.Enabled = false;
            richTextBox_HuongDanSuDung.Location = new Point(68, 68);
            richTextBox_HuongDanSuDung.Name = "richTextBox_HuongDanSuDung";
            richTextBox_HuongDanSuDung.Size = new Size(712, 545);
            richTextBox_HuongDanSuDung.TabIndex = 3;
            richTextBox_HuongDanSuDung.Text = resources.GetString("richTextBox_HuongDanSuDung.Text");
            // 
            // HuongDanSuDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 625);
            ControlBox = false;
            Controls.Add(richTextBox_HuongDanSuDung);
            Controls.Add(label_HuongDanSuDung);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HuongDanSuDung";
            Text = "HuongDanSuDung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_HuongDanSuDung;
        private RichTextBox richTextBox_HuongDanSuDung;
    }
}