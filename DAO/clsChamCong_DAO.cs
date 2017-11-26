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
    public class clsChamCong_DAO
    {

        public int LaySoLuong()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT COUNT(DISTINCT MACC) FROM CHAMCONG";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql,conn);
            int kq = (int)cmd.ExecuteScalar();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq;
        }
        public bool ThemBangChamCong(int SoNgay, List<clsChamCong_DTO> lsChamCong)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string MaCC = "CC" + (LaySoLuong() + 1).ToString();
            if (lsChamCong.Count > 0)
            {
                for (int i = 0; i < lsChamCong.Count; i++)
                {
                    string sql = "INSERT INTO CHAMCONG(MACC,MANV,THANG,NAM";
                    for (int j = 1; j <= SoNgay; j++)
                    {
                        sql += string.Format(",D{0}", j.ToString());
                    }
                    sql += ",SONGAY)";
                    sql += string.Format("VALUES('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}'", MaCC, lsChamCong[i].MaNV, lsChamCong[i].Thang, lsChamCong[i].Nam, lsChamCong[i].D1, lsChamCong[i].D2, lsChamCong[i].D3, lsChamCong[i].D4, lsChamCong[i].D5, lsChamCong[i].D6, lsChamCong[i].D7, lsChamCong[i].D8, lsChamCong[i].D9, lsChamCong[i].D10, lsChamCong[i].D11, lsChamCong[i].D12, lsChamCong[i].D13, lsChamCong[i].D14, lsChamCong[i].D15, lsChamCong[i].D16, lsChamCong[i].D17, lsChamCong[i].D18, lsChamCong[i].D19, lsChamCong[i].D20, lsChamCong[i].D21, lsChamCong[i].D22, lsChamCong[i].D23, lsChamCong[i].D24, lsChamCong[i].D25, lsChamCong[i].D26, lsChamCong[i].D27,lsChamCong[i].D28);
                   
                    if(SoNgay == 29)
                    {
                        sql += string.Format(",'{0}'",lsChamCong[i].D29);
                    }
                    else if(SoNgay == 30)
                    {
                        sql += string.Format(",'{0}','{1}'", lsChamCong[i].D29,lsChamCong[i].D30);
                    }
                    else if (SoNgay == 31)
                    {
                        sql += string.Format(",'{0}','{1}','{2}'", lsChamCong[i].D29, lsChamCong[i].D30,lsChamCong[i].D30,lsChamCong[i].D31);
                    }

                    sql += string.Format(",{0})", SoNgay);
                    SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq <= 0)
                    {
                        ThaoTacDuLieu.DongKetNoi(conn);
                        return false;
                    }
                }
            }
            else
            {
                ThaoTacDuLieu.DongKetNoi(conn);
                return false;
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return true;
        }

        public List<clsChamCong_DTO> LayTenBangChamCong()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT MACC,THANG,NAM,N'Bảng chấm công tháng ' + Convert(varchar(2),THANG) + N' năm ' +Convert(varchar(5),NAM) AS TENBANG FROM CHAMCONG GROUP BY MACC,THANG,NAM";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsChamCong_DTO> lsChamCong = new List<clsChamCong_DTO>();
            while(dr.Read())
            {
                clsChamCong_DTO ChamCong = new clsChamCong_DTO();
                if (!dr.IsDBNull(0))
                    ChamCong.MaCC = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    ChamCong.Thang = dr.GetInt32(1);
                if (!dr.IsDBNull(2))
                    ChamCong.Nam = dr.GetInt32(2);
                if (!dr.IsDBNull(3))
                    ChamCong.TenBang = dr.GetString(3);
                lsChamCong.Add(ChamCong);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return lsChamCong;
        }

        public DataTable LayBangChamCongNV(string strTK)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM CHAMCONG JOIN NHANVIEN ON NHANVIEN.MANV = CHAMCONG.MANV JOIN PHONGBAN ON PHONGBAN.MAPB = PHONG WHERE MACC = '{0}'",strTK);
            return ThaoTacDuLieu.LayBang(sql);
        }
    }
}
