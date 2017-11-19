using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhanVienDangNhap
    {
        string _Ho;

        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        string _Ten;

        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        string _Quyen;

        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }
        private string _MaNV;

        private string _TaiKhoan;


        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }

    }
}
