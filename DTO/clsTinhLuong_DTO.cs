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
        double _BHXH;

        public double BHXH
        {
            get { return _BHXH; }
            set { _BHXH = value; }
        }
        double _BHYT;

        public double BHYT
        {
            get { return _BHYT; }
            set { _BHYT = value; }
        }
        double _BHTN;

        public double BHTN
        {
            get { return _BHTN; }
            set { _BHTN = value; }
        }

        double _TienLuong;

        public double TienLuong
        {
            get { return _TienLuong; }
            set { _TienLuong = value; }
        }
        double _TongThuNhap;

        public double TongThuNhap
        {
            get { return _TongThuNhap; }
            set { _TongThuNhap = value; }
        }
        int _Thang;

        public int Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }
        int _Nam;

        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }
    }
}
