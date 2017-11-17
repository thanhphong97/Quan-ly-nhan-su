using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsQuocTich_BUS
    {
        public List<clsQuocTich_DTO> LayDSQuocTich()
        {
            clsQuocTich_DAO dao = new clsQuocTich_DAO();
            return dao.LayDanhSachQuocTinh();
        }
    }
}
