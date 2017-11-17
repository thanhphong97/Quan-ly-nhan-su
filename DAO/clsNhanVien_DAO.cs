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
            string sql = string.Format("SELECT HO, TEN, LOAIND FROM NHANVIEN, NGUOIDUNG WHERE NHANVIEN.MANV = NGUOIDUNG.MANV AND TAIKHOAN = '{0}'",strTenDN);
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
            }
            ThaoTacDuLieu.DongKetNoi(con);
            return nv;
        }

        public int LaySoLuongNhanVien()
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            int slnv = ThaoTacDuLieu.LaySoLuong("NHANVIEN", con);
            return slnv;
        }
        public bool ThemNhanVien(clsNhanVien_DTO nv)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string ngaysinh = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgaySinh);
            string Ngaybatdaulamviec = string.Format("{0:yyyy}/{0:MM}/{0:dd}", nv.NgayBatDauLamViec);
            string sql = string.Format("INSERT INTO NHANVIEN (MANV, HO, TEN, NGAYSINH, DIACHI, CMND, GIOITINH, NGUYENQUAN, TINHTHANH, QUANHUYEN, QUOCTICH, DANTOC, TONGIAO, NGAYBATDAU, PHONG, MABAC, MACV, BANGCAP, HOPDONGTV, TRANGTHAI) VALUES ('{0}', N'{1}' ,N'{2}' ,'{3}' ,N'{4}' ,'{5}', '{6}', N'{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', 'NULL', '{18}')", nv.MaNV, nv.Ho, nv.Ten, ngaysinh, nv.DiaChiThuongTru, nv.CMND, nv.GioiTinh, nv.NguyenQuan, nv.TinhThanh, nv.QuanHuyen, nv.QuocTich, nv.DanToc, nv.TonGiao, Ngaybatdaulamviec, nv.PhongBan, nv.MaBAC, nv.MaCV, nv.BangCap, nv.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int rowAffected = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (rowAffected == 0)
                return false;// Thêm thất bại
            return true;//thêm thành công
        }
        
        //public List<clsNhanVien_DTO> LayDanhSachNhanVien(List<clsPhongBan_DTO> lsPhongBan)
        //{
        //    string sql = "";
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    #region Dùng cho danh sách nhân viên nhân viên
       
        //        sql = string.Format("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, CMND, GIOITINH, NGUYENQUAN, TINHTHANH, QUANHUYEN, QUOCTINH, DANTOC, TONGIAO, NGAYBATDAU, PHONG, MABAC, MACV, BANGCAP, HOPDONGTV, TRANGTHAI FROM NHANVIEN TRANGTHAI = 1");
        //    #endregion
        //    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();
        //    while (dr.Read())
        //    {
        //        clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();

        //        if (!dr.IsDBNull(0))
        //            NhanVien.MaNV = dr.GetString(0);
        //        if (!dr.IsDBNull(1))
        //            NhanVien.Ho = dr.GetString(1);
        //        if (!dr.IsDBNull(2))
        //            NhanVien.Ten = dr.GetString(2);
        //        if (!dr.IsDBNull(3))
        //            NhanVien.NgaySinh = dr.GetDateTime(3);
        //        if (!dr.IsDBNull(4))
        //            NhanVien.DiaChiThuongTru = dr.GetString(4);
        //        if (!dr.IsDBNull(5))
        //            NhanVien.CMND = dr.GetString(5);
        //        if (!dr.IsDBNull(6))
        //            NhanVien.GioiTinh = dr.GetBoolean(6);
        //        if (!dr.IsDBNull(7))
        //            NhanVien.NguyenQuan= dr.GetString(7);
        //        if (!dr.IsDBNull(8))
        //            NhanVien.TinhThanh = dr.GetString(8);
        //        if (!dr.IsDBNull(9))
        //            NhanVien.QuocTich = dr.GetString(9);
        //        if (!dr.IsDBNull(10))
        //            NhanVien.DanToc = dr.GetString(10);
        //        if (!dr.IsDBNull(11))
        //            NhanVien.TonGiao = dr.GetString(11);
        //        if (!dr.IsDBNull(12))
        //            NhanVien.NgayBatDauLamViec = dr.GetDateTime(12);
        //        if (!dr.IsDBNull(13))
        //            NhanVien.PhongBan = dr.GetString(13);
        //        if (!dr.IsDBNull(14))
        //            NhanVien.MaBAC = dr.GetString(14);
        //        if (!dr.IsDBNull(15))
        //            NhanVien.MaBAC = dr.GetString(15);
        //        if (!dr.IsDBNull(16))
        //            NhanVien.MaCV = dr.GetString(16);
        //        if (!dr.IsDBNull(17))
        //            NhanVien.BangCap = dr.GetInt32(17);
        //        if (!dr.IsDBNull(18))
        //            NhanVien.HopDongTV = dr.GetString(18);
        //        if (!dr.IsDBNull(19))
        //            NhanVien.TrangThai = dr.GetBoolean(19);
        //        lsNhanVien.Add(NhanVien);
        //    }
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return lsNhanVien;
        //}

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
            sql += ") GROUP BY MANV,HO,TEN,PHONG ORDER BY PHONG";
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
