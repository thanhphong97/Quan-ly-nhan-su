using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsTonGiao_DAO
    {
        public List<clsTonGiao_DTO> LayDanhSachTonGiao()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM TONGIAO ";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsTonGiao_DTO> lsTonGiao = new List<clsTonGiao_DTO>();
            while (dr.Read())
            {
                clsTonGiao_DTO TonGiao = new clsTonGiao_DTO();
                if (!dr.IsDBNull(0))
                    TonGiao.MATG = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    TonGiao.TENTG = dr.GetString(1);
                lsTonGiao.Add(TonGiao);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsTonGiao;
        }
    }
}
