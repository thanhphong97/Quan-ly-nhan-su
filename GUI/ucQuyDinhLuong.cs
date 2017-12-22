using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
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
            loadDuLieuLuong();
        }
        private void loadDuLieuLuong()
        {

            clsQuyDinhLuong_BUS BUS = new clsQuyDinhLuong_BUS();
            clsQuyDinhLuong_DTO QuyDinh = BUS.LayQuyDinhLuong();
            //Giá trị mặc định
            int luong = Convert.ToInt32(QuyDinh.LuongToiThieu);
            txtLuongCoBan.Text = string.Format("{0:#,##0}", luong);
            formatPhanTram();
            nudBHYT_NV.Value = Convert.ToDecimal(QuyDinh.BHYT) * 100;
            nudBHXH_NV.Value = Convert.ToDecimal(QuyDinh.BHXH) * 100;
            nudBHTT_NV.Value = Convert.ToDecimal(QuyDinh.BHTN) * 100;
        }
        public void formatPhanTram()
        {
            nudBHYT_NV.DecimalPlaces = 2;
            nudBHYT_NV.ThousandsSeparator = true;

            nudBHXH_NV.DecimalPlaces = 2;
            nudBHXH_NV.ThousandsSeparator = true;
            
            nudBHTT_NV.DecimalPlaces = 2;
            nudBHTT_NV.ThousandsSeparator = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                clsQuyDinhLuong_DTO QuyDinh = new clsQuyDinhLuong_DTO();
                clsQuyDinhLuong_BUS BUS = new clsQuyDinhLuong_BUS();
                QuyDinh.LuongToiThieu = Convert.ToInt32(txtLuongCoBan.Text.Replace(",", ""));
                QuyDinh.BHXH = Convert.ToDouble(nudBHXH_NV.Value / 100);
                QuyDinh.BHYT = Convert.ToDouble(nudBHYT_NV.Value / 100);
                QuyDinh.BHTN = Convert.ToDouble(nudBHTT_NV.Value / 100);
                if (BUS.CapNhatQuyDinhLuong(QuyDinh))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("{0} đã cập nhật quy định lương", Program.NhanVien_Login.TaiKhoan));
                }
                loadDuLieuLuong();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Vui lòng điền Lương tối thiểu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))//chỉ nhập số
                e.Handled = true;
        }

        private void txtLuongCoBan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLuongCoBan.Text))
            {
                CultureInfo cu = new CultureInfo("en-US");
                string LuongC = txtLuongCoBan.Text.Replace(",", "");
                int LuongCB = int.Parse(LuongC, NumberStyles.AllowThousands);
                txtLuongCoBan.Text = string.Format(cu, "{0:N0}", LuongCB);
                txtLuongCoBan.SelectionStart = txtLuongCoBan.Text.Length;
            }
            
        }
    }
}
