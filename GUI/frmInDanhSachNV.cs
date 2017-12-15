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
        private DataTable dt;
        private string DieuKien;
        private string Phong;
        public frmInDanhSachNV()
        {
            InitializeComponent();
        }
        public frmInDanhSachNV(DataTable dt, string DieuKien, string Phong)
        {
            InitializeComponent();
            this.dt = dt;
            this.DieuKien = DieuKien;
            this.Phong = Phong;
        }
        private void frmInDanhSachNV_Load(object sender, EventArgs e)
        {
            // Cần phải đổi tên cột trong Datatable giống với CSDL để hiển thị dữ liệu trong rptDanhSachNV
            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    if (dc.ColumnName == "Column2")
                        dc.ColumnName = "MANV";
                    if (dc.ColumnName == "Column3")
                        dc.ColumnName = "HO";
                    if (dc.ColumnName == "Column4")
                        dc.ColumnName = "TEN";
                    if (dc.ColumnName == "Column5")
                        dc.ColumnName = "NGAYSINH";
                    if (dc.ColumnName == "Column9")
                        dc.ColumnName = "GIOITINH";
                    if (dc.ColumnName == "Column19")
                        dc.ColumnName = "TRANGTHAI";
                    if (dc.ColumnName == "Column19")
                        dc.ColumnName = "PHONG";

                }
            }
            this.rptDanhSachNV.LocalReport.ReportEmbeddedResource = "GUI.rptDSNV.rdlc";
            this.rptDanhSachNV.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsNV", dt));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraNguoilap", Program.NhanVien_Login.Ho + " " + Program.NhanVien_Login.Ten, false));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraPhong", Phong, false));
            this.rptDanhSachNV.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paraTrangThai", DieuKien, false));
            this.rptDanhSachNV.RefreshReport();
        }
    }
}
