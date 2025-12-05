namespace Bai_7._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewThuMuc = new System.Windows.Forms.TreeView();
            this.picAnhlon = new System.Windows.Forms.PictureBox();
            this.flowPanelAnh = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhlon)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewThuMuc
            // 
            this.treeViewThuMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewThuMuc.Location = new System.Drawing.Point(0, 0);
            this.treeViewThuMuc.Name = "treeViewThuMuc";
            this.treeViewThuMuc.Size = new System.Drawing.Size(231, 460);
            this.treeViewThuMuc.TabIndex = 0;
            this.treeViewThuMuc.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewThuMuc_BeforeSelect);
            this.treeViewThuMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewThuMuc_AfterSelect);
            // 
            // picAnhlon
            // 
            this.picAnhlon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnhlon.Location = new System.Drawing.Point(231, 0);
            this.picAnhlon.Name = "picAnhlon";
            this.picAnhlon.Size = new System.Drawing.Size(569, 460);
            this.picAnhlon.TabIndex = 1;
            this.picAnhlon.TabStop = false;
            this.picAnhlon.Click += new System.EventHandler(this.pic_Click);
            // 
            // flowPanelAnh
            // 
            this.flowPanelAnh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanelAnh.Location = new System.Drawing.Point(231, 301);
            this.flowPanelAnh.Name = "flowPanelAnh";
            this.flowPanelAnh.Size = new System.Drawing.Size(569, 159);
            this.flowPanelAnh.TabIndex = 2;
            this.flowPanelAnh.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelAnh_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.flowPanelAnh);
            this.Controls.Add(this.picAnhlon);
            this.Controls.Add(this.treeViewThuMuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhlon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewThuMuc;
        private System.Windows.Forms.PictureBox picAnhlon;
        private System.Windows.Forms.FlowLayoutPanel flowPanelAnh;
    }
}

