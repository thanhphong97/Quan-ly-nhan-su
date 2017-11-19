using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsHopDong_BUS
    {
        public bool ThemHopDong(clsHopDong_DTO HD)
        {
            clsHopDong_DAO DAO = new clsHopDong_DAO();
            HD.NgayBatDau = HD.NgayBatDau.Date;
            HD.NgayKy = HD.NgayKy.Date;
            HD.NgayKetThuc = HD.NgayKetThuc.Date;
            return DAO.ThemHopDong(HD);
        }
        public List<clsHopDong_DTO> LayDanhSachHopDong(string MaNV)
        {
            clsHopDong_DAO DAO = new clsHopDong_DAO();
            return DAO.LayDanhSachHopDong(MaNV);
        }
        public bool CapNhatHopDong(clsHopDong_DTO HD)
        {
            clsHopDong_DAO DAO = new clsHopDong_DAO();
            HD.NgayBatDau = HD.NgayBatDau.Date;
            HD.NgayKy = HD.NgayKy.Date;
            HD.NgayKetThuc = HD.NgayKetThuc.Date;
            return DAO.CapNhatHopDong(HD);
        }
    }
}
