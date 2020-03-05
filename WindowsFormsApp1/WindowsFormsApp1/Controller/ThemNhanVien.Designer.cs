namespace WindowsFormsApp1.Controller
{
    partial class ThemNhanVien
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
            this.GrBThemNV = new System.Windows.Forms.GroupBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.TbLuong = new System.Windows.Forms.TextBox();
            this.DTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TbTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListNhanVien = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNSNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinhNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuongNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTThemNV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CbBoxPhong = new System.Windows.Forms.ComboBox();
            this.TbGioiTinh = new System.Windows.Forms.TextBox();
            this.GrBThemNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBThemNV
            // 
            this.GrBThemNV.Controls.Add(this.TbGioiTinh);
            this.GrBThemNV.Controls.Add(this.CbBoxPhong);
            this.GrBThemNV.Controls.Add(this.lbMaNV);
            this.GrBThemNV.Controls.Add(this.TbLuong);
            this.GrBThemNV.Controls.Add(this.DTNgaySinh);
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
            this.GrBThemNV.Size = new System.Drawing.Size(973, 284);
            this.GrBThemNV.TabIndex = 0;
            this.GrBThemNV.TabStop = false;
            this.GrBThemNV.Text = "Thêm Nhân Viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(182, 57);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(37, 25);
            this.lbMaNV.TabIndex = 12;
            this.lbMaNV.Text = ".....";
            // 
            // TbLuong
            // 
            this.TbLuong.Location = new System.Drawing.Point(671, 119);
            this.TbLuong.Multiline = true;
            this.TbLuong.Name = "TbLuong";
            this.TbLuong.Size = new System.Drawing.Size(253, 44);
            this.TbLuong.TabIndex = 11;
            // 
            // DTNgaySinh
            // 
            this.DTNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaySinh.Location = new System.Drawing.Point(178, 209);
            this.DTNgaySinh.Name = "DTNgaySinh";
            this.DTNgaySinh.Size = new System.Drawing.Size(317, 30);
            this.DTNgaySinh.TabIndex = 10;
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
            // ListNhanVien
            // 
            this.ListNhanVien.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ListNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colTenNV,
            this.colNSNV,
            this.colGioiTinhNV,
            this.colLuongNV,
            this.colMaPB});
            this.ListNhanVien.HideSelection = false;
            this.ListNhanVien.Location = new System.Drawing.Point(12, 317);
            this.ListNhanVien.Name = "ListNhanVien";
            this.ListNhanVien.Size = new System.Drawing.Size(983, 233);
            this.ListNhanVien.TabIndex = 1;
            this.ListNhanVien.UseCompatibleStateImageBehavior = false;
            this.ListNhanVien.View = System.Windows.Forms.View.Details;
            this.ListNhanVien.SelectedIndexChanged += new System.EventHandler(this.ListNhanVien_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã Nhân Viên";
            this.colMaNV.Width = 107;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên Nhân Viên";
            this.colTenNV.Width = 324;
            // 
            // colNSNV
            // 
            this.colNSNV.Text = "Ngày Sinh";
            this.colNSNV.Width = 160;
            // 
            // colGioiTinhNV
            // 
            this.colGioiTinhNV.Text = "Giới Tính";
            this.colGioiTinhNV.Width = 113;
            // 
            // colLuongNV
            // 
            this.colLuongNV.Text = "Lương";
            this.colLuongNV.Width = 124;
            // 
            // colMaPB
            // 
            this.colMaPB.Text = "Mã Phòng Ban";
            this.colMaPB.Width = 126;
            // 
            // BTThemNV
            // 
            this.BTThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThemNV.Location = new System.Drawing.Point(190, 600);
            this.BTThemNV.Name = "BTThemNV";
            this.BTThemNV.Size = new System.Drawing.Size(187, 60);
            this.BTThemNV.TabIndex = 2;
            this.BTThemNV.Text = "Thêm ";
            this.BTThemNV.UseVisualStyleBackColor = true;
            this.BTThemNV.Click += new System.EventHandler(this.BTThemNV_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(683, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quay Lại Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CbBoxPhong
            // 
            this.CbBoxPhong.FormattingEnabled = true;
            this.CbBoxPhong.Location = new System.Drawing.Point(671, 213);
            this.CbBoxPhong.Name = "CbBoxPhong";
            this.CbBoxPhong.Size = new System.Drawing.Size(253, 33);
            this.CbBoxPhong.TabIndex = 13;
            // 
            // TbGioiTinh
            // 
            this.TbGioiTinh.Location = new System.Drawing.Point(671, 29);
            this.TbGioiTinh.Multiline = true;
            this.TbGioiTinh.Name = "TbGioiTinh";
            this.TbGioiTinh.Size = new System.Drawing.Size(253, 44);
            this.TbGioiTinh.TabIndex = 14;
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 723);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTThemNV);
            this.Controls.Add(this.ListNhanVien);
            this.Controls.Add(this.GrBThemNV);
            this.Name = "ThemNhanVien";
            this.Text = "ThemNhanVien";
            this.Load += new System.EventHandler(this.ThemNhanVien_Load);
            this.GrBThemNV.ResumeLayout(false);
            this.GrBThemNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBThemNV;
        private System.Windows.Forms.ListView ListNhanVien;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colNSNV;
        private System.Windows.Forms.ColumnHeader colGioiTinhNV;
        private System.Windows.Forms.ColumnHeader colLuongNV;
        private System.Windows.Forms.ColumnHeader colMaPB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTenNV;
        private System.Windows.Forms.DateTimePicker DTNgaySinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox TbLuong;
        private System.Windows.Forms.Button BTThemNV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CbBoxPhong;
        private System.Windows.Forms.TextBox TbGioiTinh;
    }
}