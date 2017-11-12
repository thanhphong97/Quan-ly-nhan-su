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
    public partial class ucQuyDinhLuong : UserControl
    {
        public ucQuyDinhLuong()
        {
            InitializeComponent();
        }

        private void ucQuyDinhLuong_Load(object sender, EventArgs e)
        {
            
            clsQuyDinhLuong_BUS BUS = new clsQuyDinhLuong_BUS();
            clsQuyDinhLuong_DTO QuyDinh = BUS.LayQuyDinhLuong();
            //Giá trị mặc định
            int luong = Convert.ToInt32(QuyDinh.LuongToiThieu);
            txtLuongCoBan.Text = string.Format("{0:#,##0}", luong);
            formatPhanTram();
            nudCongNgay.Value = Convert.ToDecimal(QuyDinh.GioCong);
            nudBHYT_NV.Value = Convert.ToDecimal(QuyDinh.BHYT) * 100;
            nudBHXH_NV.Value = Convert.ToDecimal(QuyDinh.BHXH) *100;
            nudBHTT_NV.Value = Convert.ToDecimal(QuyDinh.BHTN) * 100;
            nudCongNgay.Value = Convert.ToDecimal(QuyDinh.GioCong);
            
        }
        public void formatPhanTram()
        {
            nudCongNgay.DecimalPlaces = 2;
            nudCongNgay.ThousandsSeparator = true;

            nudBHYT_NV.DecimalPlaces = 2;
            nudBHYT_NV.ThousandsSeparator = true;

            nudBHXH_NV.DecimalPlaces = 2;
            nudBHXH_NV.ThousandsSeparator = true;
            
            nudBHTT_NV.DecimalPlaces = 2;
            nudBHTT_NV.ThousandsSeparator = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            clsQuyDinhLuong_DTO QuyDinh = new clsQuyDinhLuong_DTO();
            clsQuyDinhLuong_BUS BUS = new clsQuyDinhLuong_BUS();
            QuyDinh.LuongToiThieu = Convert.ToInt32(txtLuongCoBan.Text.Replace(",",""));
            QuyDinh.GioCong = Convert.ToDouble(nudCongNgay.Value);
            QuyDinh.BHXH = Convert.ToDouble(nudBHXH_NV.Value / 100);
            QuyDinh.BHYT = Convert.ToDouble(nudBHYT_NV.Value / 100);
            QuyDinh.BHTN = Convert.ToDouble(nudBHTT_NV.Value / 100);
            if (BUS.CapNhatQuyDinhLuong(QuyDinh))
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
