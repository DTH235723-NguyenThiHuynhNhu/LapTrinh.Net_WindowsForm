namespace Bai7
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
            this.mnstinhtoan = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.mnstinhtoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstinhtoan
            // 
            this.mnstinhtoan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstinhtoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnstinhtoan.Location = new System.Drawing.Point(0, 0);
            this.mnstinhtoan.Name = "mnstinhtoan";
            this.mnstinhtoan.Size = new System.Drawing.Size(800, 28);
            this.mnstinhtoan.TabIndex = 0;
            this.mnstinhtoan.Text = "Tính toán";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngToolStripMenuItem,
            this.hiệuToolStripMenuItem,
            this.toolStripMenuItem2,
            this.thươngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Tính Toán";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tổngToolStripMenuItem
            // 
            this.tổngToolStripMenuItem.Name = "tổngToolStripMenuItem";
            this.tổngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tổngToolStripMenuItem.Text = "tổng";
            this.tổngToolStripMenuItem.Click += new System.EventHandler(this.tổngToolStripMenuItem_Click);
            // 
            // hiệuToolStripMenuItem
            // 
            this.hiệuToolStripMenuItem.Name = "hiệuToolStripMenuItem";
            this.hiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiệuToolStripMenuItem.Text = "hiệu";
            this.hiệuToolStripMenuItem.Click += new System.EventHandler(this.hiệuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "tích";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // thươngToolStripMenuItem
            // 
            this.thươngToolStripMenuItem.Name = "thươngToolStripMenuItem";
            this.thươngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thươngToolStripMenuItem.Text = "thương";
            this.thươngToolStripMenuItem.Click += new System.EventHandler(this.thươngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(174, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHEP TOAN DON GIAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(181, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(56, 28);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(259, 30);
            this.txta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(56, 85);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(259, 30);
            this.txtb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(177, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ket qua:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(260, 347);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(280, 22);
            this.txtkq.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnstinhtoan);
            this.MainMenuStrip = this.mnstinhtoan;
            this.Name = "Form1";
            this.Text = "Bài";
            this.mnstinhtoan.ResumeLayout(false);
            this.mnstinhtoan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnstinhtoan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thươngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkq;
    }
}

