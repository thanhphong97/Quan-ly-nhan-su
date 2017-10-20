using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsQuocTich_DTO
    {
        private string _MAQT;

        public string MAQT
        {
            get { return _MAQT; }
            set { _MAQT = value; }
        }
        private string _TENQT;

        public string TENQT
        {
            get { return _TENQT; }
            set { _TENQT = value; }
        }
    }
}
