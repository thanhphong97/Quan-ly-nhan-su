using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class clsTinhLuong_DAO
    {
        public DataTable LayBangChamCong(int Nam, int Thang, string MaPB)
        {
            DataTable BangChamCong = new DataTable();
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM CHITIETCHAMCONG, CHAMCONG, NHANVIEN WHERE CHITIETCHAMCONG.MACC = CHAMCONG.MACC and THANG = {0} and nam = {1} and NHANVIEN.MANV = CHITIETCHAMCONG.MANV and NHANVIEN.PHONG = '{2}'",Thang,Nam, MaPB);
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(BangChamCong);
            ThaoTacDuLieu.DongKetNoi(con);
            return BangChamCong;
        }
        public float LayHeSoLuongTheoCongViec(string MaNV)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql_HeSoBacCV = string.Format("select HESO from BACLUONG, NHANVIEN where BACLUONG.BAC = NHANVIEN.MABAC and BACLUONG.MACV = NHANVIEN.MACV and NHANVIEN.MANV = '{0}'", MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql_HeSoBacCV, con);
            float HSCV = float.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu.DongKetNoi(con);
            return HSCV;
        }
        public float LayHeSoLuongTheoBang(string MaNV)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql_HeSoBangCap = string.Format("select HESO from NHANVIEN, BANGCAP where NHANVIEN.BANGCAP = BANGCAP.MABC and NHANVIEN.MANV = '{0}'", MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql_HeSoBangCap, con);
            float HSBC = float.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu.DongKetNoi(con);
            return HSBC;
        }
    }
}
