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
    public partial class Form2 : Form
    {
        int[] b;

        public Form2(int[] a)
        {
            InitializeComponent();
            b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            lblKq.Text = "Tổng mảng = " + TongMang().ToString();
        }
        public int TongMang()
        {
            int sum = 0;
            foreach (int x in b) sum += x;
            return sum;
        }
        private void lblKq_Click(object sender, EventArgs e)
        {

        }
    }
}
