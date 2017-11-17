using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsQuocTich_DAO
    {
        public List<clsQuocTich_DTO> LayDanhSachQuocTinh()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM QUOCTICH ";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsQuocTich_DTO> lsQuocTich = new List<clsQuocTich_DTO>();
            while (dr.Read())
            {
                clsQuocTich_DTO qt = new clsQuocTich_DTO();
                if (!dr.IsDBNull(0))
                    qt.MAQT = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    qt.TENQT = dr.GetString(1);
                lsQuocTich.Add(qt);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsQuocTich;
        }
    }
}
