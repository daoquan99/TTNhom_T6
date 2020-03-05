using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiThucHanhSo2.Model;
using BaiThucHanhSo2.Controller;

namespace BaiThucHanhSo2.View
{
    public partial class FmDangNhap : Form
    {
        QuanLyHocSinhEntities1 db = new QuanLyHocSinhEntities1();
        public FmDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            User nguoiDung = db.Users.SingleOrDefault(x => x.TenDangNhap == TbTaiKhoan.Text && x.Pass == TbMatKhau.Text);
            if (TbTaiKhoan.Text.Length == 0) MessageBox.Show("Bạn chưa nhập tài khoản!");
            else
            {
                if (TbMatKhau.Text.Length == 0) MessageBox.Show("Bạn chưa nhập mật khẩu!");
                else
                {
                    if (nguoiDung != null)
                    {
                        FormController fm = new FormController();
                        this.Hide();
                        fm.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Tài Khoản hoặc mật khẩu không chính xác!");
                }
            }
        }

        private void FmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn thoát hệ thống đăng nhập không?", "Thông Báo",
               MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                this.Show();
            }
        }
    }
}
