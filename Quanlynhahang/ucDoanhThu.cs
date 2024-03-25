using Quanlynhahang.DAL;
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
    public partial class ucDoanhThu : UserControl
    {
        public ucDoanhThu()
        {
            InitializeComponent();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDonDAL.Instance.GetListHoaDon(dtpNgayDau.Value, dtpNgayCuoi.Value);
        }
    }
}
