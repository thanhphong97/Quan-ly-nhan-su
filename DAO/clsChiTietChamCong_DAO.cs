using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class clsChiTietChamCong_DAO
    {

        //public int LaySoLuong()
        //{
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    string sql = "SELECT COUNT(DISTINCT MACC) FROM CHAMCONG";
        //    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql,conn);
        //    int kq = (int)cmd.ExecuteScalar();
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return kq;
        //}
        //public bool ThemBangChamCong(int SoNgay, List<clsChamCong_DTO> lsChamCong)
        //{
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    string MaCC = "CC" + (LaySoLuong() + 1).ToString();
        //    if (lsChamCong.Count > 0)
        //    {
        //        for (int i = 0; i < lsChamCong.Count; i++)
        //        {
        //            string sql = "INSERT INTO CHAMCONG(MACC,MANV,THANG,NAM";
        //            for (int j = 1; j <= SoNgay; j++)
        //            {
        //                sql += string.Format(",D{0}", j.ToString());
        //            }
        //            sql += ",SONGAY)";
        //            sql += string.Format("VALUES('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}'", MaCC, lsChamCong[i].MaNV, lsChamCong[i].Thang, lsChamCong[i].Nam, lsChamCong[i].D1, lsChamCong[i].D2, lsChamCong[i].D3, lsChamCong[i].D4, lsChamCong[i].D5, lsChamCong[i].D6, lsChamCong[i].D7, lsChamCong[i].D8, lsChamCong[i].D9, lsChamCong[i].D10, lsChamCong[i].D11, lsChamCong[i].D12, lsChamCong[i].D13, lsChamCong[i].D14, lsChamCong[i].D15, lsChamCong[i].D16, lsChamCong[i].D17, lsChamCong[i].D18, lsChamCong[i].D19, lsChamCong[i].D20, lsChamCong[i].D21, lsChamCong[i].D22, lsChamCong[i].D23, lsChamCong[i].D24, lsChamCong[i].D25, lsChamCong[i].D26, lsChamCong[i].D27,lsChamCong[i].D28);
                   
        //            if(SoNgay == 29)
        //            {
        //                sql += string.Format(",'{0}'",lsChamCong[i].D29);
        //            }
        //            else if(SoNgay == 30)
        //            {
        //                sql += string.Format(",'{0}','{1}'", lsChamCong[i].D29,lsChamCong[i].D30);
        //            }
        //            else if (SoNgay == 31)
        //            {
        //                sql += string.Format(",'{0}','{1}','{2}'", lsChamCong[i].D29, lsChamCong[i].D30,lsChamCong[i].D30,lsChamCong[i].D31);
        //            }

        //            sql += string.Format(",{0})", SoNgay);
        //            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
        //            int kq = (int)cmd.ExecuteNonQuery();
        //            if (kq <= 0)
        //            {
        //                ThaoTacDuLieu.DongKetNoi(conn);
        //                return false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ThaoTacDuLieu.DongKetNoi(conn);
        //        return false;
        //    }
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return true;
        //}

        //public List<clsChamCong_DTO> LayTenBangChamCong()
        //{
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    string sql = "SELECT MACC,THANG,NAM,N'Bảng chấm công tháng ' + Convert(varchar(2),THANG) + N' năm ' +Convert(varchar(5),NAM) AS TENBANG FROM CHAMCONG GROUP BY MACC,THANG,NAM";
        //    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    List<clsChamCong_DTO> lsChamCong = new List<clsChamCong_DTO>();
        //    while(dr.Read())
        //    {
        //        clsChamCong_DTO ChamCong = new clsChamCong_DTO();
        //        if (!dr.IsDBNull(0))
        //            ChamCong.MaCC = dr.GetString(0);
        //        if (!dr.IsDBNull(1))
        //            ChamCong.Thang = dr.GetInt32(1);
        //        if (!dr.IsDBNull(2))
        //            ChamCong.Nam = dr.GetInt32(2);
        //        if (!dr.IsDBNull(3))
        //            ChamCong.TenBang = dr.GetString(3);
        //        lsChamCong.Add(ChamCong);
        //    }
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return lsChamCong;
        //}

        public DataTable LayBangChiTietChamCongNV(string strTK)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM CHITIETCHAMCONG JOIN NHANVIEN ON NHANVIEN.MANV = CHITIETCHAMCONG.MANV JOIN PHONGBAN ON PHONGBAN.MAPB = PHONG WHERE MACC = '{0}'", strTK);
            return ThaoTacDuLieu.LayBang(sql);

        }

        //public bool ThemBangChamCong(clsChamCong_DTO lsChamCong)
        //{
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    string sql = string.Format("INSERT INTO CHAMCONG(MACC,MANV,THANG,NAM,SONGAY) VALUES('{0}','{1}',{2},{3},{4})", lsChamCong.MaCC, lsChamCong.MaNV, lsChamCong.Thang, lsChamCong.Nam, lsChamCong.SoNgay);
        //    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
        //    int kq = cmd.ExecuteNonQuery();
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return kq > 0;
        //}

        //public int LaySoLuongBangChamCong()
        //{
        //    SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
        //    string sql = "SELECT COUNT(*) FROM CHAMCONG";
        //    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
        //    int kq = (int)cmd.ExecuteScalar();
        //    ThaoTacDuLieu.DongKetNoi(conn);
        //    return kq;
        //}

        public bool ThemChiTietChamCong(clsChiTietChamCong_DTO ChiTiet)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("INSERT INTO CHITIETCHAMCONG(MACC,MANV) VALUES('{0}','{1}')", ChiTiet.MaCC, ChiTiet.MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }

        public List<clsChiTietChamCong_DTO> LayChiTiet(string MaCC)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT HO,TEN,NHANVIEN.MANV,PHONG,D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12,D13,D14,D15,D16,D17,D18,D19,D20,D21,D22,D23,D24,D25,D26,D27,D28,D29,D30,D31 FROM CHITIETCHAMCONG,NHANVIEN WHERE NHANVIEN.MANV = CHITIETCHAMCONG.MANV AND MACC = '{0}' AND TRANGTHAI = 1",MaCC);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsChiTietChamCong_DTO> lsCT = new List<clsChiTietChamCong_DTO>();
            while(dr.Read())
            {
                clsChiTietChamCong_DTO CT = new clsChiTietChamCong_DTO();
                clsNhanVien_DTO NV = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0))
                    NV.Ho = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    NV.Ten = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    NV.MaNV = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    NV.PhongBan = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    CT.D1 = dr.GetString(4);
                if (!dr.IsDBNull(5))
                    CT.D2 = dr.GetString(5);
                if (!dr.IsDBNull(6))
                    CT.D3 = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    CT.D4 = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    CT.D5 = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    CT.D6 = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    CT.D7 = dr.GetString(10);
                if (!dr.IsDBNull(11))
                    CT.D8 = dr.GetString(11);
                if (!dr.IsDBNull(12))
                    CT.D9 = dr.GetString(12);
                if (!dr.IsDBNull(13))
                    CT.D10 = dr.GetString(13);
                if (!dr.IsDBNull(14))
                    CT.D12 = dr.GetString(14);
                if (!dr.IsDBNull(15))
                    CT.D12 = dr.GetString(15);
                if (!dr.IsDBNull(16))
                    CT.D13 = dr.GetString(16);
                if (!dr.IsDBNull(17))
                    CT.D14 = dr.GetString(17);
                if (!dr.IsDBNull(18))
                    CT.D15 = dr.GetString(18);
                if (!dr.IsDBNull(19))
                    CT.D16 = dr.GetString(19);
                if (!dr.IsDBNull(20))
                    CT.D16 = dr.GetString(20);
                if (!dr.IsDBNull(21))
                    CT.D18 = dr.GetString(21);
                if (!dr.IsDBNull(22))
                    CT.D19 = dr.GetString(22);
                if (!dr.IsDBNull(23))
                    CT.D20 = dr.GetString(23);
                if (!dr.IsDBNull(24))
                    CT.D21 = dr.GetString(24);
                if (!dr.IsDBNull(25))
                    CT.D22 = dr.GetString(25);
                if (!dr.IsDBNull(26))
                    CT.D23 = dr.GetString(26);
                if (!dr.IsDBNull(27))
                    CT.D24 = dr.GetString(27);
                if (!dr.IsDBNull(28))
                    CT.D25 = dr.GetString(28);
                if (!dr.IsDBNull(29))
                    CT.D26 = dr.GetString(29);
                if (!dr.IsDBNull(30))
                    CT.D27 = dr.GetString(30);
                if (!dr.IsDBNull(31))
                    CT.D28 = dr.GetString(31);
                if (!dr.IsDBNull(32))
                    CT.D29 = dr.GetString(32);
                if (!dr.IsDBNull(33))
                    CT.D30 = dr.GetString(33);
                if (!dr.IsDBNull(34))
                    CT.D31 = dr.GetString(34);
                CT.NhanVien = NV;
                lsCT.Add(CT);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsCT;
        }


        public bool CapNhatChamCong(string sql )
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql,conn);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }
    }
}
