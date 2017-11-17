using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsPhongBan_BUS
    {
        public List<clsPhongBan_DTO> LayDanhSachPhongBan()
        {
            clsPhongBan_DAO DAO = new clsPhongBan_DAO();
            return DAO.LayDanhSachPhongBan();
        }

        
    }
}
