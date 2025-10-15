namespace bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.btnchu = new System.Windows.Forms.Button();
            this.btnnen = new System.Windows.Forms.Button();
            this.btntfont = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(25, 37);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(197, 22);
            this.txtnhap.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(31, 153);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(95, 32);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(191, 153);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 32);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 132);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txthienthi
            // 
            this.txthienthi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txthienthi.Location = new System.Drawing.Point(370, 40);
            this.txthienthi.Multiline = true;
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(365, 118);
            this.txthienthi.TabIndex = 4;
            // 
            // btnchu
            // 
            this.btnchu.Location = new System.Drawing.Point(370, 181);
            this.btnchu.Name = "btnchu";
            this.btnchu.Size = new System.Drawing.Size(111, 38);
            this.btnchu.TabIndex = 5;
            this.btnchu.Text = "Chọn màu chữ";
            this.btnchu.UseVisualStyleBackColor = true;
            this.btnchu.Click += new System.EventHandler(this.btnchu_Click);
            // 
            // btnnen
            // 
            this.btnnen.Location = new System.Drawing.Point(508, 181);
            this.btnnen.Name = "btnnen";
            this.btnnen.Size = new System.Drawing.Size(104, 38);
            this.btnnen.TabIndex = 6;
            this.btnnen.Text = "Chọn màu nền";
            this.btnnen.UseVisualStyleBackColor = true;
            this.btnnen.Click += new System.EventHandler(this.btnnen_Click);
            // 
            // btntfont
            // 
            this.btntfont.Location = new System.Drawing.Point(637, 181);
            this.btntfont.Name = "btntfont";
            this.btntfont.Size = new System.Drawing.Size(98, 38);
            this.btntfont.TabIndex = 7;
            this.btntfont.Text = "Chọn font";
            this.btntfont.UseVisualStyleBackColor = true;
            this.btntfont.Click += new System.EventHandler(this.btntfont_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(492, 274);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(134, 47);
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntfont);
            this.Controls.Add(this.btnnen);
            this.Controls.Add(this.btnchu);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Button btnchu;
        private System.Windows.Forms.Button btnnen;
        private System.Windows.Forms.Button btntfont;
        private System.Windows.Forms.Button btndong;
    }
}

