using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;
        public static HoaDonDAL Instance
        {
            get { if (instance == null) instance = new HoaDonDAL(); return instance; }
            private set => instance = value;
        }

        private HoaDonDAL() { }

        //lấy hóa đơn hiện tại của bàn bằng mã bàn
        public int GetIdHoaDonByIDBan(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HoaDon where MaBan = " + id + " and TrangThai = 0");

            if (data.Rows.Count > 0)
            {
                HoaDon hoaDon = new HoaDon(data.Rows[0]);
                return hoaDon.Id;
            };
            return -1;
        }

        //Thêm hóa đơn mới vào bảng hóa đơn ở CSDL
        public void InsertHoaDon(int idBan)
        {
            DataProvider.Instance.ExecuteNonQuery("ThemHoaDon @MaBan", new object[] { idBan });

        }

        //lấy mã hóa đơn lớn nhất trong bảng hóa đơn
        public int GetMaxIdHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(Ma) from HoaDon");
            }
            catch { return 1; }
        }

        public void ThanhToan(int idHoaDon, float tongTien)
        {
            string query = "update HoaDon set NgayRa = getdate(), TongTien = " + tongTien + ", TrangThai = 1 where Ma = " + idHoaDon;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetListHoaDon(DateTime ngayVao, DateTime ngayRa)
        {
            string query = "select Ma as N'Mã hóa đơn', MaBan as N'Số bàn', NgayVao as N'Ngày vào', NgayRa as N'Ngày ra', TongTien as N'Tổng tiền' from HoaDon where NgayVao >= '" + ngayVao + "' and NgayRa <= '" + ngayRa + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
