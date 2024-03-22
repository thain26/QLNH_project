using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
