using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class ThaoTacDuLieu
    {
        static string strChuoiKetNoi = @"Data Source=.;Initial Catalog=QLNV_XiNghiep;Integrated Security=True";

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
        // Để sử dụng cho ReportViewer
        public static DataTable LayBang(string strSql)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.Fill(dt);
            ThaoTacDuLieu.DongKetNoi(con);
            return dt;
        }
        public static int ThucThiCauLenh(string sql)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            return kq;
        }
        public static int DemSoLuong(string sql)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(con);
            return kq;
        }
    }
}
