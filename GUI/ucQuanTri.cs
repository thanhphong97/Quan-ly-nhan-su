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
using Microsoft.Win32;
using System.IO;
using System.Data.SqlClient;
namespace GUI
{
    public partial class ucQuanTri : UserControl
    {
        private static List<clsPhongBan_DTO> lsPhongBan;
        private static string ChuoiKetNoi = "Data Source=.;Initial Catalog=QLNV_XiNghiep;Integrated Security=True";
        public ucQuanTri()
        {
            InitializeComponent();
        }

       
        private void LoadDGV_NguoiDung()
        {
            clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
            List<clsNguoiDung_DTO> lsNguoiDung = bus.DSNguoiDung();
            dgvNhanVien.DataSource = lsNguoiDung;
            
        }
        #region Kiểm tr các thứ
        private bool KiemTraDayDu()
        {
            if (cboNhanVien.Text == "" || txtTenDN.Text == "" || txtMatKhau.Text == "")
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
            string MaNV = cboNhanVien.SelectedValue.ToString();
            clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
            bool kq = bus.KiemTraTonTai(MaNV, 1);
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
            string Quyen="";
            if (radQuanLy.Checked)
                Quyen = "L1";
            if (radNhanVienKeToan.Checked)
                Quyen = "L2";
            if (radTraCuu.Checked)
                Quyen = "L3";
            return Quyen;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTenDN())
            {
                if (KiemTraMaNV())
                {
                    if (KiemTraDayDu())
                    {
                        if (KiemTraTrungKhopMatKhau())
                        {
                            clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                            nd.MANV = cboNhanVien.SelectedValue.ToString().ToUpper();
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
                            {//thành công
                                //MessageBox.Show("Tao nguời dùng " + nd.TAIKHOAN + " Thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                                BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Tạo người dùng {0} có mã nhân viên {1}", nd.TAIKHOAN, nd.MANV));
                                LoadDGV_NguoiDung();
                                return;
                            }
                            else
                            {//thất bại
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

        private void XoaThongBao()
        {
            lblThongBao_MaNV.Visible = false;
            lblThongBao_TK.Visible = false;
        }

        private void LoadDuLieuNguoiDung()
        {
            try
            {
                string Quyen = dgvNhanVien.SelectedRows[0].Cells["colQuyen"].Value.ToString();
                if (Quyen == "Quản Lý" || Quyen == "L1")
                {  
                    radQuanLy.Checked = true;
                    chkTrangThai.Enabled = false; // không cho phép 
                    radNhanVienKeToan.Enabled = false;
                    radQuanLy.Enabled = false;
                    radTraCuu.Enabled = false;
                    goto LoadThongTin;
                }
                chkTrangThai.Enabled = true;
                radNhanVienKeToan.Enabled = true;
                radQuanLy.Enabled = true;
                radTraCuu.Enabled = true;
                if (Quyen == "Kế Toán" || Quyen == "L2")
                    radNhanVienKeToan.Checked = true;
                else if (Quyen == "Tra Cứu" || Quyen == "L3")
                    radTraCuu.Checked = true;
                //loadThongTin
                //load phòng theo mã nhân viên
                LoadThongTin:
                string MaNV = dgvNhanVien.SelectedRows[0].Cells["colMANV"].Value.ToString().ToUpper();
                clsPhongBan_BUS bus = new clsPhongBan_BUS();
                cboPhongBan.SelectedValue = bus.LayMaPhong(MaNV);
                cboNhanVien.SelectedValue = MaNV;
                txtTenDN.Text = dgvNhanVien.SelectedRows[0].Cells["colTenDN"].Value.ToString();
                bool TrangThai = (bool)dgvNhanVien.SelectedRows[0].Cells["colTrangThai"].Value;
                if (!TrangThai)
                    chkTrangThai.Checked = true;
                else
                    chkTrangThai.Checked = false;
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
                else if ((bool)e.Value)//true
                    e.Value = "";
            }
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colQuyen")
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
                if (KiemTraTrungKhopMatKhau())
                {
                    clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                    nd.MANV = cboNhanVien.SelectedValue.ToString();
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
                        clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                        BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan,DateTime.Now,string.Format("Cập nhật người dùng {0} có mã nhân viên NV{1}",nd.TAIKHOAN,nd.MANV));
                        LoadDGV_NguoiDung();
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

       

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            KiemTraTenDN();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            XoaThongBao();
            
        }
        private void XoaTextBox()
        {
            cboPhongBan.Text = cboNhanVien.Text = txtTenDN.Text = txtMatKhau.Text = txtXacNhanMK.Text = "";
        }

        private void LoadCBO_PhongBan()
        {
            clsPhongBan_BUS bus = new clsPhongBan_BUS();
            lsPhongBan = bus.LayDanhSachPhongBan();
            cboPhongBan.DataSource = lsPhongBan;
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
        }
        
        private void LoadCBO_NhanVien(string MaPB)
        {
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsNhanVien = bus.LayNhanVienTheoPhong(MaPB);
            cboNhanVien.DataSource = lsNhanVien;
            cboNhanVien.DisplayMember = "Ho";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void cboPhongBan_SelectedValueChanged(object sender, EventArgs e)
        {
            
            LoadCBO_NhanVien(cboPhongBan.SelectedValue.ToString());
        }
       
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTraMaNV();
        }

        private void tbQuanTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSuKienNK.AutoGenerateColumns = false;
            clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            dgvSuKienNK.DataSource = BUSNK.LayDanhSachNhatKy();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNhanVien.Rows.Count != 0)
            {
                LoadDuLieuNguoiDung();
                XoaThongBao();
            }
        }
        //Backup db
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string NoiLuuBackup = "";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Backup File| *.bak";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    NoiLuuBackup = sfd.FileName;
                }

                SqlConnection connect = new SqlConnection(ChuoiKetNoi);
                connect.Open();
                string sql = string.Format(@"BACKUP DATABASE [QLNV_XiNghiep] TO DISK ='{0}' with init", NoiLuuBackup);
                //with init:  ghi đè
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Hoàn thành sao lưu Cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(string.Format(@"{0}", NoiMoBackup)))//kiểm tra file trong đường dẫn chỉ định
                {
                    if (MessageBox.Show("Khôi phục dữ liệu đã sao lưu trong Database?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection connect = new SqlConnection(ChuoiKetNoi);
                        connect.Open();
                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        string sql = string.Format(@"RESTORE DATABASE [QLNV_XiNghiep] FROM DISK = '{0}'", NoiMoBackup);
                        command = new SqlCommand(sql, connect);
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Hoàn tất việc quá trình khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Không tồn tại bất kỳ bản sao lưu nào trước đây (Hoặc đường dẫn file bị sai)", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        string NoiMoBackup;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File | *.bak";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                NoiMoBackup = ofd.FileName;
                txtDuongDanBAK.Text = NoiMoBackup;
            }
        }

        private void ucQuanTri_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            XoaThongBao();
            LoadDGV_NguoiDung();
            LoadCBO_PhongBan();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.Rows.Count != 0)
            {
                LoadDuLieuNguoiDung();
                XoaThongBao();
            }
        }
       



    }
}
