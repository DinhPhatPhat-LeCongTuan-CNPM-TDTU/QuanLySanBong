using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class QuanLyTaiKhoanHeThong : Form
    {
        private bool isKhachHang = false;
        private bool isQuanLy = false;
        public QuanLyTaiKhoanHeThong()
        {
            InitializeComponent();
            groupBox_ThongTinTaiKhoan.Enabled = false;
            button_SuaTaiKhoan.Visible = false;
            button_Xoa.Visible = false;
        }

        private void button_TaiKhoanKhachHang_Click(object sender, EventArgs e)
        {
            ClearAllInThongTinTaiKhoan();
            isKhachHang = true;
            isQuanLy = false;
            CheckShow();
            DataTable dt = SelectAllTaiKhoanKhachHang();
            dataGridView_DanhSachTaiKhoan.DataSource = dt;  
            button_ThemQuanLy.Visible = false;
            button_SuaTaiKhoan.Visible = false;
            button_Xoa.Visible = false;
            button_LuuThem.Visible = false;
        }



        private void button_TaiKhoanQuanLy_Click(object sender, EventArgs e)
        {
            ClearAllInThongTinTaiKhoan();
            isKhachHang = false;
            isQuanLy = true;
            CheckShow();
            DataTable dt = SelectAllTaiKhoanQuanLy();
            dataGridView_DanhSachTaiKhoan.DataSource = dt;
            button_ThemQuanLy.Visible = true;
            button_SuaTaiKhoan.Visible = false;
            button_Xoa.Visible = false;
            button_LuuThem.Visible = false;
            groupBox_ThongTinTaiKhoan.Enabled = false;
        }

        private void CheckShow()
        {
            if (isKhachHang)
            {
                comboBox_GioiTinh.Visible = true;
                label_GioiTinh.Visible = true;
                dateTimePicker_NgaySinh.Visible = true;
                label_NgaySinh.Visible = true;
                textBox_DiaChi.Visible = true;
                label_DiaChi.Visible = true;
                textBox_SoLanDatSan.Visible = true;
                label_SoLanDatSan.Visible = true;
                comboBox_ToanQuyen.Visible = false;
                label_ToanQuyen.Visible = false;
            }
            else
            {
                comboBox_GioiTinh.Visible = false;
                label_GioiTinh.Visible = false;
                dateTimePicker_NgaySinh.Visible = false;
                label_NgaySinh.Visible = false;
                textBox_DiaChi.Visible = false;
                label_DiaChi.Visible = false;
                textBox_SoLanDatSan.Visible = false;
                label_SoLanDatSan.Visible = false;
                comboBox_ToanQuyen.Visible = true;
                label_ToanQuyen.Visible = true;
            }
        }

        private void ClearAllInThongTinTaiKhoan()
        {
            textBox_Ma.Clear();
            textBox_Ten.Clear();
            textBox_SoDienThoai.Clear();
            textBox_Email.Clear();
            textBox_MatKhau.Clear();
            comboBox_GioiTinh.SelectedIndex = -1;
            dateTimePicker_NgaySinh.Value = DateTime.Now;
            textBox_DiaChi.Clear();
            textBox_SoLanDatSan.Clear();
        }

        private DataTable SelectAllTaiKhoanKhachHang()
        {
            return KhachHang_BLL.SelectAllKhachHang();
        }

        private DataTable SelectAllTaiKhoanQuanLy()
        {
            return QuanLy_BLL.SelectAllQuanLy();
        }

        private void dataGridView_DanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    DataGridViewRow selectedRow = dataGridView_DanhSachTaiKhoan.Rows[e.RowIndex];
                    groupBox_ThongTinTaiKhoan.Enabled = true;
                    if (isKhachHang)
                    {
                        groupBox_ThongTinTaiKhoan.Enabled = true;
                        textBox_Ma.Text = selectedRow.Cells[0].Value.ToString();
                        textBox_Ten.Text = selectedRow.Cells[1].Value.ToString();
                        textBox_SoDienThoai.Text = selectedRow.Cells[2].Value.ToString();
                        textBox_Email.Text = selectedRow.Cells[3].Value.ToString();
                        textBox_MatKhau.Text = selectedRow.Cells[4].Value.ToString();
                        comboBox_GioiTinh.Text = selectedRow.Cells[5].Value.ToString();
                        dateTimePicker_NgaySinh.Text = selectedRow.Cells[6].Value.ToString();
                        textBox_DiaChi.Text = selectedRow.Cells[7].Value.ToString();
                        textBox_SoLanDatSan.Text = selectedRow.Cells[8].Value.ToString();
                        button_ThemQuanLy.Visible = isQuanLy;
                        button_LuuThem.Visible = false;
                        button_Xoa.Visible = true;
                        
                    }

                    if (isQuanLy)
                    {
                        textBox_Ma.Text = selectedRow.Cells[0].Value.ToString();
                        textBox_Ten.Text = selectedRow.Cells[1].Value.ToString();
                        textBox_SoDienThoai.Text = selectedRow.Cells[2].Value.ToString();
                        textBox_Email.Text = selectedRow.Cells[3].Value.ToString();
                        textBox_MatKhau.Text = selectedRow.Cells[4].Value.ToString();
                        comboBox_ToanQuyen.Text = (bool)selectedRow.Cells[5].Value ? "Có" : "Không";
                        groupBox_ThongTinTaiKhoan.Enabled = (comboBox_ToanQuyen.Text.Equals("Có")) ? false : true;
                        button_ThemQuanLy.Visible = isQuanLy;
                        button_SuaTaiKhoan.Visible = true;
                        button_LuuThem.Visible = false;
                        button_Xoa.Visible = true;
                        button_SuaTaiKhoan.Enabled = true;
                        button_Xoa.Enabled = true;
                    }
                }
            }
        }

        private void button_TimTheoTen_Click(object sender, EventArgs e)
        {
            if (textBox_TenMuonTim.Text.Trim() == "")
            {
                button_HienTatCa_Click(sender, e);
            }
            else
            {
                if (isKhachHang)
                {
                    DataTable dt = SelectAllTaiKhoanKhachHang();
                    var filteredData = dt.AsEnumerable();
                    filteredData = filteredData.Where(row => row.Field<string>("tenKhachHang").ToLower().Contains(textBox_TenMuonTim.Text.ToLower()));
                    if (filteredData.Any())
                    {
                        DataTable source = filteredData.CopyToDataTable();
                        dataGridView_DanhSachTaiKhoan.DataSource = source;
                        return;
                    }
                    else
                    {
                        dataGridView_DanhSachTaiKhoan.DataSource = null;
                    }
                }
                if (isQuanLy)
                {
                    DataTable dt = SelectAllTaiKhoanQuanLy();
                    var filteredData = dt.AsEnumerable();
                    filteredData = filteredData.Where(row => row.Field<string>("tenQuanLy").ToLower().Contains(textBox_TenMuonTim.Text.ToLower()));
                    if (filteredData.Any())
                    {
                        DataTable source = filteredData.CopyToDataTable();
                        dataGridView_DanhSachTaiKhoan.DataSource = source;
                        return;
                    }
                    else
                    {
                        dataGridView_DanhSachTaiKhoan.DataSource = null;
                    }
                }
            }
        }

        private void button_HienTatCa_Click(object sender, EventArgs e)
        {
            textBox_TenMuonTim.Text = "";
            if (isKhachHang)
            {
                button_TaiKhoanKhachHang_Click(sender, e);
            }
            if (isQuanLy)
            {
                button_TaiKhoanQuanLy_Click(sender, e);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (isKhachHang)
            {
                if (textBox_Ma.Text.Trim() != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa khách hàng", $"Quản lý có chắc muốn xóa khách hàng '{textBox_Ma}', {textBox_Ten}", MessageBoxButtons.YesNo);
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        KhachHang_BLL.DeleteKhachHangByMaKhachHang(textBox_Ma.Text);
                        button_TaiKhoanKhachHang_Click(sender, e);
                        MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng");
                    }
                }
            }

            if (isQuanLy)
            {
                if (comboBox_ToanQuyen.Text.Equals("Có"))
                {
                    MessageBox.Show("Không thể xóa quản lý toàn quyền", "Xóa quản lý không thành công");
                    return;
                }
                if (textBox_Ma.Text.Trim() != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa quản lý", $"Quản lý có chắc muốn xóa tài khoản quản lý này: '{textBox_Ma.Text}', {textBox_Ten.Text}", MessageBoxButtons.YesNo);
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        QuanLy_BLL.DeleteQuanLyByMaQuanLy(textBox_Ma.Text);
                        button_TaiKhoanQuanLy_Click(sender, e);
                        MessageBox.Show("Xóa tài khoản quản lý thành công", "Xóa quản lý");
                    }
                }
            }
        }

        private void button_ThemQuanLy_Click(object sender, EventArgs e)
        {
            button_Xoa.Enabled = false;
            button_SuaTaiKhoan.Enabled = false;
            button_LuuThem.Visible = true;
            ClearAllInThongTinTaiKhoan();

            groupBox_ThongTinTaiKhoan.Enabled = true;
            textBox_Ma.Enabled = false;
            textBox_Ten.Enabled = true;
            textBox_SoDienThoai.Enabled = true;
            textBox_Email.Enabled = true;
            textBox_MatKhau.Enabled = true;
            comboBox_ToanQuyen.Text = "Không";
            comboBox_ToanQuyen.Enabled = false;
        }

        private void button_LuuThem_Click(object sender, EventArgs e)
        {
            CheckThongTinQuanLy();
            QuanLy_BLL.InsertQuanLy(textBox_Ten.Text, textBox_SoDienThoai.Text, textBox_Email.Text, textBox_MatKhau.Text, false);
            MessageBox.Show($"Quản lý mới: {textBox_Ten.Text} vừa được thêm vào", "Thêm thành công");
            button_TaiKhoanQuanLy_Click(sender, e);
            return;

        }
        private bool CheckEmailValid(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        private void button_SuaTaiKhoan_Click(object sender, EventArgs e)
        {        
            if (isQuanLy)
            {
                if (!groupBox_ThongTinTaiKhoan.Enabled)
                {
                    MessageBox.Show($"Không thể sửa thông tin quản lý toàn quyền", "Sửa thất bại");
                    return;
                }
                else
                {
                    string allText = textBox_Ten.Text + textBox_SoDienThoai.Text + textBox_Email.Text + textBox_MatKhau.Text;
                    if (allText.Contains("\'"))
                    {
                        MessageBox.Show("Không được chứa ký tự đặt biệt trong thông tin: \'");
                        return;
                    }

                    if (textBox_MatKhau.Text.Length < 6)
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự");
                        return;
                    }

                    QuanLy_BLL.UpdateQuanLy(textBox_Ma.Text, textBox_Ten.Text, textBox_MatKhau.Text, comboBox_ToanQuyen.Text== "Có" ? true : false);
                    MessageBox.Show($"Cập nhật thông tin quản lý {textBox_Ma.Text} thành công");
                    button_TaiKhoanQuanLy_Click(sender, e);
                    return;
                }

            }
        }

        private void CheckThongTinQuanLy()
        {
            if (
                string.IsNullOrWhiteSpace(textBox_Ten.Text) ||
                string.IsNullOrWhiteSpace(textBox_SoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(textBox_Email.Text) ||
                string.IsNullOrWhiteSpace(textBox_MatKhau.Text))
            {
                MessageBox.Show("Không được để trống thông tin quản lý");
                return;
            }

            string allText = textBox_Ten.Text + textBox_SoDienThoai.Text + textBox_Email.Text + textBox_MatKhau.Text;

            if (allText.Contains("\'"))
            {
                MessageBox.Show("Không được chứa ký tự đặt biệt trong thông tin: \'");
                return;
            }

            if (QuanLy_BLL.SelectOneQuanLyByEmail_SoDienThoai(textBox_Email.Text) != null)
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }
            if (!Regex.IsMatch(textBox_SoDienThoai.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (QuanLy_BLL.SelectOneQuanLyByEmail_SoDienThoai(textBox_SoDienThoai.Text) != null)
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }

            if (textBox_MatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự");
                return;
            }

            if (!CheckEmailValid(textBox_Email.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
        }
    }
}
