using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsTonGiao_BUS
    {
        public List<clsTonGiao_DTO> LayDanhSachTonGiao()
        {
            clsTonGiao_DAO DAO = new clsTonGiao_DAO();
            return DAO.LayDanhSachTonGiao();
        }
    }
}
