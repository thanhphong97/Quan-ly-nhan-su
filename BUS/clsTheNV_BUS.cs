using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
namespace BUS
{
    public class clsTheNV_BUS
    {
        public DataTable LayTheNV(string MaNV)
        {
            clsTheNV_DAO dao = new clsTheNV_DAO();
            return dao.LayTheNhanVien(MaNV);
        }
    }
}
