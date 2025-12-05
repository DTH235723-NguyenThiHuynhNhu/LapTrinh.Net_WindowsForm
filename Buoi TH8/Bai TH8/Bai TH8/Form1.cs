using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_TH8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcanh.Enabled = false;
            txtdai.Enabled = false;
            txtrong.Enabled = false;
            txtbankinh.Enabled = false;

            rdohinhvuong.Enabled = true;
            txtcanh.Enabled = true;
            txtcanh.Focus();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rdohinhvuong.Checked)
            {
                if (txtcanh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào chiều dài cạnh!", "Thông báo");
                    txtcanh.Focus();
                    return;
                }

                Form2 f2 = new Form2();
                f2.canh = double.Parse(txtcanh.Text);
                f2.ShowDialog();
            }

            else if (rdohinhCN.Checked)
            {
                if (txtdai.Text == "" || txtrong.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào chiều dài và chiều rộng!", "Thông báo");
                    txtdai.Focus();
                    return;
                }

                Form3 f3 = new Form3();
                f3.dai = double.Parse(txtdai.Text);
                f3.rong = double.Parse(txtrong.Text);
                f3.ShowDialog();
            }

            else if (rdohinhtron.Checked)
            {
                if (txtbankinh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào bán kính!", "Thông báo");
                    txtbankinh.Focus();
                    return;
                }

                Form4 f4 = new Form4();
                f4.bankinh = double.Parse(txtbankinh.Text);
                f4.ShowDialog();
            }
        }

        private void rdohinhvuong_CheckedChanged(object sender, EventArgs e)
        {
            txtcanh.Clear();
            txtdai.Clear();
            txtrong.Clear();
            txtbankinh.Clear();

            txtcanh.Enabled = true;
            txtdai.Enabled = false;
            txtrong.Enabled = false;
            txtbankinh.Enabled = false;
            txtcanh.Focus();
        }

        private void rdohinhCN_CheckedChanged(object sender, EventArgs e)
        {
            txtcanh.Clear();
            txtdai.Clear();
            txtrong.Clear();
            txtbankinh.Clear();

            txtcanh.Enabled = false;
            txtdai.Enabled = true;
            txtrong.Enabled = true;
            txtbankinh.Enabled = false;
            txtdai.Focus();
        }

        private void rdohinhtron_CheckedChanged(object sender, EventArgs e)
        {
            txtcanh.Clear();
            txtdai.Clear();
            txtrong.Clear();
            txtbankinh.Clear();

            txtcanh.Enabled = false;
            txtdai.Enabled = false;
            txtrong.Enabled = false;
            txtbankinh.Enabled = true;
            txtbankinh.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
