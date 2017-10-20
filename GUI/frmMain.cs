using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TrangThaiChuaDangNhap();
        }

        private void MoFormDangNhap()
        {
            //ucDangNhap ucDN = ucDangNhap.Instances;
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.SK_DN_ThanhCong += XuLyKhiDangNhapThanhCong;
            pnlMain.Controls.Add(ucDN);
        }

        private void TrangThaiChuaDangNhap()
        {
            mnuMain.Enabled = false;
            btnDangXuat.Enabled = false;
            MoFormDangNhap();
        }

       
        public void XuLyKhiDangNhapThanhCong(Control sender, clsNhanVien_DTO nv)
        {
            //ẩn uc Đăng nhập
            this.pnlMain.Controls.Remove(sender);
            // Trạng thái đã đăng nhập thành công
            mnuMain.Enabled = true;
            btnDangXuat.Enabled = true;

            // Hiện thị thông tin người đang đăng nhập
            //lblTenNguoiDung.Text = nv.HoTen;



        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //foreach(Control child in this.pnlMain.Controls)
            //{
                 //this.pnlMain.Controls.Remove(child);
            //}
            this.pnlMain.Controls.Clear();
            TrangThaiChuaDangNhap();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuDSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuThemNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucThemNhanVien ucTNV = ucThemNhanVien.Instances;
            this.pnlMain.Controls.Add(ucTNV);
        }
    }
}
