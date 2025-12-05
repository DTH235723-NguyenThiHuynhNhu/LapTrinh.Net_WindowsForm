using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{

    public partial class Form3 : Form
    {
        public int soN; // nhận giá trị N từ Form1
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random rd = new Random();

            // tạo mảng 1 chiều có số phần tử bằng N
            int[] arr = new int[soN];
            for (int i = 0; i < soN; i++)
            {
                arr[i] = rd.Next(soN, soN + 12);
            }

            // hiển thị mảng
            txtMang.Text = string.Join(" ", arr);

            // lọc ra số chẵn
            int[] chan = arr.Where(x => x % 2 == 0).ToArray();
            txtChan.Text = string.Join(" ", chan);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
