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

namespace WindowsFormsApp1.Controller
{
    public partial class XoaNhanVien : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public XoaNhanVien()
        {
            InitializeComponent();
        }

        private void GrBThemNV_Enter(object sender, EventArgs e)
        {

        }

        private void XoaNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = db.NhanViens.ToList();
            ListNhanVien.Items.Clear();
            foreach (NhanVien nv in dsNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV.ToString());
                item.SubItems.Add(nv.TenNV);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.Luong.ToString());
                item.SubItems.Add(nv.MaPB.ToString());
                ListNhanVien.Items.Add(item);
            }
            CbBoxPhong.DataSource = db.PhongBans.ToList();
            CbBoxPhong.DisplayMember = "TenPB";
            CbBoxPhong.ValueMember = "MaPB";
        }

        private void ListNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = ListNhanVien.SelectedItems[0];
                LbMaNV.Text = itemSelected.SubItems[0].Text;
                TbTenNV.Text = itemSelected.SubItems[1].Text;
                DtNgaySinh.Value = DateTime.Parse(itemSelected.SubItems[2].Text);
                TbGioiTinh.Text = itemSelected.SubItems[3].Text;
                TbLuong.Text = itemSelected.SubItems[4].Text;
                CbBoxPhong.SelectedValue = int.Parse(itemSelected.SubItems[5].Text);
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
             NhanVien nv = db.NhanViens.Find(int.Parse(LbMaNV.Text));
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            MessageBox.Show("Xóa Thành Công");
            XoaNhanVien_Load(sender, e);
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
