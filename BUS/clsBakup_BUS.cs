using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class clsBakup_BUS
    {
        public bool SaoLuuCSDL(string NoiLuu)
        {
            clsBackup_DAO dao = new clsBackup_DAO();
            return dao.SaoLuuCSDL(NoiLuu);
        }
    }
}
