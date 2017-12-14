using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class clsTheNV_DAO
    {
        public DataTable LayTheNhanVien(string MaNV)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV AND MANV = '{0}'",MaNV);
            DataTable thenv = ThaoTacDuLieu.ThucThiTruyVan(sql, con);
            return thenv;
        }
    }
}
