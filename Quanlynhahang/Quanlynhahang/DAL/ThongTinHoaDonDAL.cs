using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class ThongTinHoaDonDAL
    {
        private static ThongTinHoaDonDAL instance;

        public static ThongTinHoaDonDAL Instance
        {
            get { if (instance == null) instance = new ThongTinHoaDonDAL(); return instance; }
            private set => instance = value;
        }

        public List<ThongTinHoaDon> GetListThongTinHoaDon(int id)
        {
            List<ThongTinHoaDon> list = new List<ThongTinHoaDon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ThongTinHoaDon where MaHoaDon = " + id);
            foreach (DataRow dr in data.Rows)
            {
                ThongTinHoaDon info = new ThongTinHoaDon(dr);
                list.Add(info);
            }

            return list;
        }

        //Thêm thông tin hóa đơn mới vào bảng thông tin hóa đơn ở CSDL
        public void InsertThongTinHoaDon(int idHoaDon, int idMonAn, int soLuong)
        {
            DataProvider.Instance.ExecuteNonQuery("ThemThongTinHoaDon @mahoadon , @mamonan , @soluongthem", new object[] { idHoaDon, idMonAn, soLuong });

        }
    }
}
