using Quanlynhahang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class ucQuanLyNhanVien : UserControl
    {
        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }


        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            /*
            string query = "select * from NhanVien";

            dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            */

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Add(tbMa.Text, tbHoTen.Text,dtpNgaySinh.Text,cbGioiTinh.Text, tbCCCD.Text, tbSDT.Text);

            tbHoTen.Clear();
            tbCCCD.Clear();
            tbSDT.Clear();
            tbCCCD.Clear();
            
            /*
            string query = "insert into NhanVien( CCCD, ten, ngaySinh, gioiTinh, SDT) values ( N'" + tbCCCD.Text + "', N'" + tbHoTen.Text + "', '" + dtpNgaySinh.Value + "', N'" + cbGioiTinh.Text + "', N'" + tbSDT.Text + "')";

            DataProvider.Instance.ExecuteQuery(query);

            ucQuanLyNhanVien_Load(sender, e);
            */
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedCells[0].RowIndex);
            }
            /*
            string query = "delete from NhanVien where Ma = " + Convert.ToString(dgvNhanVien.CurrentRow.Cells[0].Value);

            DataProvider.Instance.ExecuteQuery(query);

            ucQuanLyNhanVien_Load(sender, e);
            */
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbMa.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[0].Value);
            tbCCCD.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[3].Value);
            tbHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[1].Value);
            tbSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[4].Value);
            //cbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[4].Value);
            dtpNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells[2].Value);
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            dgvNhanVien.CurrentRow.Cells[0].Value = tbMa.Text;
            dgvNhanVien.CurrentRow.Cells[3].Value = tbCCCD.Text;
            dgvNhanVien.CurrentRow.Cells[1].Value = tbHoTen.Text;
            dgvNhanVien.CurrentRow.Cells[4].Value = tbSDT.Text;
            dgvNhanVien.CurrentRow.Cells[2].Value = dtpNgaySinh.Value;
        }
    }
}
