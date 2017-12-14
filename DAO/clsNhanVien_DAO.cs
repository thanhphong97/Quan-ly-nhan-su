using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsNhanVien_DAO
    {
        public bool KiemTraDangNhap(string strTenDN, string strMK)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT COUNT(*) FROM NGUOIDUNG WHERE TAIKHOAN = '{0}' AND MATKHAU = '{1}' AND TrangThai= 1", strTenDN, strMK);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;

        }

        public clsNhanVienDangNhap LayThongTinNhanVien(string strTenDN)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT HO, TEN, LOAIND, TAIKHOAN FROM NHANVIEN, NGUOIDUNG WHERE NHANVIEN.MANV = NGUOIDUNG.MANV AND TAIKHOAN = '{0}'",strTenDN);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            clsNhanVienDangNhap nv = new clsNhanVienDangNhap();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if (!dr.IsDBNull(0))
                    nv.Ho = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    nv.Ten = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    nv.Quyen = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    nv.TaiKhoan = dr.GetString(3);
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return nv;
        }

        public bool CapNhatThongTinNhanVien(clsNhanVien_DTO nv)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string ngaysinh = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgaySinh);
            string Ngaybatdaulamviec = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgayBatDauLamViec);
            string sql = string.Format("UPDATE NHANVIEN SET HO = N'{1}', TEN = N'{2}', NGAYSINH = '{3}', DIACHI = N'{4}', CMND = '{5}', GIOITINH = '{6}', NGUYENQUAN = N'{7}', TINHTHANH = '{8}', QUANHUYEN = '{9}', QUOCTICH = '{10}', DANTOC = '{11}', TONGIAO = '{12}', NGAYBATDAU = '{13}', PHONG = '{14}', MABAC = '{15}', MACV = '{16}', BANGCAP = '{17}', TRANGTHAI = '{18}', HINHDAIDIEN = '{19}' WHERE MANV = '{0}'",nv.MaNV, nv.Ho, nv.Ten, ngaysinh, nv.DiaChiThuongTru, nv.CMND, nv.GioiTinh, nv.NguyenQuan, nv.TinhThanh, nv.QuanHuyen, nv.QuocTich, nv.DanToc, nv.TonGiao, Ngaybatdaulamviec, nv.PhongBan, nv.MaBAC, nv.MaCV, nv.BangCap, nv.TrangThai, nv.HINHDAIDIEN);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int rowAffected = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (rowAffected == 0)
                return false;// cập nhật thất bại
            return true;//cập nhật thành công
        }

        public int LaySoLuongNhanVien()
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            int slnv = ThaoTacDuLieu.LaySoLuong("NHANVIEN", con);
            ThaoTacDuLieu.DongKetNoi(con);
            return slnv;
        }
        public bool ThemNhanVien(clsNhanVien_DTO nv)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string ngaysinh = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgaySinh);
            string Ngaybatdaulamviec = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgayBatDauLamViec);
            string sql = string.Format("INSERT INTO NHANVIEN (MANV, HO, TEN, NGAYSINH, DIACHI, CMND, GIOITINH, NGUYENQUAN, TINHTHANH, QUANHUYEN, QUOCTICH, DANTOC, TONGIAO, NGAYBATDAU, PHONG, MABAC, MACV, BANGCAP, TRANGTHAI, HINHDAIDIEN) VALUES ('{0}', N'{1}' ,N'{2}' ,'{3}' ,N'{4}' ,'{5}', '{6}', N'{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', {17}, '{18}')", nv.MaNV, nv.Ho, nv.Ten, nv.NgaySinh, nv.DiaChiThuongTru, nv.CMND, nv.GioiTinh, nv.NguyenQuan, nv.TinhThanh, nv.QuanHuyen, nv.QuocTich, nv.DanToc, nv.TonGiao, nv.NgayBatDauLamViec, nv.PhongBan, nv.MaBAC, nv.MaCV, nv.BangCap, nv.TrangThai, nv.HINHDAIDIEN);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int rowAffected = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (rowAffected == 0)
                return false;// Thêm thất bại
            return true;//thêm thành công
        }

        public List<clsNhanVien_DTO> LayDanhSachNhanVien(int dk, string MaNV, string MaPB)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            
            string  sql = string.Format("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, CMND, GIOITINH, NGUYENQUAN, TINHTHANH, QUANHUYEN, QUOCTICH, DANTOC, TONGIAO, NGAYBATDAU, PHONG, MABAC, MACV, BANGCAP, TRANGTHAI, HINHDAIDIEN FROM NHANVIEN");
            
            if(MaNV == "")
            {
                if(MaPB != "0")
                {
                    if (dk == 1)
                    {
                        sql += string.Format(" WHERE PHONG = '{0}' AND TRANGTHAI = 1",MaPB);
                    }
                    if (dk == -1)
                    {
                        sql += string.Format(" WHERE PHONG = '{0}' AND TRANGTHAI = 0",MaPB);
                    }
                }
                else
                {
                    if (dk == 1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 1");
                    }
                    if (dk == -1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 0");
                    }
                }
                if(dk == 0 && MaPB != "0")
                {
                    sql += string.Format(" WHERE PHONG = '{0}'", MaPB);
                }
            }
            else
            {
                if(MaPB != "0")
                {
                    if (dk == 1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 1 AND PHONG = '{1}' AND  (MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%' )", MaNV, MaPB);
                    }
                    if (dk == -1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 0  AND PHONG = '{1}' AND (MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%')", MaNV, MaPB);
                    }
                    if (dk == 0)
                    {
                        sql += string.Format(" WHERE PHONG = '{1}' AND (MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%')", MaNV, MaPB);
                    }
                }
                else
                {
                    if (dk == 1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 1 AND (MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%')", MaNV);
                    }
                    if (dk == -1)
                    {
                        sql += string.Format(" WHERE TRANGTHAI = 0 AND (MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%')", MaNV);
                    }
                    if (dk == 0)
                        sql += string.Format(" WHERE MANV LIKE '%{0}%' OR TEN LIKE N'%{0}%'", MaNV);
                }
            }
            sql += "  ORDER BY TEN";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();
            while (dr.Read())
            {
                clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();

                if (!dr.IsDBNull(0))
                    NhanVien.MaNV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    NhanVien.Ho = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    NhanVien.Ten = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    NhanVien.NgaySinh = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    NhanVien.DiaChiThuongTru = dr.GetString(4);
                if (!dr.IsDBNull(5))
                    NhanVien.CMND = dr.GetString(5);
                if (!dr.IsDBNull(6))
                    NhanVien.GioiTinh = dr.GetBoolean(6);
                if (!dr.IsDBNull(7))
                    NhanVien.NguyenQuan = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    NhanVien.TinhThanh = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    NhanVien.QuanHuyen = dr.GetString(9);
                if(!dr.IsDBNull(10))
                    NhanVien.QuocTich = dr.GetString(10);
                if (!dr.IsDBNull(11))
                    NhanVien.DanToc = dr.GetString(11);
                if (!dr.IsDBNull(12))
                    NhanVien.TonGiao = dr.GetString(12);
                if (!dr.IsDBNull(13))
                    NhanVien.NgayBatDauLamViec = (DateTime)dr[13];
                if (!dr.IsDBNull(14))
                    NhanVien.PhongBan = dr.GetString(14);
                if (!dr.IsDBNull(15))
                    NhanVien.MaBAC = dr.GetString(15);
                if (!dr.IsDBNull(16))
                    NhanVien.MaCV = dr.GetString(16);
                if (!dr.IsDBNull(17))
                    NhanVien.BangCap = dr.GetInt32(17);
                if (!dr.IsDBNull(18))
                    NhanVien.TrangThai = dr.GetBoolean(18);
                if (!dr.IsDBNull(19))
                    NhanVien.HINHDAIDIEN = dr.GetString(19);
                lsNhanVien.Add(NhanVien);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsNhanVien;
        }

        public List<clsNhanVien_DTO> LayDanhSachNhanVienCC(List<clsPhongBan_DTO> lsPhongBan)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT MANV,HO,TEN,PHONG FROM NHANVIEN WHERE");
            for (int i = 0; i < lsPhongBan.Count; i++)
            {
                if (i == 0)
                    sql += string.Format(" (PHONG = '{0}'", lsPhongBan[i].MAPB);
                else
                    sql += string.Format(" OR PHONG = '{0}'", lsPhongBan[i].MAPB);
            }
            sql += ") GROUP BY MANV,HO,TEN,PHONG ORDER BY PHONG,TEN";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();
            while (dr.Read())
            {
                clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0))
                    NhanVien.MaNV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    NhanVien.Ho = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    NhanVien.Ten = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    NhanVien.PhongBan = dr.GetString(3);
                lsNhanVien.Add(NhanVien);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsNhanVien;
        }


        public List<clsNhanVien_DTO> LayNhanVienTheoPhong(string MaPB)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT MANV, HO + ' ' + TEN as HoTen FROM NHANVIEN WHERE PHONG = '{0}'", MaPB);
            List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0))
                    nv.MaNV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    nv.Ho = dr.GetString(1);
                //if (!dr.IsDBNull(2))
                //    nv.Ten = dr.GetString(2);
                lsNhanVien.Add(nv);
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return lsNhanVien;
        }
    }
}
