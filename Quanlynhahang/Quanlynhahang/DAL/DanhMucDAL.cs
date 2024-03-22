using Quanlynhahang.DTO;
using System;
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

    }
}
