using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txthoten.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo");
                txthoten.Focus();
                return;
            }

            if (rdolopa.Checked)
                lsta.Items.Add(ten);
            else if (rdolopb.Checked)
                lstb.Items.Add(ten);
            else
                MessageBox.Show("Vui lòng chọn lớp A hoặc lớp B!");

            txthoten.Clear();
            txthoten.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnasangb_Click(object sender, EventArgs e)
        {
            while (lsta.SelectedItems.Count > 0)
            {
                lstb.Items.Add(lsta.SelectedItems[0]);
                lsta.Items.Remove(lsta.SelectedItems[0]);
            }
        }

        private void btnbsanga_Click(object sender, EventArgs e)
        {
            while (lstb.SelectedItems.Count > 0)
            {
                lsta.Items.Add(lstb.SelectedItems[0]);
                lstb.Items.Remove(lstb.SelectedItems[0]);
            }
        }

        private void btnallsangb_Click(object sender, EventArgs e)
        {
            foreach (var item in lsta.Items)
                lstb.Items.Add(item);
            lsta.Items.Clear();
        }

        private void btnallsanga_Click(object sender, EventArgs e)
        {
            foreach (var item in lstb.Items)
                lsta.Items.Add(item);
            lstb.Items.Clear();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int tong = lsta.Items.Count + lstb.Items.Count;
            MessageBox.Show($"Tổng số sinh viên: {tong}", "Kết quả");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
