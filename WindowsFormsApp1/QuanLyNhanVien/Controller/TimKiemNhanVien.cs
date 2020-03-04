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
    public partial class TimKiemNhanVien : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void HienThiKetQua(List<NhanVien> dsNhanVien)
        {
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
        }
        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = db.NhanViens.ToList();
            HienThiKetQua(dsNhanVien);
        }
        private void TbTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenNV = TbTenNV.Text;
            if(tenNV=="")
            {
                HienThiKetQua(db.NhanViens.ToList());
            }
            else
            {
                List<NhanVien> KetQua = db.NhanViens.Where( x => x.TenNV.ToUpper().Contains(tenNV.ToUpper())).ToList();
                HienThiKetQua(KetQua);
            }
        }
    }
}
