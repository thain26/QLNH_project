using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void btQuanLyBan_Click(object sender, EventArgs e)
        {
            ucQuanLyBan uctrl = new ucQuanLyBan();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(uctrl);
        }

        private void btQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ucQuanLyNhanVien uctrl = new ucQuanLyNhanVien();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(uctrl);
        }

        private void btMonAn_Click(object sender, EventArgs e)
        {
            ucMonAn uctrl = new ucMonAn();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(uctrl);
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            ucThongKe uctrl = new ucThongKe();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(uctrl);
        }
    }
}
