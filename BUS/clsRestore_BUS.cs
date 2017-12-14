using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class clsRestore_BUS
    {
        public bool KhoiPhucCSDL(string NoiMo)
        {
            clsRestore_DAO dao = new clsRestore_DAO();
            return dao.KhoiPhucCSDL(NoiMo);
        }
    }
}
