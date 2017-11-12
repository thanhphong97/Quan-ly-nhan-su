using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsQuyDinhLuong_DTO
    {
        private string _MaQD;

        public string MaQD
        {
            get { return _MaQD; }
            set { _MaQD = value; }
        }
        private decimal _LuongToiThieu;

        public decimal LuongToiThieu
        {
            get { return _LuongToiThieu; }
            set { _LuongToiThieu = value; }
        }
        private double _GioCong;

        public double GioCong
        {
            get { return _GioCong; }
            set { _GioCong = value; }
        }
        private double _BHXH;

        public double BHXH
        {
            get { return _BHXH; }
            set { _BHXH = value; }
        }
        private double _BHYT;

        public double BHYT
        {
            get { return _BHYT; }
            set { _BHYT = value; }
        }
        private double _BHTN;

        public double BHTN
        {
            get { return _BHTN; }
            set { _BHTN = value; }
        }

    }
}
