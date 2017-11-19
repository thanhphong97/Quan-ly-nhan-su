using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsThanNhan_DTO
    {
        private int _MaQHGD;

        public int MaQHGD
        {
            get { return _MaQHGD; }
            set { _MaQHGD = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _HoTenTN;

        public string HoTenTN
        {
            get { return _HoTenTN; }
            set { _HoTenTN = value; }
        }
        private int _MoiQH;

        public int MoiQH
        {
            get { return _MoiQH; }
            set { _MoiQH = value; }
        }
        private DateTime _NgaySinhTN;

        public DateTime NgaySinhTN
        {
            get { return _NgaySinhTN; }
            set { _NgaySinhTN = value; }
        }
        private string _NgheNghiepTN;

        public string NgheNghiepTN
        {
            get { return _NgheNghiepTN; }
            set { _NgheNghiepTN = value; }
        }
    }
}
