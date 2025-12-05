using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string drive in Directory.GetLogicalDrives())
            {
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                node.Nodes.Add("...");
                treeViewThuMuc.Nodes.Add(node);
            }

            // Cấu hình hiển thị FlowLayoutPanel
            flowPanelAnh.AutoScroll = true;
            flowPanelAnh.WrapContents = true;
        }

        private void treeViewThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flowPanelAnh.Controls.Clear(); // xóa ảnh cũ
            string path = e.Node.Tag.ToString();

            try
            {
                string[] files = Directory.GetFiles(path, "*.*")
                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                foreach (string file in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(file);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 100;
                    pic.Height = 70;
                    pic.Padding = new Padding(5);
                    pic.Tag = file;

                    // Khi click vào ảnh nhỏ -> hiện ảnh lớn
                    pic.Click += pic_Click;

                    flowPanelAnh.Controls.Add(pic);
                }
            }
            catch { }
        }

        private void treeViewThuMuc_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string path = e.Node.Tag.ToString();
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    node.Tag = dir;
                    node.Nodes.Add("...");
                    e.Node.Nodes.Add(node);
                }
            }
            catch { }
        }

        private void picAnhlon_Click(object sender, EventArgs e)
        {

        }

        private void flowPanelAnh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                picAnhlon.Image = pic.Image; // picAnhLon là PictureBox ảnh lớn
            }
        }
    }
}
