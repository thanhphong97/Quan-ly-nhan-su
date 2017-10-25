using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsTinhQuanHuyen_DAO
    {
        public List<clsTinhQuanHuyen_DTO> LayDanhSachTinhThanh()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT MATINH,TENTINH FROM TINHQUANHUYEN GROUP BY MATINH,TENTINH";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsTinhQuanHuyen_DTO> lsTinhThanh = new List<clsTinhQuanHuyen_DTO>();
            while(dr.Read())
            {
                clsTinhQuanHuyen_DTO TinhThanh = new clsTinhQuanHuyen_DTO();
                if (!dr.IsDBNull(0))
                    TinhThanh.MATINH = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    TinhThanh.TENTINH = dr.GetString(1);
                lsTinhThanh.Add(TinhThanh);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsTinhThanh;
        }

        public List<clsTinhQuanHuyen_DTO> LayDanhSachQuanHuyen()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT MAQH,TENQH FROM TINHQUANHUYEN GROUP BY MAQH,TENQH";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsTinhQuanHuyen_DTO> lsQuanHuyen = new List<clsTinhQuanHuyen_DTO>();
            while (dr.Read())
            {
                clsTinhQuanHuyen_DTO QuanHuyen = new clsTinhQuanHuyen_DTO();
                if (!dr.IsDBNull(0))
                    QuanHuyen.MAQH = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    QuanHuyen.TENQH = dr.GetString(1);
                lsQuanHuyen.Add(QuanHuyen);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsQuanHuyen;
        }

    }
}
