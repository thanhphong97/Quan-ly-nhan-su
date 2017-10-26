using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNguoiDung_DTO
    {
        private string _TAIKHOAN;

        public string TAIKHOAN
        {
            get { return _TAIKHOAN; }
            set { _TAIKHOAN = value; }
        }
        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private string _LOAIND;

        public string LOAIND
        {
            get { return _LOAIND; }
            set { _LOAIND = value; }
        }
        private string _MANV;

        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private bool _TRANGTHAI;

        public bool TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }
    }
}
