using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Microsoft.Reporting.WinForms;
namespace GUI
{
    public partial class frmBaoCaoBangLuong : Form
    {
        private int Nam;
        private int Thang;
        private string MaPB;

        public frmBaoCaoBangLuong()
        {
            InitializeComponent();
        }

        public frmBaoCaoBangLuong(int Nam, int Thang, string MaPB)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Nam = Nam;
            this.Thang = Thang;
            this.MaPB = MaPB;
        }

        private void frmBaoCaoBangLuong_Load(object sender, EventArgs e)
        {
            string nguoiLap = Program.NhanVien_Login.Ho + " " + Program.NhanVien_Login.Ten;
            clsTinhLuong_BUS bus = new clsTinhLuong_BUS();
            DataTable dt = bus.LayBangLuongBaoCao(Nam, Thang, MaPB);
            this.rptBangLuong.LocalReport.ReportEmbeddedResource = "GUI.rptBangLuong.rdlc";
            this.rptBangLuong.LocalReport.DataSources.Add(new ReportDataSource("dsBangLuongg", dt));
            this.rptBangLuong.LocalReport.SetParameters(new ReportParameter("paraThang", Thang.ToString(), false));
            this.rptBangLuong.LocalReport.SetParameters(new ReportParameter("paraNam", Nam.ToString(), false));
            this.rptBangLuong.LocalReport.SetParameters(new ReportParameter("paraNguoiLap", nguoiLap, false));
            this.rptBangLuong.RefreshReport();
        }
    }
}
