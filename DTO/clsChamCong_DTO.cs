using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChamCong_DTO
    {
        private string _MaCC;

        public string MaCC
        {
            get { return _MaCC; }
            set { _MaCC = value; }
        }
        private int _Thang;

        public int Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }
        private int _Nam;

        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }
       
    }
}
