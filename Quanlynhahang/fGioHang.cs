using Quanlynhahang.DAL;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class fGioHang : Form
    {
        private int idBan;

        public fGioHang()
        {
            InitializeComponent();
        }

        public fGioHang(int idBan)
        {
            this.idBan = idBan;
            InitializeComponent();
        }

        //hiển thị hóa đơn của bàn
        void showHoaDon(int id)
        {
            lvThongTinHoaDon.Items.Clear();
            List<HoaDonHienThi> ListThongTinHoaDon = HoaDonHienThiDAL.Instance.GetHoaDonHienThiByTable(id);

            float tongTien = 0;
            foreach (HoaDonHienThi thongTinHoaDon in ListThongTinHoaDon)
            {
                ListViewItem item = new ListViewItem(thongTinHoaDon.FoodName.ToString());
                item.SubItems.Add(thongTinHoaDon.Price.ToString());
                item.SubItems.Add(thongTinHoaDon.Amount.ToString());
                item.SubItems.Add(thongTinHoaDon.TotalPrice.ToString());

                lvThongTinHoaDon.Items.Add(item);

                tongTien += thongTinHoaDon.TotalPrice;
            }

            tbTongTien.Text = tongTien.ToString();
        }

        // khi form giỏ hàng load sẽ hiển thị hóa đơn của bàn đã chọn
        private void fGioHang_Load(object sender, EventArgs e)
        {
            LoadListDanhMuc();
            showHoaDon(idBan);
        }
        
        // load các danh mục món ăn lên combobox danh mục
        void LoadListDanhMuc()
        {
            List<DanhMuc> list = DanhMucDAL.Instance.GetListDanhMuc();
            cbDanhMuc.DataSource = list;
            cbDanhMuc.DisplayMember = "Name";
        }

        // load các món ăn tương ứng với combobox danh mục lên combobox món ăn
        void LoadListMonAn(int id)
        {
            List<MonAn> list = MonAnDAL.Instance.GetListMonAn(id);
            cbMonAn.DataSource = list;
            cbMonAn.DisplayMember = "Name";

        }

        //khi combobox danh mục thay đổi thì load các món ăn tương ứng với danh mục đó lên combobox món ăn
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            if (cbDanhMuc.SelectedItem == null) return;

            DanhMuc selected = cbDanhMuc.SelectedItem as DanhMuc;
            id = selected.Id;

            LoadListMonAn(id);
        }

        //thêm thông tin món đã chọn ở combobox vào hóa đơn
        private void btThemMon_Click(object sender, EventArgs e)
        {
            int idHoaDon = HoaDonDAL.Instance.GetIdHoaDonByIDBan(idBan);
            int idMonAn = (cbMonAn.SelectedItem as MonAn).Id;
            int soLuongThem = (int)nudSoLuong.Value;

            if (idHoaDon == -1) 
            {
                HoaDonDAL.Instance.InsertHoaDon(idBan);
                ThongTinHoaDonDAL.Instance.InsertThongTinHoaDon(HoaDonDAL.Instance.GetMaxIdHoaDon(), idMonAn, soLuongThem);
            }
            else
            {
                ThongTinHoaDonDAL.Instance.InsertThongTinHoaDon(idHoaDon, idMonAn, soLuongThem);
            }
            showHoaDon(idBan);
        }

        //thay đổi trạng thái hóa đơn
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            int idHoaDon = HoaDonDAL.Instance.GetIdHoaDonByIDBan(idBan);

            if (MessageBox.Show("Xác nhận thanh toán?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                float tongTien = (float)Convert.ToDouble(tbTongTien.Text);
                HoaDonDAL.Instance.ThanhToan(idHoaDon, tongTien);
                showHoaDon(idBan);
            }
        }

    }
}
