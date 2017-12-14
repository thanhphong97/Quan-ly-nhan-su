using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class clsRestore_DAO
    {
        public bool KhoiPhucCSDL(string NoiMo)
        {
            SqlConnection con = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand command;
            command = new SqlCommand("use master", con);
            command.ExecuteNonQuery();
            string sql = string.Format(@"RESTORE DATABASE [QLNV_XiNghiep] FROM DISK = '{0}'", NoiMo);
            command = new SqlCommand(sql, con);
            int kq = command.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(con);
            if (kq == -1)
                return true;
            return false;
        }
    }
}
