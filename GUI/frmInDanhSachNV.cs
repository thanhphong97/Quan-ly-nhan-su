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
namespace GUI
{
    public partial class frmInDanhSachNV : Form
    {
        private string Phong;
        private DataTable dsNhanVienTheoDieuKien;
        private string strDieuKien;
        public frmInDanhSachNV()
        {
            InitializeComponent();
        }
        public frmInDanhSachNV(DataTable dsNhanVienTheoDieuKien, string strDieuKien, string Phong)
        {
            InitializeComponent();
            this.dsNhanVienTheoDieuKien = dsNhanVienTheoDieuKien;
            this.strDieuKien = strDieuKien;
            this.Phong = Phong;
        }
        private void frmInDanhSachNV_Load(object sender, EventArgs e)
        {
          
            this.rptDanhSachNV.LocalReport.ReportEmbeddedResource = "GUI.rptDSNV.rdlc";
            this.rptDanhSachNV.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsNV", dsNhanVienTheoDieuKien));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraNguoilap", Program.NhanVien_Login.Ho + " " + Program.NhanVien_Login.Ten, false));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraPhong", Phong, false));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraTrangThai", strDieuKien, false));
            this.rptDanhSachNV.RefreshReport();
        }
    }
}
