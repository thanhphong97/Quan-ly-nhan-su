using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsKyHieuChamCong_BUS
    {
        public List<clsKyHieuChamCong_DTO> LayDanhSachKyHieu()
        {
            clsKyHieuChamCong_DAO DAO = new clsKyHieuChamCong_DAO();
            return DAO.LayDanhSachKyHieu();
        }
    }
}
