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
    public partial class Form3 : Form
    {
        public double dai, rong;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double dientich = dai * rong;
            double chuvi = (dai + rong) * 2;

            txtdientich.Text = dientich.ToString();
            txtchuvi.Text = chuvi.ToString();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
