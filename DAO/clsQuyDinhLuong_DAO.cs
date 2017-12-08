using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class clsQuyDinhLuong_DAO
    {
        public bool CapNhatQuyDinhLuong(clsQuyDinhLuong_DTO QuyDinh)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("UPDATE QUYDINHLUONG SET LUONGTOITHIEU = {0}, BHXH = {1},BHYT = {2}, BHTN = {3} WHERE MAQD = 'QD1'", QuyDinh.LuongToiThieu, QuyDinh.BHXH, QuyDinh.BHYT, QuyDinh.BHTN);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return kq > 0;
        }
        public clsQuyDinhLuong_DTO LayQuyDinhLuong()
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "SELECT * FROM QUYDINHLUONG WHERE MAQD = 'QD1'";
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            clsQuyDinhLuong_DTO QuyDinh = new clsQuyDinhLuong_DTO();
            while(dr.Read())
            {
                if (!dr.IsDBNull(0))
                    QuyDinh.MaQD = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    QuyDinh.LuongToiThieu = dr.GetDecimal(1);
                if (!dr.IsDBNull(2))
                    QuyDinh.BHXH = dr.GetDouble(2);
                if (!dr.IsDBNull(3))
                    QuyDinh.BHYT = dr.GetDouble(3);
                if (!dr.IsDBNull(4))
                    QuyDinh.BHTN = dr.GetDouble(4);
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return QuyDinh;
        }
    }
}
