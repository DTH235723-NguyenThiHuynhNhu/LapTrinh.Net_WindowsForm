using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboHoTen.Items.Add("Nguyen Van A");
            cboHoTen.Items.Add("Tran Van C");
            cboHoTen.Items.Add("Ly Thi D");

            // Đặt mặc định
            cboHoTen.SelectedIndex = 0;
        }

        private void btnhienloichao_Click(object sender, EventArgs e)
        {
            if (cboHoTen.SelectedItem != null)
            {
                string ten = cboHoTen.SelectedItem.ToString();
                MessageBox.Show("Chào " + ten + ". Chúc một ngày vui vẻ.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn họ tên trước!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
