namespace Bai2
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
            this.btnrandom = new System.Windows.Forms.Button();
            this.lblKq = new System.Windows.Forms.Label();
            this.btnin = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử mảng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(208, 25);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(209, 22);
            this.txtnhap.TabIndex = 1;
            // 
            // btnrandom
            // 
            this.btnrandom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnrandom.Location = new System.Drawing.Point(432, 24);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(238, 31);
            this.btnrandom.TabIndex = 2;
            this.btnrandom.Text = "Tạo bảng random";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // lblKq
            // 
            this.lblKq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKq.Location = new System.Drawing.Point(16, 85);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(654, 157);
            this.lblKq.TabIndex = 3;
            this.lblKq.Click += new System.EventHandler(this.lblKq_Click);
            // 
            // btnin
            // 
            this.btnin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnin.Location = new System.Drawing.Point(140, 258);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(121, 44);
            this.btnin.TabIndex = 4;
            this.btnin.Text = "In mảng";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(325, 261);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(110, 44);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnmax
            // 
            this.btnmax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmax.Location = new System.Drawing.Point(511, 261);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(75, 44);
            this.btnmax.TabIndex = 6;
            this.btnmax.Text = "Max";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.btnrandom);
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
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnmax;
    }
}

