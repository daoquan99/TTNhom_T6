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
    public partial class FormNhanVien : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
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

        }
    }
}
