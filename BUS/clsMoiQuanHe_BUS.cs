using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsMoiQuanHe_BUS
    {
        public List<clsMoiQuanHe_DTO> LayDanhSachMoiQuanHe()
        {
            clsMoiQuanHe_DAO DAO = new clsMoiQuanHe_DAO();
            return DAO.LayDanhSachMoiQuanHe();
        }
    }
}
