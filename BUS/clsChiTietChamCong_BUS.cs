using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class clsChiTietChamCong_BUS
    {
        //public bool ThemBangChamCong(int SoNgay, List<clsChamCong_DTO> lsChamCong)
        //{
        //    clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
        //    return DAO.ThemBangChamCong(SoNgay ,lsChamCong);
        //}
        //public List<clsChamCong_DTO> LayTenBangChamCong()
        //{
        //    clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
        //    return DAO.LayTenBangChamCong();
        //}
        ////public List<clsChamCong_DTO> LayDanhSachChamCong(string MaCC)
        ////{
        ////    clsChamCong_DAO DAO = new clsChamCong_DAO();
        ////    return DAO.LayDanhSachChamCong(MaCC);
        ////}
        public DataTable LayBangChiTietChamCongNV(string strTK)
        {
            clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
            return DAO.LayBangChiTietChamCongNV(strTK);
        }
        //public int LaySoLuong()
        //{
        //    clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
        //    return DAO.LaySoLuong();
        //}

        //public bool ThemBangChamCong(clsChamCong_DTO lsChamCong)
        //{
        //    clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
        //    return DAO.ThemBangChamCong(lsChamCong);
        //}
        //public int LaySoLuongBangChamCong()
        //{
        //    clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
        //    return DAO.LaySoLuongBangChamCong();
        //}
        public bool ThemChiTietChamCong(clsChiTietChamCong_DTO ChiTiet)
        {
            clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
            return DAO.ThemChiTietChamCong(ChiTiet);
        }
        public List<clsChiTietChamCong_DTO> LayChiTiet(string MaCC)
        {
            clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
            return DAO.LayChiTiet(MaCC);
        }
        public bool CapNhatChamCong(string sql)
        {
            clsChiTietChamCong_DAO DAO = new clsChiTietChamCong_DAO();
            return DAO.CapNhatChamCong(sql);
        }
    }
}
