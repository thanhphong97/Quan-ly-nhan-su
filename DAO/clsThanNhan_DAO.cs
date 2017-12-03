using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class clsThanNhan_DAO
    {
        public bool ThemThanNhan(clsThanNhan_DTO TN)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("INSERT INTO THANNHAN(MANV,HOTEN,MOIQH,NGAYSINH,NGHENGHIEP) VALUES('{0}',N'{1}',{2},'{3}',N'{4}')", TN.MaNV, TN.HoTenTN, TN.MoiQH, TN.NgaySinhTN, TN.NgheNghiepTN);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }
        public List<clsThanNhan_DTO> LayDanhSachThanNhan(string MaNV)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM THANNHAN WHERE MANV = '{0}'", MaNV);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsThanNhan_DTO> lsTN = new List<clsThanNhan_DTO>();
            while(dr.Read())
            {
                clsThanNhan_DTO TN = new clsThanNhan_DTO();
                if (!dr.IsDBNull(0))
                    TN.MaQHGD = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    TN.MaNV = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    TN.HoTenTN = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    TN.MoiQH = dr.GetInt32(3);
                if (!dr.IsDBNull(4))
                    TN.NgaySinhTN = dr.GetDateTime(4);
                if (!dr.IsDBNull(5))
                    TN.NgheNghiepTN = dr.GetString(5);
                lsTN.Add(TN);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsTN;
        }

        public bool CapNhatThanNhan(clsThanNhan_DTO TN)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("UPDATE THANNHAN SET HOTEN = N'{0}', MOIQH = {1}, NGAYSINH = '{2}', NGHENGHIEP = N'{3}' WHERE MAQHGD = {4}", TN.HoTenTN, TN.MoiQH, TN.NgaySinhTN, TN.NgheNghiepTN, TN.MaQHGD);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }
        public int LaySoLuongTN()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            int SL = ThaoTacDuLieu.LaySoLuong("THANNHAN", conn);
            ThaoTacDuLieu.DongKetNoi(conn);
            return SL;
        }
        
    }
}
