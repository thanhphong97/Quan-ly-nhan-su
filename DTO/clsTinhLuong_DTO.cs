using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTinhLuong_DTO
    {
        string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        int _SoNgayNghiKhongPhep;

        public int SoNgayNghiKhongPhep
        {
            get { return _SoNgayNghiKhongPhep; }
            set { _SoNgayNghiKhongPhep = value; }
        }
        int _SoNgayNghiCoPhep;

        public int SoNgayNghiCoPhep
        {
            get { return _SoNgayNghiCoPhep; }
            set { _SoNgayNghiCoPhep = value; }
        }
        int _SoNgayDiLam;

        public int SoNgayDiLam
        {
            get { return _SoNgayDiLam; }
            set { _SoNgayDiLam = value; }
        }
        float _TienLuong;

        public float TienLuong
        {
            get { return _TienLuong; }
            set { _TienLuong = value; }
        }
    }
}
