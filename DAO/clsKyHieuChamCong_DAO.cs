using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsKyHieuChamCong_DAO
    {
        public List<clsKyHieuChamCong_DTO> LayDanhSachKyHieu()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM KYHIEUCHAMCONG";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsKyHieuChamCong_DTO> lsKyHieu = new List<clsKyHieuChamCong_DTO>();
            while (dr.Read())
            {
                clsKyHieuChamCong_DTO KyHieu = new clsKyHieuChamCong_DTO();
                if (!dr.IsDBNull(0))
                    KyHieu.KyHieu = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    KyHieu.DienGiai = dr.GetString(1);
                lsKyHieu.Add(KyHieu);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsKyHieu;
        }
    }
}
