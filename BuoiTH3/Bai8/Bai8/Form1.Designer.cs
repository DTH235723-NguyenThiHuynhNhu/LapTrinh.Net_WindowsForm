namespace Bai8
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
            this.lblhoten = new System.Windows.Forms.Label();
            this.cboHoTen = new System.Windows.Forms.ComboBox();
            this.btnhienloichao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblhoten.Location = new System.Drawing.Point(174, 108);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(68, 22);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ tên:";
            // 
            // cboHoTen
            // 
            this.cboHoTen.FormattingEnabled = true;
            this.cboHoTen.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Tran Van C",
            "Ly Thi D"});
            this.cboHoTen.Location = new System.Drawing.Point(264, 109);
            this.cboHoTen.Name = "cboHoTen";
            this.cboHoTen.Size = new System.Drawing.Size(219, 24);
            this.cboHoTen.TabIndex = 1;
            this.cboHoTen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnhienloichao
            // 
            this.btnhienloichao.Location = new System.Drawing.Point(310, 188);
            this.btnhienloichao.Name = "btnhienloichao";
            this.btnhienloichao.Size = new System.Drawing.Size(113, 61);
            this.btnhienloichao.TabIndex = 2;
            this.btnhienloichao.Text = "Hien Loi Chao\r\n";
            this.btnhienloichao.UseVisualStyleBackColor = true;
            this.btnhienloichao.Click += new System.EventHandler(this.btnhienloichao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhienloichao);
            this.Controls.Add(this.cboHoTen);
            this.Controls.Add(this.lblhoten);
            this.Name = "Form1";
            this.Text = "Bai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.ComboBox cboHoTen;
        private System.Windows.Forms.Button btnhienloichao;
    }
}

