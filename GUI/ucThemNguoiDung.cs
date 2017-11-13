using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class ucThemNguoiDung : UserControl
    {

        
        public ucThemNguoiDung()
        {
            InitializeComponent();
        }

        private void ucThemNguoiDung_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            clearThongBao();
            loadDuLieu();
            
        }
        private void loadDuLieu()
        {
            clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
            List<clsNguoiDung_DTO> lsNguoiDung = bus.DSNguoiDung();
            dgvNhanVien.DataSource = lsNguoiDung;
        }
        #region Kiểm tr các thứ
        private bool KiemTraDayDu()
        {
           if(txtMaNV.Text == "" || txtTenDN.Text == "" || txtMatKhau.Text == "")
           {
               return false;
           }
            return true;
        }
        private bool KiemTraTrungKhopMatKhau()
        {
            string strMatKhau = txtMatKhau.Text;
            string strXacNhanMatKhau = txtXacNhanMK.Text;
            return (strMatKhau == strXacNhanMatKhau);
        }
        private bool KiemTraMaNV()
        {
            string MaNV = txtMaNV.Text;
            clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
            bool kq = bus.KiemTraTonTai(MaNV,1);
            if (kq)//MaNV này chưa được cấp tài khoản
            {
                btnThem.Enabled = true;
                lblThongBao_MaNV.Visible = false;
            }
            else//MaNV này đã được cấp tài khoản
            {
                btnThem.Enabled = false;
                lblThongBao_MaNV.Visible = true;
            }
            return kq;
        }
        private bool KiemTraTenDN()
        {
            string TenDN = txtTenDN.Text;
            clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
            bool kq = bus.KiemTraTonTai(TenDN, 2);
            if (kq)//MaNV này chưa được cấp tài khoản
            {
                btnThem.Enabled = true;
                lblThongBao_TK.Visible = false;
            }
            else//MaNV này đã được cấp tài khoản
            {
                btnThem.Enabled = false;
                lblThongBao_TK.Visible = true;
            }
            return kq;
        }
        #endregion
        string LayQuyenTruyCap()
        {
            string Quyen = "L3";
            if (radAdministrator.Checked)
                Quyen = "L1";
            else if (radNhanVienKeToan.Checked)
                Quyen = "L2";
            return Quyen;
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraTenDN())
            {
            if(KiemTraMaNV())
            {
                if (KiemTraDayDu())
                {
                    if (KiemTraTrungKhopMatKhau())
                    {
                        clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                        nd.MANV = txtMaNV.Text.ToUpper();
                        nd.TAIKHOAN = txtTenDN.Text;
                        nd.MATKHAU = txtMatKhau.Text;
                        if (!chkTrangThai.Checked)
                            nd.TRANGTHAI = true;
                        else
                            nd.TRANGTHAI = false;
                        nd.LOAIND = LayQuyenTruyCap();
                        clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
                        bool kq = bus.TaoTaiKhoan(nd);
                        if (kq)
                        {
                            MessageBox.Show("Tao nguời dùng " + nd.TAIKHOAN + " Thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDuLieu();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các trường");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã được cấp tài khoản", "Thông báo");
            }
        }
            else
            {
                MessageBox.Show("Tên đăng nhập này đã được sử dụng", "Thông báo");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDuLieuNguoiDung();
            clearThongBao();
        }

        private void clearThongBao()
        {
            lblThongBao_MaNV.Visible = false;
            lblThongBao_TK.Visible = false;
        }

        private void LoadDuLieuNguoiDung()
        {
            try
            {
                string Quyen = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
                if (Quyen == "Administrator")
                {
                    radAdministrator.Checked = true;
                    btnCapNhat.Enabled = false;
                    txtMaNV.Text = "Người quản trị hệ thống";
                    txtTenDN.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                    txtMatKhau.Clear();
                    txtXacNhanMK.Clear();
                    return;
                }
                btnCapNhat.Enabled = true;
                if (Quyen == "Kế Toán")
                    radNhanVienKeToan.Checked = true;
                else if (Quyen == "Tra Cứu")
                    radTraCuu.Checked = true;
                txtMaNV.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString().ToUpper();
                txtTenDN.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
               
                
                bool TrangThai = (bool)dgvNhanVien.SelectedRows[0].Cells[3].Value;
                if (!TrangThai)
                    chkTrangThai.Checked = true;
                txtMatKhau.Text = txtXacNhanMK.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
          
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if (!(bool)e.Value)//false
                    e.Value = "Bị cấm";
                else if((bool)e.Value)//true
                    e.Value = "Bình thường";
            }
            if(dgvNhanVien.Columns[e.ColumnIndex].Name == "colQuyen")
            {
                clsLoaiND_BUS bus = new clsLoaiND_BUS();
                List<clsLoaiND_DTO> LoaiND = bus.layDSLoaiND();
                foreach (clsLoaiND_DTO lnd in LoaiND)
                {
                    if (lnd.MALOAI == dgvNhanVien.Rows[e.RowIndex].Cells["colQuyen"].Value.ToString())
                       dgvNhanVien.Rows[e.RowIndex].Cells["colQuyen"].Value = lnd.TENLOAI;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDayDu())
            {
                if(KiemTraTrungKhopMatKhau())
                {
                    clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                    nd.MANV = txtMaNV.Text;
                    nd.TAIKHOAN = txtTenDN.Text;
                    nd.MATKHAU = txtMatKhau.Text;
                    if (!chkTrangThai.Checked)
                        nd.TRANGTHAI = true;
                    else
                        nd.TRANGTHAI = false;
                    nd.LOAIND = LayQuyenTruyCap();
                    clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
                    bool kq = bus.CapNhatTaiKhoan(nd);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật nguời dùng " + nd.TAIKHOAN + " Thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDuLieu();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                 else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường");
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            KiemTraMaNV();
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            KiemTraTenDN();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = txtTenDN.Text = txtMatKhau.Text = txtXacNhanMK.Text = "";
        }

       

       

    }
}
