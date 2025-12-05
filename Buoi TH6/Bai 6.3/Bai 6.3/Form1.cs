using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboLop.Items.AddRange(new string[] { "Lớp A", "Lớp B", "Lớp C" });
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa toàn bộ danh sách không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                txtkq.Clear();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
       
            // Lấy dữ liệu
            string ma = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToShortDateString();  // Đúng tên DateTimePicker
            string lop = cboLop.Text.Trim();                           // Đúng tên ComboBox
            string diaChi = txtDiaChi.Text.Trim();

            // Kiểm tra nhập đủ thông tin
            MessageBox.Show($"ma = {ma}\nten = {ten}\ndiaChi = {diaChi}\nngaySinh = {ngaySinh}\nlop = {lop}", "DEBUG");
            if (ma == "" || ten == "" || diaChi == "" || lop == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Ghi kết quả ra TextBox
            string dong = $"Mã SV: {ma} | Họ tên: {ten} | Ngày sinh: {ngaySinh} | Lớp: {lop} | Địa chỉ: {diaChi}";
            txtkq.AppendText(dong + Environment.NewLine);

            // Xóa dữ liệu nhập để nhập mới
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.SelectedIndex = -1;
            txtMaSV.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
