using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class clsTinhLuong_BUS
    {
        public List<clsTinhLuong_DTO> lsBangLuong(int Nam, int Thang, string MaPhong)
        {
            List<clsTinhLuong_DTO> lsBangLuong = new List<clsTinhLuong_DTO>();
            clsTinhLuong_DAO dao = new clsTinhLuong_DAO();
            DataTable BangChamCong = dao.LayBangChamCong(Nam, Thang, MaPhong);
            
            float LuongToiThieu = dao.LayLuongToiThieu();
            int soNgayTrongThang = DateTime.DaysInMonth(Nam, Thang);
            #region Tính Lương
            for (int i = 0; i < BangChamCong.Rows.Count; i++ )
            {
                clsTinhLuong_DTO Luong = new clsTinhLuong_DTO();
                DataRow r = BangChamCong.Rows[i];
                string MaNV = r["MANV"].ToString();
                float HSCV = dao.LayHeSoLuongTheoCongViec(MaNV);
                float HSBC = dao.LayHeSoLuongTheoBang(MaNV);
                int DL = 0;//số ngày đi làm
                int KP = 0;//số ngày nghỉ không phép
                int CP = 0;//số ngày nghủ có phép
                int CN = 0;//số ngày cn
                for (int j = 2; j < soNgayTrongThang + 2; j++)
                {
                    if (r[j].ToString() != "CN")
                    {

                        if (r[j].ToString() == "K")
                        {
                            KP++;
                        }
                        else if (r[j].ToString() == "P")
                        {
                            CP++;
                        }
                        else
                        {
                            string gc = r[j].ToString();
                            DL++;//số ngày đi làm
                        }
                    }
                    else
                    {
                        CN++;
                    }
                }
                int ngayCongChuan = soNgayTrongThang - CN;
                float bouns = (LuongToiThieu * HSBC * HSCV);//Bc: bằng cấp, CV: bậc công việc
                float LuongThucTe = (LuongToiThieu + bouns) / ngayCongChuan * DL;//DL là số ngày đi làm
                Luong.MaNV = MaNV;
                Luong.HoTen = r["HO"].ToString() + " " + r["TEN"].ToString();
                Luong.SoNgayDiLam = DL;
                Luong.SoNgayNghiCoPhep = CP;
                Luong.SoNgayNghiKhongPhep = KP;
                Luong.TienLuong = LuongThucTe;
                lsBangLuong.Add(Luong);
            }
            #endregion
            return lsBangLuong;
        }
    }
}
