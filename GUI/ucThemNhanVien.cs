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
            this.Dock = DockStyle.Fill;
            this.radNam.Checked = true;

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
            cboQuocTich.Items.Add("Việt Nam");
            cboQuocTich.SelectedIndex= 0 ;
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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //_Instances = null;
            this.DestroyHandle();
        }



        private void btnLamLai_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThanNhan_Click(object sender, EventArgs e)
        {
            //string tenTN = txtTenTN.Text;
            //string MQH = cboQuanHe.SelectedItem.ToString();
            //ListViewItem lv = new ListViewItem(tenTN);
            //lv.SubItems.Add(MQH);
            //lvwThanNhan.Items.Add(lv);
        }

        private void ucThemNhanVien_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            //ThemNhanVien();   
        }

        private void ThemNhanVien(clsNhanVien_DTO nv)
        {
            
            //Thông tin cá nhân
            nv.Ho = txtHo.Text;
            nv.Ten = txtTen.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.CMND = txtCMND.Text;
            //nv.DiaChiThuongTru = txtDiaChiThuongTru.Text;
            //nv.NguyenQuan = txtNguyenQuan.Text;
            if (radNam.Checked == true)
                nv.GioiTinh = true; // nam
            else
                nv.GioiTinh = false;// nữ
            //Chưa có database sẽ chọn từ Items 
            nv.TinhThanh = cboTinh.SelectedItem.ToString();
            nv.QuanHuyen = cboQuanHuyen.SelectedItem.ToString();
            nv.QuocTich = cboQuocTich.SelectedItem.ToString();
            nv.TonGiao = cboTonGiao.SelectedItem.ToString();
            //mã bậc cần có trong Database
            //Thông tin cơ bản ở công ty
            // mã phòng, mã chức vụ cần Database
            
            //Thông tin thân nhân
            //lưu vào bảng thân nhân sau khi đã insert Nhân Viên
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            if(bus.ThemNhanVien(nv) == true)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
          //chặn nhập chữ
        }

        private void grbHopDong_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            //clsNhanVien_DTO NhanVien = new clsNhanVien_DTO();
            //NhanVien.Ho = txtHo.Text.Trim();
            //NhanVien.Ten = txtTen.Text.Trim();
            //NhanVien.NgaySinh = dtpNgaySinh.Value;
            //NhanVien.CMND = txtCMND.Text.Trim();
            //NhanVien.GioiTinh = (radNam.Checked == true) ? true : false;
            //NhanVien.ChucVu = cboChucVu.SelectedValue.ToString();
            //NhanVien.HeSoLuong = Convert.ToDouble(numHeSoLuong.Value);
            //NhanVien.DiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            //NhanVien.NguyenQuan = txtNguyenQuan.Text.Trim();
            //NhanVien.QuocTich = cboQuocTich.SelectedValue.ToString();
            //NhanVien.TinhThanh = cboTinh.SelectedValue.ToString();
            //NhanVien.TonGiao = cboTonGiao.SelectedValue.ToString();
            //NhanVien.MaBC = cboTrinhDo.SelectedValue.ToString();
            //NhanVien.NgayBatDauLamViec = dtpNgaySinh.Value;
               
        }

        private void tpNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
