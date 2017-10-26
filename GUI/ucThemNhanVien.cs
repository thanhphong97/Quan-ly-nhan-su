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
        private static ucThemNhanVien _Instances = null;

        public static ucThemNhanVien Instances
        {
            get
            {
                if (_Instances == null)
                    _Instances = new ucThemNhanVien();
                return ucThemNhanVien._Instances;
            }
            set { ucThemNhanVien._Instances = value; }
        }
        private ucThemNhanVien()
        {
            InitializeComponent();
        }

        private void ucThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadCbo();
        }

        private void LoadCbo()
        {
            //Tỉnh 
            cboTinh.Items.Add("Tiền Giang");
            //Quận Huyện
            cboQuanHuyen.Items.Add("Cái Bè");
            //quốc tịnh
            cboQuocTich.Items.Add("Việt Nam");
            //tôn giáo
            cboTonGiao.Items.Add("Không");
            //Mối quan hệ
            cboQuanHe.Items.Add("Cha Me");
            cboQuanHe.Items.Add("Con Cái");
            cboQuanHe.Items.Add("Anh Chị Em");
            cboQuanHe.Items.Add("Vợ Chồng");
            //Phòng Ban
            cboPhongBan.Items.Add("Bảo Vệ");
            //chức vụ
            cboChucVu.Items.Add("Chúa Tể Hội Đồng Bảo Vệ");
            //Học Vấn
            cboTrinhDo.Items.Add("Trung Cấp");
            cboTrinhDo.Items.Add("Cao Đẳng");
            cboTrinhDo.Items.Add("Đại Học");
            cboTrinhDo.Items.Add("Cấp 2");
            cboTrinhDo.Items.Add("Cấp 3");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _Instances = null;
            this.DestroyHandle();
        }



        private void btnLamLai_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThanNhan_Click(object sender, EventArgs e)
        {
            string tenTN = txtTenTN.Text;
            string MQH = cboQuanHe.SelectedItem.ToString();
            dataGridView1.Rows.Add(tenTN, MQH);
        }

        private void ucThemNhanVien_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien();   
        }

        private void ThemNhanVien()
        {
            clsNhanVien_DTO nv = new clsNhanVien_DTO();
            //Thông tin cá nhân
            nv.Ho = txtHoLot.Text;
            nv.Ten = txtTen.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.CMND = txtCMND.Text;
            nv.DiaChiThuongTru = txtDiaChiThuongTru.Text;
            nv.NguyenQuan = txtNguyenQuan.Text;
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
            nv.NgayBatDauLamViec = dtpNgayVaoLam.Value;
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
    }
}
