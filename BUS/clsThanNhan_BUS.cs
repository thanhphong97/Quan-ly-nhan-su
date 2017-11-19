using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class clsThanNhan_BUS
    {
        public bool ThemThanNhan(clsThanNhan_DTO TN)
        {
            clsThanNhan_DAO DAO = new clsThanNhan_DAO();
            return DAO.ThemThanNhan(TN);
        }
        public List<clsThanNhan_DTO> LayDanhSachThanNhan(string MaNV)
        {
            clsThanNhan_DAO DAO = new clsThanNhan_DAO();
            return DAO.LayDanhSachThanNhan(MaNV);
        }
        public bool CapNhatThanNhan(clsThanNhan_DTO TN)
        {
            clsThanNhan_DAO DAO = new clsThanNhan_DAO();
            return DAO.CapNhatThanNhan(TN);
        }
    }
}
