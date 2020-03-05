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
using BaiThucHanhSo2.View;

namespace BaiThucHanhSo2.Controller
{
    public partial class FormController : Form
    {
        QuanLyHocSinhEntities1 db = new QuanLyHocSinhEntities1();
        public FormController()
        {
            InitializeComponent();
        }

        private void FormController_Load(object sender, EventArgs e)
        {
            HienLenTreView();
        }
        private void HienLenTreView()
        {
            TvLopHoc.Nodes.Clear();
            List<LopHoc> dsLopHoc = db.LopHocs.ToList();
            foreach (LopHoc lp in dsLopHoc)
            {
                TreeNode nodeLop = new TreeNode(lp.TenLop);
                nodeLop.Tag = lp;
                TvLopHoc.Nodes.Add(nodeLop);
                ThongTinGiangDay ttcn = db.ThongTinGiangDays.SingleOrDefault(x => x.MaLop == lp.MaLop && 
                x.LaGiaoVienChuNhiem == true);
                GiaoVien gvChuNhiem = db.GiaoViens.SingleOrDefault(x => x.MaGV == ttcn.MaGV);
                TreeNode nodeGv = new TreeNode(gvChuNhiem.TenGV);
                nodeGv.Tag = gvChuNhiem;
                nodeLop.Nodes.Add(nodeGv);
            }

            string str = "danh sach giao vien";
            TreeNode newNode = new TreeNode(str);
            newNode.Tag = str;
            TvLopHoc.Nodes.Add(newNode);

            HienDsGiaoVien(newNode);
        }
        private void HienDsGiaoVien(TreeNode newNode)
        {
            List<GiaoVien> dsGiaoVien = db.GiaoViens.ToList();
            foreach (GiaoVien gv in dsGiaoVien)
            {
                TreeNode nodeGv = new TreeNode(gv.TenGV);
                nodeGv.Tag = gv;
                newNode.Nodes.Add(nodeGv);
            }
        }

        private void FormController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn thoát chương trình chính không?", "Thông Báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                this.Show();
            }
        }

        private void TvLopHoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node!=null)
            {
                if(e.Node.Level==0)
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    if(lp!=null) HienThiDSHocSinhTheoLop(lp);
                    else LsHocSinh.Items.Clear();
                }
                else
                {
                    LsHocSinh.Items.Clear();
                    if(e.Node.Level==1)
                    {
                        Model.GiaoVien gv = e.Node.Tag as Model.GiaoVien;
                        if (gv != null) HienThiDSHSCuaGV(gv);
                        else LsHocSinh.Items.Clear();
                    }
                }
            }
        }

        private void HienThiDSHSCuaGV(Model.GiaoVien gv)
        {
            List<ThongTinGiangDay> dsLopHoc = db.ThongTinGiangDays.Where(x => x.MaGV == gv.MaGV).ToList();
            foreach(ThongTinGiangDay tt in dsLopHoc)
            {
                LopHoc lp = db.LopHocs.Find(tt.MaLop);
                HienThiDSHocSinhTheoLop(lp);
            }
        }

        private void HienThiDSHocSinhTheoLop(LopHoc lp)
        {
            LsHocSinh.Items.Clear();
            List<Model.HocSinh> dsHocSinh = db.HocSinhs.Where(x => x.MaLop == lp.MaLop).ToList();
            foreach (Model.HocSinh hs in dsHocSinh)
            {
                ListViewItem item = new ListViewItem(hs.MaHS.ToString());
                item.SubItems.Add(hs.TenHS);
                item.SubItems.Add(hs.NgaySinh.ToString());
                item.SubItems.Add(hs.GioiTinh);
                item.SubItems.Add(hs.MaLop);
                LsHocSinh.Items.Add(item);
            }
        }

        private void hocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thao tác với học sinh không?", "Thông Báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                FormQuanLyHocSinh ths = new FormQuanLyHocSinh();
                this.Hide();
                ths.ShowDialog();
                this.Show();
            }
        }

        private void giaoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thao tác với giáo viên không?", "Thông Báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                FormQuanLyGiaoVien ths = new FormQuanLyGiaoVien();
                this.Hide();
                ths.ShowDialog();
                this.Show();
            }
        }

        private void thôngTinGiangDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thao tác với thông tin giảng dạy của giáo viên không?", "Thông Báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                FormThongTinGiangDay ths = new FormThongTinGiangDay();
                this.Hide();
                ths.ShowDialog();
                this.Show();
            }
        }
    }
}
