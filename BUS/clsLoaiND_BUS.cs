using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsLoaiND_BUS
    {
        public List<clsLoaiND_DTO> layDSLoaiND()
        {
            clsLoaiND_DAO dao = new clsLoaiND_DAO();
            return dao.dsLoaiND();
        }
    }
}
