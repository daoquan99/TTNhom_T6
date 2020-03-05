using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.View
{
    public partial class GioiThieu : Form
    {
        public GioiThieu()
        {
            InitializeComponent();
        }

        private void BTThemNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNV = new ThemNhanVien();
            this.Hide();
            themNV.ShowDialog();
            this.Show();
        }

        private void GioiThieu_Load(object sender, EventArgs e)
        {

        }

        private void BtSuaNV_Click(object sender, EventArgs e)
        {
            SuaNhanVien suaNV = new SuaNhanVien();
            this.Hide();
            suaNV.ShowDialog();
            this.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtXoaNV_Click(object sender, EventArgs e)
        {
            XoaNhanVien xoaNV = new XoaNhanVien();
            this.Hide();
            xoaNV.ShowDialog();
            this.Show();
        }

        private void BtTimNV_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien timKiem = new TimKiemNhanVien();
            this.Hide();
            timKiem.ShowDialog();
            this.Show();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhongBan pb = new FormPhongBan();
            this.Hide();
            pb.ShowDialog();
            this.Show();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKy fmdk = new FormDangKy();
            this.Hide();
            fmdk.ShowDialog();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap fmdn = new FormDangNhap();
            this.Hide();
            fmdn.ShowDialog();
            this.Close();
        }
    }
}
