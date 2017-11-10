using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
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
            dgvChamCong.AutoGenerateColumns = false;
            cboThang.SelectedIndex = 0;
            nudNam.Minimum = 1;
            nudNam.Maximum = 9999;
            nudNam.Value = DateTime.Now.Year;

            clsChamCong_BUS BUS = new clsChamCong_BUS();
            dgvChamCong.DataSource = BUS.LayTenBangChamCong();
           
            
        }

        private void btnTaoBangChamCong_Click(object sender, EventArgs e)
        {
            _Thang = Convert.ToInt32(cboThang.SelectedIndex) + 1;
            _Nam = Convert.ToInt32(nudNam.Value);
            frmPhongBan frm_PhongBan = new frmPhongBan(this);
            frm_PhongBan.ShowDialog();
            clsChamCong_BUS BUS = new clsChamCong_BUS();
            dgvChamCong.DataSource = BUS.LayTenBangChamCong();
            
        }

        private void dgvChamCong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvChamCong.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

    }
}
