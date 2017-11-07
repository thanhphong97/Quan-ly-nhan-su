using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsKyHieuChamCong_DTO
    {
        private string _KyHieu;

        public string KyHieu
        {
            get { return _KyHieu; }
            set { _KyHieu = value; }
        }
        private string _DienGiai;

        public string DienGiai
        {
            get { return _DienGiai; }
            set { _DienGiai = value; }
        }
    }
}
