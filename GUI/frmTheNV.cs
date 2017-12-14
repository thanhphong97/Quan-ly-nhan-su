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
namespace GUI
{
    public partial class frmTheNV : Form
    {
        private string manv;

        public frmTheNV()
        {
            InitializeComponent();
        }

        public frmTheNV(string manv)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.manv = manv;
        }

        private void frmTheNV_Load(object sender, EventArgs e)
        {
            clsTheNV_BUS bus = new clsTheNV_BUS();
            DataTable thenv = bus.LayTheNV(manv);
            foreach (DataRow r in thenv.Rows)
            {
                r["HINHDAIDIEN"] = "File:\\" + Application.StartupPath + "/" + r["HINHDAIDIEN"];
            }
            this.rptTheNV.LocalReport.EnableExternalImages = true;
            this.rptTheNV.LocalReport.ReportEmbeddedResource = "GUI.rptTheNV.rdlc";
            this.rptTheNV.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTheNVV", thenv));
            this.rptTheNV.RefreshReport();
        }
    }
}
