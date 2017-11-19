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
            //TimKiemNhanVien();
            loadThongTinCuaNhanVien();
            this.radNam.Checked = true;
            cboChucVu.SelectedValue = 0;

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
                nv.HopDongTV = null;
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
                }
                else
                {
                    MessageBox.Show("Thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //
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

                nv.NgayBatDauLamViec = dtpNgayVaoLam.Value;
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.MaBAC = cboBacLuong.SelectedValue.ToString();
                nv.PhongBan = cboPhongBan.SelectedValue.ToString();
                nv.HopDongTV = null;
                if (!chkBoViec.Checked)
                    nv.TrangThai = true;
                else
                    nv.TrangThai = false;
                clsNhanVien_BUS bus = new clsNhanVien_BUS();
                bool kq = bus.CapNhatThongTinNhanVien(nv);
                if (kq)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TimKiemNhanVien();
                }
                else
                {
                    MessageBox.Show("Thất bại, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XoaMangHinh();
            try
            {

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
                cboBacLuong.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colMaBac"].Value.ToString();
                LayHeSoLuong(cboChucVu.SelectedValue.ToString(), cboBacLuong.SelectedValue.ToString());
                cboPhongBan.SelectedValue = dgvNhanVien.SelectedRows[0].Cells["colPhong"].Value.ToString();
                bool TrangThai = (bool)dgvNhanVien.SelectedRows[0].Cells["colTrangThai"].Value;
                if (!TrangThai)
                    chkBoViec.Checked = true;
                else
                    chkBoViec.Checked = false;
            }
            catch
            {

            }
        }

        private void loadThongTinCuaNhanVien()
        {
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsDanhSachNV = bus.LayDSNhanVien(0,"");
            dgvNhanVien.DataSource = lsDanhSachNV;
        }

        private void txtMaNV_TK_TextChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void TimKiemNhanVien()
        {
            int DieuKien = 0;
            string MaNV = txtMaNV_TK.Text;
            if(radTatCa.Checked)
                DieuKien = 0;//Tất cả nhân viên
            if(radConLamViec.Checked)
                DieuKien = 1;//Còn đang làm việc
            if (radDaNghiViec.Checked)
                DieuKien = -1;//Đã thôi việc
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsDanhSachNV = bus.LayDSNhanVien(DieuKien,MaNV);
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
            if(dgvNhanVien.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if (!(bool)e.Value)//false
                    e.Value = "Đã nghỉ";
                else if ((bool)e.Value)//true
                    e.Value = "Còn làm việc";
            }
        }


    }
}
