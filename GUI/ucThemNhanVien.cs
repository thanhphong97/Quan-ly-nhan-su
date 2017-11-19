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
    public partial class ucThemNhanVien : UserControl
    {
        public ucThemNhanVien()
        {
            InitializeComponent();
        }

        private void ucThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadCbo();
            clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = BUSNV.LayDSNhanVien();
            this.radNam.Checked = true;
            cboChucVu.SelectedValue = 0;
            clsMoiQuanHe_BUS BUSMQH = new clsMoiQuanHe_BUS();
            cboMoiQH.DataSource = BUSMQH.LayDanhSachMoiQuanHe();
            cboMoiQH.DisplayMember = "TENMQH";
            cboMoiQH.ValueMember = "MAMQH";

            
        }
      
        private void LoadCbo()
        {
            //Tỉnh 
            clsTinhQuanHuyen_BUS BUSQH = new clsTinhQuanHuyen_BUS();
            cboTinh.DataSource = BUSQH.LayDanhSachTinhThanh();
            cboTinh.DisplayMember = "TENTINH";
            cboTinh.ValueMember = "MATINH";
            //Quận Huyện
            clsTinhQuanHuyen_BUS BUSTT = new clsTinhQuanHuyen_BUS();
            cboQuanHuyen.DataSource = BUSTT.LayDanhSachQuanHuyen();
            cboQuanHuyen.DisplayMember = "TENQH";
            cboQuanHuyen.ValueMember = "MAQH";
            //quốc tịch
            clsQuocTich_BUS BUSQT = new clsQuocTich_BUS();
            cboQuocTich.DataSource = BUSQT.LayDSQuocTich();
            cboQuocTich.DisplayMember = "TENQT";
            cboQuocTich.ValueMember = "MAQT";
            //tôn giáo
            
            clsTonGiao_BUS BUSTG = new clsTonGiao_BUS();
            cboTonGiao.DataSource = BUSTG.LayDanhSachTonGiao();
            cboTonGiao.DisplayMember = "TENTG";
            cboTonGiao.ValueMember = "MATG";
            //Mối quan hệ
            clsMoiQuanHe_BUS BUSMQH = new clsMoiQuanHe_BUS();  
            //Phòng Ban
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            cboPhongBan.DataSource = BUSPB.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
            //chức vụ
            clsChucVu_BUS BUSCV = new clsChucVu_BUS();
            cboChucVu.DataSource = BUSCV.LayDanhSachChucVu();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "MACV";
            //Học Vấn
            clsBangCap_BUS BUSBC = new clsBangCap_BUS();
            cboTrinhDo.DataSource = BUSBC.LayDanhSachBangCap();
            cboTrinhDo.DisplayMember = "TENBC";
            cboTrinhDo.ValueMember = "MABC";
            //bacluong
            clsBacLuong_BUS BUSBACLUONG = new clsBacLuong_BUS();
            cboBacLuong.DataSource = BUSBACLUONG.LayDSBacLuong();
           
            cboBacLuong.ValueMember = "BAC";
            //dân tộc
            clsDanToc_BUS BUSDT = new clsDanToc_BUS();
            cboDanToc.DataSource = BUSDT.LayDSDanToc();
            cboDanToc.ValueMember = "MaDT";
            cboDanToc.DisplayMember = "TenDT";
        }
       
      private void LayHeSoLuong(string MaCV, string MaBAC)
        {
          clsBacLuong_BUS bus = new clsBacLuong_BUS();
          txtHeSo.Text = bus.LayHeSoLuong(MaCV, MaBAC).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            XoaMangHinh();
        }

        private void XoaMangHinh()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now.Date;
            txtCMND.Text = "";
            string gioitinh = "";
            if (gioitinh == "true")
                radNam.Checked = true;
            if (gioitinh == "false")
                radNu.Checked = true;
            cboTrinhDo.SelectedValue = "";
            cboTonGiao.SelectedValue = "";
            cboDanToc.SelectedValue = "";

            rtbNguyenQuan.Text = "";
            cboBacLuong.SelectedValue = "";
            cboQuocTich.SelectedValue = "";
            cboTinh.SelectedValue = "";
            cboQuanHuyen.SelectedValue = "";
            rtbSoNhaTenDuong.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now.Date;
            cboChucVu.SelectedValue = "";
            txtHeSo.Text = "";

            cboPhongBan.SelectedValue = "";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                nv.Ho = txtHo.Text;
                nv.Ten = txtTen.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.CMND = txtCMND.Text;
                //false nữ, true nam
                if (radNam.Checked)
                    nv.GioiTinh = true;
                else
                    nv.GioiTinh = false;
                nv.BangCap = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.TonGiao = cboTonGiao.SelectedValue.ToString();
                nv.NguyenQuan = rtbNguyenQuan.Text;
                nv.DanToc = cboDanToc.SelectedValue.ToString();
                
                nv.QuocTich = cboQuocTich.SelectedValue.ToString();
                nv.TinhThanh = cboTinh.SelectedValue.ToString();
                nv.QuanHuyen = cboQuanHuyen.SelectedValue.ToString();
                nv.DiaChiThuongTru = rtbSoNhaTenDuong.Text;

                nv.NgayBatDauLamViec = dtpNgayVaoLam.Value;
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaBAC = cboBacLuong.SelectedValue.ToString();
                nv.PhongBan = cboPhongBan.SelectedValue.ToString();
                if (!chkBoViec.Checked)
                    nv.TrangThai = true;
                else
                    nv.TrangThai = false;
                clsNhanVien_BUS bus = new clsNhanVien_BUS();
                bool kq = bus.ThemNhanVien(nv);
                MessageBox.Show(kq.ToString());
            }
            

        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void cboBacLuong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                LayHeSoLuong(cboChucVu.SelectedValue.ToString(), cboBacLuong.SelectedValue.ToString());
            }
            catch
            { }
           
        }

        private void cboChucVu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                LayHeSoLuong(cboChucVu.SelectedValue.ToString(), cboBacLuong.SelectedValue.ToString());
            }
            catch
            { }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                XoaMangHinh();
                txtHo.Text = dgvNhanVien.SelectedRows[0].Cells["colHo"].Value.ToString();
                txtTen.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvNhanVien.SelectedRows[0].Cells[3].Value;
                txtCMND.Text = dgvNhanVien.SelectedRows[0].Cells["colCMND"].Value.ToString();
                string gioitinh = dgvNhanVien.SelectedRows[0].Cells["colGioiTinh"].Value.ToString();
                if (gioitinh == "true")
                    radNam.Checked = true;
                if (gioitinh == "false")
                    radNu.Checked = true;
                cboTrinhDo.SelectedValue = int.Parse(dgvNhanVien.SelectedRows[0].Cells["colBangCap"].Value.ToString());
                cboTonGiao.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colTonGiao"].Value.ToString();
                cboDanToc.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colDanToc"].Value.ToString();

                rtbNguyenQuan.Text = dgvNhanVien.SelectedRows[0].Cells["colNguyenQuan"].Value.ToString();

                cboQuocTich.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colQuocTich"].Value.ToString();
                cboTinh.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colTinhThanh"].Value.ToString();
                cboQuanHuyen.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colQuanHuyen"].Value.ToString();
                rtbSoNhaTenDuong.Text = dgvNhanVien.SelectedRows[0].Cells["colDiaChi"].Value.ToString();
                dtpNgayVaoLam.Value = (DateTime)dgvNhanVien.SelectedRows[0].Cells[13].Value;

                cboChucVu.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colMaCV"].Value.ToString();
                
                //cboBacLuong.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colMaBac"].Value.ToString();
                cboBacLuong.SelectedValue = dgvNhanVien.CurrentRow.Cells["colMaBac"].Value;
                LayHeSoLuong(cboChucVu.SelectedValue.ToString(), cboBacLuong.SelectedValue.ToString());
                cboPhongBan.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colPhong"].Value.ToString();
            }
            catch
            {

            }
            if(tabNhanVien.CanSelect)
            {
                txtHoTenNV.Text = txtHoTenNV.Text = dgvNhanVien.CurrentRow.Cells["colHo"].Value.ToString() + " " + dgvNhanVien.CurrentRow.Cells["colTen"].Value.ToString();
                if(tabNhanVien.CanFocus)
                {
                    clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
                    dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString());
                }
            }
            
        }

        private void loadThongTinCuaNhanVien()
        {
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsDanhSachNV = bus.LayDSNhanVien();
            dgvNhanVien.DataSource = lsDanhSachNV;
        }

        private void btnHopDongNV_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow r = dgvNhanVien.CurrentRow;
            clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();

            // Lấy thông tin của nhân viên ở dgvNhanVie
            NhanVien.MaNV = r.Cells["colMANV"].Value.ToString();
            NhanVien.Ho = r.Cells["colHo"].Value.ToString();
            NhanVien.Ten = r.Cells["colTen"].Value.ToString();
            NhanVien.NgaySinh = Convert.ToDateTime(r.Cells["colNgaySinh"].Value);
            NhanVien.DiaChiThuongTru = r.Cells["colDiaChi"].Value.ToString();
            NhanVien.CMND = r.Cells["colCMND"].Value.ToString();
            NhanVien.GioiTinh = Convert.ToBoolean(r.Cells["colGioiTinh"].Value);
            NhanVien.NguyenQuan = r.Cells["colNguyenQuan"].Value.ToString();
            NhanVien.TinhThanh = r.Cells["colTinhThanh"].Value.ToString();
            NhanVien.QuanHuyen = r.Cells["colQuanHuyen"].Value.ToString();
            NhanVien.QuocTich = r.Cells["colQuocTich"].Value.ToString();
            NhanVien.TonGiao = r.Cells["colTonGiao"].Value.ToString();
            NhanVien.DanToc = r.Cells["colDanToc"].Value.ToString();
            NhanVien.MaCV = r.Cells["colMaCV"].Value.ToString();
            NhanVien.NgayBatDauLamViec = Convert.ToDateTime(r.Cells["colNgayBatDau"].Value);
            NhanVien.PhongBan = r.Cells["colPhong"].Value.ToString();
            NhanVien.MaBAC = r.Cells["colMaBac"].Value.ToString();
            NhanVien.TrangThai = Convert.ToBoolean(r.Cells["colHopDong"].Value);

            frmHopDong frmHD = new frmHopDong(NhanVien);
            frmHD.Show();
        }

        
        private void btnThemTN_Click(object sender, EventArgs e)
        {
            clsThanNhan_DTO ThanNhan = new clsThanNhan_DTO();
            ThanNhan.MaNV = dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString();
            if (txtHoTenTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                ThanNhan.HoTenTN = txtHoTenTN.Text.Trim();
            if (txtNgheNghiepTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ThanNhan.NgheNghiepTN = txtNgheNghiepTN.Text.Trim();
            ThanNhan.NgaySinhTN = dtpNgaySinhTN.Value;
            ThanNhan.MoiQH = Convert.ToInt32(cboMoiQH.SelectedValue);
            clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
            if (BUSTN.ThemThanNhan(ThanNhan))
            {
                MessageBox.Show("Thêm thân nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(ThanNhan.MaNV);
                clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Thêm thân nhân {0} cho nhân viên {1}", ThanNhan.HoTenTN, txtHoTenNV.Text));
            }
            else
            {
                MessageBox.Show("Thêm thân nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
            dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString());
        }

        private void btnLamLaiTN_Click(object sender, EventArgs e)
        {
            txtHoTenTN.Clear();
            txtNgheNghiepTN.Clear();
            cboMoiQH.SelectedIndex = 0;
            
        }

        private void dgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTenTN.Text = dgvThanNhan.CurrentRow.Cells["colHoTen"].Value.ToString();
            txtNgheNghiepTN.Text = dgvThanNhan.CurrentRow.Cells["colNgheNghiep"].Value.ToString();
            cboMoiQH.SelectedValue = dgvThanNhan.CurrentRow.Cells["colMoiQH"].Value;
            dtpNgaySinhTN.Value = Convert.ToDateTime(dgvThanNhan.CurrentRow.Cells["colNgaySinhThanNhan"].Value);
        }

        private void btnCapNhatTN_Click(object sender, EventArgs e)
        {
            bool KiemTra = false; // Dữ liệu chưa nhập đủ
            clsThanNhan_DTO ThanNhan = new clsThanNhan_DTO();
            ThanNhan.MaQHGD = Convert.ToInt32(dgvThanNhan.CurrentRow.Cells["colMaQHGD"].Value.ToString());
            ThanNhan.MaNV = dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString();
            if (txtHoTenTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ThanNhan.HoTenTN = txtHoTenTN.Text.Trim();
                KiemTra = true;
            }
            if (txtNgheNghiepTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                ThanNhan.NgheNghiepTN = txtNgheNghiepTN.Text.Trim();
                KiemTra = true;
            }

            ThanNhan.NgaySinhTN = dtpNgaySinhTN.Value;
            ThanNhan.MoiQH = Convert.ToInt32(cboMoiQH.SelectedValue);
            clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
            if (KiemTra) // Đã đủ dữ liệu
            {
                if (BUSTN.CapNhatThanNhan(ThanNhan))
                {
                    MessageBox.Show("Cập nhật thân nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(ThanNhan.MaNV);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Cập nhật thân nhân {0} cho nhân viên {1}", ThanNhan.HoTenTN, txtHoTenNV.Text));
                }
                else
                {
                    MessageBox.Show("cập nhật thân nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
