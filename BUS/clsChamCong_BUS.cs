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
    public class clsChamCong_BUS
    {
        public bool ThemBangChamCong(int SoNgay, List<clsChamCong_DTO> lsChamCong)
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.ThemBangChamCong(SoNgay ,lsChamCong);
        }
        public List<clsChamCong_DTO> LayTenBangChamCong()
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.LayTenBangChamCong();
        }
        //public List<clsChamCong_DTO> LayDanhSachChamCong(string MaCC)
        //{
        //    clsChamCong_DAO DAO = new clsChamCong_DAO();
        //    return DAO.LayDanhSachChamCong(MaCC);
        //}
        public DataTable LayBangChamCongNV(string strTK)
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.LayBangChamCongNV(strTK);
        }
        public int LaySoLuong()
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.LaySoLuong();
        }
        
    }
}
