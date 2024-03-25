using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class MonAnDAL
    {
        private static MonAnDAL instance;

        public static MonAnDAL Instance
        {
            get { if (instance == null) instance = new MonAnDAL(); return instance; }
            private set => instance = value;
        }

        public MonAnDAL() { }

        public List<MonAn> GetListMonAn(int id)
        {
            List<MonAn> list = new List<MonAn>();

            string query = "select * from MonAn where MaDanhMuc = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                MonAn item = new MonAn(row);
                list.Add(item);
            }

            return list;
        }

        public DataTable GetListMonAn()
        {
            string query = "select MonAn.Ten as N'Tên món ăn', DanhMuc.Ten as N'Danh mục', Gia as N'Đơn giá'  from MonAn, DanhMuc where MaDanhMuc = DanhMuc.Ma order by DanhMuc.Ten";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void AddMonAn(string tenMon, int idDanhMuc, float price)
        {
            string query = "insert into MonAn( Ten, MaDanhMuc, Gia) values( N'" + tenMon + "', " + idDanhMuc + ", " + price + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void RemoveMonAn(string tenMon)
        {
            string query = "delete MonAn where Ten = " + tenMon;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateMonAn(string newTenMon, string tenMon, int idDanhMuc, float price )
        {
            string query = "update MonAn set Ten = N'" + newTenMon + "', MaDanhMuc = " + idDanhMuc + ", Gia = "+price+" where Ten = N'" + tenMon + "'";
            DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
