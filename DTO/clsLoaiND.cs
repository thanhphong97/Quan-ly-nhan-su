using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiND
    {
        private string _MALOAI;

        public string MALOAI
        {
            get { return _MALOAI; }
            set { _MALOAI = value; }
        }
        private string _TENLOAI;

        public string TENLOAI
        {
            get { return _TENLOAI; }
            set { _TENLOAI = value; }
        }
    }
}
