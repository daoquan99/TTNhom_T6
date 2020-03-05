namespace WindowsFormsApp1.Controller
{
    partial class FormDangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbMatKhau = new System.Windows.Forms.TextBox();
            this.TbQuocTich = new System.Windows.Forms.TextBox();
            this.BtDangKy = new System.Windows.Forms.Button();
            this.PnGt = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RdNam = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.PnGt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Thông Tin Người Dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính: ";
            // 
            // TbTaiKhoan
            // 
            this.TbTaiKhoan.Location = new System.Drawing.Point(213, 92);
            this.TbTaiKhoan.Name = "TbTaiKhoan";
            this.TbTaiKhoan.Size = new System.Drawing.Size(289, 36);
            this.TbTaiKhoan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quốc Tịch :";
            // 
            // TbMatKhau
            // 
            this.TbMatKhau.Location = new System.Drawing.Point(213, 149);
            this.TbMatKhau.Name = "TbMatKhau";
            this.TbMatKhau.Size = new System.Drawing.Size(289, 36);
            this.TbMatKhau.TabIndex = 6;
            // 
            // TbQuocTich
            // 
            this.TbQuocTich.Location = new System.Drawing.Point(213, 269);
            this.TbQuocTich.Name = "TbQuocTich";
            this.TbQuocTich.Size = new System.Drawing.Size(289, 36);
            this.TbQuocTich.TabIndex = 9;
            // 
            // BtDangKy
            // 
            this.BtDangKy.Location = new System.Drawing.Point(201, 349);
            this.BtDangKy.Name = "BtDangKy";
            this.BtDangKy.Size = new System.Drawing.Size(161, 41);
            this.BtDangKy.TabIndex = 10;
            this.BtDangKy.Text = "Đăng Ký";
            this.BtDangKy.UseVisualStyleBackColor = true;
            this.BtDangKy.Click += new System.EventHandler(this.BtDangKy_Click);
            // 
            // PnGt
            // 
            this.PnGt.Controls.Add(this.radioButton2);
            this.PnGt.Controls.Add(this.RdNam);
            this.PnGt.Location = new System.Drawing.Point(213, 191);
            this.PnGt.Name = "PnGt";
            this.PnGt.Size = new System.Drawing.Size(289, 61);
            this.PnGt.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(186, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 33);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RdNam
            // 
            this.RdNam.AutoSize = true;
            this.RdNam.Location = new System.Drawing.Point(37, 14);
            this.RdNam.Name = "RdNam";
            this.RdNam.Size = new System.Drawing.Size(88, 33);
            this.RdNam.TabIndex = 9;
            this.RdNam.TabStop = true;
            this.RdNam.Text = "Nam";
            this.RdNam.UseVisualStyleBackColor = true;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 415);
            this.Controls.Add(this.PnGt);
            this.Controls.Add(this.BtDangKy);
            this.Controls.Add(this.TbQuocTich);
            this.Controls.Add(this.TbMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký ";
            this.panel1.ResumeLayout(false);
            this.PnGt.ResumeLayout(false);
            this.PnGt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbMatKhau;
        private System.Windows.Forms.TextBox TbQuocTich;
        private System.Windows.Forms.Button BtDangKy;
        private System.Windows.Forms.Panel PnGt;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton RdNam;
    }
}