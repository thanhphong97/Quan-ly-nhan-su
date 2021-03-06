﻿using System;
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
using System.Data.SqlClient;
namespace GUI
{
    public partial class ucTinhLuong : UserControl
    {
        public ucTinhLuong()
        {
            InitializeComponent();
        }
        private void ucTinhLuong_Load(object sender, EventArgs e)
        {
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            List<clsPhongBan_DTO> lsPhongBan = BUSPB.LayDanhSachPhongBan();
            clsPhongBan_DTO pb = new clsPhongBan_DTO();
            pb.TENPB = "Tất cả";
            pb.MAPB = "0";
            lsPhongBan.Insert(0, pb);
            cboPhongBan.DataSource = lsPhongBan;
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
        }
        private void loadDSTIenLuong()
        {
            clsTinhLuong_BUS bus = new clsTinhLuong_BUS();
            List<clsTinhLuong_DTO> lsBangLuong = bus.lsBangLuong(dtpThangNam.Value.Year, dtpThangNam.Value.Month, cboPhongBan.SelectedValue.ToString());
            if (lsBangLuong.Count > 0)
            {
                dgvTienLuong.DataSource = lsBangLuong;
                dgvTienLuong.AutoGenerateColumns = false;
                clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Đã tính lương tháng {0} năm {1} cho phòng {2}", dtpThangNam.Value.Month, dtpThangNam.Value.Year, cboPhongBan.Text));
            }
            else
            {
                dgvTienLuong.DataSource = lsBangLuong;
                MessageBox.Show("Chưa có bảng chấm công cho tháng này nên không thể xem bảng lương", "THÔNG BÁO");
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            try
            {
                loadDSTIenLuong();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnInBangLuong_Click(object sender, EventArgs e)
        {
            int Nam = dtpThangNam.Value.Year;
            int Thang = dtpThangNam.Value.Month;
            string MaPB = cboPhongBan.SelectedValue.ToString();
            frmBaoCaoBangLuong frm = new frmBaoCaoBangLuong(Nam, Thang, MaPB);
            frm.Show();
            clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Đã in bảng lương tháng {0} năm {1} cho phòng {2}", dtpThangNam.Value.Month, dtpThangNam.Value.Year, cboPhongBan.Text));
        }
    }
}
