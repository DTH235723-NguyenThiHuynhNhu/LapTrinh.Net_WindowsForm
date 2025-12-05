using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ho = txtho.Text.Trim();
            string ten = txtten.Text.Trim();

            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên!");
                return;
            }

            // Lấy ký tự đầu tiên của tên (chuyển về chữ in hoa)
            char firstChar = char.ToUpper(ten[0]);

            // Tìm node có ký tự đầu tiên
            TreeNode node = null;
            foreach (TreeNode n in treeViewDanhBa.Nodes)
            {
                if (n.Text == firstChar.ToString())
                {
                    node = n;
                    break;
                }
            }

            if (node != null)
            {
                string hoTen = ten + ", " + ho;
                node.Nodes.Add(hoTen);
                node.Expand(); // Mở rộng để thấy tên vừa thêm
            }

            // Xóa ô nhập sau khi thêm
            txtho.Clear();
            txtten.Clear();
            txtten.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                treeViewDanhBa.Nodes.Add(c.ToString());
            }
        }
    }
}
