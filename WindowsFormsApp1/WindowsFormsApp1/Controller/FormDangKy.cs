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
    
    public partial class FormDangKy : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void BtDangKy_Click(object sender, EventArgs e)
        {
            string TaiKhoan = TbTaiKhoan.Text;
            User ktrUser = db.Users.SingleOrDefault(x => x.TenTk == TaiKhoan);
            if (ktrUser == null)
            {
                User userNew = new User()
                {
                    TenTk = TbTaiKhoan.Text,
                    MatKhau = TbMatKhau.Text,
                    GioiTinh = CheckGioiTinh(PnGt),
                    QuocTich = TbQuocTich.Text
                };
                db.Users.Add(userNew);
                db.SaveChanges();
                MessageBox.Show("Đăng ký thành công", "thông báo");
                FormDangNhap fmDN = new FormDangNhap();
                this.Hide();
                fmDN.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tài khoản đã tồn tại", "thông báo");
        }
        string CheckGioiTinh(Panel pnGT)
        {
            foreach(RadioButton rad in pnGT.Controls)
            {
                if (rad.Checked) return rad.Text;
            }
            return " ";
        }

    }
}
