using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsHopDong_BUS
    {
        public bool ThemHopDong(clsHopDong_DTO HD)
        {
            clsHopDong_DAO DAO = new clsHopDong_DAO();
            //HD.NgayKetThuc = (HD.NgayKetThuc == null) ? string.Format("") : HD.NgayKetThuc;
            return DAO.ThemHopDong(HD);
        }
    }
}
