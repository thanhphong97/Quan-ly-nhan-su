using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GUI
{
    public partial class ucTinhLuong : UserControl
    {
        public ucTinhLuong()
        {
            InitializeComponent();
        }
        private static string ChuoiKetNoi = "Data Source=.;Initial Catalog=QLNV_XiNghiep;Integrated Security=True";
        private void ucTinhLuong_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            //try
            //{
                if(txtMaNV.Text != "")
                {
                    SqlConnection con = new SqlConnection(ChuoiKetNoi);
                    con.Open();
                    string sql = string.Format("select * from CHITIETCHAMCONG, CHAMCONG where CHITIETCHAMCONG.MACC = CHAMCONG.MACC and THANG = 11 and nam = 2017 and manv = '{0}'", txtMaNV.Text);
                    string sql_HeSoCV = string.Format("select HESO from BACLUONG, NHANVIEN where BACLUONG.BAC = NHANVIEN.MABAC and BACLUONG.MACV = NHANVIEN.MACV and NHANVIEN.MANV = '{0}'", txtMaNV.Text);
                    string sql_HeSoBC = string.Format("select HESO from BACLUONG, NHANVIEN where BACLUONG.BAC = NHANVIEN.MABAC and BACLUONG.MACV = NHANVIEN.MACV and NHANVIEN.MANV = '{0}'", txtMaNV.Text);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    //
                    cmd = new SqlCommand(sql_HeSoCV, con);
                    float HSCV = float.Parse(cmd.ExecuteScalar().ToString());
                    //
                    cmd = new SqlCommand(sql_HeSoBC, con);
                    float HSBC = float.Parse(cmd.ExecuteScalar().ToString());
                    //
                    cmd = new SqlCommand("select LUONGTOITHIEU from QUYDINHLUONG", con);
                    float LuongToiThieu = float.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                    int DL = 0;
                    int KP = 0;
                    int CP = 0;
                    int GC = 0;
                    dgvTienLuong.DataSource = dt;
                    for (int i = 2; i < 33; i++)
                    {
                        if (dt.Rows[0][i].ToString() != "" && dt.Rows[0][i].ToString() != "CN")
                        {
                            
                            if (dt.Rows[0][i].ToString() == "K")
                            {
                                KP++;
                            }
                            else if (dt.Rows[0][i].ToString() == "P")
                            {
                                CP++;
                            }
                            else
                            {
                                string gc = dt.Rows[0][i].ToString();
                                GC += int.Parse(gc);
                                DL++;//số ngày đi làm
                            }
                        }
                        
                        
                    }
                    lblSoNgayDiLam.Text = DL.ToString();
                    lblSoNgayKP.Text = KP.ToString();
                    lblSoNgayP.Text = CP.ToString();
                    lblSoGioCong.Text = GC.ToString();
                    //float CongTG = GC/8;
                    //float CD = CongTG * HSBC * HSCV;
                    //float TL = CD * 3750000;
                    float luongSida = (LuongToiThieu / 27) * DL;
                    lblLuong.Text = string.Format("{0:#,##0} VNĐ", luongSida);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        
    }
}
