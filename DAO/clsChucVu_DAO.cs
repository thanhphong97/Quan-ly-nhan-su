using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsChucVu_DAO
    {
        public List<clsChucVu_DTO> LayDanhSachChucVu()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM CHUCVU";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsChucVu_DTO> lsChucVu = new List<clsChucVu_DTO>();
            while(dr.Read())
            {
                clsChucVu_DTO ChucVu = new clsChucVu_DTO();
                if (!dr.IsDBNull(0))
                    ChucVu.MACV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    ChucVu.TENCV = dr.GetString(1);
                lsChucVu.Add(ChucVu);   
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsChucVu;
        }
    }
}
