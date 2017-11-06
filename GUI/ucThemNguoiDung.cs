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
               MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDayDu() && KiemTraTrungKhopMatKhau())
            {
                clsNguoiDung_DTO nd = new clsNguoiDung_DTO();
                nd.MANV = txtMaNV.Text;
                nd.TAIKHOAN = txtTenDN.Text;
                nd.MATKHAU = txtMatKhau.Text;
                nd.TRANGTHAI = true;
                nd.LOAIND = LayQuyenTruyCap();
                clsNguoiDung_BUS bus = new clsNguoiDung_BUS();
                bool kq = bus.TaoTaiKhoan(nd);
                if(kq)
                {
                    MessageBox.Show("Tao nguời dùng " + nd.TAIKHOAN + " Thành công","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDuLieu();
                    return;
                }
            }
        }

    }
}
