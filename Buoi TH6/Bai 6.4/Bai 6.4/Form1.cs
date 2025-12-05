using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboquequan.Items.AddRange(new string[]
          {
                "Cần Thơ", "Tiền Giang", "An Giang", "Đồng Tháp", "Vĩnh Long"
          });

            // Cấu hình ListView
            lvsinhvien.View = View.Details;
            lvsinhvien.FullRowSelect = true;
            lvsinhvien.GridLines = true;

            lvsinhvien.Columns.Add("Mã SV", 80);
            lvsinhvien.Columns.Add("Họ tên", 150);
            lvsinhvien.Columns.Add("Phái", 60);
            lvsinhvien.Columns.Add("Ngày sinh", 100);
            lvsinhvien.Columns.Add("Điện thoại", 100);
            lvsinhvien.Columns.Add("Quê quán", 120);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmasv.Text.Trim();
            string ten = txthoten.Text.Trim();
            string phai = rdonam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpngaysinh.Value.ToShortDateString();
            string dienThoai = txtdienthoai.Text.Trim();
            string queQuan = cboquequan.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Mã sinh viên và Họ tên không được để trống!", "Thông báo");
                return;
            }

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(ten);
            item.SubItems.Add(phai);
            item.SubItems.Add(ngaySinh);
            item.SubItems.Add(dienThoai);
            item.SubItems.Add(queQuan);

            lvsinhvien.Items.Add(item);
            ClearInput();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvsinhvien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", "Thông báo");
                return;
            }

            var item = lvsinhvien.SelectedItems[0];

            string ma = txtmasv.Text.Trim();
            string ten = txthoten.Text.Trim();
            string phai = rdonam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpngaysinh.Value.ToShortDateString();
            string dienThoai = txtdienthoai.Text.Trim();
            string queQuan = cboquequan.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Mã sinh viên và Họ tên không được để trống!", "Thông báo");
                return;
            }

            item.SubItems[0].Text = ma;
            item.SubItems[1].Text = ten;
            item.SubItems[2].Text = phai;
            item.SubItems[3].Text = ngaySinh;
            item.SubItems[4].Text = dienThoai;
            item.SubItems[5].Text = queQuan;

            ClearInput();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvsinhvien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?",
                                             "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                lvsinhvien.Items.Remove(lvsinhvien.SelectedItems[0]);
                ClearInput();
            }
        }

        private void lvsinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsinhvien.SelectedItems.Count > 0)
            {
                var item = lvsinhvien.SelectedItems[0];
                txtmasv.Text = item.SubItems[0].Text;
                txthoten.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam")
                    rdonam.Checked = true;
                else
                    rdonu.Checked = true;
                dtpngaysinh.Value = DateTime.Parse(item.SubItems[3].Text);
                txtdienthoai.Text = item.SubItems[4].Text;
                cboquequan.Text = item.SubItems[5].Text;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?",
                                            "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                this.Close();
        }
        private void ClearInput()
        {
            txtmasv.Clear();
            txthoten.Clear();
            txtdienthoai.Clear();
            cboquequan.SelectedIndex = -1;
            rdonam.Checked = true;
            dtpngaysinh.Value = DateTime.Now;
            txtmasv.Focus();
        }
    }
}
