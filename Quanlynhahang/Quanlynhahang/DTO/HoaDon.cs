using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class HoaDon
    {
        private int _status;

        private int _id;

        private int _idTable;

        private DateTime? _dateCheckIn;

        private DateTime? _dateCheckOut;
        public int Id { get => _id; set => _id = value; }
        public int IdTable { get => _idTable; set => _idTable = value; }
        public DateTime? DateCheckIn { get => _dateCheckIn; set => _dateCheckIn = value; }
        public DateTime? DateCheckOut { get => _dateCheckOut; set => _dateCheckOut = value; }
        public int Status { get => _status; set => _status = value; }

        public HoaDon(int id, int idtable, DateTime dateCheckIn, DateTime dateCheckOut, int status )
        {
            _id = id;
            _idTable = idtable;
            _dateCheckIn = dateCheckIn;
            _dateCheckOut = dateCheckOut;
            _status = status;
        }

        public HoaDon(DataRow row)
        {
            _id = (int)row["Ma"];
            _idTable = (int)row["MaBan"];
            _dateCheckIn = (DateTime?)row["NgayVao"];

            var dateCheckOutTemp = row["NgayRa"];
            if (dateCheckOutTemp.ToString() != "")
            {
                _dateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            _status = (int)row["TrangThai"];
        }
    }
}
