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
using System.Collections;
namespace GUI
{
    public partial class frmBangChamCong : Form
    {

        // Thiết lập Tên cột và chỉ số cho dgvBangChamCong
        private List<clsPhongBan_DTO> lsPhongBan;
        private frmPhongBan frm_PhongBan;
        private ucTienLuong ucTL;
        private clsPhongBan_BUS BUSPB;
        private List<clsPhongBan_DTO> lsPhongBan2;
        private bool _btnLuu = false;
        public bool BtnLuu
        {
            get { return _btnLuu; }
            set { _btnLuu = value; }
        }

        private bool _btnDong = false;

        public bool BtnDong
        {
            get { return _btnDong; }
            set { _btnDong = value; }
        }
        public frmBangChamCong()
        {
            InitializeComponent();
        }

        public frmBangChamCong(Control sender, List<clsPhongBan_DTO> lsPhongBan, ucTienLuong ucTL)
        {
            InitializeComponent();
            clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
            clsKyHieuChamCong_BUS BUKH = new clsKyHieuChamCong_BUS();
            BUSPB = new clsPhongBan_BUS();
            lsPhongBan2 = BUSPB.LayDanhSachPhongBan(); // Lấy tất cả các phòng ban để hiển thị tên phòng bang ở sự kiện dgvBangChamCong_CellFormatting

            this.lsPhongBan = lsPhongBan;
            frm_PhongBan = sender as frmPhongBan;
            this.ucTL = ucTL;

            int DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang); // Trả về tháng đó có bao nhiêu ngày
            for (var i = 1; i <= DayInMonth; i++)
            {
                var col = "col" + i;
                dgvBangChamCong.Columns[col].Visible = true;
                DataGridViewComboBoxColumn dgvcbo = (DataGridViewComboBoxColumn)dgvBangChamCong.Columns[col];
               
                DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, i);
                if (dt.DayOfWeek != 0) // Không phải là ngày chủ nhật
                {
                    List<clsKyHieuChamCong_DTO> lsKH = BUSKH.LayDanhSachKyHieu();
                    for(int j = 0 ; j < lsKH.Count; j++)
                    {
                        string a = lsKH[j].KyHieu;
                        if (lsKH[j].KyHieu == "CN")
                            lsKH.RemoveAt(j); // Xóa bỏ ký hiệu chấm công là CN 
                    }
                    dgvcbo.DataSource = lsKH;   
                    dgvcbo.DisplayMember = "KYHIEU";
                    dgvcbo.ValueMember = "KYHIEU";
                }
                else // Thứ 2 đến thứ 7 
                {
                    dgvcbo.DataSource = BUSKH.LayDanhSachKyHieu();
                    dgvcbo.DisplayMember = "KYHIEU";
                    dgvcbo.ValueMember = "KYHIEU";
                }
            }

        }

        private void frmBangChamCong_Load(object sender, EventArgs e)
        {

            dgvBangChamCong.AutoGenerateColumns = false;
            clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
            dgvBangChamCong.DataSource = BUSNV.LayDanhSachNhanVien(lsPhongBan);
            lblBangChamCong.Text = string.Format("Bảng chấm công tháng {0} năm {1}", ucTL.Thang, ucTL.Nam);
            ChamCongTuDong();

        }

  

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<clsChamCong_DTO> lsChamCong = new List<clsChamCong_DTO>();
            
            for (int i = 0; i < dgvBangChamCong.Rows.Count; i++ ) // Chấm công cho từ ngày 1 -> 27. Chủ nhật mặc định là CN
            {
                clsChamCong_DTO ChamCong = new clsChamCong_DTO();
                ChamCong.MaNV =  dgvBangChamCong.Rows[i].Cells["colMaNV"].Value.ToString();
                ChamCong.Thang = ucTL.Thang;
                ChamCong.Nam = ucTL.Nam;
                ChamCong.D1 = dgvBangChamCong.Rows[i].Cells["col1"].Value.ToString() ;
                ChamCong.D2 = dgvBangChamCong.Rows[i].Cells["col2"].Value.ToString();
                ChamCong.D3 = dgvBangChamCong.Rows[i].Cells["col3"].Value.ToString();
                ChamCong.D4 = dgvBangChamCong.Rows[i].Cells["col4"].Value.ToString();
                ChamCong.D5 = dgvBangChamCong.Rows[i].Cells["col5"].Value.ToString();
                ChamCong.D6 = dgvBangChamCong.Rows[i].Cells["col6"].Value.ToString();
                ChamCong.D7 = dgvBangChamCong.Rows[i].Cells["col7"].Value.ToString();
                ChamCong.D8 = dgvBangChamCong.Rows[i].Cells["col8"].Value.ToString();
                ChamCong.D9 = dgvBangChamCong.Rows[i].Cells["col9"].Value.ToString();
                ChamCong.D10 = dgvBangChamCong.Rows[i].Cells["col10"].Value.ToString();
                ChamCong.D11 = dgvBangChamCong.Rows[i].Cells["col11"].Value.ToString();
                ChamCong.D12 = dgvBangChamCong.Rows[i].Cells["col12"].Value.ToString();
                ChamCong.D13 = dgvBangChamCong.Rows[i].Cells["col13"].Value.ToString();
                ChamCong.D14 = dgvBangChamCong.Rows[i].Cells["col14"].Value.ToString();
                ChamCong.D15 = dgvBangChamCong.Rows[i].Cells["col15"].Value.ToString();
                ChamCong.D16 = dgvBangChamCong.Rows[i].Cells["col16"].Value.ToString();
                ChamCong.D17 = dgvBangChamCong.Rows[i].Cells["col17"].Value.ToString();
                ChamCong.D18 = dgvBangChamCong.Rows[i].Cells["col18"].Value.ToString();
                ChamCong.D19 = dgvBangChamCong.Rows[i].Cells["col19"].Value.ToString();
                ChamCong.D20 = dgvBangChamCong.Rows[i].Cells["col20"].Value.ToString();
                ChamCong.D21 = dgvBangChamCong.Rows[i].Cells["col21"].Value.ToString();
                ChamCong.D22 = dgvBangChamCong.Rows[i].Cells["col22"].Value.ToString();
                ChamCong.D23 = dgvBangChamCong.Rows[i].Cells["col23"].Value.ToString();
                ChamCong.D24 = dgvBangChamCong.Rows[i].Cells["col24"].Value.ToString();
                ChamCong.D25 = dgvBangChamCong.Rows[i].Cells["col25"].Value.ToString();
                ChamCong.D26 = dgvBangChamCong.Rows[i].Cells["col26"].Value.ToString();
                ChamCong.D27 = dgvBangChamCong.Rows[i].Cells["col27"].Value.ToString();
                if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 28)
                {
                    ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                }
                else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 29)
                {
                    ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                    ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                }
                else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 30)
                {
                    ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                    ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                    ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
                }
                else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 31)
                {
                    ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                    ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                    ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
                    ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col31"].Value.ToString();
                }
                ChamCong.Thang = ucTL.Thang;
                ChamCong.Nam= ucTL.Nam;
                lsChamCong.Add(ChamCong);
                
                
            }
            clsChamCong_BUS BUS = new clsChamCong_BUS();
            if (BUS.ThemBangChamCong(DateTime.DaysInMonth(ucTL.Nam,ucTL.Thang) , lsChamCong))
            {
                MessageBox.Show("Đã lưu dữ liệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                int SoLuongCC = BUS.LaySoLuong();
                BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Tạo bảng chấm công có mã CC{0} tháng {1} năm {2}",SoLuongCC,ucTL.Thang,ucTL.Nam));
                _btnLuu = true;
                this.Hide();
                frm_PhongBan.Close();
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị hủy. Bản có muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (dgvBangChamCong.Columns[e.ColumnIndex].Name == "colMaPB")
            {
                foreach (clsPhongBan_DTO pb in lsPhongBan2)
                {
                    if (dgvBangChamCong.Rows[e.RowIndex].Cells[3].Value.ToString() == pb.MAPB)
                    {
                        e.Value = pb.TENPB; // Hiển thị Tên phòng ban ở colMaPB
                        break;
                    }
                }
            }
            for(int i = 1; i <= 31; i++)

            {
                string col = "col"+i;
                if (dgvBangChamCong.Columns[e.ColumnIndex].Name == col)
                    if (e.Value.ToString() == "CN")
                    {
                        dgvBangChamCong.Columns[e.ColumnIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }

            }
            dgvBangChamCong.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ChamCongTuDong() // Tự động chấm tất cả ngày công trong tháng. Không chấm chủ nhật (cách chấm dành cho phòng Nhân Sự).
        {
            for (int indexcolumn = 0; indexcolumn < dgvBangChamCong.Columns.Count; indexcolumn++)
            {
                if (dgvBangChamCong.Columns[indexcolumn].Name != "colMaNV" && dgvBangChamCong.Columns[indexcolumn].Name != "ColHo" && dgvBangChamCong.Columns[indexcolumn].Name != "colTen" && dgvBangChamCong.Columns[indexcolumn].Name != "colMaPB")
                {
                    int Ngay = Convert.ToInt32((dgvBangChamCong.Columns[indexcolumn].Name).Replace("col", "")); // Lấy ra ngày trong tháng
                    DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
                    for (int indexrow = 0; indexrow < dgvBangChamCong.Rows.Count; indexrow++)
                    {
                        if (dt.DayOfWeek == 0) // Nếu là ngày chủ nhật
                            (dgvBangChamCong.Rows[indexrow].Cells[indexcolumn] as DataGridViewComboBoxCell).Value = "CN";
                        else
                        {
                            (dgvBangChamCong.Rows[indexrow].Cells[indexcolumn] as DataGridViewComboBoxCell).Value = "8";     
                        }
                    }
                }
            }
        }

       

    }
}
