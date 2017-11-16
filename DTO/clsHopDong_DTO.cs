using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHopDong_DTO
    {
        private string _MaHDLD;

        public string MaHDLD
        {
            get { return _MaHDLD; }
            set { _MaHDLD = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _LoaiHD;

        public string LoaiHD
        {
            get { return _LoaiHD; }
            set { _LoaiHD = value; }
        }
        private DateTime _NgayBatDau;

        public DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        private DateTime _NgayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        private string _DiaDiemLam;

        public string DiaDiemLam
        {
            get { return _DiaDiemLam; }
            set { _DiaDiemLam = value; }
        }
        private string _ChucVu;

        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        private string _CongViec;

        public string CongViec
        {
            get { return _CongViec; }
            set { _CongViec = value; }
        }
        private double _ThoiGianLam;

        public double ThoiGianLam
        {
            get { return _ThoiGianLam; }
            set { _ThoiGianLam = value; }
        }
        private string _TrangBi;

        public string TrangBi
        {
            get { return _TrangBi; }
            set { _TrangBi = value; }
        }
        private double _HeSoLuong;

        public double HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }
        private double _PhuCap;

        public double PhuCap
        {
            get { return _PhuCap; }
            set { _PhuCap = value; }
        }
        private DateTime _NgayKy;

        public DateTime NgayKy
        {
            get { return _NgayKy; }
            set { _NgayKy = value; }
        }

    }
}
