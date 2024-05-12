using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class DieuChinhGiaSan : Form
    {
        public DieuChinhGiaSan()
        {
            InitializeComponent();
        }

        private void DieuChinhGiaSan_Load(object sender, EventArgs e)
        {
            dataGridView_DanhSachSanBong.DataSource = SanBong_BLL.SelectAllSanBong();
            textBox_GiaSanTrenPhut.Enabled = false;
        }

        private void dataGridView_DanhSachSanBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button_CapNhatGiaSan.Enabled = true;
                textBox_GiaSanTrenPhut.Enabled = true;
                DataGridViewRow selectedRow = dataGridView_DanhSachSanBong.Rows[e.RowIndex];
                textBox_Ma.Text = selectedRow.Cells[0].Value.ToString();
                textBox_Ten.Text = selectedRow.Cells[1].Value.ToString();
                textBox_GiaSanTrenPhut.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void button_CapNhatGiaSan_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(textBox_GiaSanTrenPhut.Text, out num))
            {
                MessageBox.Show("Giá sân không hợp lệ");
                return;
            }

            SanBong_BLL.UpdateGiaSanTheoPhut(textBox_Ma.Text, int.Parse(textBox_GiaSanTrenPhut.Text));
            DieuChinhGiaSan_Load(null, null);
        }
    }
}