using Quanlynhahang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
            dtpThangCuoi.CustomFormat = "MM/yyyy";
            dtpThangDau.CustomFormat = "MM/yyyy";
            dateTimePicker4.CustomFormat = "MM/yyyy";
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDonDAL.Instance.GetListHoaDon(dtpNgayDau.Value, dtpNgayCuoi.Value);
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
