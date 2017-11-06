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
    public partial class frmPhongBan : Form
    {
        
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmChamCongPhongBan_Load(object sender, EventArgs e)
        {
            dgvPhongBan.AutoGenerateColumns = false;
            clsPhongBan_BUS BUS = new clsPhongBan_BUS();
            dgvPhongBan.DataSource = BUS.LayDanhSachPhongBan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            frmBangChamCong frm_BangChamCong = new frmBangChamCong();
            frm_BangChamCong.ShowDialog();
        }
    }
}
