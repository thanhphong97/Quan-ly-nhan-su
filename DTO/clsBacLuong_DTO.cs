using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsBacLuong_DTO
    {
        string _MaCV;

        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }
        string _BAC;

        public string BAC
        {
            get { return _BAC; }
            set { _BAC = value; }
        }
        float _HeSo;

        public float HeSo
        {
            get { return _HeSo; }
            set { _HeSo = value; }
        }
    }
}
