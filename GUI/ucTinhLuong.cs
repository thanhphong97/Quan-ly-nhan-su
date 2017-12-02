using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class ucTinhLuong : UserControl
    {
        public ucTinhLuong()
        {
            InitializeComponent();
        }
        private void ucTinhLuong_Load(object sender, EventArgs e)
        {
            //loadDuLieu();
            loadDSTIenLuong();
        }

        private void loadDSTIenLuong()
        {
            clsTinhLuong_BUS bus = new clsTinhLuong_BUS();
            dgvTienLuong.DataSource = bus.lsBangLuong(2017, 11, txtMaPhong.Text);//mặc định 2017 tháng 11, phòng PB2
        }

        //private void loadDuLieu()
        //{
        //    //try
        //    //{
        //        if(txtMaPhong.Text != "")
        //        {
        //            SqlConnection con = new SqlConnection(ChuoiKetNoi);
        //            con.Open();
        //            string sql = string.Format("select * from CHITIETCHAMCONG, CHAMCONG where CHITIETCHAMCONG.MACC = CHAMCONG.MACC and THANG = 11 and nam = 2017 and manv = '{0}'", txtMaPhong.Text);

        //            string sql_HeSoBacCV = string.Format("select HESO from BACLUONG, NHANVIEN where BACLUONG.BAC = NHANVIEN.MABAC and BACLUONG.MACV = NHANVIEN.MACV and NHANVIEN.MANV = '{0}'", txtMaPhong.Text);

        //            string sql_HeSoBangCap = string.Format("select HESO from NHANVIEN, BANGCAP where NHANVIEN.BANGCAP = BANGCAP.MABC and NHANVIEN.MANV = '{0}'", txtMaPhong.Text);
        //            SqlCommand cmd = new SqlCommand(sql, con);
        //            DataTable dt = new DataTable();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            da.Fill(dt);
        //            //
        //            cmd = new SqlCommand(sql_HeSoBacCV, con);
        //            float HSCV = float.Parse(cmd.ExecuteScalar().ToString());
        //            //
        //            cmd = new SqlCommand(sql_HeSoBangCap, con);
        //            float HSBC = float.Parse(cmd.ExecuteScalar().ToString());
        //            //
        //            cmd = new SqlCommand("SELECT LUONGTOITHIEU from QUYDINHLUONG", con);
        //            float LuongToiThieu = float.Parse(cmd.ExecuteScalar().ToString());
        //            con.Close();
        //            int DL = 0;//số ngày đi làm
        //            int KP = 0;//số ngày nghỉ không phép
        //            int CP = 0;//số ngày nghủ có phép
        //            int CN = 0;//số ngày cn
        //            dgvTienLuong.DataSource = dt;
        //            dgvTienLuong.AutoGenerateColumns = false;
        //            lblSoNgayDiLam.Text = DL.ToString();
        //            lblSoNgayKP.Text = KP.ToString();
        //            lblSoNgayP.Text = CP.ToString();

        //            #region tính lương
        //            int nam = 2017;
        //            int thang = 11;
        //            int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);
        //            for (int i = 2; i < soNgayTrongThang+2; i++)
        //            {
        //                if (dt.Rows[0][i].ToString() != "CN")
        //                {

        //                    if (dt.Rows[0][i].ToString() == "K")
        //                    {
        //                        KP++;
        //                    }
        //                    else if (dt.Rows[0][i].ToString() == "P")
        //                    {
        //                        CP++;
        //                    }
        //                    else
        //                    {
        //                        string gc = dt.Rows[0][i].ToString();
        //                        DL++;//số ngày đi làm
        //                    }
        //                }
        //                else
        //                {
        //                    CN++;
        //                }
        //            }
        //            int ngayCongChuan = soNgayTrongThang - CN;
        //            float bouns = (LuongToiThieu * HSBC * HSCV);//Bc: bằng cấp, CV: bậc công việc
        //            float luongSida = (LuongToiThieu + bouns) / ngayCongChuan * DL;//DL là số ngày đi làm
        //            lblLuong.Text = string.Format("{0:#,##0} VNĐ", luongSida);
        //            #endregion
        //        }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //}

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            //loadDuLieu();
            loadDSTIenLuong();
        }

        private void dgvTienLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
        
    }
}
