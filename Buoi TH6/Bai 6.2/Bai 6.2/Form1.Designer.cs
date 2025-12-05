namespace Bai_6._2
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdolopa = new System.Windows.Forms.RadioButton();
            this.rdolopb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnasangb = new System.Windows.Forms.Button();
            this.btnbsanga = new System.Windows.Forms.Button();
            this.btnallsangb = new System.Windows.Forms.Button();
            this.btnallsanga = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsta = new System.Windows.Forms.ListBox();
            this.lstb = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txthoten.Location = new System.Drawing.Point(100, 20);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(519, 30);
            this.txthoten.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(657, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(106, 42);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdolopb);
            this.groupBox1.Controls.Add(this.rdolopa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(234, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // rdolopa
            // 
            this.rdolopa.AutoSize = true;
            this.rdolopa.Location = new System.Drawing.Point(18, 29);
            this.rdolopa.Name = "rdolopa";
            this.rdolopa.Size = new System.Drawing.Size(81, 26);
            this.rdolopa.TabIndex = 4;
            this.rdolopa.TabStop = true;
            this.rdolopa.Text = "Lớp A";
            this.rdolopa.UseVisualStyleBackColor = true;
            // 
            // rdolopb
            // 
            this.rdolopb.AutoSize = true;
            this.rdolopb.Location = new System.Drawing.Point(177, 29);
            this.rdolopb.Name = "rdolopb";
            this.rdolopb.Size = new System.Drawing.Size(81, 26);
            this.rdolopb.TabIndex = 5;
            this.rdolopb.TabStop = true;
            this.rdolopb.Text = "Lớp B";
            this.rdolopb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsta);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnasangb
            // 
            this.btnasangb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnasangb.Location = new System.Drawing.Point(313, 184);
            this.btnasangb.Name = "btnasangb";
            this.btnasangb.Size = new System.Drawing.Size(145, 52);
            this.btnasangb.TabIndex = 6;
            this.btnasangb.Text = ">";
            this.btnasangb.UseVisualStyleBackColor = true;
            this.btnasangb.Click += new System.EventHandler(this.btnasangb_Click);
            // 
            // btnbsanga
            // 
            this.btnbsanga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnbsanga.Location = new System.Drawing.Point(313, 242);
            this.btnbsanga.Name = "btnbsanga";
            this.btnbsanga.Size = new System.Drawing.Size(145, 50);
            this.btnbsanga.TabIndex = 7;
            this.btnbsanga.Text = "<";
            this.btnbsanga.UseVisualStyleBackColor = true;
            this.btnbsanga.Click += new System.EventHandler(this.btnbsanga_Click);
            // 
            // btnallsangb
            // 
            this.btnallsangb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnallsangb.Location = new System.Drawing.Point(313, 298);
            this.btnallsangb.Name = "btnallsangb";
            this.btnallsangb.Size = new System.Drawing.Size(145, 53);
            this.btnallsangb.TabIndex = 8;
            this.btnallsangb.Text = ">>";
            this.btnallsangb.UseVisualStyleBackColor = true;
            this.btnallsangb.Click += new System.EventHandler(this.btnallsangb_Click);
            // 
            // btnallsanga
            // 
            this.btnallsanga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnallsanga.Location = new System.Drawing.Point(313, 357);
            this.btnallsanga.Name = "btnallsanga";
            this.btnallsanga.Size = new System.Drawing.Size(145, 50);
            this.btnallsanga.TabIndex = 9;
            this.btnallsanga.Text = "  <<";
            this.btnallsanga.UseVisualStyleBackColor = true;
            this.btnallsanga.Click += new System.EventHandler(this.btnallsanga_Click);
            // 
            // btntong
            // 
            this.btntong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntong.Location = new System.Drawing.Point(134, 433);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(199, 55);
            this.btntong.TabIndex = 10;
            this.btntong.Text = "Tổng số sinh viên";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(446, 433);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(150, 55);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstb);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(494, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 240);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lsta
            // 
            this.lsta.FormattingEnabled = true;
            this.lsta.ItemHeight = 22;
            this.lsta.Location = new System.Drawing.Point(36, 38);
            this.lsta.Name = "lsta";
            this.lsta.Size = new System.Drawing.Size(175, 180);
            this.lsta.TabIndex = 0;
            // 
            // lstb
            // 
            this.lstb.FormattingEnabled = true;
            this.lstb.ItemHeight = 22;
            this.lstb.Location = new System.Drawing.Point(39, 38);
            this.lstb.Name = "lstb";
            this.lstb.Size = new System.Drawing.Size(203, 180);
            this.lstb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.btnallsanga);
            this.Controls.Add(this.btnallsangb);
            this.Controls.Add(this.btnbsanga);
            this.Controls.Add(this.btnasangb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Danh sách sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdolopb;
        private System.Windows.Forms.RadioButton rdolopa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnasangb;
        private System.Windows.Forms.Button btnbsanga;
        private System.Windows.Forms.Button btnallsangb;
        private System.Windows.Forms.Button btnallsanga;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsta;
        private System.Windows.Forms.ListBox lstb;
    }
}

