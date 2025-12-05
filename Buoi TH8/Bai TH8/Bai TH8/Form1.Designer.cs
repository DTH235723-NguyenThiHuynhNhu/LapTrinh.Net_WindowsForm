namespace Bai_TH8
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdohinhtron = new System.Windows.Forms.RadioButton();
            this.rdohinhCN = new System.Windows.Forms.RadioButton();
            this.rdohinhvuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(217, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH DIỆN TÍCH VÀ CHU VI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdohinhtron);
            this.groupBox1.Controls.Add(this.rdohinhCN);
            this.groupBox1.Controls.Add(this.rdohinhvuong);
            this.groupBox1.Location = new System.Drawing.Point(47, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(275, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdohinhtron
            // 
            this.rdohinhtron.AutoSize = true;
            this.rdohinhtron.Location = new System.Drawing.Point(58, 174);
            this.rdohinhtron.Name = "rdohinhtron";
            this.rdohinhtron.Size = new System.Drawing.Size(105, 26);
            this.rdohinhtron.TabIndex = 2;
            this.rdohinhtron.Text = "Hình tròn";
            this.rdohinhtron.UseVisualStyleBackColor = true;
            this.rdohinhtron.CheckedChanged += new System.EventHandler(this.rdohinhtron_CheckedChanged);
            // 
            // rdohinhCN
            // 
            this.rdohinhCN.AutoSize = true;
            this.rdohinhCN.Location = new System.Drawing.Point(58, 120);
            this.rdohinhCN.Name = "rdohinhCN";
            this.rdohinhCN.Size = new System.Drawing.Size(140, 26);
            this.rdohinhCN.TabIndex = 2;
            this.rdohinhCN.Text = "Hình chữ nhật";
            this.rdohinhCN.UseVisualStyleBackColor = true;
            this.rdohinhCN.CheckedChanged += new System.EventHandler(this.rdohinhCN_CheckedChanged);
            // 
            // rdohinhvuong
            // 
            this.rdohinhvuong.AutoSize = true;
            this.rdohinhvuong.Checked = true;
            this.rdohinhvuong.Location = new System.Drawing.Point(58, 65);
            this.rdohinhvuong.Name = "rdohinhvuong";
            this.rdohinhvuong.Size = new System.Drawing.Size(121, 26);
            this.rdohinhvuong.TabIndex = 2;
            this.rdohinhvuong.TabStop = true;
            this.rdohinhvuong.Text = "Hình vuông";
            this.rdohinhvuong.UseVisualStyleBackColor = true;
            this.rdohinhvuong.CheckedChanged += new System.EventHandler(this.rdohinhvuong_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbankinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtrong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcanh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(344, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(107, 170);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(235, 30);
            this.txtbankinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bán kính";
            // 
            // txtrong
            // 
            this.txtrong.Location = new System.Drawing.Point(243, 106);
            this.txtrong.Name = "txtrong";
            this.txtrong.Size = new System.Drawing.Size(100, 30);
            this.txtrong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(186, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rộng";
            // 
            // txtdai
            // 
            this.txtdai.Location = new System.Drawing.Point(67, 106);
            this.txtdai.Name = "txtdai";
            this.txtdai.Size = new System.Drawing.Size(100, 30);
            this.txtdai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dài";
            // 
            // txtcanh
            // 
            this.txtcanh.Location = new System.Drawing.Point(78, 39);
            this.txtcanh.Name = "txtcanh";
            this.txtcanh.Size = new System.Drawing.Size(265, 30);
            this.txtcanh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cạnh";
            // 
            // btnthuchien
            // 
            this.btnthuchien.Location = new System.Drawing.Point(105, 448);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(150, 50);
            this.btnthuchien.TabIndex = 3;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            this.btnthuchien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(440, 450);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(141, 48);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 619);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdohinhtron;
        private System.Windows.Forms.RadioButton rdohinhCN;
        private System.Windows.Forms.RadioButton rdohinhvuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.Button btnthoat;
    }
}

