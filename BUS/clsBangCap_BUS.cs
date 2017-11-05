using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsBangCap_BUS
    {
        public List<clsBangCap_DTO> LayDanhSachBangCap()
        {
            clsBangCap_DAO DAO = new clsBangCap_DAO();
            return DAO.LayDanhSachBangCap();
        }
    }
}
