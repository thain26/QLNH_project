using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class DanhMuc
    {
        private int _id;
        private string _name;

        public DanhMuc(int id, string name)
        {
            _id = id;
            _name = name;

        }

        public DanhMuc(DataRow row)
        {
            _id = (int)row["Ma"];
            _name = row["Ten"].ToString();
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
