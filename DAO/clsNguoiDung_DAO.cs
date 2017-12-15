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
            string sql = "SELECT TAIKHOAN, LOAIND, MANV, TRANGTHAI, MATKHAU FROM NGUOIDUNG";
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
                if (!dr.IsDBNull(3))
                    nd.TRANGTHAI = dr.GetBoolean(3);
                if (!dr.IsDBNull(4))
                    nd.MATKHAU = dr.GetString(4);
                lsNguoiDung.Add(nd);
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return lsNguoiDung;
        }
       
        private bool KiemTraMaNVHopLe(string MaNV)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '{0}'",MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int SoLuongTaiKhoan = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(con);
            if (SoLuongTaiKhoan != 1)
                return false;
            return true;
        }
        public bool TaoTaiKhoan(clsNguoiDung_DTO nd)
        {
            if (KiemTraMaNVHopLe(nd.MANV))
            {
                SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
                string sql = string.Format("INSERT INTO NGUOIDUNG(TAIKHOAN, MATKHAU, LOAIND, MANV, TRANGTHAI) VALUES('{0}','{1}','{2}','{3}','{4}')", nd.TAIKHOAN, nd.MATKHAU, nd.LOAIND, nd.MANV, nd.TRANGTHAI);
                SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
                int rowaff = cmd.ExecuteNonQuery();
                ThaoTacDuLieu.DongKetNoi(con);
                if (rowaff == 0)
                    return false;
                return true;
            }
            else
                return false;

        }

        public bool CapNhatNguoiDung(clsNguoiDung_DTO nd)
        {
            if(KiemTraMaNVHopLe(nd.MANV))
            {
                SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
                string sql = "";
                if(nd.MATKHAU != "")
                {
                    sql = string.Format("UPDATE NGUOIDUNG SET TAIKHOAN = '{0}', MATKHAU = '{1}', LOAIND = '{2}',TRANGTHAI = '{4}' WHERE MANV = '{3}'", nd.TAIKHOAN, nd.MATKHAU, nd.LOAIND, nd.MANV, nd.TRANGTHAI);
                }
                else
                {
                    sql = string.Format("UPDATE NGUOIDUNG SET TAIKHOAN = '{0}', LOAIND = '{1}',TRANGTHAI = '{3}' WHERE MANV = '{2}'", nd.TAIKHOAN, nd.LOAIND, nd.MANV, nd.TRANGTHAI);
                }
               
                SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
                int rowaff = cmd.ExecuteNonQuery();
                ThaoTacDuLieu.DongKetNoi(con);
                if (rowaff == 0)
                    return false;
                return true;
            }
            else
                return false;
        }
        public bool CapNhatNguoiDung(bool TrangThai, string MANV)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("UPDATE NGUOIDUNG SET TRANGTHAI = '{0}' WHERE MANV = '{1}'", TrangThai,MANV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int rowaff = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (rowaff == 0)
                return false;
            return true;
        }

        public bool KiemTraTonTai(string str, int loaiKT)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT COUNT(*) FROM NGUOIDUNG";
            if (loaiKT == 1)
                sql += string.Format(" WHERE MaNV = '{0}'", str);
            if (loaiKT == 2)
                sql += string.Format(" WHERE TAIKHOAN =  '{0}'", str);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int SoLuongTaiKhoan = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(con);
            if (SoLuongTaiKhoan > 0)
                return false;
            return true;
        }
    }
}
