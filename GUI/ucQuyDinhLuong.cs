using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int luong = 3750000;
            txtLuongCoBan.Text = string.Format("{0:#,##0}", luong);
            formatPhanTram();

            //giá trị mặc định
            nudcongthang.Value = 24;
            nudCongNgay.Value = 8;
            nudBHYT_NV.Value = 2;
            nudBHYT_CT.Value = 3;
            nudBHXH_NV.Value = 4;
            nudBHXH_CT.Value = 5;
            nudBHTT_NV.Value = 6;
            nudBHTT_CT.Value = 7;
            
        }
        public void formatPhanTram()
        {
            nudcongthang.DecimalPlaces = 2;
            nudcongthang.ThousandsSeparator = true;

            nudCongNgay.DecimalPlaces = 2;
            nudCongNgay.ThousandsSeparator = true;

            nudBHYT_NV.DecimalPlaces = 2;
            nudBHYT_NV.ThousandsSeparator = true;

            nudBHYT_CT.DecimalPlaces = 2;
            nudBHYT_CT.ThousandsSeparator = true;

            nudBHXH_NV.DecimalPlaces = 2;
            nudBHXH_NV.ThousandsSeparator = true;

            nudBHXH_CT.DecimalPlaces = 2;
            nudBHXH_CT.ThousandsSeparator = true;

            nudBHTT_NV.DecimalPlaces = 2;
            nudBHTT_NV.ThousandsSeparator = true;

            nudBHTT_CT.DecimalPlaces = 2;
            nudBHTT_CT.ThousandsSeparator = true;
        }
    }
}
