namespace WindowsFormsApp1.Controller
{
    partial class TimKiemNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListNhanVien = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTenNV = new System.Windows.Forms.TextBox();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lương = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(26, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 423);
            this.groupBox1.TabIndex = 0;
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
            this.Lương,
            this.MaPB});
            this.ListNhanVien.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListNhanVien.GridLines = true;
            this.ListNhanVien.HideSelection = false;
            this.ListNhanVien.Location = new System.Drawing.Point(19, 40);
            this.ListNhanVien.Name = "ListNhanVien";
            this.ListNhanVien.Size = new System.Drawing.Size(716, 362);
            this.ListNhanVien.TabIndex = 0;
            this.ListNhanVien.UseCompatibleStateImageBehavior = false;
            this.ListNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NV";
            // 
            // TbTenNV
            // 
            this.TbTenNV.Location = new System.Drawing.Point(174, 39);
            this.TbTenNV.Multiline = true;
            this.TbTenNV.Name = "TbTenNV";
            this.TbTenNV.Size = new System.Drawing.Size(546, 41);
            this.TbTenNV.TabIndex = 7;
            this.TbTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTenNV_KeyPress);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 77;
            // 
            // TenNV
            // 
            this.TenNV.Text = "Tên NV";
            this.TenNV.Width = 195;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày Sinh";
            this.NgaySinh.Width = 122;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.Width = 104;
            // 
            // Lương
            // 
            this.Lương.Text = "Lương";
            this.Lương.Width = 125;
            // 
            // MaPB
            // 
            this.MaPB.Text = "Mã PB";
            this.MaPB.Width = 93;
            // 
            // TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 541);
            this.Controls.Add(this.TbTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimKiemNhanVien";
            this.Text = "TimKiemNhanVien";
            this.Load += new System.EventHandler(this.TimKiemNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListNhanVien;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader TenNV;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader Lương;
        private System.Windows.Forms.ColumnHeader MaPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTenNV;
    }
}