using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            clsChucVu_BUS BUSCV = new clsChucVu_BUS();
            cboChucVu. DataSource = BUSCV.LayDanhSachChucVu();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "TENCV";
            cboLoaiHD.SelectedIndex = 0;

            int  a =  Convert.ToInt32(cboLoaiHD.SelectedValue);
            

        }


        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            bool KiemTra = false;
            clsHopDong_DTO HopDong = new clsHopDong_DTO();
            HopDong.MaNV = "NV1"; // Lấy mã nhân viên được chọn ở  DgvNhanVien
            //txtHo.Text = "Vũ Tuấn";
            //txtHo.Text = "Kiệt";
            //HopDong.MaNV = "NV1"; // Sẽ lấy mã nhân viên đang được chọn ở datagridview ngoài Tabcontrol
            HopDong.NgayBatDau = dtpNgayBatDau.Value;
            if (cboLoaiHD.SelectedIndex == 0)
            {

                HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (HopDong.NgayBatDau.Date.AddMonths(12) != HopDong.NgayKetThuc.Date && HopDong.NgayBatDau.Date.AddMonths(36) != HopDong.NgayKetThuc.Date) // Thời điểm kết chấm dứt hợp đồng xác định thời hạn chưa đủ 12 tháng hoặc chưa đủ 36 tháng
                {
                    MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng xác định thời hạn trong khoảng thời gian từ đủ 12 tháng đến 36 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Đủ điều kiện của hợp đồng xác định thời hạn
                {
                    HopDong.LoaiHD = "Xác định thời hạn";
                    KiemTra = true;
                }
            }
            if (cboLoaiHD.SelectedIndex == 1) 
            {
                HopDong.LoaiHD = "Không xác định thời hạn";
                KiemTra = true;
            }
            if (cboLoaiHD.SelectedIndex == 2)  // Là hợp đồng thời vụ
            {   
                HopDong.NgayKetThuc = dtpNgayKetThuc.Value;
                if (HopDong.NgayKetThuc.Date <= HopDong.NgayBatDau.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (HopDong.NgayBatDau.Date.AddDays(HopDong.NgayKetThuc.Date.Subtract(HopDong.NgayBatDau.Date).TotalDays) >= HopDong.NgayBatDau.Date.AddMonths(12)) // Hợp đồng thời vụ lớn hoặc bằng 12 
                {
                    MessageBox.Show("Thời điểm chấm dứt hiệu lực của hợp đồng thời vụ phải dưới 12 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HopDong.LoaiHD = "Thời vụ";
                    KiemTra = true;
                }
            }  
            
            HopDong.DiaDiemLam = "Công ty";
            //HopDong.ChucVu = cboChucVu.SelectedValue.ToString(); // Chọn sẵn khi chọn Mã nhân viên của datagridview ngoài tabcontrol
            HopDong.ChucVu = cboChucVu.SelectedValue.ToString();
            HopDong.HeSoLuong = 2;// Chọn sẵn khi chọn Mã nhân viên của datagridview ngoài tabcontrol
            HopDong.CongViec = "Sẽ ghi nhân viên này thì cụ thể làm những công việc gì tại công ty, xí nghiệp";
            HopDong.ThoiGianLam = 8; // Thời gian làm bao nhiêu giờ 1 ngày
            HopDong.TrangBi = "Khi nhân viên đi làm thì có được trang bị lao động gì không";
            HopDong.PhuCap = 0;// Thêm phụ cấp cho nhân viên
            HopDong.NgayKy = dtpNgayKy.Value; // Lấy ngày kí hợp đồng là ngày hệ thống
            clsHopDong_BUS BUSHD = new clsHopDong_BUS();
            if (KiemTra)
            {
                if (BUSHD.ThemHopDong(HopDong))
                    MessageBox.Show("Thêm hợp đồng thành công");
                else
                    MessageBox.Show("Thêm hợp đồng thất bại");
            }
        }

        private void cboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cboLoaiHD.SelectedIndex == 1) // Là hợp đồng Không xác định thời hạn
             {
                 dtpNgayKetThuc.Enabled = false;
             }
             else
             {
                 dtpNgayKetThuc.Enabled = true;
             }
        }
    }
}
