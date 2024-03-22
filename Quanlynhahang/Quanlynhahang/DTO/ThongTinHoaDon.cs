using Quanlynhahang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class ThongTinHoaDon
    {
        private int _id;
        private int _idBill;
        private int _idFood;
        private int _amount;

        public int Amount { get => _amount; set => _amount = value; }
        public int IdFood { get => _idFood; set => _idFood = value; }
        public int IdBill { get => _idBill; set => _idBill = value; }
        public int Id { get => _id; set => _id = value; }
        public ThongTinHoaDon(int id, int idBill, int idFood, int amount)
        {
            _id = id;
            _idBill = idBill;
            _idFood = idFood;
            _amount = amount;
        }

        public ThongTinHoaDon(DataRow row)
        {
            _id = (int)row["Ma"];
            _idBill = (int)row["MaHoaDon"];
            _idFood = (int)row["MaMonAn"];
            _amount = (int)row["SoLuong"];
        }
    }
}
