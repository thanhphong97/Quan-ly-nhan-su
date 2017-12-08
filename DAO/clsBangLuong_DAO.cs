using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsBangLuong_DAO
    {
        public DataTable layBangLuong(int Nam, int Thang, string MaPB)
        {
            DataTable dt = new DataTable();
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("select * from BANGLUONG, NHANVIEN, PHONGBAN where NHANVIEN.MANV = BANGLUONG.MANV AND THANG = {0} AND NAM = {1} AND NHANVIEN.PHONG = PHONGBAN.MAPB", Thang, Nam, MaPB);

            if(MaPB == "0")
            {
                sql += string.Format(" AND PHONG IN (SELECT PHONG FROM NHANVIEN, BANGLUONG where NHANVIEN.MANV = BANGLUONG.MANV AND THANG = {0} AND NAM = {1} GROUP BY PHONG)", Thang, Nam);
            }
            else
            {
                sql += string.Format(" AND PHONG IN (SELECT PHONG FROM NHANVIEN, BANGLUONG where NHANVIEN.MANV = BANGLUONG.MANV AND THANG = {0} AND NAM = {1} AND PHONG = '{2}' GROUP BY PHONG)", Thang, Nam, MaPB);
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            ThaoTacDuLieu.DongKetNoi(con);
            return dt;
        }
        public void LuuBangLuong(List<clsTinhLuong_DTO> lsTinhLuong)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd;
            
            for(int i = 0; i < lsTinhLuong.Count; i++)
            {
                
                string sql = string.Format("INSERT INTO BANGLUONG VALUES({0},{1},'{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9},{10})", lsTinhLuong[i].Thang, lsTinhLuong[i].Nam, lsTinhLuong[i].MaNV, lsTinhLuong[i].SoNgayDiLam, lsTinhLuong[i].SoNgayNghiKhongPhep, lsTinhLuong[i].SoNgayNghiCoPhep, lsTinhLuong[i].TongThuNhap, lsTinhLuong[i].BHYT, lsTinhLuong[i].BHXH, lsTinhLuong[i].BHTN, lsTinhLuong[i].TienLuong);
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            ThaoTacDuLieu.DongKetNoi(con);
        }
    }
}
