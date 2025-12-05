namespace Bai_6._4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rdonu = new System.Windows.Forms.RadioButton();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.cboquequan = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvsinhvien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboquequan);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.rdonam);
            this.groupBox1.Controls.Add(this.rdonu);
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(724, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quê quán";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(140, 34);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(180, 30);
            this.txtmasv.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(140, 72);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(180, 30);
            this.txthoten.TabIndex = 7;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(140, 113);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(180, 30);
            this.dtpngaysinh.TabIndex = 8;
            // 
            // rdonu
            // 
            this.rdonu.AutoSize = true;
            this.rdonu.Location = new System.Drawing.Point(527, 34);
            this.rdonu.Name = "rdonu";
            this.rdonu.Size = new System.Drawing.Size(56, 26);
            this.rdonu.TabIndex = 9;
            this.rdonu.TabStop = true;
            this.rdonu.Text = "Nữ";
            this.rdonu.UseVisualStyleBackColor = true;
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Location = new System.Drawing.Point(600, 35);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(68, 26);
            this.rdonam.TabIndex = 10;
            this.rdonam.TabStop = true;
            this.rdonam.Text = "Nam";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(526, 72);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(184, 30);
            this.txtdienthoai.TabIndex = 11;
            // 
            // cboquequan
            // 
            this.cboquequan.FormattingEnabled = true;
            this.cboquequan.Location = new System.Drawing.Point(526, 113);
            this.cboquequan.Name = "cboquequan";
            this.cboquequan.Size = new System.Drawing.Size(184, 30);
            this.cboquequan.TabIndex = 12;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(69, 229);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(126, 47);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(234, 229);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(126, 46);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(408, 229);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(126, 44);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(567, 231);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(126, 40);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvsinhvien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(25, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 214);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // lvsinhvien
            // 
            this.lvsinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvsinhvien.FullRowSelect = true;
            this.lvsinhvien.GridLines = true;
            this.lvsinhvien.HideSelection = false;
            this.lvsinhvien.Location = new System.Drawing.Point(13, 29);
            this.lvsinhvien.Name = "lvsinhvien";
            this.lvsinhvien.Size = new System.Drawing.Size(697, 179);
            this.lvsinhvien.TabIndex = 0;
            this.lvsinhvien.UseCompatibleStateImageBehavior = false;
            this.lvsinhvien.View = System.Windows.Forms.View.Details;
            this.lvsinhvien.SelectedIndexChanged += new System.EventHandler(this.lvsinhvien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Sinh";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện ";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quê quán";
            this.columnHeader6.Width = 149;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.RadioButton rdonu;
        private System.Windows.Forms.ComboBox cboquequan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvsinhvien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

