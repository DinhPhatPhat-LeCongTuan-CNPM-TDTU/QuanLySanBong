using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InAnThongKeKinhDoanh : Form
    {
        public InAnThongKeKinhDoanh()
        {
            InitializeComponent();
            FillDataGridView();
        }

        public void FillDataGridView()
        {
            DateTime tu = dateTimePicker_Tu.Value;
            DateTime den = dateTimePicker_Den.Value;
            DataTable dt = PhieuDatSan_BLL.ThongKeKinhDoanh(tu, den);
            dataGridView_ThongKeKinhDoanh.DataSource = dt;
            dataGridView_ThongKeKinhDoanh.Show();
            textBox_TongTien.Text = TongTien(dt).ToString();
            textBox_SoLanDatSan.Text = SoLanDatSan(dt).ToString();

        }

        private void dateTimePicker_Den_ValueChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dateTimePicker_Tu_ValueChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private int TongTien(DataTable dt)
        {
            int tongTien = 0;
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            foreach (DataRow row in dt.Rows)
            {
                tongTien += int.Parse(row["Giá"].ToString());
            }
            return tongTien;
        }

        private int SoLanDatSan(DataTable dt)
        {
            int count = 0;
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            foreach (DataRow row in dt.Rows)
            {
                count += 1;
            }
            return count;
        }
        private void button_InThongKe_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument1,
                WindowState = FormWindowState.Maximized
            };
            printPreviewDialog.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Dictionary<TextBox, Point> textBoxLocations = new Dictionary<TextBox, Point>
            {
                {textBox_SoLanDatSan, textBox_SoLanDatSan.Location },
                {textBox_TongTien, textBox_TongTien.Location }
            };

            Dictionary<Label, Point> labelLocations = new Dictionary<Label, Point>
            {
                {label_Tu,label_Tu.Location },
                {label_Den, label_Den.Location },
                {label_SanBongTriHai, label_SanBongTriHai.Location },
                {label_ThongKeKinhDoanh, label_ThongKeKinhDoanh.Location },
                {label_TongTien, label_TongTien.Location },
                {label_SoLanDatSan, label_SoLanDatSan.Location }
            };

            Dictionary<DateTimePicker, Point> dateTimePickerLocations = new Dictionary<DateTimePicker, Point>
            {
                {dateTimePicker_Tu, dateTimePicker_Tu.Location},
                {dateTimePicker_Den, dateTimePicker_Den.Location}
            };

            foreach (var textBoxLocation in textBoxLocations)
            {
                TextBox textBox = textBoxLocation.Key;
                Point location = textBoxLocation.Value;
                string text = textBox.Text;
                e.Graphics.DrawString(text, textBox.Font, Brushes.Black, location);
            }

            foreach (var labelLocation in labelLocations)
            {
                Label label = labelLocation.Key;
                Point location = new Point (labelLocation.Value.X, labelLocation.Value.Y - 5);
                string text = label.Text;
                e.Graphics.DrawString(text, label.Font, Brushes.Black, location);
            }

            foreach (var dateTimePickerLocation in dateTimePickerLocations)
            {
                DateTimePicker dateTimePicker = dateTimePickerLocation.Key;
                Point location = dateTimePickerLocation.Value;
                string text = dateTimePicker.Text;
                e.Graphics.DrawString(text, dateTimePicker.Font, Brushes.Black, location);
            }
            // Vẽ nội dung của DataGridView
            int cellHeight = 25; // Độ cao của mỗi ô trong DataGridView
            int y = 300; // Vị trí bắt đầu vẽ cho DataGridView
            int x = 70; // Vị trí bắt đầu vẽ cho cột đầu tiên trong DataGridView

            // Vẽ tiêu đề của các cột
            for (int i = 0; i < dataGridView_ThongKeKinhDoanh.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView_ThongKeKinhDoanh.Columns[i].HeaderText, dataGridView_ThongKeKinhDoanh.Font, Brushes.Black, new Point(x, y));
                x += dataGridView_ThongKeKinhDoanh.Columns[i].Width;
            }

            y += cellHeight;

            // Vẽ nội dung của từng ô trong DataGridView
            foreach (DataGridViewRow row in dataGridView_ThongKeKinhDoanh.Rows)
            {
                x = 70; // Reset vị trí bắt đầu vẽ cho mỗi dòng
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Lấy nội dung của ô
                    string cellValue = cell.Value.ToString();
                    // Vẽ nội dung của ô lên giấy
                    e.Graphics.DrawString(cellValue, dataGridView_ThongKeKinhDoanh.Font, Brushes.Black, new Point(x, y));
                    // Di chuyển vị trí vẽ sang phải cho ô tiếp theo
                    x += cell.OwningColumn.Width;
                }
                // Di chuyển vị trí vẽ xuống dòng tiếp theo
                y += cellHeight;
            }


        }
    }
}
