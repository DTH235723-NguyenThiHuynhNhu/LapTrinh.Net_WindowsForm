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
    public partial class Form2 : Form
    {
        public double canh;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double dientich = canh * canh;
            double chuvi = canh * 4;

            txtdientich.Text = dientich.ToString();
            txtchuvi.Text = chuvi.ToString();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
