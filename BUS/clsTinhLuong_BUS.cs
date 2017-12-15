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
       private List<clsTinhLuong_DTO> lsBangLuongTheoBangCong = new List<clsTinhLuong_DTO>();
        public List<clsTinhLuong_DTO> lsBangLuong(int Nam, int Thang, string MaPhong)
        {
            clsBangLuong_DAO daoBangLuong = new clsBangLuong_DAO();
            DataTable BangLuong = daoBangLuong.layBangLuong(Nam, Thang, MaPhong);//bảng lương theo tháng, của phòng nào đó
            if(BangLuong.Rows.Count == 0)// tiền lương chưa được tính
            {
               TinhLuongTheoBangCong(Nam,Thang,MaPhong);
            }
            else
            {
                
                for(int i = 0; i < BangLuong.Rows.Count; i++)
                {
                    //nếu null khoong cho gán
                    clsTinhLuong_DTO Luong = new clsTinhLuong_DTO();
                    DataRow r = BangLuong.Rows[i];
                    Luong.MaNV = r["MANV"].ToString(); ;
                    Luong.HoTen = r["HO"].ToString() + " " + r["TEN"].ToString();
                    Luong.SoNgayDiLam = (int)r["SONGAYDILAM"];
                    Luong.SoNgayNghiCoPhep = (int)r["SONGAYNGHICOPHEP"];
                    Luong.SoNgayNghiKhongPhep = (int)r["SONGAYNGHIKHONGPHEP"];
                    Luong.TongThuNhap = (double)r["TONGTHUNHAP"];
                    Luong.BHXH = (double)r["BHXH"];
                    Luong.BHYT = (double)r["BHYT"];
                    Luong.BHTN = (double)r["BHTN"];
                    Luong.TienLuong = (double)r["TIENLUONG"];
                    lsBangLuongTheoBangCong.Add(Luong);
                }
            }
            return lsBangLuongTheoBangCong;
        }
        public DataTable LayBangLuongBaoCao(int Nam, int Thang, string MaPhong)
        {
            clsBangLuong_DAO daoBangLuong = new clsBangLuong_DAO();
            return daoBangLuong.layBangLuong(Nam, Thang, MaPhong);
        }
        public void TinhLuongTheoBangCong(int Nam, int Thang, string MaPhong)
        {
            // #region Tinh luong theo bang cong
                clsTinhLuong_DAO daoTinhLuong = new clsTinhLuong_DAO();
                DataTable BangChamCong = daoTinhLuong.LayBangChamCong(Nam, Thang, MaPhong);
                //nếu bảng chấm công có tồn tại
                if (BangChamCong.Rows.Count > 0)
                {
                    clsQuyDinhLuong_BUS busQDL = new clsQuyDinhLuong_BUS();
                    clsQuyDinhLuong_DTO QDL = busQDL.LayQuyDinhLuong();
                    int soNgayTrongThang = DateTime.DaysInMonth(Nam, Thang);
                   
                    for (int i = 0; i < BangChamCong.Rows.Count; i++)
                    {
                        clsTinhLuong_DTO Luong = new clsTinhLuong_DTO();
                        DataRow r = BangChamCong.Rows[i];
                        string MaNV = r["MANV"].ToString();
                        float HSCV = daoTinhLuong.LayHeSoLuongTheoCongViec(MaNV);
                        float HSBC = daoTinhLuong.LayHeSoLuongTheoBang(MaNV);
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

                        if (CP > 3)
                            DL = DL - (CP % 3);// nghỉ 3 bữa có phép sẽ trừ 1 ngày đi làm
                        int ngayCongChuan = soNgayTrongThang - CN;
                        float LuongCoBan = ((float)QDL.LuongToiThieu * HSBC * HSCV);//Bc: bằng cấp, CV: bậc công việc
                        float TongThuNhap = (LuongCoBan) / ngayCongChuan * DL;//DL là số ngày đi làm
                        double LuongDongBaoHiem = TongThuNhap * (QDL.BHYT + QDL.BHXH + QDL.BHTN);
                        double LuongThucTe = TongThuNhap - LuongDongBaoHiem;
                        Luong.MaNV = MaNV;
                        Luong.HoTen = r["HO"].ToString() + " " + r["TEN"].ToString();
                        Luong.SoNgayDiLam = DL;
                        Luong.SoNgayNghiCoPhep = CP;
                        Luong.SoNgayNghiKhongPhep = KP;
                        Luong.TongThuNhap = TongThuNhap;
                        Luong.BHXH = TongThuNhap * QDL.BHXH;
                        Luong.BHYT = TongThuNhap * QDL.BHYT;
                        Luong.BHTN = TongThuNhap * QDL.BHTN;
                        Luong.TienLuong = LuongThucTe;
                        Luong.Thang = Thang;
                        Luong.Nam = Nam;
                        lsBangLuongTheoBangCong.Add(Luong);
                        
                    }
                    //lưu bảng lương vào Database
                    clsBangLuong_BUS busLuuBangLuong = new clsBangLuong_BUS();
                    busLuuBangLuong.LuuBangLuong(lsBangLuongTheoBangCong);
                }
                //#endregion
        }
    }
}
