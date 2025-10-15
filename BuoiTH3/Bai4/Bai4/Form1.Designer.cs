namespace Bai4
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChuThuong = new System.Windows.Forms.RadioButton();
            this.rdoChuHoa = new System.Windows.Forms.RadioButton();
            this.btnKQ = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(115, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(231, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 22);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuHoa);
            this.groupBox1.Controls.Add(this.rdoChuThuong);
            this.groupBox1.Location = new System.Drawing.Point(119, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rdoChuThuong
            // 
            this.rdoChuThuong.AutoSize = true;
            this.rdoChuThuong.Location = new System.Drawing.Point(6, 22);
            this.rdoChuThuong.Name = "rdoChuThuong";
            this.rdoChuThuong.Size = new System.Drawing.Size(100, 20);
            this.rdoChuThuong.TabIndex = 3;
            this.rdoChuThuong.TabStop = true;
            this.rdoChuThuong.Text = "Chữ Thường";
            this.rdoChuThuong.UseVisualStyleBackColor = true;
            // 
            // rdoChuHoa
            // 
            this.rdoChuHoa.AutoSize = true;
            this.rdoChuHoa.Location = new System.Drawing.Point(7, 58);
            this.rdoChuHoa.Name = "rdoChuHoa";
            this.rdoChuHoa.Size = new System.Drawing.Size(93, 20);
            this.rdoChuHoa.TabIndex = 3;
            this.rdoChuHoa.TabStop = true;
            this.rdoChuHoa.Text = "Chữ In Hoa";
            this.rdoChuHoa.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(119, 216);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(100, 23);
            this.btnKQ.TabIndex = 3;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(225, 216);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(130, 22);
            this.txtKQ.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(363, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(363, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đổi kiểu chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChuThuong;
        private System.Windows.Forms.RadioButton rdoChuHoa;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

