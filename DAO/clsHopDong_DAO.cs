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

            string sql = string.Format("INSERT INTO HOPDONGLAODONG(MAHDLD,MANV,LOAIHD,TUNGAY,DENNGAY,DIADIEMLAM,CHUCVU,CONGVIEC,THOIGIANLAM,TRANGBILAODONG,HESOLUONG,PHUCAP,NGAYKY) VALUES  ('{0}','{1}',N'{2}','{3}','{4}',N'{5}',N'{6}',N'{7}',{8},N'{9}',{10},{11},'{12}')","HDLD" + (ThaoTacDuLieu.LaySoLuong("HOPDONGLAODONG", conn) + 1).ToString(),HD.MaNV,HD.LoaiHD,HD.NgayBatDau,HD.NgayKetThuc,HD.DiaDiemLam,HD.ChucVu,HD.CongViec,HD.ThoiGianLam,HD.TrangBi,HD.HeSoLuong,HD.PhuCap,HD.NgayKy);
            SqlCommand cmd = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
