﻿using System;
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
            DateTime dt = new DateTime(1900, 1, 1);
            if (HD.NgayKetThuc == dt.Date)
            {
                sql = string.Format("INSERT INTO HOPDONGLAODONG(MAHDLD,MANV,LOAIHD,TUNGAY,DIADIEMLAM,CONGVIEC,THOIGIANLAM,TRANGBILAODONG,NGAYKY,DENNGAY) VALUES  ('{0}','{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}',{9},{10},'{11}')", "HDLD" + (ThaoTacDuLieu.LaySoLuong("HOPDONGLAODONG", conn) + 1).ToString(), HD.MaNV, HD.LoaiHD, HD.NgayBatDau, HD.DiaDiemLam, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.NgayKy,HD.NgayKetThuc);
            }
            else
            {
                sql = string.Format("INSERT INTO HOPDONGLAODONG(MAHDLD,MANV,LOAIHD,TUNGAY,DENNGAY,DIADIEMLAM,CONGVIEC,THOIGIANLAM,TRANGBILAODONG,NGAYKY) VALUES  ('{0}','{1}',N'{2}','{3}','{4}',N'{5}',N'{6}',{7},N'{8}','{9}')", "HDLD" + (ThaoTacDuLieu.DemSoLuong("SELECT COUNT(*) FROM HOPDONGLAODONG") + 1).ToString(), HD.MaNV, HD.LoaiHD, HD.NgayBatDau, dt.Date, HD.DiaDiemLam, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.NgayKy);
            }
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }

        public List<clsHopDong_DTO> LayDanhSachHopDong(string MaNV)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM HOPDONGLAODONG WHERE MANV = '{0}' ORDER BY TUNGAY", MaNV);
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
                    HD.CongViec = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    HD.ThoiGianLam = dr.GetDouble(7);
                if (!dr.IsDBNull(8))
                    HD.TrangBi = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    HD.NgayKy = dr.GetDateTime(9);
                //hợp đồng không xác dịnh thời hạn
                lsHD.Add(HD);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsHD;
        }

        public bool CapNhatHopDong(clsHopDong_DTO HD)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "";
            DateTime dt = new DateTime(1900, 1, 1);
            if (HD.NgayKetThuc == dt.Date)
            {
                sql = string.Format("UPDATE HOPDONGLAODONG SET LOAIHD = N'{0}', TUNGAY = '{1}', DIADIEMLAM = N'{2}', CONGVIEC = N'{3}', THOIGIANLAM = {4}, TRANGBILAODONG = N'{5}', NGAYKY = '{6}', DENNGAY = '' WHERE MAHDLD = '{7}'", HD.LoaiHD, HD.NgayBatDau, HD.DiaDiemLam, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.NgayKy,HD.MaHDLD);
            }
            else
            {

                sql = string.Format("UPDATE HOPDONGLAODONG SET LOAIHD = N'{0}', TUNGAY = '{1}', DENNGAY = '{2}', DIADIEMLAM = N'{3}', CONGVIEC = N'{4}', THOIGIANLAM = {5}, TRANGBILAODONG = N'{6}', NGAYKY = '{7}' WHERE MAHDLD = '{8}'", HD.LoaiHD, HD.NgayBatDau, HD.NgayKetThuc, HD.DiaDiemLam, HD.CongViec, HD.ThoiGianLam, HD.TrangBi, HD.NgayKy, HD.MaHDLD);
            }
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }
    }
}
