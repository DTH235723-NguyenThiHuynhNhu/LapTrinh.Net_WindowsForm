using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RutGon(ref int tu, ref int mau)
        {
            if (mau == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }
        private void LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2)
        {
            try
            {
                tu1 = int.Parse(txtTu1.Text);
                mau1 = int.Parse(txtMau1.Text);
                tu2 = int.Parse(txtTu2.Text);
                mau2 = int.Parse(txtMau2.Text);

                if (mau1 == 0 || mau2 == 0)
                {
                    MessageBox.Show("Mẫu số không được bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tu1 = mau1 = tu2 = mau2 = 0;
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2);
            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;
            RutGon(ref tu, ref mau);
            MessageBox.Show($"Kết quả: {tu}/{mau}", "Phép cộng");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int tu1, mau1, tu2, mau2;
            if (!LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2)) return;
            {
                int tu = tu1 * mau2 - tu2 * mau1;
                int mau = mau1 * mau2;
                RutGon(ref tu, ref mau);
                MessageBox.Show($"Kết quả: {tu}/{mau}", "Phép trừ");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnChia_Click(object sender, EventArgs e)
        {

        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {

        }
    }
}
