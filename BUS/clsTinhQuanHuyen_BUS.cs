using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class clsTinhQuanHuyen_BUS
    {
        public List<clsTinhQuanHuyen_DTO> LayDanhSachTinhThanh()
        {
            clsTinhQuanHuyen_DAO DAO = new clsTinhQuanHuyen_DAO();
            return DAO.LayDanhSachTinhThanh();
        }
        public List<clsTinhQuanHuyen_DTO> LayDanhSachQuanHuyen(string MaTinh)
        {
            clsTinhQuanHuyen_DAO DAO = new clsTinhQuanHuyen_DAO();
            return DAO.LayDanhSachQuanHuyen(MaTinh);
        }
    }
}
