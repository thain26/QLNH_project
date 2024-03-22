using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class BanDAL
    {
        private static BanDAL instance;

        public static BanDAL Instance
        {
            get { if (instance == null) instance = new BanDAL(); return instance; }
            private set => instance = value;
        }

        public static int Width = 100;
        public static int Height = 100;
        private BanDAL() { }

        public List<Ban> LoadTableList()
        {
            List<Ban> list = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BanAn");

            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);

            }

            return list;
        }
    }
}
