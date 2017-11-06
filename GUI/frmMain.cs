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
           
           
           
            this.pnlMain.Dock = DockStyle.Bottom;
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
            ucThemNhanVien ucThemNV = new ucThemNhanVien();
            this.pnlMain.Controls.Add(ucThemNV);
            // Hiện thị thông tin người đang đăng nhập
            //lblTenNguoiDung.Text = nv.HoTen
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

      

        private void mnuThemNguoiDung_Click(object sender, EventArgs e)
        {
            ucThemNguoiDung ucTND;
            //Tìm ucThemNguoiDung trong Pnl hay không nếu có thì gán cho c nếu không thì giá trị trả về là null c
            ucThemNguoiDung c = pnlMain.Controls.Find("ucThemNguoiDung", false).FirstOrDefault() as ucThemNguoiDung;
            
            if(c == null)
            {
                // Tạo mới ucThemNguoiDung
                ucTND = new ucThemNguoiDung();
                pnlMain.Controls.Add(ucTND);
            }
            else
            {
                // Nếu đã tồn tại ucThemNguoiDung thì hiển thị 
                c.Show();
            }
            // Ẩn các ucControl khác ucThemNguoiDung
            foreach(Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucThemNguoiDung") 
                {
                    ctrl.Hide(); 
                }   
            }
        }

        private void mnuThemNhanVien_Click(object sender, EventArgs e)
        {
            //ucThemNhanVien ucTNV = ucThemNhanVien.Instances;
            //this.pnlMain.Controls.Add(ucTNV);
            ucThemNhanVien ucTNV;
            ucThemNhanVien c = pnlMain.Controls.Find("ucThemNhanVien",false).FirstOrDefault() as ucThemNhanVien;
            
            if(c == null)
            {
                ucTNV = new ucThemNhanVien();
                pnlMain.Controls.Add(ucTNV);
            }
            else
            {
                c.Show();
            }
            foreach(Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucThemNhanVien") 
                {
                    ctrl.Hide(); 
                }   
            }
        
            
        }

        private void mnuQuyDnhLuong_Click(object sender, EventArgs e)
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



        private void mnuTienLuong_Click_1(object sender, EventArgs e)
        {
            ucTienLuong ucTL;
            ucTienLuong c = pnlMain.Controls.Find("ucTienLuong", false).FirstOrDefault() as ucTienLuong;

            if (c == null)
            {
                ucTL = new ucTienLuong();
                pnlMain.Controls.Add(ucTL);
            }
            else
            {
                c.Show();
            }
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "ucTienLuong")
                {
                    ctrl.Hide();
                }
            }
        }
    }
}
