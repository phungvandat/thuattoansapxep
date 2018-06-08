namespace nhap_tong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dayso = new System.Windows.Forms.TextBox();
            this.tinhtong_click = new System.Windows.Forms.Button();
            this.xuatra = new System.Windows.Forms.GroupBox();
            this.HienThiTungBuoc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soluongphantu = new System.Windows.Forms.NumericUpDown();
            this.LuaChonThuatToan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodeThuatToan = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgauNhien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YTuong = new System.Windows.Forms.RichTextBox();
            this.ReSet = new System.Windows.Forms.Button();
            this.SapTang = new System.Windows.Forms.RadioButton();
            this.SapGiam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongphantu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dãy số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dayso
            // 
            this.dayso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dayso.Location = new System.Drawing.Point(83, 81);
            this.dayso.Name = "dayso";
            this.dayso.Size = new System.Drawing.Size(248, 25);
            this.dayso.TabIndex = 1;
            this.dayso.TextChanged += new System.EventHandler(this.dayso_TextChanged);
            // 
            // tinhtong_click
            // 
            this.tinhtong_click.BackColor = System.Drawing.Color.Red;
            this.tinhtong_click.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tinhtong_click.ForeColor = System.Drawing.Color.LightGreen;
            this.tinhtong_click.Location = new System.Drawing.Point(12, 213);
            this.tinhtong_click.Name = "tinhtong_click";
            this.tinhtong_click.Size = new System.Drawing.Size(169, 47);
            this.tinhtong_click.TabIndex = 4;
            this.tinhtong_click.Text = "SẮP XẾP";
            this.tinhtong_click.UseVisualStyleBackColor = false;
            this.tinhtong_click.Click += new System.EventHandler(this.label1_Click);
            // 
            // xuatra
            // 
            this.xuatra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuatra.BackgroundImage")));
            this.xuatra.Controls.Add(this.HienThiTungBuoc);
            this.xuatra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuatra.Location = new System.Drawing.Point(6, 271);
            this.xuatra.Name = "xuatra";
            this.xuatra.Size = new System.Drawing.Size(646, 254);
            this.xuatra.TabIndex = 4;
            this.xuatra.TabStop = false;
            this.xuatra.Text = "MÔ PHỎNG CÁC BƯỚC THỰC HIỆN SẮP XẾP";
            this.xuatra.Enter += new System.EventHandler(this.xuatra_Enter);
            // 
            // HienThiTungBuoc
            // 
            this.HienThiTungBuoc.BackColor = System.Drawing.Color.LightGreen;
            this.HienThiTungBuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HienThiTungBuoc.ForeColor = System.Drawing.Color.Red;
            this.HienThiTungBuoc.Location = new System.Drawing.Point(20, 21);
            this.HienThiTungBuoc.Name = "HienThiTungBuoc";
            this.HienThiTungBuoc.Size = new System.Drawing.Size(605, 219);
            this.HienThiTungBuoc.TabIndex = 0;
            this.HienThiTungBuoc.Text = "";
            this.HienThiTungBuoc.TextChanged += new System.EventHandler(this.HienThiTungBuoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập số phần tử của mảng";
            // 
            // soluongphantu
            // 
            this.soluongphantu.BackColor = System.Drawing.Color.White;
            this.soluongphantu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soluongphantu.Location = new System.Drawing.Point(173, 43);
            this.soluongphantu.Name = "soluongphantu";
            this.soluongphantu.Size = new System.Drawing.Size(43, 22);
            this.soluongphantu.TabIndex = 0;
            this.soluongphantu.ValueChanged += new System.EventHandler(this.soluongphantu_ValueChanged);
            // 
            // LuaChonThuatToan
            // 
            this.LuaChonThuatToan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LuaChonThuatToan.FormattingEnabled = true;
            this.LuaChonThuatToan.Items.AddRange(new object[] {
            "1. Interchange Sort",
            "2. Bubble Sort",
            "3. Selection Sort",
            "4. Heap Sort",
            "5. Merge Sort",
            "6. QuickSort"});
            this.LuaChonThuatToan.Location = new System.Drawing.Point(118, 148);
            this.LuaChonThuatToan.Name = "LuaChonThuatToan";
            this.LuaChonThuatToan.Size = new System.Drawing.Size(141, 21);
            this.LuaChonThuatToan.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.CodeThuatToan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(658, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 482);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code Thuật Toán";
            // 
            // CodeThuatToan
            // 
            this.CodeThuatToan.BackColor = System.Drawing.Color.PaleGreen;
            this.CodeThuatToan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CodeThuatToan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CodeThuatToan.Location = new System.Drawing.Point(9, 25);
            this.CodeThuatToan.Name = "CodeThuatToan";
            this.CodeThuatToan.Size = new System.Drawing.Size(239, 443);
            this.CodeThuatToan.TabIndex = 0;
            this.CodeThuatToan.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn Thuật Toán";
            // 
            // NgauNhien
            // 
            this.NgauNhien.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgauNhien.Location = new System.Drawing.Point(136, 115);
            this.NgauNhien.Name = "NgauNhien";
            this.NgauNhien.Size = new System.Drawing.Size(111, 21);
            this.NgauNhien.TabIndex = 2;
            this.NgauNhien.Text = "Nhập Ngẫu Nhiên";
            this.NgauNhien.UseVisualStyleBackColor = true;
            this.NgauNhien.Click += new System.EventHandler(this.NgauNhien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.YTuong);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(337, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ý TƯỞNG";
            // 
            // YTuong
            // 
            this.YTuong.BackColor = System.Drawing.Color.PaleGreen;
            this.YTuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.YTuong.Location = new System.Drawing.Point(17, 21);
            this.YTuong.Name = "YTuong";
            this.YTuong.Size = new System.Drawing.Size(277, 170);
            this.YTuong.TabIndex = 0;
            this.YTuong.Text = "";
            this.YTuong.TextChanged += new System.EventHandler(this.YTuong_TextChanged);
            // 
            // ReSet
            // 
            this.ReSet.BackColor = System.Drawing.Color.Red;
            this.ReSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ReSet.ForeColor = System.Drawing.Color.Gold;
            this.ReSet.Location = new System.Drawing.Point(230, 229);
            this.ReSet.Name = "ReSet";
            this.ReSet.Size = new System.Drawing.Size(100, 28);
            this.ReSet.TabIndex = 5;
            this.ReSet.Text = "RESET";
            this.ReSet.UseVisualStyleBackColor = false;
            this.ReSet.Click += new System.EventHandler(this.ReSet_Click);
            // 
            // SapTang
            // 
            this.SapTang.AutoSize = true;
            this.SapTang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SapTang.Location = new System.Drawing.Point(105, 184);
            this.SapTang.Name = "SapTang";
            this.SapTang.Size = new System.Drawing.Size(69, 17);
            this.SapTang.TabIndex = 10;
            this.SapTang.TabStop = true;
            this.SapTang.Text = "Sắp Tăng";
            this.SapTang.UseVisualStyleBackColor = true;
            this.SapTang.CheckedChanged += new System.EventHandler(this.SapTang_CheckedChanged);
            // 
            // SapGiam
            // 
            this.SapGiam.AutoSize = true;
            this.SapGiam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SapGiam.Location = new System.Drawing.Point(190, 183);
            this.SapGiam.Name = "SapGiam";
            this.SapGiam.Size = new System.Drawing.Size(71, 17);
            this.SapGiam.TabIndex = 11;
            this.SapGiam.TabStop = true;
            this.SapGiam.Text = "Sắp Giảm";
            this.SapGiam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cách Sắp Xếp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.BackgroundImage")));
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hướngDẫnToolStripMenuItem.BackgroundImage")));
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giớiThiệuToolStripMenuItem.BackgroundImage")));
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.giớiThiệuToolStripMenuItem.Text = "Giới Thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(915, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SapGiam);
            this.Controls.Add(this.SapTang);
            this.Controls.Add(this.ReSet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NgauNhien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LuaChonThuatToan);
            this.Controls.Add(this.soluongphantu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xuatra);
            this.Controls.Add(this.tinhtong_click);
            this.Controls.Add(this.dayso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MÔ PHỎNG THUẬT TOÁN SẮP XÊP";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xuatra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soluongphantu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayso;
        private System.Windows.Forms.Button tinhtong_click;
        private System.Windows.Forms.GroupBox xuatra;
        private System.Windows.Forms.RichTextBox HienThiTungBuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown soluongphantu;
        private System.Windows.Forms.ComboBox LuaChonThuatToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CodeThuatToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NgauNhien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox YTuong;
        private System.Windows.Forms.Button ReSet;
        private System.Windows.Forms.RadioButton SapTang;
        private System.Windows.Forms.RadioButton SapGiam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
    }
}

