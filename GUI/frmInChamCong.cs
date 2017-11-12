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
        private ucTienLuong ucTL;
        public frmInChamCong()
        {
            InitializeComponent();
        }
        public frmInChamCong(Control sender)
        {
            InitializeComponent();
            ucTL = sender as ucTienLuong;
        }

        private void frmInChamCong_Load(object sender, EventArgs e)
        {
            clsChamCong_BUS BUSCC = new clsChamCong_BUS();
            DataTable dt = BUSCC.LayBangChamCongNV(ucTL.MaCC);
            rptChamCong.ZoomPercent = 100;
            rptChamCong.LocalReport.ReportEmbeddedResource = "GUI.rptInChamCong.rdlc";
            rptChamCong.LocalReport.DataSources.Add(new ReportDataSource("dsChamCongNV", dt));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraThang", ucTL.Thang.ToString(), false));
            rptChamCong.LocalReport.SetParameters(new ReportParameter("paraNam", ucTL.Nam.ToString(), false));
            this.rptChamCong.RefreshReport();
        }
    }
}
