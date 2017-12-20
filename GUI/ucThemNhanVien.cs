using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
        private List<clsMoiQuanHe_DTO> lsMQH;
        private string anhDaiDien;
        private void ucThemNhanVien_Load(object sender, EventArgs e)
        {
            picHinh.Image = Image.FromFile(@"HinhAnh\nv.jpg");
            LoadCbo();
            LoadDGV_NhanVien();
            this.radNam.Checked = true;
            cboChucVu.SelectedValue = 0;
            clsMoiQuanHe_BUS BUSMQH = new clsMoiQuanHe_BUS();
            lsMQH = BUSMQH.LayDanhSachMoiQuanHe();
            cboMoiQH.DataSource = lsMQH;
            cboMoiQH.DisplayMember = "TENMQH";
            cboMoiQH.ValueMember = "MAMQH";
            dtpNgaySinhTN.Format = DateTimePickerFormat.Custom;
            dtpNgaySinhTN.CustomFormat = "dd/MM/yyyy";
            if (Program.NhanVien_Login.Quyen == "L3")
            {
                //tpNhanVien
                grbThôngTinNV.Enabled = false;
                btnThemNV.Enabled = false;
                btnClear.Enabled = false;
                btnCapNhat.Enabled = false;
                //tpThanNhan
                grbThanNhan.Enabled = false;
                btnThemTN.Enabled = false;
                btnCapNhatTN.Enabled = false;
                btnLamLaiTN.Enabled = false;
                //frm Hợp đồng
            }
        }

        private void LoadCbo()
        {
            //Tỉnh 
            clsTinhQuanHuyen_BUS BUSQH = new clsTinhQuanHuyen_BUS();
            cboTinh.DataSource = BUSQH.LayDanhSachTinhThanh();
            cboTinh.DisplayMember = "TENTINH";
            cboTinh.ValueMember = "MATINH";
            cboTinh.SelectedIndex = 0;
            //Quận Huyện
            clsTinhQuanHuyen_BUS BUSTT = new clsTinhQuanHuyen_BUS();
            cboQuanHuyen.DataSource = BUSTT.LayDanhSachQuanHuyen(cboTinh.SelectedValue.ToString());
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
            cboTonGiao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTonGiao.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Mối quan hệ
            clsMoiQuanHe_BUS BUSMQH = new clsMoiQuanHe_BUS();
            //Phòng Ban
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            cboPhongBan.DataSource = BUSPB.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
            //tìm kiếm
            List<clsPhongBan_DTO> lsPhongBan_TK = BUSPB.LayDanhSachPhongBan();
            clsPhongBan_DTO pb = new clsPhongBan_DTO();
            pb.TENPB = "Tất cả";
            pb.MAPB = "0";
            lsPhongBan_TK.Insert(0, pb);
            cboPhongBan_TK.DataSource = lsPhongBan_TK;
            cboPhongBan_TK.DisplayMember = "TENPB";
            cboPhongBan_TK.ValueMember = "MAPB";
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
            cboBacLuong.DisplayMember = "TENBAC";
            //dân tộc
            clsDanToc_BUS BUSDT = new clsDanToc_BUS();
            cboDanToc.DataSource = BUSDT.LayDSDanToc();
            cboDanToc.ValueMember = "MaDT";
            cboDanToc.DisplayMember = "TenDT";
            cboDanToc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDanToc.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LayHeSoLuong(string MaCV, string MaBAC)
        {
            clsBacLuong_BUS bus = new clsBacLuong_BUS();
            txtHeSo.Text = bus.LayHeSoLuong(MaCV, MaBAC).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            XoaMangHinh();
            btnThemNV.Enabled = true;
            btnCapNhat.Enabled = false;
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
            anhDaiDien = @"HinhAnh\nv.jpg";
            picHinh.Image = Image.FromFile(anhDaiDien);
            rtbNguyenQuan.Text = "";
            cboBacLuong.SelectedValue = "";
            cboQuocTich.SelectedValue = "";
            cboTinh.SelectedIndex = 0;
            rtbSoNhaTenDuong.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now.Date;
            cboChucVu.SelectedValue = "";
            txtHeSo.Text = "";
            cboPhongBan.SelectedValue = "";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
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
                if(anhDaiDien != "")
                {
                    nv.HINHDAIDIEN = anhDaiDien;
                }
                else
                {
                    nv.HINHDAIDIEN = @"HinhAnh\nv.jpg";
                }
                if (!chkBoViec.Checked)
                    nv.TrangThai = true;
                else
                    nv.TrangThai = false;
                clsNhanVien_BUS bus = new clsNhanVien_BUS();
                bool kq = bus.ThemNhanVien(nv);
                if (kq)
                {
                    //thêm thành công
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    int SoLuongNV = bus.LaySoLuongNhanVien();
                    //load Lại DGV
                    TimKiemNhanVien();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Thêm nhân viên {0} {1} có mã NV{2}", nv.Ho, nv.Ten, SoLuongNV));
                }
                else
                {
                    MessageBox.Show("Thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Vui lòng điền đủ các trường. \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                nv.MaNV = dgvNhanVien.SelectedRows[0].Cells["colMANV"].Value.ToString();
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
                nv.HINHDAIDIEN = anhDaiDien;
                nv.NgayBatDauLamViec = dtpNgayVaoLam.Value;
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaBAC = cboBacLuong.SelectedValue.ToString();
                nv.PhongBan = cboPhongBan.SelectedValue.ToString();
                if (!chkBoViec.Checked)
                {
                    nv.TrangThai = true;
                }
                else
                {
                    nv.TrangThai = false;//nghi viec
                    clsNguoiDung_BUS BUSND = new clsNguoiDung_BUS();
                    BUSND.CapNhatTaiKhoan(nv.TrangThai, nv.MaNV);//Chặn tài khoản của người này đăng nhập
                }
                clsNhanVien_BUS bus = new clsNhanVien_BUS();
                bool kq = bus.CapNhatThongTinNhanVien(nv);
                if (kq)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Cập nhật nhân viên {0} {1} có mã {2}", nv.Ho, nv.Ten, nv.MaNV));
                    TimKiemNhanVien();
                }
                else
                {
                    MessageBox.Show("Thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))//chỉ nhập số
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

        private void DocThongTinTuDGV()
        {
            btnCapNhat.Enabled = true;
            btnThemNV.Enabled = false;
            XoaMangHinh();
            try
            {

                txtHo.Text = dgvNhanVien.SelectedRows[0].Cells["colHo"].Value.ToString();
                txtTen.Text = dgvNhanVien.SelectedRows[0].Cells["colTen"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvNhanVien.SelectedRows[0].Cells["colNgaySinh"].Value;
                txtCMND.Text = dgvNhanVien.SelectedRows[0].Cells["colCMND"].Value.ToString();
                bool gioitinh = (bool)dgvNhanVien.SelectedRows[0].Cells["colGioiTinh"].Value;
                if (gioitinh == true)
                    radNam.Checked = true;
                if (gioitinh == false)
                    radNu.Checked = true;
                cboTrinhDo.SelectedValue = int.Parse(dgvNhanVien.SelectedRows[0].Cells["colBangCap"].Value.ToString());
                cboTonGiao.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colTonGiao"].Value.ToString();
                cboDanToc.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colDanToc"].Value.ToString();
                rtbNguyenQuan.Text = dgvNhanVien.SelectedRows[0].Cells["colNguyenQuan"].Value.ToString();
                cboQuocTich.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colQuocTich"].Value.ToString();
                cboTinh.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colTinhThanh"].Value.ToString();
                cboQuanHuyen.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colQuanHuyen"].Value.ToString();
                rtbSoNhaTenDuong.Text = dgvNhanVien.SelectedRows[0].Cells["colDiaChi"].Value.ToString();
                dtpNgayVaoLam.Value = (DateTime)dgvNhanVien.SelectedRows[0].Cells["colNgayBatDau"].Value;
                cboChucVu.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colMaCV"].Value.ToString();
                cboBacLuong.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colMaBac"].Value.ToString();
                LayHeSoLuong(cboChucVu.SelectedValue.ToString(), cboBacLuong.SelectedValue.ToString());
                cboPhongBan.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colPhong"].Value.ToString();
                bool TrangThai = (bool)dgvNhanVien.SelectedRows[0].Cells["colTrangThai"].Value;
                if (!TrangThai)
                    chkBoViec.Checked = true;
                else
                    chkBoViec.Checked = false;
                if (dgvNhanVien.SelectedRows[0].Cells["colHinhAnh"].Value != null)
                {
                    anhDaiDien = dgvNhanVien.SelectedRows[0].Cells["colHinhAnh"].Value.ToString();
                    picHinh.Image = Image.FromFile(anhDaiDien);
                    
                }
                else
                {
                    picHinh.Image = Image.FromFile(@"HinhAnh\nv.jpg");
                }
            }
            catch 
            {
            }
            if (tabNhanVien.CanSelect)
            {
                txtHoTenNV.Text = txtHoTenNV.Text = dgvNhanVien.CurrentRow.Cells["colHo"].Value.ToString() + " " + dgvNhanVien.CurrentRow.Cells["colTen"].Value.ToString();
                if (tabNhanVien.CanFocus)
                {
                    clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
                    dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString());
                }
            }
        }

        private void LoadDGV_NhanVien()
        {
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsDanhSachNV = bus.LayDSNhanVien(0, "","0");
            dgvNhanVien.DataSource = lsDanhSachNV;
        }
        static int DieuKien = 0;
        private void TimKiemNhanVien()
        {
            
            string TenHoacMaNV = txtMaNV_TK.Text;
            if (radTatCa.Checked)
                DieuKien = 0;//Tất cả nhân viên
            if (radConLamViec.Checked)
                DieuKien = 1;//Còn đang làm việc
            if (radDaNghiViec.Checked)
                DieuKien = -1;//Đã thôi việc
            string MaPB = cboPhongBan_TK.SelectedValue.ToString();
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsDanhSachNV = bus.LayDSNhanVien(DieuKien, TenHoacMaNV,MaPB);
            dgvNhanVien.DataSource = lsDanhSachNV;

        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void radConLamViec_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void radDaNghiViec_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if (!(bool)e.Value)//false
                    e.Value = "Đã nghỉ";
                else if ((bool)e.Value)//true
                    e.Value = "";
            }
           
                foreach (DataGridViewRow r in dgvNhanVien.Rows)
                {
                    r.Cells["colHoTenNV"].Value = r.Cells["colHo"].Value.ToString()+ " " + r.Cells["colTen"].Value.ToString();
                }
            }
            catch { }

        }

        private void btnHopDongNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvNhanVien.CurrentRow;
            clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();

            // Lấy thông tin của nhân viên ở dgvNhanVieN
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
            NhanVien.TrangThai = Convert.ToBoolean(r.Cells["colTrangThai"].Value);

            frmHopDong frmHD = new frmHopDong(NhanVien);
            frmHD.Show();
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            bool KiemTra = false; // Chưa đủ dữ liệu
            clsThanNhan_DTO ThanNhan = new clsThanNhan_DTO();
            ThanNhan.MaNV = dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString();
            if (txtHoTenTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KiemTra = false;
            }
            else
            {
                ThanNhan.HoTenTN = txtHoTenTN.Text.Trim();
                KiemTra = true;
            }
            if (txtNgheNghiepTN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập nghề nghiệp thân nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KiemTra = false;
            }
            else
            {
                KiemTra = true;
                ThanNhan.NgheNghiepTN = txtNgheNghiepTN.Text.Trim();
            }
            ThanNhan.NgaySinhTN = dtpNgaySinhTN.Value;
            ThanNhan.MoiQH = Convert.ToInt32(cboMoiQH.SelectedValue);
            clsThanNhan_BUS BUSTN = new clsThanNhan_BUS();
            if (KiemTra)// Đã đủ dữ liệu
            {
                if (BUSTN.ThemThanNhan(ThanNhan))
                {
                    MessageBox.Show("Thêm thân nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvThanNhan.DataSource = BUSTN.LayDanhSachThanNhan(ThanNhan.MaNV);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
                    int SoLuongNV = BUSNV.LaySoLuongNhanVien();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Thêm thân nhân {0} cho nhân viên {1} có mã NV{2}", ThanNhan.HoTenTN, txtHoTenNV.Text, SoLuongNV));
                }
                else
                {
                    MessageBox.Show("Thêm thân nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCapNhatTN_Click(object sender, EventArgs e)
        {
            bool KiemTra = false; // Dữ liệu chưa nhập đủ
            clsThanNhan_DTO ThanNhan = new clsThanNhan_DTO();
            ThanNhan.MaQHGD = Convert.ToInt32(dgvThanNhan.CurrentRow.Cells["colMaQHGD"].Value.ToString());
            ThanNhan.MaNV = dgvNhanVien.CurrentRow.Cells["colMANV"].Value.ToString();
            if (txtHoTenTN.Text.Trim() == "" || txtNgheNghiepTN.Text.Trim() == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ThanNhan.HoTenTN = txtHoTenTN.Text.Trim();
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
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Cập nhật thân nhân {0} cho nhân viên {1} có mã {2}", ThanNhan.HoTenTN, txtHoTenNV.Text, ThanNhan.MaNV));
                }
                else
                {
                    MessageBox.Show("cập nhật thân nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamLaiTN_Click(object sender, EventArgs e)
        {
            txtHoTenTN.Clear();
            txtNgheNghiepTN.Clear();
            cboMoiQH.SelectedIndex = 0; // Mối quan hệ Vợ - Chồng
            dtpNgaySinhTN.Value = DateTime.Now;
            btnThemTN.Enabled = true;
        }

        private void dgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtHoTenTN.Text = dgvThanNhan.CurrentRow.Cells["colHoTen"].Value.ToString();
                txtNgheNghiepTN.Text = dgvThanNhan.CurrentRow.Cells["colNgheNghiep"].Value.ToString();
                cboMoiQH.SelectedValue = dgvThanNhan.CurrentRow.Cells["colMoiQH"].Value;
                dtpNgaySinhTN.Value = Convert.ToDateTime(dgvThanNhan.CurrentRow.Cells["colNgaySinhThanNhan"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNV_EnabledChanged(object sender, EventArgs e)
        {
            if (btnThemNV.Enabled)
                chkBoViec.Enabled = false;
            else
                chkBoViec.Enabled = true;
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsTinhQuanHuyen_BUS BUSTT = new clsTinhQuanHuyen_BUS();
                cboQuanHuyen.DataSource = BUSTT.LayDanhSachQuanHuyen(cboTinh.SelectedValue.ToString());
                cboQuanHuyen.DisplayMember = "TENQH";
                cboQuanHuyen.ValueMember = "MAQH";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvThanNhan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtHoTenTN.Text = dgvThanNhan.CurrentRow.Cells["colHoTen"].Value.ToString();
                txtNgheNghiepTN.Text = dgvThanNhan.CurrentRow.Cells["colNgheNghiep"].Value.ToString();
                cboMoiQH.SelectedValue = dgvThanNhan.CurrentRow.Cells["colMoiQH"].Value;
                dtpNgaySinhTN.Value = Convert.ToDateTime(dgvThanNhan.CurrentRow.Cells["colNgaySinhThanNhan"].Value);
            }
            catch { }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load cbo Phòng ban theo chức vụ
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            cboPhongBan.DataSource = BUSPB.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
        }
        private void dgvThanNhan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvThanNhan.Columns[e.ColumnIndex].Name == "colMoiQH")
                {
                    foreach (clsMoiQuanHe_DTO mqh in lsMQH)
                    {
                        if (mqh.MAMQH == int.Parse(dgvThanNhan.Rows[e.RowIndex].Cells["colMoiQH"].Value.ToString()))
                        {
                            e.Value = mqh.TENMQH;
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void cboQuocTich_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //nếu quốc tịch là nước ngoài => dân tộc = khác
            string QuocTich = cboQuocTich.SelectedValue.ToString();
            if (QuocTich != "QT1")
                cboDanToc.SelectedValue = "DT0";
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DocThongTinTuDGV();
        }
        private void picHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Chọn ảnh đại diện nhân viên";
            fd.Filter = "Image Only (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {

                if (fd.CheckFileExists)
                {
                    picHinh.Image = Image.FromFile(fd.FileName);
                    picHinh.SizeMode = PictureBoxSizeMode.Zoom;
                    File.Copy(fd.FileName, @"HinhAnh\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName));
                    anhDaiDien = @"HinhAnh\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName);
                }
            }
        }
        
        private void btnInTheNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if(row == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string manv = row.Cells["colMANV"].Value.ToString();
                frmTheNV frm = new frmTheNV(manv);
                frm.Show();
            }
        }
        private void cboPhongBan_TK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }
        private void btnInDSNV_Click(object sender, EventArgs e)
        {
            string Phong = cboPhongBan_TK.SelectedValue.ToString();
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            List<clsPhongBan_DTO> lsPB = BUSPB.LayDanhSachPhongBan();
            foreach(clsPhongBan_DTO pb in lsPB)
            {
                if(Phong == "0")
                {
                    Phong = "Tất cả "; break;
                }
                else if(Phong == pb.MAPB)
                {
                    Phong = pb.TENPB; break;
                }
            }
            string strDieuKien = "";
            if (radTatCa.Checked)
                strDieuKien = "Còn làm việc và đã nghỉ";
            else if (radConLamViec.Checked)
                strDieuKien = "Còn làm việc";
            else // Đã nghỉ
                strDieuKien = "Đã nghỉ";
            clsNhanVien_BUS busDSNV = new clsNhanVien_BUS();
            string TenHoacMaNV = txtMaNV_TK.Text;
            if (radTatCa.Checked)
                DieuKien = 0;//Tất cả nhân viên
            if (radConLamViec.Checked)
                DieuKien = 1;//Còn đang làm việc
            if (radDaNghiViec.Checked)
                DieuKien = -1;//Đã thôi việc
            string MaPB = cboPhongBan_TK.SelectedValue.ToString();
            DataTable dsNhanVienTheoDieuKien = busDSNV.LayDanhSachNhanVienInreport(DieuKien, TenHoacMaNV, MaPB);
            frmInDanhSachNV frmInDS = new frmInDanhSachNV(dsNhanVienTheoDieuKien,strDieuKien, Phong);
            frmInDS.Show();

        }
        // Hàm Convert từ dgv sang datable đê dùng cho chức năng in danh sách nhân viên
        private DataTable ToDataTable(DataGridView dataGridView)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                    dt.Columns.Add();
            }
            var cell = new object[dataGridView.Columns.Count];
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    cell[i] = dataGridViewRow.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DocThongTinTuDGV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        //////////////////////////
    }
}
