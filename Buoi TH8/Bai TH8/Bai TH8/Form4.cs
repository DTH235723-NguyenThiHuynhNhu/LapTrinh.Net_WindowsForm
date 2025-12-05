using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_TH8
{
    public partial class Form4 : Form
    {
        public double bankinh;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            double dientich = Math.PI * bankinh * bankinh;
            double chuvi = 2 * Math.PI * bankinh;

            txtdientich.Text = Math.Round(dientich, 2).ToString();
            txtchuvi.Text = Math.Round(chuvi, 2).ToString();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
