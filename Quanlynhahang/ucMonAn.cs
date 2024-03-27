using Quanlynhahang.DAL;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class ucMonAn : UserControl
    {
        public ucMonAn()
        {
            InitializeComponent();
        }

        void LoadListDanhMuc()
        {
            List<DanhMuc> list = DanhMucDAL.Instance.GetListDanhMuc();
            cbDanhMuc.DataSource = list;
            cbDanhMuc.DisplayMember = "Name";
        }

        void LoadListMonAn()
        {
            dgvMonAn.DataSource = MonAnDAL.Instance.GetListMonAn();
        }

        private void ucMonAn_Load(object sender, EventArgs e)
        {
            LoadListMonAn();
            LoadListDanhMuc();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu của textbox thêm món ăn
            string tenMonAn = tbTenMonAn.Text;

            DanhMuc selected = cbDanhMuc.SelectedItem as DanhMuc;
            int idDanhMuc = selected.Id;

            float gia = (float)(Convert.ToDouble(tbGia.Text));

            //thực hiện thêm món ăn vào csdl
            MonAnDAL.Instance.AddMonAn(tenMonAn, idDanhMuc, gia);

            LoadListMonAn();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int idDanhMuc = DanhMucDAL.Instance.GetIdDanhMuc(cbDanhMuc.Text);

            string newTenMon = tbTenMonAn.Text;

            string tenMon = dgvMonAn.CurrentRow.Cells[0].Value.ToString();

            float gia = (float)Convert.ToDouble(tbGia.Text);

            //thực hiện sửa thông tin món ăn thông qua tên
            MonAnDAL.Instance.UpdateMonAn(newTenMon, tenMon, idDanhMuc, gia);

            LoadListMonAn();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string tenMon = tbTenMonAn.Text;

            MonAnDAL.Instance.RemoveMonAn(tenMon);

            LoadListMonAn();
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTenMonAn.Text = dgvMonAn.CurrentRow.Cells[0].Value.ToString();
            tbGia.Text = dgvMonAn.CurrentRow.Cells[2].Value.ToString();
            cbDanhMuc.Text = dgvMonAn.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
