using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class HoaDonHienThiDAL
    {
        private static HoaDonHienThiDAL instance;

        public static HoaDonHienThiDAL Instance 
        {
            get { if (instance == null) instance = new HoaDonHienThiDAL(); return instance; }
            private set => instance = value;
        }

        private HoaDonHienThiDAL() { }

        public List<HoaDonHienThi> GetHoaDonHienThiByTable(int id)
        {
            List<HoaDonHienThi> list = new List<HoaDonHienThi>();

            string query = "select MonAn.Ten, MonAn.Gia, ThongTinHoaDon.SoLuong, ThongTinHoaDon.SoLuong * MonAn.Gia as ThanhTien from HoaDon, ThongTinHoaDon, MonAn where HoaDon.Ma = ThongTinHoaDon.MaHoaDon and ThongTinHoaDon.MaMonAn = MonAn.Ma and HoaDon.TrangThai = 0 and HoaDon.MaBan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                HoaDonHienThi item = new HoaDonHienThi(row);
                list.Add(item);

            }
            
            return list;
        }
    }
}
