using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsBangLuong_BUS
    {
        internal void LuuBangLuong(List<clsTinhLuong_DTO> lsBangLuongTheoBangCong)
        {
            clsBangLuong_DAO dao = new clsBangLuong_DAO();
            dao.LuuBangLuong(lsBangLuongTheoBangCong);
        }
    }
}
