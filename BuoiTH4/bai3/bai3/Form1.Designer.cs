namespace bai3
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
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnmang = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Phần Tử Mảng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(222, 25);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(261, 22);
            this.txtnhap.TabIndex = 1;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // btnmang
            // 
            this.btnmang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmang.Location = new System.Drawing.Point(502, 25);
            this.btnmang.Name = "btnmang";
            this.btnmang.Size = new System.Drawing.Size(216, 34);
            this.btnmang.TabIndex = 2;
            this.btnmang.Text = "Tạo Mảng Random";
            this.btnmang.UseVisualStyleBackColor = true;
            this.btnmang.Click += new System.EventHandler(this.btnmang_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(502, 76);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 36);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnmax
            // 
            this.btnmax.Enabled = false;
            this.btnmax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmax.Location = new System.Drawing.Point(288, 77);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(140, 36);
            this.btnmax.TabIndex = 4;
            this.btnmax.Text = "Số Lớn Nhất";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnsum
            // 
            this.btnsum.Enabled = false;
            this.btnsum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsum.Location = new System.Drawing.Point(29, 76);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(165, 37);
            this.btnsum.TabIndex = 5;
            this.btnsum.Text = "Tổng Mảng";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnmang);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btnmang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnsum;
    }
}

