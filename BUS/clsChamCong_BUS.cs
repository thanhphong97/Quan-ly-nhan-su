using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsChamCong_BUS
    {
        public int LaySoLuong()
        {
            return ThaoTacDuLieu.DemSoLuong("SELECT COUNT(*) FROM CHAMCONG");
        }
        public bool ThemBangChamCong(clsChamCong_DTO ChamCong)
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.ThemBangChamCong(ChamCong);
        }
        public List<clsChamCong_DTO> LayBangChamCong()
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.LayBangChamCong();
        }

        public bool KiemTraPhongChamCong(int Thang, int Nam, string MaPB)
        {
            clsChamCong_DAO DAO = new clsChamCong_DAO();
            return DAO.KiemTraPhongChamCong(Thang, Nam, MaPB);
        }
    }
}
