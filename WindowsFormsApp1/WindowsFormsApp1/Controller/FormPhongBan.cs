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
    public partial class FormPhongBan : Form
    {
        QuanLyNhanVienEntities2 db = new QuanLyNhanVienEntities2();
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            List<PhongBan> dsPhongBan = db.PhongBans.ToList();
            foreach(PhongBan x in dsPhongBan)
            {
                ListViewItem item = new ListViewItem(x.MaPB.ToString());
                item.SubItems.Add(x.TenPB);
                listPhongBan.Items.Add(item);
            }
        }
    }
}
