using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsBacLuong_BUS
    {
        public float LayHeSoLuong(string MaCV, string MaBAC)
        {
            clsBacLuong_DAO dao = new clsBacLuong_DAO();
            return dao.LayHeSo(MaCV, MaBAC);
        }
        public List<clsBacLuong_DTO> LayDSBacLuong()
        {
            clsBacLuong_DAO dao = new clsBacLuong_DAO();
            return dao.LayDSBacLuong();
        }
    }
}
