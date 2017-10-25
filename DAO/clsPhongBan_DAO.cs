using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsPhongBan_DAO
    {
        public List<clsPhongBan_DTO> LayDanhSachPhongBan()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM PHONGBAN ";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsPhongBan_DTO> lsPhongBan = new List<clsPhongBan_DTO>();
            while (dr.Read())
            {
                clsPhongBan_DTO PhongBan = new clsPhongBan_DTO();
                if (!dr.IsDBNull(0))
                    PhongBan.MAPB = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    PhongBan.TENPB = dr.GetString(1);
                lsPhongBan.Add(PhongBan);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsPhongBan;
        }
    }
}
