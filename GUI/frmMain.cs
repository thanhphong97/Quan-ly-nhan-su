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
using BUS;
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
            this.pnlMain.Dock = DockStyle.Fill;
            TrangThaiChuaDangNhap();
        }

        private void MoFormDangNhap()
        {
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.SK_DN_ThanhCong += XuLyKhiDangNhapThanhCong;
            pnlMain.Controls.Add(ucDN);
        }

        private void TrangThaiChuaDangNhap()
        {
            mnuMain.Enabled = false;
            tbtnDangXuat.Enabled = false;
            lblNguoiDung.Text = "";
            MoFormDangNhap();
        }


        public void XuLyKhiDangNhapThanhCong(Control sender, clsNhanVienDangNhap nv)
        {
            //ẩn uc Đăng nhập
            this.pnlMain.Controls.Remove(sender);
            // Trạng thái đã đăng nhập thành công
            mnuMain.Enabled = true;
            tbtnDangXuat.Enabled = true;
            ucThemNhanVien ucThemNV = new ucThemNhanVien();
            this.pnlMain.Controls.Add(ucThemNV);
            lblNguoiDung.Text = nv.Ho + " " + nv.Ten;
            LoadPhanQuyen();
            clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, "Đã đăng nhập vào hệ thống");
            //System.Drawing.Size kichthuoc = this.Size;
            //MessageBox.Show(kichthuoc.ToString());
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                
                e.Cancel = true;
            }
            //clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            //BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, "Đã đăng xuất khỏi hệ thống");
        }
        
    
        private void LoadPhanQuyen()
        {
            string quyen = Program.NhanVien_Login.Quyen;
            if(quyen == "L1")
            {
                //toàn bộ chức năng
                tbtnQuanTri.Enabled = tbtLuong.Enabled = tbtnQuyDInhLuong.Enabled = tbtnQuanTri.Enabled = true;
            }
            if(quyen == "L2")
            {
                //chỉ chấm công + tiền lương
                tbtnQuanTri.Enabled = false;
            }
            if(quyen == "L3")
            {
                //chỉ tra cứu ds nhân viên
                tbtnQuanTri.Enabled = tbtLuong.Enabled = tbtnQuyDInhLuong.Enabled = false;
            }
        }

        private void tbtnQuanTri_Click(object sender, EventArgs e)
        {
            ucQuanTri ucTND;
            //Tìm ucThemNguoiDung trong Pnl hay không nếu có thì gán cho c nếu không thì giá trị trả về là null c
            ucQuanTri c = pnlMain.Controls.Find("ucQuanTri", false).FirstOrDefault() as ucQuanTri;

            if (c == null)
            {
                // Tạo mới ucThemNguoiDung
                ucTND = new ucQuanTri();
                pnlMain.Controls.Add(ucTND);
            }
            else
            {
                // Nếu đã tồn tại ucThemNguoiDung thì hiển thị 
                c.Show();
            }
            // Ẩn các ucControl khác ucThemNguoiDung
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucQuanTri")
                {
                    ctrl.Hide();
                }
            }
        }

        private void tbtnNhanVien_Click(object sender, EventArgs e)
        {
            ucThemNhanVien ucTNV;
            ucThemNhanVien c = pnlMain.Controls.Find("ucThemNhanVien", false).FirstOrDefault() as ucThemNhanVien;

            if (c == null)
            {
                ucTNV = new ucThemNhanVien();
                pnlMain.Controls.Add(ucTNV);
            }
            else
            {
                c.Show();
            }
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucThemNhanVien")
                {
                    ctrl.Hide();
                }
            }
        }

        private void tbtLuong_Click(object sender, EventArgs e)
        {
            ucChamCong ucCC;
            ucChamCong c = pnlMain.Controls.Find("ucChamCong", false).FirstOrDefault() as ucChamCong;

            if (c == null)
            {
                ucCC= new ucChamCong();
                pnlMain.Controls.Add(ucCC);
            }
            else
            {
                c.Show();
            }
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucChamCong")
                {
                    ctrl.Hide();
                }
            }
        }


        private void tbtnDangXuat_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, "Đã đăng xuất khỏi hệ thống");
            Program.NhanVien_Login = null;
            TrangThaiChuaDangNhap();
        }

        private void tbtnQuyDInhLuong_Click(object sender, EventArgs e)
        {
            ucQuyDinhLuong ucTNV;
            ucQuyDinhLuong c = pnlMain.Controls.Find("ucQuyDinhLuong", false).FirstOrDefault() as ucQuyDinhLuong;

            if (c == null)
            {
                ucTNV = new ucQuyDinhLuong();
                pnlMain.Controls.Add(ucTNV);
            }
            else
            {
                c.Show();
            }
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucQuyDinhLuong")
                {
                    ctrl.Hide();
                }
            }
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            ucTinhLuong ucTL;
            ucTinhLuong c = pnlMain.Controls.Find("ucTinhLuong", false).FirstOrDefault() as ucTinhLuong;

            if (c == null)
            {
                ucTL = new ucTinhLuong();
                pnlMain.Controls.Add(ucTL);
            }
            else
            {
                c.Show();
            }
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucTinhLuong")
                {
                    ctrl.Hide();
                }
            }
        }
        


        ////////////////////////////
    }
}
