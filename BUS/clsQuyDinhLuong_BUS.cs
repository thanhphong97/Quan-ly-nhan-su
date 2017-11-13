using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsQuyDinhLuong_BUS
    {
        public bool CapNhatQuyDinhLuong(clsQuyDinhLuong_DTO QuyDinh)
        {
            clsQuyDinhLuong_DAO DAO = new clsQuyDinhLuong_DAO();
            return DAO.CapNhatQuyDinhLuong(QuyDinh);
        }
        public clsQuyDinhLuong_DTO LayQuyDinhLuong()
        {
            clsQuyDinhLuong_DAO DAO = new clsQuyDinhLuong_DAO();
            return DAO.LayQuyDinhLuong();
        }
    }
}
