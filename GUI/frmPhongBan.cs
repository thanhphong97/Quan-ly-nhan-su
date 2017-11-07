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
using DTO;
namespace GUI
{
    
    public partial class frmPhongBan : Form
    {
        private ucTienLuong ucTL;
        private string _MaPB;

        public string MaPB
        {
            get { return _MaPB; }
            set { _MaPB = value; }
        }
        public frmPhongBan()
        {
            InitializeComponent();
        }
        public frmPhongBan(ucTienLuong ucTL)
        {
            InitializeComponent();
            this.ucTL = ucTL;
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
            int chkcol = 0; // trong dgvPhongBan không có cột nào được chọn
            List<clsPhongBan_DTO> lsPhongBan = new List<clsPhongBan_DTO>();
            for(int i = 0 ; i < dgvPhongBan.RowCount ; i++)
            {
                if(Convert.ToBoolean(dgvPhongBan.Rows[i].Cells[0].Value) == true)
                {
                    clsPhongBan_DTO PhongBan = new clsPhongBan_DTO();
                    PhongBan.MAPB = dgvPhongBan.Rows[i].Cells[1].Value.ToString();
                    lsPhongBan.Add(PhongBan);
                    chkcol++;
                }
            }
            if(chkcol > 0) // Có phòng ban được chọn
            {
                
                chkcol = 0;
                frmBangChamCong frm_BangChamCong = new frmBangChamCong(this,lsPhongBan,ucTL);
                frm_BangChamCong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
