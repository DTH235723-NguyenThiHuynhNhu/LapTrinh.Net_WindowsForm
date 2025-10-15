using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;

        public Form1()
        {
            InitializeComponent();
            btnsum.Enabled = false;
            btnmax.Enabled = false;
        }
        public void TaoMang(int n)
        {
            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-10, 100);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmang_Click(object sender, EventArgs e)
        {
            if (txtnhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng!");
                txtnhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtnhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Số phần tử mảng phải > 0");
                    txtnhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    string kq = string.Join(" ", a);
                    MessageBox.Show("Mảng vừa tạo: " + kq);

                    btnsum.Enabled = true;
                    btnmax.Enabled = true;
                }
            }
        }


        private void btnmax_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn tiếp tục tìm số lớn nhất?",
                                          "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form3 f3 = new Form3(a);  // truyền mảng a sang Form3
                f3.ShowDialog();
            }

        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn tiếp tục tính tổng mảng?",
                                         "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form2 f2 = new Form2(a);  // truyền mảng a sang Form2
                f2.ShowDialog();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
