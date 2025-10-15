namespace Bai1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btngiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.btnLon = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnhoanhao = new System.Windows.Forms.Button();
            this.btnNguyen = new System.Windows.Forms.Button();
            this.btnle = new System.Windows.Forms.Button();
            this.btnchan = new System.Windows.Forms.Button();
            this.btntrungbinh = new System.Windows.Forms.Button();
            this.btnucln = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhập 1 phần tử";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(139, 20);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(160, 22);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.btnTang_Click);
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(305, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(105, 38);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(532, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btngiam
            // 
            this.btngiam.Location = new System.Drawing.Point(532, 56);
            this.btngiam.Name = "btngiam";
            this.btngiam.Size = new System.Drawing.Size(109, 44);
            this.btngiam.TabIndex = 5;
            this.btngiam.Text = "Sắp Xếp Giảm";
            this.btngiam.UseVisualStyleBackColor = true;
            this.btngiam.Click += new System.EventHandler(this.btngiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(532, 106);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(109, 40);
            this.btnTang.TabIndex = 6;
            this.btnTang.Text = "Sắp Xếp Tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(532, 152);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(109, 41);
            this.btntong.TabIndex = 7;
            this.btntong.Text = "Tổng Mảng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnLon
            // 
            this.btnLon.Location = new System.Drawing.Point(532, 199);
            this.btnLon.Name = "btnLon";
            this.btnLon.Size = new System.Drawing.Size(109, 42);
            this.btnLon.TabIndex = 8;
            this.btnLon.Text = "Số Lớn Nhất";
            this.btnLon.UseVisualStyleBackColor = true;
            this.btnLon.Click += new System.EventHandler(this.btnLon_Click);
            // 
            // btnNho
            // 
            this.btnNho.Location = new System.Drawing.Point(402, 199);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(124, 43);
            this.btnNho.TabIndex = 9;
            this.btnNho.Text = "Số Nhỏ Nhất";
            this.btnNho.UseVisualStyleBackColor = true;
            this.btnNho.Click += new System.EventHandler(this.btnNho_Click);
            // 
            // btnhoanhao
            // 
            this.btnhoanhao.Location = new System.Drawing.Point(402, 152);
            this.btnhoanhao.Name = "btnhoanhao";
            this.btnhoanhao.Size = new System.Drawing.Size(124, 41);
            this.btnhoanhao.TabIndex = 10;
            this.btnhoanhao.Text = "Số Hoàn Hảo";
            this.btnhoanhao.UseVisualStyleBackColor = true;
            this.btnhoanhao.Click += new System.EventHandler(this.btnhoanhao_Click);
            // 
            // btnNguyen
            // 
            this.btnNguyen.Location = new System.Drawing.Point(273, 152);
            this.btnNguyen.Name = "btnNguyen";
            this.btnNguyen.Size = new System.Drawing.Size(123, 41);
            this.btnNguyen.TabIndex = 11;
            this.btnNguyen.Text = "Số Nguyên";
            this.btnNguyen.UseVisualStyleBackColor = true;
            this.btnNguyen.Click += new System.EventHandler(this.btnNguyen_Click);
            // 
            // btnle
            // 
            this.btnle.Location = new System.Drawing.Point(149, 151);
            this.btnle.Name = "btnle";
            this.btnle.Size = new System.Drawing.Size(118, 42);
            this.btnle.TabIndex = 12;
            this.btnle.Text = "Đếm Số Lẻ";
            this.btnle.UseVisualStyleBackColor = true;
            this.btnle.Click += new System.EventHandler(this.btnle_Click);
            // 
            // btnchan
            // 
            this.btnchan.Location = new System.Drawing.Point(27, 151);
            this.btnchan.Name = "btnchan";
            this.btnchan.Size = new System.Drawing.Size(116, 42);
            this.btnchan.TabIndex = 13;
            this.btnchan.Text = "Đếm Số Chẵn";
            this.btnchan.UseVisualStyleBackColor = true;
            this.btnchan.Click += new System.EventHandler(this.btnchan_Click);
            // 
            // btntrungbinh
            // 
            this.btntrungbinh.Location = new System.Drawing.Point(257, 199);
            this.btntrungbinh.Name = "btntrungbinh";
            this.btntrungbinh.Size = new System.Drawing.Size(139, 43);
            this.btntrungbinh.TabIndex = 14;
            this.btntrungbinh.Text = "Trung Bình Mảng";
            this.btntrungbinh.UseVisualStyleBackColor = true;
            this.btntrungbinh.Click += new System.EventHandler(this.btntrungbinh_Click);
            // 
            // btnucln
            // 
            this.btnucln.Location = new System.Drawing.Point(27, 199);
            this.btnucln.Name = "btnucln";
            this.btnucln.Size = new System.Drawing.Size(224, 43);
            this.btnucln.TabIndex = 15;
            this.btnucln.Text = "UCLN 2 Phần Tử Đầu Tiên";
            this.btnucln.UseVisualStyleBackColor = true;
            this.btnucln.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKq
            // 
            this.txtKq.BackColor = System.Drawing.Color.Khaki;
            this.txtKq.Location = new System.Drawing.Point(27, 56);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(499, 90);
            this.txtKq.TabIndex = 16;
            this.txtKq.TextChanged += new System.EventHandler(this.txtKq_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnucln);
            this.Controls.Add(this.btntrungbinh);
            this.Controls.Add(this.btnchan);
            this.Controls.Add(this.btnle);
            this.Controls.Add(this.btnNguyen);
            this.Controls.Add(this.btnhoanhao);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnLon);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btngiam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btngiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnLon;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnhoanhao;
        private System.Windows.Forms.Button btnNguyen;
        private System.Windows.Forms.Button btnle;
        private System.Windows.Forms.Button btnchan;
        private System.Windows.Forms.Button btntrungbinh;
        private System.Windows.Forms.Button btnucln;
        private System.Windows.Forms.TextBox txtKq;
    }
}

