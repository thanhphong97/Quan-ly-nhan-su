using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class clsDanToc_DAO
    {
        public List<clsDanToc_DTO> LayDSDanToc()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM DANTOC";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsDanToc_DTO> lsDanToc = new List<clsDanToc_DTO>();
            while (dr.Read())
            {
                clsDanToc_DTO qt = new clsDanToc_DTO();
                if (!dr.IsDBNull(0))
                    qt.MADT = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    qt.TENDT = dr.GetString(1);
                lsDanToc.Add(qt);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsDanToc;
        }
    }
}
