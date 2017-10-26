using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsChucVu_BUS
    {
        public List<clsChucVu_DTO> LayDanhSachChucVu()
        {
            clsChucVu_DAO DAO = new clsChucVu_DAO();
            return DAO.LayDanhSachChucVu();
        }
    }
}
