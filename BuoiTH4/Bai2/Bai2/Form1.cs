using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{

    public partial class Form1 : Form
    {
        int[] a;   // mảng số nguyên
        int n;
        public Form1()
        {
           

            InitializeComponent();
        }
        public void TaoMang(int n)
        {
            a = new int[n];              // cấp phát mảng
            Random rd = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-10, 100);  // sinh số ngẫu nhiên từ -10 đến 100
            }

        }
        public string InMang()
        {
            if (a == null || a.Length == 0)
                return "Mảng rỗng!";

            string chuoi = "";
            for (int i = 0; i < a.Length; i++)
            {
                chuoi += a[i] + " ";
            }
            return chuoi;
        }
        
        private void btnrandom_Click(object sender, EventArgs e)
        {
            if (txtnhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtnhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtnhap.Text);

                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                    txtnhap.Focus();
                }
                else
                {
                    TaoMang(n);   // tạo mảng ngẫu nhiên
                    lblKq.Text = "Mảng ngẫu nhiên đã được tạo xong!";
                    btnin.Enabled = true;   // bật nút In mảng
                    btnmax.Enabled = true;      // bật nút Max
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            lblKq.Text = "Các phần tử của mảng: " + InMang();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                lblKq.Text = "Mảng rỗng!";
            }
            else
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                lblKq.Text = "Phần tử lớn nhất trong mảng là: " + max;
            }
        }

        private void lblKq_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();   // thoát toàn bộ chương trình
        }

    }
}
