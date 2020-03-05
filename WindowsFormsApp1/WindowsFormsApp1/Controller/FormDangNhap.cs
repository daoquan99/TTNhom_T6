using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public partial class FormDangNhap : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void BtDangNhap_Click(object sender, EventArgs e)
        {
            string name = TbName.Text;
            string pas = TbPass.Text;
            if (name.Length == 0) MessageBox.Show("Bạn Chưa điền tên tài khoản", "thông báo");
            User user1 = db.Users.SingleOrDefault(x => x.TenTk == name && x.MatKhau == pas);
            if(user1!=null)
            {
                GioiThieu gt = new GioiThieu();
                this.Hide();
                gt.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "thông báo");
        }

        private void BtDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy fmDK = new FormDangKy();
            this.Hide();
            fmDK.ShowDialog();
            this.Close();
        }
    }
}
