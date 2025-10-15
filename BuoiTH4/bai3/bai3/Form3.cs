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
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a)
        {
            InitializeComponent();
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            lblKq.Text = "Số lớn nhất trong mảng = " + TimMax().ToString();
        }
        public int TimMax()
        {
            int max = c[0];
            foreach (int x in c) if (x > max) max = x;
            return max;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
