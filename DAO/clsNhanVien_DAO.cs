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
            //auto thành công;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT COUNT(*) FROM NGUOIDUNG WHERE TAIKHOAN = '{0}' AND MATKHAU = '{1}'", strTenDN, strMK);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(conn);

            return kq > 0;

        }

        public DTO.clsNhanVien_DTO LayThongTinNhanVien(string strTenDN)
        {
            throw new NotImplementedException();
        }

        public int DemNhanVien()
        {
            throw new NotImplementedException();

        }


        public bool ThemNhanVien(clsNhanVien_DTO nv)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            //thêm theo thứ tự cột trong của bảng NHANVIEN trong Database
            string sql = string.Format("INSERT INTO NHANVIEN VALUE('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')", nv.MaNV, nv.Ho, nv.Ten, nv.NgaySinh, nv.DiaChiThuongTru, nv.CMND, nv.GioiTinh, nv.NguyenQuan, nv.TinhThanh, nv.QuanHuyen, nv.QuocTich, nv.DanToc, nv.TonGiao, nv.NgayBatDauLamViec, nv.PhongBan, nv.MaBacND, nv.MaBacHSL, nv.MaCV, nv.MaBC);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int rowAffected = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (rowAffected == 0)
                return false;// Thêm thất bại
            return true;//thêm thành công
        }

        public List<clsNhanVien_DTO> LayDanhSachNhanVien(List<clsPhongBan_DTO> lsPhongBan)
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


        
    }
}
