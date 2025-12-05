namespace Bai_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kiểmTraSốHoànHảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mởFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraSốHoànHảoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = " ";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(339, 119);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 28);
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem.Name = "kiểmTraSốHoànHảoToolStripMenuItem";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.kiểmTraSốHoànHảoToolStripMenuItem.Text = "Kiểm tra số hoàn hảo";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFormToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "Mở Form";
            // 
            // mởFormToolStripMenuItem
            // 
            this.mởFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem1,
            this.tạoMảngToolStripMenuItem});
            this.mởFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            this.mởFormToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.mởFormToolStripMenuItem.Text = "Mở Form";
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem1
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem1.Name = "kiểmTraSốHoànHảoToolStripMenuItem1";
            this.kiểmTraSốHoànHảoToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.kiểmTraSốHoànHảoToolStripMenuItem1.Text = "Kiểm tra số hoàn hảo";
            // 
            // tạoMảngToolStripMenuItem
            // 
            this.tạoMảngToolStripMenuItem.Name = "tạoMảngToolStripMenuItem";
            this.tạoMảngToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.tạoMảngToolStripMenuItem.Text = "Tạo mảng";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(87, 185);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(207, 41);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm tra số hoàn hảo";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTaoMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMang.Location = new System.Drawing.Point(350, 185);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(207, 41);
            this.btnTaoMang.TabIndex = 5;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.UseVisualStyleBackColor = false;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.AllowDrop = true;
            this.btnLamLai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(111, 273);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(149, 40);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(350, 273);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(155, 40);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mởFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tạoMảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnthoat;
    }
}

