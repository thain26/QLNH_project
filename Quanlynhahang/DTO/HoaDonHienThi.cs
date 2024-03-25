using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class HoaDonHienThi
    {
        private string _foodName;

        private int _amount;

        private float _price;

        private float _totalPrice;

        public string FoodName { get => _foodName; set => _foodName = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public float Price { get => _price; set => _price = value; }
        public float TotalPrice { get => _totalPrice; set => _totalPrice = value; }

        public HoaDonHienThi(string fooodName, int amount, float price, float totalPrice)
        {
            _foodName = fooodName;
            _amount = amount;
            _price = price;
            _totalPrice = totalPrice;
        }

        public HoaDonHienThi(DataRow row)
        {
            _foodName = row["Ten"].ToString();
            _amount = (int)row["Soluong"];
            _price = (float)Convert.ToDouble((row["Gia"].ToString()));
            _totalPrice = (float)Convert.ToDouble((row["Gia"].ToString()));
        }
    }
}
