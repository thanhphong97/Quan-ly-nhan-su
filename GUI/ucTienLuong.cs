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
        private int _Thang;

        public int Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }
        private int _Nam;

        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }
       
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
            _Thang = Convert.ToInt32(cboThang.SelectedIndex) + 1;
            _Nam = Convert.ToInt32(nudNam.Value);
            frmPhongBan frm_PhongBan = new frmPhongBan(this);
            frm_PhongBan.ShowDialog();
            
        }

        private void dgvChamCong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int day = DateTime.DaysInMonth(2017, 2);
            MessageBox.Show(day.ToString());
        }

    }
}
