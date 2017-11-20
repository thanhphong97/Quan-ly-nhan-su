using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsNhatKy_BUS
    {
        public void ThemNhatKy(string TaiKhoan,DateTime ThoiGian, string SuKien)
        {
            clsNhatKy_DAO DAO = new clsNhatKy_DAO();
            DAO.ThemNhatKy(TaiKhoan, ThoiGian, SuKien);
        }
        public List<clsNhatKy_DTO> LayDanhSachNhatKy()
        {
            clsNhatKy_DAO DAO = new clsNhatKy_DAO();
            return DAO.LayDanhSachNhatKy();
        }
    }
}
