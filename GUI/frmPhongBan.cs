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
            List<clsPhongBan_DTO> lsPB = new List<clsPhongBan_DTO>();
            foreach(DataGridViewRow row in dgvPhongBan.Rows)
            {
                if((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    clsPhongBan_DTO PB = new clsPhongBan_DTO();
                    PB.MAPB =  row.Cells[1].Value.ToString();
                    lsPB.Add(PB);
                    chkcol++;
                }
            }
            if (chkcol > 0) // Có phòng ban được chọn
            {

                chkcol = 0;
                //frmBangChamCong frm_BangChamCong = new frmBangChamCong(this,lsPhongBan,ucTL);
                //frm_BangChamCong.ShowDialog();

                clsChamCong_BUS BUSCC = new clsChamCong_BUS();
                clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
                clsChiTietChamCong_BUS BUSCTCC = new clsChiTietChamCong_BUS();

                clsChamCong_DTO ChamCong = new clsChamCong_DTO();
                      
                List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();

                ChamCong.MaCC = "CC" + (BUSCC.LaySoLuong() + 1).ToString();
                ChamCong.Thang = ucTL.Thang;
                ChamCong.Nam = ucTL.Nam;
                //Thêm dữ liệu vào CHAMCONG
                BUSCC.ThemBangChamCong(ChamCong);
                //Lấy danh sách nhân viên theo phòng ban
                lsNhanVien = BUSNV.LayDanhSachNhanVienCC(lsPB);
                for(int i = 0; i < lsNhanVien.Count; i++)
                {
                    clsChiTietChamCong_DTO ChiTietCC = new clsChiTietChamCong_DTO();
                    ChiTietCC.MaCC = ChamCong.MaCC;
                    ChiTietCC.MaNV = lsNhanVien[i].MaNV;
                    BUSCTCC.ThemChiTietChamCong(ChiTietCC);
                }
                
                DataGridView dgvChamCong = ucTL.Controls.Find("dgvChamCong", true).FirstOrDefault() as DataGridView;
                dgvChamCong.DataSource = BUSCC.LayBangChamCong();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ////var dgvChamCong = ucTL.Controls.Find("dgvChamCong", true) as Datagridview;
            ////dgvChamCong.DataBindings();
            //var dgv = ucTL.Controls.Find("dgvChamCong", true);
            //DataGridView dgvChamCong = dgv[0] as DataGridView;
            //clsChamCong_BUS BUSCC = new clsChamCong_BUS();
            //dgvChamCong.DataSource = BUSCC.LayBangChamCong();
            
        }
    }
}
