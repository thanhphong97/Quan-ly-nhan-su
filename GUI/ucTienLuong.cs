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
        private string _MaCC;

        public string MaCC
        {
            get { return _MaCC; }
            set { _MaCC = value; }
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

        private void btnInChamCong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvChamCong.CurrentRow;
            MaCC = r.Cells[0].Value.ToString();
            Thang = Convert.ToInt32(r.Cells[1].Value.ToString());
            Nam = Convert.ToInt32(r.Cells[2].Value.ToString());
            frmInChamCong frm_InChamCong = new frmInChamCong(this);
            frm_InChamCong.ShowDialog();
            clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("In bảng chấm công {0}", MaCC));
        }
    }
}
