using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsNhatKy_DAO
    {
        public void ThemNhatKy(string TaiKhoan,DateTime ThoiGian, string SuKien)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("INSERT INTO NHATKY(TAIKHOAN,THOIGIAN,SUKIEN) VALUES ('{0}','{1}',N'{2}')", TaiKhoan, ThoiGian, SuKien);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
        }
    }
}
