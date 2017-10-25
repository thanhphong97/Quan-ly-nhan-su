using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsMoiQuanHe_DAO
    {
        public List<clsMoiQuanHe_DTO> LayDanhSachMoiQuanHe()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM MOIQUANHE";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsMoiQuanHe_DTO> lsMoiQuanHe = new List<clsMoiQuanHe_DTO>();
            while(dr.Read())
            {
                clsMoiQuanHe_DTO MQH = new clsMoiQuanHe_DTO();
                if (!dr.IsDBNull(0))
                    MQH.MAMQH = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    MQH.TENMQH = dr.GetString(1);
                lsMoiQuanHe.Add(MQH);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsMoiQuanHe;
        }
    }
}
