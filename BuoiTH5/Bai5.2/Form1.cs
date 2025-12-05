using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LaSoHoanHao(int n)
        {
            if (n <= 1)
                return false;

            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
                return;

            if (LaSoHoanHao(n))
                MessageBox.Show($"{n} là số hoàn hảo!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"{n} không phải là số hoàn hảo!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
