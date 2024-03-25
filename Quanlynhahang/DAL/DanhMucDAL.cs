using Quanlynhahang.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class DanhMucDAL
    {
        private static DanhMucDAL instance;

        public static DanhMucDAL Instance 
        {
            get { if (instance == null) instance = new DanhMucDAL(); return instance; }
            private set => instance = value;
        }

        public DanhMucDAL() { }

        //lấy dữ liệu danh mục dưới dạng list các bảng
        public List<DanhMuc> GetListDanhMuc()
        {
            List<DanhMuc> list = new List<DanhMuc>();

            string query = "select * from DanhMuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                DanhMuc item = new DanhMuc(row);    
                list.Add(item);
            }

            return list;
        }

        public int GetIdDanhMuc(string tenDanhMuc)
        {
            int id = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DanhMuc where Ten = N'" + tenDanhMuc + "'");
            foreach (DataRow row in data.Rows)
            {
                DanhMuc item = new DanhMuc(row);
                id = item.Id;
            }
            return id;
        }

    }
}
