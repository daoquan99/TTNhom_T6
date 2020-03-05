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
    public partial class FormQuanLyHocSinh : Form
    {
        QuanLyHocSinhEntities1 db = new QuanLyHocSinhEntities1();   
        public FormQuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void FormQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            List<HocSinh> dsHocSinh =db.HocSinhs.ToList();
            HienDSHocSinh(dsHocSinh);
        }

        private void LstHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstHocSinh.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = LstHocSinh.SelectedItems[0];
                lbMaHS.Text = itemSelected.SubItems[0].Text;
                tbTenHS.Text = itemSelected.SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(itemSelected.SubItems[2].Text);

                if (itemSelected.SubItems[3].Text == "Nam") rdNam.Checked = true;
                else rdNu.Checked = true;

                cbLopHoc.SelectedValue = itemSelected.SubItems[4].Text;
            }
        }
        string gioiTinh(Panel pan)
        {
            foreach(RadioButton rad in pan.Controls)
            {
                if (rad.Checked == true) return rad.Text;
            }
            return "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
           try
            {
                HocSinh hs = new HocSinh()
                {
                    TenHS = tbTenHS.Text,
                    NgaySinh = dtNgaySinh.Value,
                    GioiTinh = gioiTinh(pnGioiTinh),
                    MaLop = cbLopHoc.SelectedValue.ToString()
                };
                db.HocSinhs.Add(hs);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!","Thông báo: ");
                FormQuanLyHocSinh_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm thất bai. chi tiết lỗi: " + ex.Message, "Thông báo: ");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = db.HocSinhs.Find(int.Parse(lbMaHS.Text));
                hs.TenHS = tbTenHS.Text;
                hs.NgaySinh = dtNgaySinh.Value;
                hs.GioiTinh = gioiTinh(pnGioiTinh);
                hs.MaLop = cbLopHoc.SelectedValue.ToString();

                db.SaveChanges();
                MessageBox.Show("Sửa thành công!","thông báo");
                FormQuanLyHocSinh_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa thất bai. Chi tiết lỗi: " + ex.Message, "thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = db.HocSinhs.Find(int.Parse(lbMaHS.Text));
            if(MessageBox.Show("Bạn có muốn xóa học sinh đã chọn không?","thông báo: ",
                MessageBoxButtons.YesNo) ==System.Windows.Forms.DialogResult.Yes)
            {
                db.HocSinhs.Remove(hs);
                db.SaveChanges();
                MessageBox.Show("xóa thành công!", "Thông báo: ");
                FormQuanLyHocSinh_Load(sender, e);
            }
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string res = tbTimKiem.Text;
            if(res=="")
            {
                List<HocSinh> dsHocSinh = db.HocSinhs.ToList();
                HienDSHocSinh(dsHocSinh);
            }
            else
            {
                List<HocSinh> dsHocSinh = db.HocSinhs.Where(x => x.TenHS.ToUpper().Contains(res.ToUpper()) ).ToList();
                HienDSHocSinh(dsHocSinh);
            }

        }
        private void HienDSHocSinh(List<HocSinh> dsHocSinh)
        {
            LstHocSinh.Items.Clear();
            foreach (HocSinh hs in dsHocSinh)
            {
                ListViewItem item = new ListViewItem(hs.MaHS.ToString());
                item.SubItems.Add(hs.TenHS);
                item.SubItems.Add(hs.NgaySinh.ToString());

                item.SubItems.Add(hs.GioiTinh);
                item.SubItems.Add(hs.MaLop);

                LstHocSinh.Items.Add(item);
            }
            cbLopHoc.DataSource = db.LopHocs.ToList();
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
            
        }
    }
}
