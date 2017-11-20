﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsNhatKy_DAO
    {
        public void ThemNhatKy(string TaiKhoan,DateTime ThoiGian, string SuKien)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("INSERT INTO NHATKY(TAIKHOAN,THOIGIAN,SUKIEN) VALUES ('{0}','{1}',N'{2}')", TaiKhoan, ThoiGian, SuKien);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
        }

        public List<clsNhatKy_DTO> LayDanhSachNhatKy()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM NHATKY ORDER BY MANK DESC";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsNhatKy_DTO> lsNK = new List<clsNhatKy_DTO>();
            while(dr.Read())
            {
                clsNhatKy_DTO NK = new clsNhatKy_DTO();
                if (!dr.IsDBNull(0))
                    NK.MaNK = dr.GetInt64(0);
                if (!dr.IsDBNull(1))
                    NK.TaiKhoan = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    NK.ThoiGian = dr.GetDateTime(2);
                if (!dr.IsDBNull(3))
                    NK.SuKien = dr.GetString(3);
                lsNK.Add(NK);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsNK;
        }
    }
}
