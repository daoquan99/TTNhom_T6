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
    public partial class FormThongTinGiangDay : Form
    {
        QuanLyHocSinhEntities1 db = new QuanLyHocSinhEntities1();
        public FormThongTinGiangDay()
        {
            InitializeComponent();
        }
        private void FormThongTinGiangDay_Load(object sender, EventArgs e)
        {
            lstTT.Items.Clear();
            List<LopHoc> dsLopHoc = db.LopHocs.ToList();
            List<GiaoVien> dsGiaoVien = db.GiaoViens.ToList();
            HienDsLop(dsLopHoc);
            HienDsGiaoVien(dsGiaoVien);
            cbGiaoVien.DataSource = db.GiaoViens.ToList();
            cbGiaoVien.DisplayMember = "TenGV";
            cbGiaoVien.ValueMember = "MaGV";
            cbLopHoc.DataSource = db.LopHocs.ToList();
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
            cbGiaoVien.Text = " ";
            cbLopHoc.Text = " ";
            
        }
        /// <summary>
        /// Hiện danh sách giáo viên lên treeView
        /// </summary>
        /// <param name="dsGiaoVien"></param>
        private void HienDsGiaoVien(List<GiaoVien> dsGiaoVien)
        {
            string str1 = "Danh sách giáo viên : ";
            TreeNode nodeDsGV = new TreeNode(str1);
            nodeDsGV.Tag = str1;
            treeViewTT.Nodes.Add(nodeDsGV);
            HienNodeConGV(nodeDsGV);
        }
        private void HienNodeConGV(TreeNode nodeDsGV)
        {
            List<GiaoVien> DsGV = db.GiaoViens.ToList();
            foreach(GiaoVien gv in DsGV)
            {
                TreeNode nodeGv = new TreeNode(gv.TenGV);
                nodeGv.Tag = gv;
                nodeDsGV.Nodes.Add(nodeGv);
            }
        }
        /// <summary>
        /// Hiện danh sách lớp lên treeView 
        /// </summary>
        /// <param name="dsLopHoc"></param>
        private void HienDsLop(List<LopHoc> dsLopHoc)
        {
            treeViewTT.Nodes.Clear();
            string str1 = "Danh sách lớp học : ";
            TreeNode nodeDsLH = new TreeNode(str1);
            nodeDsLH.Tag = str1;
            treeViewTT.Nodes.Add(nodeDsLH);

            HienNodeConLopHoc(nodeDsLH);
        }
        private void HienNodeConLopHoc(TreeNode newNode)
        {
            List<LopHoc> dsLopHoc = db.LopHocs.ToList();
            foreach (LopHoc lp in dsLopHoc)
            {
                TreeNode nodeLop = new TreeNode(lp.TenLop);
                nodeLop.Tag = lp;
                newNode.Nodes.Add(nodeLop);
            }
        }

        /// <summary>
        /// Chọn trên treeView để hiện thị lên listView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewTT_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node!=null)
            {
                if(e.Node.Level==1)
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    GiaoVien gv = e.Node.Tag as GiaoVien;
                    if (lp != null)
                    {
                        HienGVLen(lp);
                    }
                    if (gv != null)
                    {
                        HienLopLen(gv);
                    }
                }
            }
        }
        /// <summary>
        /// Hiện danh sách các lớp dạy của giáo viên được chọn trên treeView để hiện lên ListView
        /// </summary>
        /// <param name="gv"></param>
        private void HienLopLen(GiaoVien gv)
        {
            lstTT.Items.Clear();
            List<ThongTinGiangDay> dsLp = db.ThongTinGiangDays.Where(x => x.MaGV == gv.MaGV).ToList();
            cbGiaoVien.Text = gv.TenGV;
            cbLopHoc.DataSource = db.LopHocs.ToList();
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
            foreach (ThongTinGiangDay tt in dsLp)
            {
                ListViewItem newItem = new ListViewItem(gv.MaGV);
                newItem.SubItems.Add(gv.TenGV);
                LopHoc lp = db.LopHocs.SingleOrDefault(x => x.MaLop == tt.MaLop);
                newItem.SubItems.Add(lp.TenLop);
                newItem.SubItems.Add(lp.SiSo.ToString());
                newItem.SubItems.Add(tt.LaGiaoVienChuNhiem.ToString());
                cbLopHoc.Text = LopDay(dsLp);
                lstTT.Items.Add(newItem);
            }
            
            if (dsLp.Count == 0)
            {
                cbLopHoc.Text = " ";
                rdBtTrue.Checked = false;
                rdBtFalse.Checked = false;
            }
        }
        private string LopDay(List<ThongTinGiangDay> dsLp)
        {
            foreach(ThongTinGiangDay tt in dsLp)
            {
                if(tt.LaGiaoVienChuNhiem==true)
                {
                    LopHoc lp = db.LopHocs.SingleOrDefault(x => x.MaLop == tt.MaLop);
                    return lp.TenLop;
                }
            }
            return " ";
        }
        /// <summary>
        /// Hiện ds các giáo viên dạy lớp đã chọn trên treeView
        /// </summary>
        /// <param name="lp"></param>
        private void HienGVLen(LopHoc lp)
        {
            lstTT.Items.Clear();
            List<ThongTinGiangDay> dsGv = db.ThongTinGiangDays.Where(x => x.MaLop == lp.MaLop).ToList();
            cbLopHoc.Text = lp.TenLop;
            cbGiaoVien.DataSource = db.GiaoViens.ToList();
            cbGiaoVien.DisplayMember = "TenGV";
            cbGiaoVien.ValueMember = "MaGV";

            foreach (ThongTinGiangDay tt in dsGv)
            {
                GiaoVien gv= db.GiaoViens.SingleOrDefault(x => x.MaGV == tt.MaGV);
                ListViewItem newItem = new ListViewItem(gv.MaGV);
                newItem.SubItems.Add(gv.TenGV);

                newItem.SubItems.Add(lp.TenLop);
                newItem.SubItems.Add(lp.SiSo.ToString());
                newItem.SubItems.Add(tt.LaGiaoVienChuNhiem.ToString());
                lstTT.Items.Add(newItem);
                if (tt.LaGiaoVienChuNhiem.ToString() == "True") rdBtTrue.Checked = true;
                else rdBtFalse.Checked = true;
                cbGiaoVien.Text = GVChuNhiem(dsGv);
            }
            if (dsGv.Count == 0)
            {
                cbGiaoVien.Text = " ";
                rdBtFalse.Checked = false;
                rdBtTrue.Checked = false;
            }
        }

        private string GVChuNhiem(List<ThongTinGiangDay> dsGv)
        {
           foreach(ThongTinGiangDay tt in dsGv)
           {
                if(tt.LaGiaoVienChuNhiem==true)
                {
                    GiaoVien gv = db.GiaoViens.SingleOrDefault(x => x.MaGV == tt.MaGV);
                    return gv.TenGV;
                }
           }
            return "";
        }

        private void lstTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTT.SelectedItems.Count>0)
            {
                ListViewItem itemSelected = lstTT.SelectedItems[0];
                cbGiaoVien.Text = itemSelected.SubItems[1].Text;
                cbLopHoc.Text = itemSelected.SubItems[2].Text;
                if (itemSelected.SubItems[4].Text == "True") rdBtTrue.Checked = true;
                else rdBtFalse.Checked = true;
            }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string res = "";
            ThongTinGiangDay ttNew = new ThongTinGiangDay()
            {
                MaLop = cbLopHoc.SelectedValue.ToString(),
                MaGV = cbGiaoVien.SelectedValue.ToString(),
                LaGiaoVienChuNhiem = LaChuNhiem(pnTF)
            };
            ThongTinGiangDay ktra = db.ThongTinGiangDays.SingleOrDefault(x =>x.MaGV == ttNew.MaGV && x.MaLop == ttNew.MaLop);

            if (ktra != null) MessageBox.Show("Không thêm được giáo viên này đã đang dạy lớp này!", "Thông báo: ");
            else
            {
                List<ThongTinGiangDay> DsKtra = db.ThongTinGiangDays.Where(x => x.MaLop == ttNew.MaLop).ToList();
                if (KtraGiaoVienChuNhiem(DsKtra)==true)
                    MessageBox.Show("Lớp này đã có giáo viên chủ nhiệm!", "Thông báo: ");
                else
                {
                    db.ThongTinGiangDays.Add(ttNew);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo :");
                    FormThongTinGiangDay_Load(sender, e);
                }
            }
        }

        private bool KtraGiaoVienChuNhiem(List<ThongTinGiangDay> dsKtra)
        {
            foreach(ThongTinGiangDay tt in dsKtra)
            {
                if (tt.LaGiaoVienChuNhiem == true) return true;

            }
            return false;
        }

        bool LaChuNhiem(Panel pan)
        {
            foreach(RadioButton rad in pan.Controls)
            {
                if (rad.Checked == true) return bool.Parse(rad.Text); 
            }
            return false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maGV = cbGiaoVien.SelectedValue.ToString();
            string maLop = cbLopHoc.SelectedValue.ToString();
            ThongTinGiangDay ttNew = db.ThongTinGiangDays.SingleOrDefault(x => x.MaGV == maGV && x.MaLop == maLop);
            if(MessageBox.Show("Bạn có muốn xóa thông tin đã chọn không?","Thông báo: ",
                        MessageBoxButtons.YesNo) ==System.Windows.Forms.DialogResult.Yes)
            {
                db.ThongTinGiangDays.Remove(ttNew);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công!", "Thông báo: ");
                FormThongTinGiangDay_Load(sender, e);
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            string maGv = cbGiaoVien.SelectedValue.ToString();
            string maLop = cbLopHoc.SelectedValue.ToString();
            ThongTinGiangDay ttGiangDay = db.ThongTinGiangDays.SingleOrDefault(x => x.MaGV == maGv && x.MaLop == maLop);
            foreach(RadioButton rad in pnTF.Controls)
            {
                if(rad.Checked==true) ttGiangDay.LaGiaoVienChuNhiem=rad.Checked;
            }
            
            if (ttGiangDay.LaGiaoVienChuNhiem==false)
            {
                db.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công!", "thông báo");
                FormThongTinGiangDay_Load(sender, e);
            }
            else
            {
                List<ThongTinGiangDay> DsKtra = db.ThongTinGiangDays.Where(x => x.MaLop == ttGiangDay.MaLop).ToList();
                if (KtraGiaoVienChuNhiem(DsKtra) == true)
                    MessageBox.Show("Lớp này đã có giáo viên chủ nhiệm!", "Thông báo: ");
                else
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo :");
                    FormThongTinGiangDay_Load(sender, e);
                }
            }
        }
    }
}
