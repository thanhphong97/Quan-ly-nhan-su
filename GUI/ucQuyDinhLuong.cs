﻿using System;
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
         
            nudCongNgay.Value = 8;
            nudBHYT_NV.Value = 2;
            nudBHXH_NV.Value = 4;
            nudBHTT_NV.Value = 6;
            
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
    }
}
