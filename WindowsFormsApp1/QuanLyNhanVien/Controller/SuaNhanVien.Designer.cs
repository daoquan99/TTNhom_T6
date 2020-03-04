namespace WindowsFormsApp1.Controller
{
    partial class SuaNhanVien
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
            this.button2 = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.GrBThemNV = new System.Windows.Forms.GroupBox();
            this.TbGioiTinh = new System.Windows.Forms.TextBox();
            this.CbBoxPhong = new System.Windows.Forms.ComboBox();
            this.LbMaNV = new System.Windows.Forms.Label();
            this.TbLuong = new System.Windows.Forms.TextBox();
            this.DtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TbTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListNhanVien = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrBThemNV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(648, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Quay Lại Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtSua
            // 
            this.BtSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSua.Location = new System.Drawing.Point(202, 623);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(187, 60);
            this.BtSua.TabIndex = 6;
            this.BtSua.Text = "Lưu Thông Tin";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // GrBThemNV
            // 
            this.GrBThemNV.Controls.Add(this.TbGioiTinh);
            this.GrBThemNV.Controls.Add(this.CbBoxPhong);
            this.GrBThemNV.Controls.Add(this.LbMaNV);
            this.GrBThemNV.Controls.Add(this.TbLuong);
            this.GrBThemNV.Controls.Add(this.DtNgaySinh);
            this.GrBThemNV.Controls.Add(this.TbTenNV);
            this.GrBThemNV.Controls.Add(this.label6);
            this.GrBThemNV.Controls.Add(this.label5);
            this.GrBThemNV.Controls.Add(this.label4);
            this.GrBThemNV.Controls.Add(this.label3);
            this.GrBThemNV.Controls.Add(this.label2);
            this.GrBThemNV.Controls.Add(this.label1);
            this.GrBThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.GrBThemNV.Location = new System.Drawing.Point(12, 12);
            this.GrBThemNV.Name = "GrBThemNV";
            this.GrBThemNV.Size = new System.Drawing.Size(976, 272);
            this.GrBThemNV.TabIndex = 4;
            this.GrBThemNV.TabStop = false;
            this.GrBThemNV.Text = "Thêm Nhân Viên";
            // 
            // TbGioiTinh
            // 
            this.TbGioiTinh.Location = new System.Drawing.Point(671, 24);
            this.TbGioiTinh.Multiline = true;
            this.TbGioiTinh.Name = "TbGioiTinh";
            this.TbGioiTinh.Size = new System.Drawing.Size(253, 44);
            this.TbGioiTinh.TabIndex = 14;
            // 
            // CbBoxPhong
            // 
            this.CbBoxPhong.FormattingEnabled = true;
            this.CbBoxPhong.Location = new System.Drawing.Point(671, 214);
            this.CbBoxPhong.Name = "CbBoxPhong";
            this.CbBoxPhong.Size = new System.Drawing.Size(253, 33);
            this.CbBoxPhong.TabIndex = 13;
            // 
            // LbMaNV
            // 
            this.LbMaNV.AutoSize = true;
            this.LbMaNV.Location = new System.Drawing.Point(182, 57);
            this.LbMaNV.Name = "LbMaNV";
            this.LbMaNV.Size = new System.Drawing.Size(37, 25);
            this.LbMaNV.TabIndex = 12;
            this.LbMaNV.Text = ".....";
            // 
            // TbLuong
            // 
            this.TbLuong.Location = new System.Drawing.Point(671, 119);
            this.TbLuong.Multiline = true;
            this.TbLuong.Name = "TbLuong";
            this.TbLuong.Size = new System.Drawing.Size(253, 44);
            this.TbLuong.TabIndex = 11;
            // 
            // DtNgaySinh
            // 
            this.DtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtNgaySinh.Location = new System.Drawing.Point(178, 209);
            this.DtNgaySinh.Name = "DtNgaySinh";
            this.DtNgaySinh.Size = new System.Drawing.Size(317, 30);
            this.DtNgaySinh.TabIndex = 10;
            // 
            // TbTenNV
            // 
            this.TbTenNV.Location = new System.Drawing.Point(178, 119);
            this.TbTenNV.Multiline = true;
            this.TbTenNV.Name = "TbTenNV";
            this.TbTenNV.Size = new System.Drawing.Size(317, 44);
            this.TbTenNV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phòng Ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 317);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // ListNhanVien
            // 
            this.ListNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.GioiTinh,
            this.Luong,
            this.MaPB});
            this.ListNhanVien.FullRowSelect = true;
            this.ListNhanVien.GridLines = true;
            this.ListNhanVien.HideSelection = false;
            this.ListNhanVien.Location = new System.Drawing.Point(23, 35);
            this.ListNhanVien.Name = "ListNhanVien";
            this.ListNhanVien.Size = new System.Drawing.Size(945, 262);
            this.ListNhanVien.TabIndex = 0;
            this.ListNhanVien.UseCompatibleStateImageBehavior = false;
            this.ListNhanVien.View = System.Windows.Forms.View.Details;
            this.ListNhanVien.SelectedIndexChanged += new System.EventHandler(this.ListNhanVien_SelectedIndexChanged);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 179;
            // 
            // TenNV
            // 
            this.TenNV.Text = "Tên Nhân Viên";
            this.TenNV.Width = 237;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày Sinh";
            this.NgaySinh.Width = 145;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.Width = 120;
            // 
            // Luong
            // 
            this.Luong.Text = "Luong";
            this.Luong.Width = 120;
            // 
            // MaPB
            // 
            this.MaPB.Text = "Mã PB";
            this.MaPB.Width = 186;
            // 
            // SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.GrBThemNV);
            this.Name = "SuaNhanVien";
            this.Text = "SuaNhanVien";
            this.Load += new System.EventHandler(this.SuaNhanVien_Load);
            this.GrBThemNV.ResumeLayout(false);
            this.GrBThemNV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.GroupBox GrBThemNV;
        private System.Windows.Forms.Label LbMaNV;
        private System.Windows.Forms.TextBox TbLuong;
        private System.Windows.Forms.DateTimePicker DtNgaySinh;
        private System.Windows.Forms.TextBox TbTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbBoxPhong;
        private System.Windows.Forms.TextBox TbGioiTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListNhanVien;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader TenNV;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader Luong;
        private System.Windows.Forms.ColumnHeader MaPB;
    }
}