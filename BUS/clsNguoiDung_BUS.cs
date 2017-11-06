using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsNguoiDung_BUS
    {
        public List<clsNguoiDung_DTO> DSNguoiDung()
        {
            clsNguoiDung_DAO dao = new clsNguoiDung_DAO();
            return dao.DanhSachNguoiDung();
        }

        public bool TaoTaiKhoan(clsNguoiDung_DTO nd)
        {
            clsNguoiDung_DAO dao = new clsNguoiDung_DAO();
            return dao.TaoTaiKhoan(nd);
        }
    }
}
