using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsHopDong_DAO
    {
        public bool ThemHopDong(clsHopDong_DTO HD)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "";
            DateTime dt = new DateTime(0001, 1, 1);
            if (HD.NgayKetThuc == dt.Date)
            {
                sql = string.Format("INSERT INTO HOPDONGLAODONG(MAHDLD,MANV,LOAIHD,TUNGAY,DIADIEMLAM,CHUCVU,CONGVIEC,THOIGIANLAM,TRANGBILAODONG,HESOLUONG,PHUCAP,NGAYKY) VALUES  ('{0}','{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',{9},{10},'{11}')", "HDLD" + (ThaoTacDuLieu.LaySoLuong("HOPDONGLAODONG", conn) + 1).ToString(), HD.MaNV, HD.LoaiHD, HD.NgayBatDau, HD.DiaDiemLam, HD.ChucVu, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.HeSoLuong, HD.PhuCap, HD.NgayKy);
            }
            else
            {
                sql = string.Format("INSERT INTO HOPDONGLAODONG(MAHDLD,MANV,LOAIHD,TUNGAY,DENNGAY,DIADIEMLAM,CHUCVU,CONGVIEC,THOIGIANLAM,TRANGBILAODONG,HESOLUONG,PHUCAP,NGAYKY) VALUES  ('{0}','{1}',N'{2}','{3}','{4}',N'{5}',N'{6}',N'{7}',{8},N'{9}',{10},{11},'{12}')", "HDLD" + (ThaoTacDuLieu.LaySoLuong("HOPDONGLAODONG", conn) + 1).ToString(), HD.MaNV, HD.LoaiHD, HD.NgayBatDau, HD.NgayKetThuc, HD.DiaDiemLam, HD.ChucVu, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.HeSoLuong, HD.PhuCap, HD.NgayKy);
            }
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            return kq > 0;
        }

        public List<clsHopDong_DTO> LayDanhSachHopDong(string MaNV)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM HOPDONGLAODONG WHERE MANV = '{0}'",MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsHopDong_DTO> lsHD = new List<clsHopDong_DTO>();
            while (dr.Read())
            {
                clsHopDong_DTO HD = new clsHopDong_DTO();
                if (!dr.IsDBNull(0))
                    HD.MaHDLD = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    HD.MaNV = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    HD.LoaiHD = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    HD.NgayBatDau = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    HD.NgayKetThuc = dr.GetDateTime(4);
                if (!dr.IsDBNull(5))
                    HD.DiaDiemLam = dr.GetString(5);
                if (!dr.IsDBNull(6))
                    HD.ChucVu = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    HD.CongViec = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    HD.ThoiGianLam = dr.GetDouble(8);
                if (!dr.IsDBNull(9))
                    HD.TrangBi = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    HD.HeSoLuong = dr.GetDouble(10);
                if (!dr.IsDBNull(11))
                    HD.PhuCap = dr.GetDouble(11);
                if (!dr.IsDBNull(12))
                    HD.NgayKy = dr.GetDateTime(12);
                lsHD.Add(HD);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsHD;
        }

        public bool CapNhatHopDong(clsHopDong_DTO HD)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "";
            DateTime dt = new DateTime(0001, 1, 1);
            if (HD.NgayKetThuc == dt.Date)
            {
                sql = string.Format("UPDATE HOPDONGLAODONG SET LOAIHD = N'{0}', TUNGAY = '{1}', DIADIEMLAM = N'{2}', CHUCVU = N'{3}', CONGVIEC = N'{4}', THOIGIANLAM = {5}, TRANGBILAODONG = N'{6}', HESOLUONG = {7}, PHUCAP = {8}, NGAYKY = '{9}' WHERE MAHDLD = '{10}'", HD.LoaiHD, HD.NgayBatDau, HD.DiaDiemLam, HD.ChucVu, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.HeSoLuong, HD.PhuCap, HD.NgayKy, HD.MaHDLD);
            }
            else
            {

                sql = string.Format("UPDATE HOPDONGLAODONG SET LOAIHD = N'{0}', TUNGAY = '{1}', DENNGAY = '{2}', DIADIEMLAM = N'{3}', CHUCVU = N'{4}', CONGVIEC = N'{5}', THOIGIANLAM = {6}, TRANGBILAODONG = N'{7}', HESOLUONG = {8}, PHUCAP = {9}, NGAYKY = '{10}' WHERE MAHDLD = '{11}'", HD.LoaiHD, HD.NgayBatDau, HD.NgayKetThuc, HD.DiaDiemLam, HD.ChucVu, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.HeSoLuong, HD.PhuCap, HD.NgayKy, HD.MaHDLD);
            }
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
