using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class clsBackup_DAO
    {
        public bool SaoLuuCSDL(string NoiLuu)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format(@"BACKUP DATABASE [QLNV_XiNghiep] TO DISK ='{0}' with init", NoiLuu);
            //with init:  ghi đè
            SqlCommand command = ThaoTacDuLieu.TaoDoiTuongTruyVan(sql, con);
            int kq = command.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (kq == -1)
                return true;
            return false;
        }
    }
}
