namespace WindowsFormsApp1.Controller
{
    partial class FormPhongBan
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPhongBan = new System.Windows.Forms.ListView();
            this.MaPb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay Lại Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listPhongBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng Ban";
            // 
            // listPhongBan
            // 
            this.listPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPb,
            this.TenPB});
            this.listPhongBan.FullRowSelect = true;
            this.listPhongBan.GridLines = true;
            this.listPhongBan.HideSelection = false;
            this.listPhongBan.Location = new System.Drawing.Point(22, 56);
            this.listPhongBan.Name = "listPhongBan";
            this.listPhongBan.Size = new System.Drawing.Size(684, 339);
            this.listPhongBan.TabIndex = 0;
            this.listPhongBan.UseCompatibleStateImageBehavior = false;
            this.listPhongBan.View = System.Windows.Forms.View.Details;
            // 
            // MaPb
            // 
            this.MaPb.Text = "Mã Phòng Ban";
            this.MaPb.Width = 254;
            // 
            // TenPB
            // 
            this.TenPB.Text = "Tên Phòng Ban";
            this.TenPB.Width = 428;
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listPhongBan;
        private System.Windows.Forms.ColumnHeader MaPb;
        private System.Windows.Forms.ColumnHeader TenPB;
    }
}