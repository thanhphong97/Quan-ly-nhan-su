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
        private ucChamCong ucTL;
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
        public frmPhongBan(ucChamCong ucTL)
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

            clsChamCong_BUS BUSCC = new clsChamCong_BUS();
            clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
            clsChiTietChamCong_BUS BUSCTCC = new clsChiTietChamCong_BUS();

            clsChamCong_DTO ChamCong = new clsChamCong_DTO();

            List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();

            DataGridViewRow r = dgvPhongBan.CurrentRow;

            ChamCong.MaCC = "CC" + (BUSCC.LaySoLuong() + 1).ToString();
            ChamCong.Thang = ucTL.Thang;
            ChamCong.Nam = ucTL.Nam;
            ChamCong.Phong = r.Cells[0].Value.ToString();
            //Thêm dữ liệu vào CHAMCONG
            if (BUSCC.KiemTraPhongChamCong(ChamCong.Thang, ChamCong.Nam, ChamCong.Phong) == false)
            {
                BUSCC.ThemBangChamCong(ChamCong);
                DataGridView dgvChamCong = ucTL.Controls.Find("dgvChamCong", true).FirstOrDefault() as DataGridView;
                dgvChamCong.DataSource = BUSCC.LayBangChamCong();


                // Lấy phòng ban vừa được chọn để chấm công                  
                clsPhongBan_DTO PB = new clsPhongBan_DTO();
                PB.MAPB = ChamCong.Phong;
                List<clsPhongBan_DTO> lsPB = new List<clsPhongBan_DTO>();
                lsPB.Add(PB);

                //Lấy danh sách nhân viên theo phòng ban
                lsNhanVien = BUSNV.LayDanhSachNhanVienCC(lsPB);
                for (int i = 0; i < lsNhanVien.Count; i++)
                {
                    clsChiTietChamCong_DTO ChiTietCC = new clsChiTietChamCong_DTO();
                    ChiTietCC.MaCC = ChamCong.MaCC;
                    ChiTietCC.MaNV = lsNhanVien[i].MaNV;
                    BUSCTCC.ThemChiTietChamCong(ChiTietCC);
                    this.Close();
                }
            }
            else
                MessageBox.Show(string.Format("Đã chấm công cho phòng {0} tháng {1} năm {2}", r.Cells[1].Value.ToString(), ChamCong.Thang, ChamCong.Nam));
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
