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

namespace BaiThucHanhSo2.View
{
    public partial class FormQuanLyGiaoVien : Form
    {
        QuanLyHocSinhEntities1 db = new QuanLyHocSinhEntities1();
        public FormQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            List<GiaoVien> dsGiaoVien = db.GiaoViens.ToList();
            HienThiDSGiaoVien(dsGiaoVien);
        }

        private void HienThiDSGiaoVien(List<GiaoVien> dsGiaoVien)
        {
            LstGiaoVien.Items.Clear();
            foreach(GiaoVien gv in dsGiaoVien)
            {
                ListViewItem item = new ListViewItem(gv.MaGV);
                item.SubItems.Add(gv.TenGV);
                item.SubItems.Add(gv.NgaySinh.ToString());

                item.SubItems.Add(gv.GioiTinh);
                item.SubItems.Add(gv.Luong.ToString());

                LstGiaoVien.Items.Add(item);
            }
        }

        private void LstGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LstGiaoVien.SelectedItems.Count>0)
            {
                ListViewItem selectedItem = LstGiaoVien.SelectedItems[0];
                tbMaGV.Text = selectedItem.SubItems[0].Text;
                tbTenGV.Text = selectedItem.SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[2].Text);
                if (selectedItem.SubItems[3].Text == "Nam") rdNam.Checked = true;
                else rdNu.Checked = true;
                nUDLuong.Value = decimal.Parse(selectedItem.SubItems[4].Text);
            }
        }

        string gioiTinh(Panel pan)
        {
            foreach (RadioButton rad in pan.Controls)
            {
                if (rad.Checked == true) return rad.Text;
            }
            return "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien()
            {
                MaGV = tbMaGV.Text,
                TenGV = tbTenGV.Text,
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = gioiTinh(pnGioiTinh),
                Luong = nUDLuong.Value
            };
            GiaoVien GV1 = db.GiaoViens.SingleOrDefault(x => x.MaGV == gv.MaGV);
            if(GV1!=null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại!", "Thông báo");
            }
            else
            {
                db.GiaoViens.Add(gv);
                db.SaveChanges();
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo: ");
                FormQuanLyGiaoVien_Load(sender, e);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien gv = db.GiaoViens.Find(tbMaGV.Text);
                gv.TenGV = tbTenGV.Text;
                gv.NgaySinh = dtNgaySinh.Value;
                gv.GioiTinh = gioiTinh(pnGioiTinh);
                gv.Luong = nUDLuong.Value;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công. Đã lưu thay đổi!", "thông báo");
                FormQuanLyGiaoVien_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa thất bai. Chi Tiết lỗi: " + ex.Message, "Thông báo: ");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = db.GiaoViens.SingleOrDefault(x => x.MaGV == tbMaGV.Text);
            if (gv == null) MessageBox.Show("Đối tượng Giáo Viên không tồn tại!", "Thông báo: ");
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa giáo viên đã chọn không?", "thông báo: ",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.GiaoViens.Remove(gv);
                    db.SaveChanges();
                    MessageBox.Show("xóa thành công!", "Thông báo: ");
                    FormQuanLyGiaoVien_Load(sender, e);
                }
            }
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string TenGV = tbTimKiem.Text;
            List<GiaoVien> dsGiaoVien = db.GiaoViens.Where(x => x.TenGV.ToUpper()
                                            .Contains(TenGV.ToUpper())).ToList();
            if(TenGV=="")
            {
                HienThiDSGiaoVien(db.GiaoViens.ToList());
            }
            else
            {
                HienThiDSGiaoVien(dsGiaoVien);
            }
        }
    }
}
