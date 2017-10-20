using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsDanToc
    {
        private string _MADT;

        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }
        private string _TENDT;

        public string TENDT
        {
            get { return _TENDT; }
            set { _TENDT = value; }
        }
    }
}
