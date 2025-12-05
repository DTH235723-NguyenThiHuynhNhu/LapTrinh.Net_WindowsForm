namespace Bai_6._1
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
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.btnchonfont = new System.Windows.Forms.Button();
            this.btnchonmau = new System.Windows.Forms.Button();
            this.btnmo = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập đoạn văn bản";
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(60, 70);
            this.txthienthi.Multiline = true;
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(648, 236);
            this.txthienthi.TabIndex = 1;
            // 
            // btnchonfont
            // 
            this.btnchonfont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchonfont.Location = new System.Drawing.Point(60, 326);
            this.btnchonfont.Name = "btnchonfont";
            this.btnchonfont.Size = new System.Drawing.Size(126, 51);
            this.btnchonfont.TabIndex = 2;
            this.btnchonfont.Text = "Đổi font";
            this.btnchonfont.UseVisualStyleBackColor = true;
            this.btnchonfont.Click += new System.EventHandler(this.btnchonfont_Click);
            // 
            // btnchonmau
            // 
            this.btnchonmau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchonmau.Location = new System.Drawing.Point(231, 326);
            this.btnchonmau.Name = "btnchonmau";
            this.btnchonmau.Size = new System.Drawing.Size(126, 51);
            this.btnchonmau.TabIndex = 3;
            this.btnchonmau.Text = "Chọn màu";
            this.btnchonmau.UseVisualStyleBackColor = true;
            this.btnchonmau.Click += new System.EventHandler(this.btnchonmau_Click);
            // 
            // btnmo
            // 
            this.btnmo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmo.Location = new System.Drawing.Point(403, 326);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(126, 49);
            this.btnmo.TabIndex = 4;
            this.btnmo.Text = "Open";
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(582, 326);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(126, 44);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Save";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(309, 385);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(144, 53);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnmo);
            this.Controls.Add(this.btnchonmau);
            this.Controls.Add(this.btnchonfont);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CommonDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Button btnchonfont;
        private System.Windows.Forms.Button btnchonmau;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

