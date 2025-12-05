using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamLai.Enabled = false;
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            btnLamLai.Enabled = !string.IsNullOrWhiteSpace(txtN.Text);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
            btnLamLai.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n))
            {
                MessageBox.Show("Nhập số N hợp lệ!");
                return;
            }
            // mở Form2
            Form2 f2 = new Form2();
            f2.soN = n;
            f2.ShowDialog();

            // bật lại nút Làm lại
            btnLamLai.Enabled = true;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n))
            {
                MessageBox.Show("Nhập số N hợp lệ!");
                return;
            }

            Form3 f3 = new Form3();
            f3.soN = n; // truyền giá trị N sang Form3
            f3.ShowDialog();

            // tùy muốn: bật nút làm lại nếu vẫn có txtN
            btnLamLai.Enabled = !string.IsNullOrWhiteSpace(txtN.Text);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
