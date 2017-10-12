using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class clsNhanVien_BUS
    {
        public DTO.clsNhanVien_DTO LayThongTinNhanVien(string strTenDN)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayThongTinNhanVien(strTenDN);
        }

        public bool KiemTraDangNhap(string strTenDN, string strMK)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.KiemTraDangNhap(strTenDN, strMK);
        }

        public bool ThemNhanVien(DTO.clsNhanVien_DTO nv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.ThemNhanVien(nv);
        }
        public int DemNhanVien()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            int soLuongNhanVien = dao.DemNhanVien();
            return soLuongNhanVien;

        }
    }
}
