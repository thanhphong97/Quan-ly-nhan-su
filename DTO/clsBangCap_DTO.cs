using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsBangCap_DTO
    {
        private int _MaBC;

        public int MaBC
        {
            get { return _MaBC; }
            set { _MaBC = value; }
        }
        private string _TenBC;

        public string TenBC
        {
            get { return _TenBC; }
            set { _TenBC = value; }
        }
        private float _HeSo;

        public float HeSo
        {
            get { return _HeSo; }
            set { _HeSo = value; }
        }

    }
}
