namespace Bai_7._5
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
            this.cboHinhve = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBorderColor = new System.Windows.Forms.PictureBox();
            this.cbosize = new System.Windows.Forms.ComboBox();
            this.picFillColor = new System.Windows.Forms.PictureBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình vẽ";
            // 
            // cboHinhve
            // 
            this.cboHinhve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboHinhve.FormattingEnabled = true;
            this.cboHinhve.Location = new System.Drawing.Point(69, 81);
            this.cboHinhve.Name = "cboHinhve";
            this.cboHinhve.Size = new System.Drawing.Size(174, 30);
            this.cboHinhve.TabIndex = 1;
            this.cboHinhve.SelectedIndexChanged += new System.EventHandler(this.cboHinhve_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbosize);
            this.groupBox1.Controls.Add(this.picBorderColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(32, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picFillColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(32, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // picBorderColor
            // 
            this.picBorderColor.Location = new System.Drawing.Point(85, 43);
            this.picBorderColor.Name = "picBorderColor";
            this.picBorderColor.Size = new System.Drawing.Size(100, 27);
            this.picBorderColor.TabIndex = 4;
            this.picBorderColor.TabStop = false;
            this.picBorderColor.Click += new System.EventHandler(this.picBorderColor_Click);
            // 
            // cbosize
            // 
            this.cbosize.FormattingEnabled = true;
            this.cbosize.Location = new System.Drawing.Point(83, 98);
            this.cbosize.Name = "cbosize";
            this.cbosize.Size = new System.Drawing.Size(121, 30);
            this.cbosize.TabIndex = 4;
            this.cbosize.SelectedIndexChanged += new System.EventHandler(this.cbosize_SelectedIndexChanged);
            // 
            // picFillColor
            // 
            this.picFillColor.Location = new System.Drawing.Point(83, 57);
            this.picFillColor.Name = "picFillColor";
            this.picFillColor.Size = new System.Drawing.Size(100, 32);
            this.picFillColor.TabIndex = 4;
            this.picFillColor.TabStop = false;
            this.picFillColor.Click += new System.EventHandler(this.picFillColor_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Location = new System.Drawing.Point(313, 139);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(407, 319);
            this.panelDraw.TabIndex = 4;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboHinhve);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "vẽ hình cơ bản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHinhve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbosize;
        private System.Windows.Forms.PictureBox picBorderColor;
        private System.Windows.Forms.PictureBox picFillColor;
        private System.Windows.Forms.Panel panelDraw;
    }
}

