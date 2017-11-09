using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class clsLoaiND_DAO
    {
       public List<clsLoaiND_DTO> dsLoaiND()
       {
           List<clsLoaiND_DTO> lsLoaiND = new List<clsLoaiND_DTO>();
           SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
           string sql = "SELECT MALOAI, TENLOAI FROM LOAIND";
           SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
           SqlDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               clsLoaiND_DTO lnd = new clsLoaiND_DTO();
               if (!dr.IsDBNull(0))
                   lnd.MALOAI = dr.GetString(0);
               if (!dr.IsDBNull(1))
                   lnd.TENLOAI = dr.GetString(1);
               lsLoaiND.Add(lnd);
           }
           ThaoTacDuLieu.DongKetNoi(con);
           return lsLoaiND;
       }
    }
}
