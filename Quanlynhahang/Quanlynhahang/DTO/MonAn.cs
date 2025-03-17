using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class MonAn
    {
        private int _id;
        private string _name;
        private int _idcategory;
        private float _price;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public float Price { get => _price; set => _price = value; }
        public int Idcategory { get => _idcategory; set => _idcategory = value; }

        public MonAn(int id, string name, int idcategory, float price)
        {
            _id = id;
            _name = name;
            _idcategory = idcategory;
            _price = price;
        }

        public MonAn(DataRow row)
        {
            _id = (int)row["Ma"];
            _name = row["Ten"].ToString();
            _idcategory = (int)row["MaDanhMuc"];
            _price = (float)Convert.ToDouble((row["Gia"].ToString()));
        }
    }
}
