using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        private void txtN_TextChanged(object sender, EventArgs e)
    {
            int n;
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                txtKQ.Text = "";
                txtSNT.Text = "";
                return;
            }

            // Kiểm tra n có phải số nguyên tố
            if (LaSoNguyenTo(n))
                txtKQ.Text = $"{n} là số nguyên tố";
            else
                txtKQ.Text = $"{n} không phải là số nguyên tố";

            // Liệt kê các số nguyên tố nhỏ hơn n
            string s = "";
            for (int i = 2; i < n; i++)
            {
                if (LaSoNguyenTo(i))
                    s += i + " ";
            }
            txtSNT.Text = s;
        }
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Clear();
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
