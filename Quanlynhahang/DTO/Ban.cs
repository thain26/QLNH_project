  using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class Ban
    {
        private int _id;

        private string _name;

        private string _status;

        
        public Ban(int id, string name, string status) 
        {
            _id = id;
            _name = name;
            _status = status;
        }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Status { get => _status; set => _status = value; }

        public Ban(DataRow row) 
        {
            _id = (int)row["Ma"];
            _name = (string)row["Ten"];
            _status = (string)row["TrangThai"];
        }
    }
}
