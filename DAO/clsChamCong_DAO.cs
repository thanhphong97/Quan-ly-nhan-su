using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsChamCong_DAO
    {
       public bool ThemBangChamCong(clsChamCong_DTO ChamCong)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("INSERT INTO CHAMCONG(MACC,THANG,NAM,PHONG) VALUES('{0}',{1},{2},'{3}')", ChamCong.MaCC, ChamCong.Thang, ChamCong.Nam,ChamCong.Phong);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }

       public List<clsChamCong_DTO> LayBangChamCong()
       {
           SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
           string sql = "SELECT * FROM CHAMCONG";
           SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
           List<clsChamCong_DTO> lsCC = new List<clsChamCong_DTO>();
           SqlDataReader dr = cmd.ExecuteReader();
           while(dr.Read())
           {
                clsChamCong_DTO CC = new clsChamCong_DTO();
                if(!dr.IsDBNull(0))
                    CC.MaCC = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    CC.Thang = dr.GetInt32(1);
                if (!dr.IsDBNull(2))
                    CC.Nam = dr.GetInt32(2);
                lsCC.Add(CC);
           }
           ThaoTacDuLieu.DongKetNoi(conn);
           return lsCC;
       }

       public bool KiemTraPhongChamCong(int Thang, int Nam, string MaPB)
       {
           SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
           string sql = string.Format("SELECT COUNT(*) FROM CHAMCONG WHERE THANG = {0} AND NAM = {1} AND PHONG = '{2}'", Thang, Nam, MaPB);
           SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
           int kq = (int)cmd.ExecuteScalar();
           ThaoTacDuLieu.DongKetNoi(conn);
           return kq > 0;
       }
    }
}
