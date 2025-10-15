using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                txtkq.Text = (a + b).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void hiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                txtkq.Text = (a - b).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                txtkq.Text = (a * b).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void thươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                if (b != 0)
                    txtkq.Text = (a / b).ToString();
                else
                    MessageBox.Show("Không thể chia cho 0!");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }
    }
}
