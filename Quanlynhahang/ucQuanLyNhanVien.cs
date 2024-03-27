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
using static System.Net.WebRequestMethods;

namespace Quanlynhahang
{
    public partial class ucQuanLyNhanVien : UserControl
    {
        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        string str = @"Data Source=LAPTOPCUATAO;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

        void Loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgvNhanVien.DataSource = dataTable;
        }

        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loaddata();
            dgvNhanVien.AutoResizeColumns();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values('" + tbMa.Text + "','" + tbCCCD.Text + "',N'" + tbHoTen.Text + "',N'" + dtpNgaySinh.Text + "',N'" + cbGioiTinh.Text + "','" + tbSDT.Text + "')";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where Ma='" + tbMa.Text + "'";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbMa.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            tbCCCD.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            tbHoTen.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            cbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            tbSDT.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set Ma=N'" + tbMa.Text + "',Ten=N'" + tbHoTen.Text + "',NgaySinh='" + dtpNgaySinh.Text + "',GioiTinh=N'" + cbGioiTinh.Text + "',SDT='" + tbSDT.Text + "'where Ma='" + tbMa.Text + "'";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void btKhoiTao_Click(object sender, EventArgs e)
        {
            tbMa.Text = " ";
            tbHoTen.Text = " ";
            tbCCCD.Text = " ";
            tbSDT.Text = " ";
            cbGioiTinh.Text = " ";
            dtpNgaySinh.Text = "1/1/2001";
        }

        private void gbTim_Enter(object sender, EventArgs e)
        {

        }
    }
}
