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
using System.Data.SqlClient;
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
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            cboPhongBan.DataSource = BUSPB.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
        }

        private void loadDSTIenLuong()
        {

            clsTinhLuong_BUS bus = new clsTinhLuong_BUS();
            dgvTienLuong.DataSource = bus.lsBangLuong(Convert.ToInt32(txtNam.Text), Convert.ToInt32(cboThang.SelectedIndex + 1), cboPhongBan.SelectedValue.ToString());
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadDSTIenLuong();
        }
    }
}
