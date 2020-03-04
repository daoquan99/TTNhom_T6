using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1.Controller
{
    public partial class ThemNhanVien : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = db.NhanViens.ToList();
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
            
        }

        private void BTThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien()
                {
                    TenNV = TbTenNV.Text,
                    NgaySinh = DTNgaySinh.Value,
                    GioiTinh = TbGioiTinh.Text,
                    Luong = int.Parse(TbLuong.Text),
                    MaPB = int.Parse(CbBoxPhong.SelectedValue.ToString()),
                };
                db.NhanViens.Add(nv);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                ListViewItem newItem = new ListViewItem(nv.MaNV.ToString());
                newItem.SubItems.Add(nv.TenNV);
                newItem.SubItems.Add(nv.NgaySinh.ToString());
                newItem.SubItems.Add(nv.GioiTinh);
                newItem.SubItems.Add(nv.Luong.ToString());
                newItem.SubItems.Add(nv.MaPB.ToString());
                ListNhanVien.Items.Add(newItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }
    }
}
