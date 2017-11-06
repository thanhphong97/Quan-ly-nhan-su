using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucTienLuong : UserControl
    {
        public ucTienLuong()
        {
            InitializeComponent();
        }

        private void ucTienLuong_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cboThang.SelectedIndex = 0;
            nudNam.Minimum = 1888;
            nudNam.Maximum = 9999;
            nudNam.Value = DateTime.Now.Year;
        }

        private void btnTaoBangChamCong_Click(object sender, EventArgs e)
        {
            frmPhongBan frm_PhongBan = new frmPhongBan();
            frm_PhongBan.ShowDialog();
        }

        
    }
}
