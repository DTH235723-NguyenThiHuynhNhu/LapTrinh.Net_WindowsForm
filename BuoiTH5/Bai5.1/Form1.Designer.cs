namespace Bai5_2
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.txtSNT = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(411, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 33);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamlai.Location = new System.Drawing.Point(217, 343);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(132, 33);
            this.btnLamlai.TabIndex = 17;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = false;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // txtSNT
            // 
            this.txtSNT.Location = new System.Drawing.Point(268, 250);
            this.txtSNT.Name = "txtSNT";
            this.txtSNT.Size = new System.Drawing.Size(261, 22);
            this.txtSNT.TabIndex = 16;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(268, 205);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(261, 22);
            this.txtKQ.TabIndex = 15;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(268, 159);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(261, 22);
            this.txtN.TabIndex = 14;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tìm SNT nhỏ hơn N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kiểm tra SNT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(202, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kiểm Tra và Tìm SNT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.txtSNT);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KT SNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.TextBox txtSNT;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

