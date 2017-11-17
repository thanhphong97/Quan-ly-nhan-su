using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsDanToc_BUS
    {
        public List<clsDanToc_DTO> LayDSDanToc()
        {
            clsDanToc_DAO dao = new clsDanToc_DAO();
            return dao.LayDSDanToc();
        }
    }
}
