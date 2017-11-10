using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
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
    }
}
