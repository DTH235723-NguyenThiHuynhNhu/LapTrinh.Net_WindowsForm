using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnen_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txthienthi.BackColor = cd.Color;
            }
        }

        private void btntfont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txthienthi.Font = fd.Font;
            }


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnhap.Text))
            {
                listBox1.Items.Add(txtnhap.Text);
                txtnhap.Clear();
                txtnhap.Focus();
            }
        

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                txthienthi.Text = listBox1.SelectedItem.ToString();
            }


        }

        private void btnchu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txthienthi.ForeColor = cd.Color;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
