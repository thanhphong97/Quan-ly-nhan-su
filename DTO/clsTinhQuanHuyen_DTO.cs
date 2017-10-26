using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTinhQuanHuyen_DTO
    {
        private string _MATINH;

        public string MATINH
        {
            get { return _MATINH; }
            set { _MATINH = value; }
        }
        private string _MAQH;

        public string MAQH
        {
            get { return _MAQH; }
            set { _MAQH = value; }
        }
        private string _TENTINH;

        public string TENTINH
        {
            get { return _TENTINH; }
            set { _TENTINH = value; }
        }
        private string _TENQH;

        public string TENQH
        {
            get { return _TENQH; }
            set { _TENQH = value; }
        }
    }
}
