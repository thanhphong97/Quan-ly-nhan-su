using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;
using System.Reflection;
namespace GUI
{
    public partial class frmInChamCong : Form
    {
        private ucChamCong ucTL;
        public frmInChamCong()
        {
            InitializeComponent();
        }
        public frmInChamCong(Control sender)
        {
            InitializeComponent();
            ucTL = sender as ucChamCong;
        }

        private void frmInChamCong_Load(object sender, EventArgs e)
        {
            string nguoiLapBaoCao = Program.NhanVien_Login.Ho + " " + Program.NhanVien_Login.Ten;
            clsChiTietChamCong_BUS BUSCTCC = new clsChiTietChamCong_BUS();
            DataTable dt = BUSCTCC.LayBangChiTietChamCongNV(ucTL.MaCC);
            int TongNgayNghi = 0;
            int NghiCoPhep = 0;
            int NghiKhongPhep = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Rows[i][j].ToString() == "K")
                        NghiKhongPhep++;
                    if (dt.Rows[i][j].ToString() == "P")
                        NghiCoPhep++;
                }
            }
            TongNgayNghi = NghiCoPhep + NghiKhongPhep;
            rptChamCong.ZoomPercent = 100;
            rptChamCong.LocalReport.ReportEmbeddedResource = "GUI.rptInChamCong.rdlc";
            rptChamCong.LocalReport.DataSources.Add(new ReportDataSource("dsChamCongNV", dt));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraThang", ucTL.Thang.ToString(), false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraNam", ucTL.Nam.ToString(), false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraNguoiLapBaoCao", nguoiLapBaoCao, false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraTongNgayNghi", TongNgayNghi.ToString(), false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraCoPhep", NghiCoPhep.ToString(), false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraKhongPhep", NghiKhongPhep.ToString(), false));
            this.rptChamCong.RefreshReport();
        }
    }
}
