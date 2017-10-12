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
    public delegate void TenDelegate(Control sender, clsNhanVien_DTO nv);
    public partial class ucDangNhap : UserControl
    {
        
        public event TenDelegate SK_DN_ThanhCong;

        //private static ucDangNhap _Instances = null;

        //public static ucDangNhap Instances
        //{
        //    get
        //    {
        //        if (_Instances == null)
        //            _Instances = new ucDangNhap();
        //        return ucDangNhap._Instances; }
        //    set { ucDangNhap._Instances = value; }
        //}

        public ucDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            XuLyDangNhap();
        }

        private void XuLyDangNhap()
        {
            string strTenDN = txtTenDN.Text;
            string strMK = txtMatKhau.Text;
            // kiểm tra đã nhập đầy đủ tên đăng nhập và mật khẩu
            if (strTenDN == "" || strMK == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            // Kiểm tra Tên Đăng Nhập và Mật khẩu đúng không?
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            if (bus.KiemTraDangNhap(strTenDN, strMK))
            {
                // Xử lý khi đăng nhập thành công
                //Program.nv = bus.LayThongTinNhanVien(strTenDN);
                //phát sinh sự kiện khi đăng nhập thành công
                if (SK_DN_ThanhCong != null)
                    SK_DN_ThanhCong(this, Program.NhanVien_Login);
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên Đăng nhập không tồn tại HOẶC Mật khẩu không đúng");
            }
        }

        private void ucDangNhap_Load(object sender, EventArgs e)
        {
            //load tài khoản có sẵn trong hệ thống
          
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
                XuLyDangNhap();
        }

        private void ucDangNhap_ControlRemoved(object sender, ControlEventArgs e)
        {
          //  _Instances = null;
        }
    }
}
