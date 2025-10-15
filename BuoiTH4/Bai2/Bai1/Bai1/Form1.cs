using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();   // mảng số nguyên

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            arr.Sort();
            HienThiMang();
        }


        private void btntong_Click(object sender, EventArgs e)
        {
            int sum = arr.Sum();
            MessageBox.Show("Tổng mảng = " + sum);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtNhap.Text, out int x))
                {
                    arr.Add(x);
                    txtNhap.Clear();
                    HienThiMang();
                }
            }
        }

        private void HienThiMang()
        {
            txtKq.Text = "Các phần tử trong mảng là: " + string.Join(" ", arr);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int x))
            {
                arr.Add(x);   // thêm số vào mảng
                txtNhap.Clear();
            }

            // hiển thị mảng ra ô vàng
            txtKq.Text = "Các phần tử trong mảng là: " + string.Join(" ", arr);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            arr.Clear();
            txtKq.Text = "Mảng đã được xóa!";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiam_Click(object sender, EventArgs e)
        {
            arr.Sort();
            arr.Reverse();
            HienThiMang();
        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            int count = arr.Count(x => x % 2 == 0);
            MessageBox.Show("Số chẵn: " + count);
        }

        private void btnle_Click(object sender, EventArgs e)
        {
            int count = arr.Count(x => x % 2 != 0);
            MessageBox.Show("Số lẻ: " + count);
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void btnNguyen_Click(object sender, EventArgs e)
        {
            var primes = arr.Where(x => IsPrime(x));
            MessageBox.Show("Số nguyên tố: " + string.Join(" ", primes));
        }
        private bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) sum += i;
            return sum == n && n > 0;
        }
        private void btnhoanhao_Click(object sender, EventArgs e)
        {
            var shh = arr.Where(x => IsPerfect(x));
            MessageBox.Show("Số hoàn hảo: " + string.Join(" ", shh));
        }
        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (arr.Count >= 2)
            {
                int result = GCD(arr[0], arr[1]);
                MessageBox.Show($"UCLN({arr[0]}, {arr[1]}) = " + result);
            }
            else MessageBox.Show("Cần ít nhất 2 phần tử!");
        }

        private void btntrungbinh_Click(object sender, EventArgs e)
        {
            double tb = arr.Average();
            MessageBox.Show("Trung bình cộng = " + tb);
        }

        private void btnNho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min = " + arr.Min());
        }

        private void btnLon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max = " + arr.Max());
        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {
           
        }
    }

}
