using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsNguoiDung_DAO
    {

        public List<clsNguoiDung_DTO> DanhSachNguoiDung()
        {
            List<clsNguoiDung_DTO> lsNguoiDung = new List<clsNguoiDung_DTO>();
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT TAIKHOAN, LOAIND, MANV FROM NGUOIDUNG WHERE TRANGTHAI = 1";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                if (!dr.IsDBNull(0))
                    nd.TAIKHOAN = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    nd.LOAIND = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    nd.MANV = dr.GetString(2);
                lsNguoiDung.Add(nd);
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return lsNguoiDung;
        }
        public List<clsNguoiDung_DTO> DanhSachNguoiDung(string a)
        {
            List<clsNguoiDung_DTO> lsNguoiDung = new List<clsNguoiDung_DTO>();
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT TAIKHOAN, LOAIND, MANV FROM NGUOIDUNG WHERE TRANGTHAI = 1";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                if (!dr.IsDBNull(0))
                    nd.TAIKHOAN = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    nd.LOAIND = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    nd.MANV = dr.GetString(2);
                lsNguoiDung.Add(nd);
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return lsNguoiDung;
        }
    }
}
