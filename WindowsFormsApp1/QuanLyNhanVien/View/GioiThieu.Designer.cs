namespace WindowsFormsApp1.View
{
    partial class GioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GioiThieu));
            this.BTThemNV = new System.Windows.Forms.Button();
            this.BtSuaNV = new System.Windows.Forms.Button();
            this.BtXoaNV = new System.Windows.Forms.Button();
            this.BtTimNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trơGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.BtThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTThemNV
            // 
            this.BTThemNV.Location = new System.Drawing.Point(23, 120);
            this.BTThemNV.Name = "BTThemNV";
            this.BTThemNV.Size = new System.Drawing.Size(153, 47);
            this.BTThemNV.TabIndex = 0;
            this.BTThemNV.Text = "Thêm Nhân Viên";
            this.BTThemNV.UseVisualStyleBackColor = true;
            this.BTThemNV.Click += new System.EventHandler(this.BTThemNV_Click);
            // 
            // BtSuaNV
            // 
            this.BtSuaNV.Location = new System.Drawing.Point(23, 204);
            this.BtSuaNV.Name = "BtSuaNV";
            this.BtSuaNV.Size = new System.Drawing.Size(153, 47);
            this.BtSuaNV.TabIndex = 1;
            this.BtSuaNV.Text = "Sửa Nhân Viên";
            this.BtSuaNV.UseVisualStyleBackColor = true;
            this.BtSuaNV.Click += new System.EventHandler(this.BtSuaNV_Click);
            // 
            // BtXoaNV
            // 
            this.BtXoaNV.Location = new System.Drawing.Point(23, 287);
            this.BtXoaNV.Name = "BtXoaNV";
            this.BtXoaNV.Size = new System.Drawing.Size(153, 47);
            this.BtXoaNV.TabIndex = 2;
            this.BtXoaNV.Text = "Xóa Nhân Viên";
            this.BtXoaNV.UseVisualStyleBackColor = true;
            this.BtXoaNV.Click += new System.EventHandler(this.BtXoaNV_Click);
            // 
            // BtTimNV
            // 
            this.BtTimNV.Location = new System.Drawing.Point(23, 371);
            this.BtTimNV.Name = "BtTimNV";
            this.BtTimNV.Size = new System.Drawing.Size(153, 47);
            this.BtTimNV.TabIndex = 3;
            this.BtTimNV.Text = "Tìm Kiếm Nhân Viên";
            this.BtTimNV.UseVisualStyleBackColor = true;
            this.BtTimNV.Click += new System.EventHandler(this.BtTimNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phần Mềm Quản Lý Nhân Sự";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem,
            this.hêThôngToolStripMenuItem,
            this.trơGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongBanToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMucToolStripMenuItem.Text = "Danh Mục";
            // 
            // phongBanToolStripMenuItem
            // 
            this.phongBanToolStripMenuItem.Name = "phongBanToolStripMenuItem";
            this.phongBanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phongBanToolStripMenuItem.Text = "Phong Ban";
            this.phongBanToolStripMenuItem.Click += new System.EventHandler(this.phongBanToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hêThôngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // trơGiupToolStripMenuItem
            // 
            this.trơGiupToolStripMenuItem.Name = "trơGiupToolStripMenuItem";
            this.trơGiupToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trơGiupToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtThoat
            // 
            this.BtThoat.Location = new System.Drawing.Point(23, 461);
            this.BtThoat.Name = "BtThoat";
            this.BtThoat.Size = new System.Drawing.Size(153, 47);
            this.BtThoat.TabIndex = 7;
            this.BtThoat.Text = "Thoát";
            this.BtThoat.UseVisualStyleBackColor = true;
            this.BtThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(250, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 396);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýTàiKhoảnToolStripMenuItem,
            this.đăngNhậpToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ngườiDùngToolStripMenuItem.Text = "Người Dùng";
            // 
            // đăngKýTàiKhoảnToolStripMenuItem
            // 
            this.đăngKýTàiKhoảnToolStripMenuItem.Name = "đăngKýTàiKhoảnToolStripMenuItem";
            this.đăngKýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngKýTàiKhoảnToolStripMenuItem.Text = "Đăng Ký Tài Khoản";
            this.đăngKýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.đăngKýTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtThoat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtTimNV);
            this.Controls.Add(this.BtXoaNV);
            this.Controls.Add(this.BtSuaNV);
            this.Controls.Add(this.BTThemNV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GioiThieu";
            this.Text = "Giới Thiệu";
            this.Load += new System.EventHandler(this.GioiThieu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTThemNV;
        private System.Windows.Forms.Button BtSuaNV;
        private System.Windows.Forms.Button BtXoaNV;
        private System.Windows.Forms.Button BtTimNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trơGiupToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
    }
}