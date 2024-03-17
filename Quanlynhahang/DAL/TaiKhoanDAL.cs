using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;

        public static TaiKhoanDAL Instance
        { 
            get { if (instance == null) instance = new TaiKhoanDAL(); return instance; } 
            private set => instance = value;
        }

        private TaiKhoanDAL() { }

        public bool dangNhap(string tk, string mk, int loai)
        {
            string query = "select * from TaiKhoan where TenDangNhap = N'"+ tk + "' and MatKhau = N'" + mk + "' and LoaiTaiKhoan = " + loai;

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            return table.Rows.Count > 0;
        }
    }
}
