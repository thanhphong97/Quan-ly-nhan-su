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
    public partial class ucChamCong : UserControl
    {
        private List<clsPhongBan_DTO> lsPB;
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
        public ucChamCong()
        {
            InitializeComponent();
        }

       

        private void btnTaoBangChamCong_Click(object sender, EventArgs e)
        {

            _Thang = dtpThangNam.Value.Month;
            _Nam = dtpThangNam.Value.Year;
            if (_Nam > DateTime.Now.Year || DateTime.Now.Year <= _Nam && _Thang > DateTime.Now.Month)
                MessageBox.Show("Tháng chấm công không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                frmPhongBan frm_PhongBan = new frmPhongBan(this);
                frm_PhongBan.ShowDialog();
               // clsChiTietChamCong_BUS BUS = new clsChiTietChamCong_BUS();
            }
           
            
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

        private void dgvChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvChamCong.Columns[e.ColumnIndex].Name == "colTenBangChamCong")
            {
                dgvChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Bảng chấm công tháng " + dgvChamCong.Rows[e.RowIndex].Cells[1].Value.ToString()+ " năm " + dgvChamCong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            if(dgvChamCong.Columns[e.ColumnIndex].Name == "colPhong")
            {
                clsPhongBan_DTO PB = lsPB.First(u => u.MAPB == e.Value.ToString());
                e.Value = PB.TENPB;
            }
            
        }

        private void dgvChamCong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvChamCong.CurrentRow;
            _Thang = Convert.ToInt32(r.Cells[1].Value.ToString());
            _Nam = Convert.ToInt32(r.Cells[2].Value.ToString());
            _MaCC = r.Cells[0].Value.ToString();
            frmBangChamCong frm_BangChamcong = new frmBangChamCong(this);
            frm_BangChamcong.Show();
        }

        private void ucChamCong_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dgvChamCong.AutoGenerateColumns = false;
            clsChamCong_BUS BUSCC = new clsChamCong_BUS();
            dgvChamCong.DataSource = BUSCC.LayBangChamCong();

            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            lsPB = BUSPB.LayDanhSachPhongBan();
        }
    }
}
