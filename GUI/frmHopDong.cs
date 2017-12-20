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
    public partial class frmHopDong : Form
    {
        private clsNhanVien_DTO NhanVien = null;
        private List<clsHopDong_DTO> lsHopDong;
        public frmHopDong()
        {
            InitializeComponent();
        }
        public frmHopDong(clsNhanVien_DTO NhanVien)
        {
            InitializeComponent();
            this.NhanVien = NhanVien;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {

            cboLoaiHD.SelectedIndex = 0;// Là hợp đồng xác định thời hạn

            clsHopDong_BUS BUSHD = new clsHopDong_BUS();
            lsHopDong = BUSHD.LayDanhSachHopDong(NhanVien.MaNV);
            //lsHopDong.Sort()
            dgvHopDongNV.DataSource = lsHopDong;
            if (Program.NhanVien_Login.Quyen == "L3")
            {
                grbThongTin.Enabled = false;
                btnThemHopDong.Enabled = false;
                btnCapNhatHopDong.Enabled = false;
                btnLamLai.Enabled = false;

            }

            txtHo.Text = NhanVien.Ho;
            txtTen.Text = NhanVien.Ten;
            if (dgvHopDongNV.SelectedRows.Count == 0)
                btnCapNhatHopDong.Enabled = false;
            else
                btnCapNhatHopDong.Enabled = true;
            btnThemHopDong.Enabled = false;

            if(cboLoaiHD.SelectedIndex == 1)
            {
                dtpNgayKetThuc.Enabled = false;
            }
            if (dgvHopDongNV.Rows.Count == 0)
                btnThemHopDong.Enabled = true;
        }


        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            bool KiemTra = false;
            clsHopDong_DTO HopDong = new clsHopDong_DTO();
            HopDong.MaNV = NhanVien.MaNV;
            HopDong.NgayBatDau = dtpNgayBatDau.Value;
            if (cboLoaiHD.SelectedIndex == 0)
            {

                HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (HopDong.NgayBatDau.Date.AddMonths(12) != HopDong.NgayKetThuc.Date && HopDong.NgayBatDau.Date.AddMonths(36) != HopDong.NgayKetThuc.Date) // Thời điểm kết chấm dứt hợp đồng xác định thời hạn chưa đủ 12 tháng hoặc chưa đủ 36 tháng
                {
                    MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng xác định thời hạn trong khoảng thời gian từ đủ 12 tháng đến 36 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Đủ điều kiện của hợp đồng xác định thời hạn
                {
                    HopDong.LoaiHD = "Xác định thời hạn";
                    KiemTra = true;
                }
            }
            if (cboLoaiHD.SelectedIndex == 1)
            {
                HopDong.LoaiHD = "Không xác định thời hạn";
                KiemTra = true;
            }
            if (cboLoaiHD.SelectedIndex == 2)  // Là hợp đồng thời vụ
            {
                HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (HopDong.NgayBatDau.Date.AddDays(HopDong.NgayKetThuc.Date.Subtract(HopDong.NgayBatDau.Date).TotalDays) >= HopDong.NgayBatDau.Date.AddMonths(12)) // Hợp đồng thời vụ lớn hoặc bằng 12 
                {
                    MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng thời vụ phải dưới 12 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HopDong.LoaiHD = "Thời vụ";
                    KiemTra = true;
                }
            }

            HopDong.DiaDiemLam = txtDiaDiem.Text;
            //HopDong.ChucVu = cboChucVu.SelectedValue.ToString(); // Chọn sẵn khi chọn Mã nhân viên của datagridview ngoài tabcontrol           
            HopDong.CongViec = txtCongViec.Text;
            HopDong.ThoiGianLam = 8; // Thời gian làm bao nhiêu giờ 1 ngày
            HopDong.TrangBi = txtTrangBiLD.Text;
            HopDong.NgayKy = dtpNgayKy.Value; // Lấy ngày kí hợp đồng là ngày hệ thống
            
            if (KiemTra && KiemTraDuLieu())
            {
                clsHopDong_BUS BUSHD = new clsHopDong_BUS();
                if (BUSHD.ThemHopDong(HopDong))
                {
                    MessageBox.Show("Thêm hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHopDongNV.DataSource = BUSHD.LayDanhSachHopDong(NhanVien.MaNV);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Thêm hợp đồng {0} {1} cho nhân viên {2} {3} ", HopDong.LoaiHD, HopDong.MaHDLD, NhanVien.Ho, NhanVien.Ten));
                    btnThemHopDong.Enabled = false;

                }
                else
                    MessageBox.Show("Thêm hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHD.SelectedIndex == 1) // Là hợp đồng Không xác định thời hạn
            {
                dtpNgayKetThuc.Enabled = false;
                
            }
            else
            {
                dtpNgayKetThuc.Enabled = true;
                dtpNgayKetThuc.Value = DateTime.Now;
            }
        }

        private void btnCapNhatHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                bool KiemTra = false; // Nhập sai ngày bắt đầu hợp đồng và ngày kết thúc hợp đồng
                clsHopDong_DTO HopDong = new clsHopDong_DTO();
                HopDong.MaHDLD = dgvHopDongNV.CurrentRow.Cells["colMaHDLD"].Value.ToString(); // Lấy Mã hợp đồng được chọn ở dgvHopDongNV
                HopDong.MaNV = NhanVien.MaNV; // Lấy mã nhân viên được chọn ở  DgvNhanVien
                HopDong.NgayBatDau = dtpNgayBatDau.Value;
                if (cboLoaiHD.SelectedIndex == 0)
                {

                    HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                    if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (HopDong.NgayBatDau.Date.AddMonths(12) != HopDong.NgayKetThuc.Date && HopDong.NgayBatDau.Date.AddMonths(36) != HopDong.NgayKetThuc.Date) // Thời điểm kết chấm dứt hợp đồng xác định thời hạn chưa đủ 12 tháng hoặc chưa đủ 36 tháng
                    {
                        MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng xác định thời hạn trong khoảng thời gian từ đủ 12 tháng đến 36 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else //Đủ điều kiện của hợp đồng xác định thời hạn
                    {
                        HopDong.LoaiHD = "Xác định thời hạn";
                        KiemTra = true;
                    }
                    
                }
                if (cboLoaiHD.SelectedIndex == 1)
                {
                    HopDong.LoaiHD = "Không xác định thời hạn";
                    KiemTra = true;
                }
                if (cboLoaiHD.SelectedIndex == 2)  // Là hợp đồng thời vụ
                {
                    HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                    if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (HopDong.NgayBatDau.Date.AddDays(HopDong.NgayKetThuc.Date.Subtract(HopDong.NgayBatDau.Date).TotalDays) >= HopDong.NgayBatDau.Date.AddMonths(12)) // Hợp đồng thời vụ lớn hoặc bằng 12 
                    {
                        MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng thời vụ phải dưới 12 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HopDong.LoaiHD = "Thời vụ";
                        KiemTra = true;
                    }
                    
                }

                HopDong.DiaDiemLam = txtDiaDiem.Text;           
                HopDong.CongViec = txtCongViec.Text;
                HopDong.ThoiGianLam = Convert.ToDouble(nudThoiGian.Value); // Thời gian làm bao nhiêu giờ 1 ngày
                HopDong.TrangBi = txtTrangBiLD.Text;   
                HopDong.NgayKy = dtpNgayKy.Value; // Lấy ngày kí hợp đồng là ngày hệ thống
                
                if(cboLoaiHD.SelectedIndex == 1)
                {
                    DateTime dt = new DateTime(1900, 1, 1);
                    HopDong.NgayKetThuc = dt;
                }
                if (KiemTra && KiemTraDuLieu())
                {
                    clsHopDong_BUS BUSHD = new clsHopDong_BUS();
                    if (BUSHD.CapNhatHopDong(HopDong))
                    {
                        MessageBox.Show(string.Format("Cập nhật hợp mã hợp đồng {0} thành công", HopDong.MaHDLD), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvHopDongNV.DataSource = BUSHD.LayDanhSachHopDong(NhanVien.MaNV); // Lấy mã nhân viên ở dgvNhanVien
                        clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                        BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Cập nhật hợp đồng {0} của nhân viên {1} {2}", HopDong.MaHDLD, NhanVien.Ho, NhanVien.Ten));
                       
                    }
                    else
                        MessageBox.Show("Thêm hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvHopDongNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadThongTinHopDong();
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHopDongNV_SelectionChanged(object sender, EventArgs e)
        {
            LoadThongTinHopDong();
        }
        private void LoadThongTinHopDong()
        {
            try
            {
                DataGridViewRow r = dgvHopDongNV.CurrentRow;
                cboLoaiHD.SelectedItem = r.Cells["colLoaiHD"].Value;
                dtpNgayBatDau.Value = Convert.ToDateTime(r.Cells["colNgayBatDau"].Value);
                txtDiaDiem.Text = r.Cells["colDiaDiem"].Value.ToString();
                txtCongViec.Text = r.Cells["colCongViec"].Value.ToString();
                nudThoiGian.Value = Convert.ToDecimal(r.Cells["colThoiGian"].Value);
                txtTrangBiLD.Text = r.Cells["colTrangBi"].Value.ToString();
                dtpNgayKy.Value = Convert.ToDateTime(r.Cells["colNgayKy"].Value);
                btnThemHopDong.Enabled = false;
                btnCapNhatHopDong.Enabled = true;
                string loaihd = r.Cells["colLoaiHD"].Value.ToString();
                if (loaihd.Equals("Không xác định thời hạn"))
                {
                    dtpNgayKetThuc.Enabled = false;
                }
                else
                    dtpNgayKetThuc.Enabled = true;
                dtpNgayKetThuc.Value = Convert.ToDateTime(r.Cells["colNgayKetThuc"].Value); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            btnThemHopDong.Enabled = true;
            btnCapNhatHopDong.Enabled = false;
        }

        private void XoaDuLieu()
        {
            cboLoaiHD.SelectedIndex = 0;
            txtDiaDiem.Text = "";
            txtCongViec.Text = "";
            nudThoiGian.Value = 0;
            txtTrangBiLD.Text = "";
        }
        DateTime kxd = new DateTime();
        private void dgvHopDongNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvHopDongNV.Columns[e.ColumnIndex].Name == "colNgayKetThuc")
                    if ((DateTime)dgvHopDongNV.Rows[e.RowIndex].Cells["colNgayKetThuc"].Value == kxd || (DateTime)dgvHopDongNV.Rows[e.RowIndex].Cells["colNgayKetThuc"].Value == Convert.ToDateTime("1900-01-01 00:00:00.000"))
                    {
                        e.Value = "Không xác định";
                    }
            }
            catch { }
           
        }

        private void txtHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }


        private bool KiemTraDuLieu()
        {
            if (txtDiaDiem.Text == "")
            {
                MessageBox.Show("Địa điểm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtCongViec.Text == "")
            {
                MessageBox.Show("Công việc không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtTrangBiLD.Text == "")
            {
                MessageBox.Show("Trang bị lao động không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

    }
}
