using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsBacLuong_DAO
    {
        public float LayBacLuong(string MaCV, string MaBAC)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT HESO FROM BACLUONG WHERE BAC = '{0}' AND MACV = '{1}'",MaBAC,MaCV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            float kq = float.Parse(cmd.ExecuteScalar().ToString());
            return kq;
        }
        public List<clsBacLuong_DTO> LayDSBacLuong()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT DISTINCT BAC FROM BACLUONG";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsBacLuong_DTO> lsBacLuong = new List<clsBacLuong_DTO>();
            while (dr.Read())
            {
                clsBacLuong_DTO luong = new clsBacLuong_DTO();
                if (!dr.IsDBNull(0))
                    luong.BAC = dr.GetString(0);
                lsBacLuong.Add(luong);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsBacLuong;
        }
    }
}
