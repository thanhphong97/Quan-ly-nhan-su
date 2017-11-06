using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class ThaoTacDuLieu
    {
       static string strChuoiKetNoi = @"Data Source=.;Initial Catalog=QLNV_XiNghiep;Integrated Security=True";
       //static string strChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV_XiNghiep;Integrated Security=True";
       public static SqlConnection TaoVaMoKetNoi()
       {
           SqlConnection con = new SqlConnection(strChuoiKetNoi);
           con.Open();
           return con;
       }
        public static SqlCommand TaoDoiTuongTruyVan(string sql, SqlConnection con)
       {
           SqlCommand cmd = new SqlCommand(sql, con);
           return cmd;
       }
        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }

        // Đếm số dòng của một table trong CSDL
        public static int LaySoLuong(string table, SqlConnection conn)
        {
            string sql = string.Format("SELECT COUNT(*) FROM {0}",table);
            SqlCommand cmd = TaoDoiTuongTruyVan(sql,conn);
            int kq = (int)cmd.ExecuteScalar();
            return kq;
        }

    }
}
