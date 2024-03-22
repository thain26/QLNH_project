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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void btQuanLyBan_Click(object sender, EventArgs e)
        {
            ucQuanLyBan f = new ucQuanLyBan();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(f);
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            ucDoanhThu uctrl = new ucDoanhThu();
            pnShow.Controls.Clear();
            pnShow.Controls.Add(uctrl);
        }
    }
}
