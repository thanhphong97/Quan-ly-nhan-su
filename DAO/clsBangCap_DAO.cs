using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsBangCap_DAO
    {
        public List<clsBangCap_DTO> LayDanhSachBangCap()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT MABC,TENBC FROM BANGCAP ORDER BY MABC";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsBangCap_DTO> lsBangCap = new List<clsBangCap_DTO>();
            while(dr.Read()) 
            {
                clsBangCap_DTO BangCap = new clsBangCap_DTO();
                if (!dr.IsDBNull(0))
                    BangCap.MaBC = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    BangCap.TenBC = dr.GetString(1);
                lsBangCap.Add(BangCap);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsBangCap;
        }
    }
}
