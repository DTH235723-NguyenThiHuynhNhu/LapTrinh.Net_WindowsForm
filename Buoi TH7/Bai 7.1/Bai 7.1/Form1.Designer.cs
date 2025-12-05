namespace Bai_7._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtho = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.treeViewDanhBa = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtho);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(376, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(95, 48);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(203, 30);
            this.txtten.TabIndex = 2;
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(95, 105);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(203, 30);
            this.txtho.TabIndex = 3;
            this.txtho.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(120, 171);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(119, 38);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(496, 306);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 36);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // treeViewDanhBa
            // 
            this.treeViewDanhBa.Location = new System.Drawing.Point(24, 31);
            this.treeViewDanhBa.Name = "treeViewDanhBa";
            this.treeViewDanhBa.Size = new System.Drawing.Size(299, 407);
            this.treeViewDanhBa.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewDanhBa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TreeView treeViewDanhBa;
    }
}

