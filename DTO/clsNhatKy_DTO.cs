using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhatKy_DTO
    {
        private string _TaiKhoan;

        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        private DateTime _ThoiGian;

        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
        private string _SuKien;

        public string SuKien
        {
            get { return _SuKien; }
            set { _SuKien = value; }
        }
    }
}
