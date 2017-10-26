using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsMoiQuanHe_DTO
    {
        private int _MAMQH;

        public int MAMQH
        {
            get { return _MAMQH; }
            set { _MAMQH = value; }
        }
        private string _TENMQH;

        public string TENMQH
        {
            get { return _TENMQH; }
            set { _TENMQH = value; }
        }
    }
}
