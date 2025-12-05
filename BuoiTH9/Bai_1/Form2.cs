using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form2 : Form
    {
        public int soN; // public để Form1 gán được
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 1; i <= soN / 2; i++)
            {
                if (soN % i == 0)
                    tong += i;
            }

            if (tong == soN)
                lblKetQua.Text = $"{soN} là số hoàn hảo";
            else
                lblKetQua.Text = $"{soN} không phải là số hoàn hảo";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
