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
using System.Collections;
namespace GUI
{
    public partial class frmBangChamCong : Form
    {
        
        // Thiết lập Tên cột và chỉ số cho dgvBangChamCong
        struct Column
        {
            public static string MaNV = "Mã nhân viên";
            public static string HoTen = "Họ tên";
            public static string col1 = "1";
            public static string col2 = "2";
            public static string col3 = "3";
            public static string col4 = "4";
            public static string col5 = "5";
            public static string col6 = "6";
            public static string col7 = "7";
            public static string col8 = "8";
            public static string col9 = "9";
            public static string col10 = "10";
            public static string col11 = "11";
            public static string col12 = "12";
            public static string col13 = "13";
            public static string col14 = "14";
            public static string col15 = "15";
            public static string col16 = "16";
            public static string col17 = "17";
            public static string col18 = "18";
            public static string col19 = "19";
            public static string col20 = "20";
            public static string col21 = "21";
            public static string col22 = "22";
            public static string col23 = "23";
            public static string col24 = "24";
            public static string col25 = "25";
            public static string col26 = "26";
            public static string col27 = "27";
            public static string col28 = "28";
            public static string col29 = "29";
            public static string col30 = "30";
            public static string col31 = "31";

            public struct Key
            {
                public static int MaNV = 0;
                public static int HoTen = 1;
                public static int col1 = 2;
                public static int col2 = 3;
                public static int col3 = 4;
                public static int col4 = 5;
                public static int col5 = 6;
                public static int col6 = 7;
                public static int col7 = 8;
                public static int col8 = 9;
                public static int col9 = 10;
                public static int col10 = 11;
                public static int col11 = 12;
                public static int col12 = 13;
                public static int col13 = 14;
                public static int col14 = 15;
                public static int col15 = 16;
                public static int col16 = 17;
                public static int col17 = 18;
                public static int col18 = 19;
                public static int col19 = 20;
                public static int col20 = 21;
                public static int col21 = 22;
                public static int col22 = 23;
                public static int col23 = 24;
                public static int col24 = 25;
                public static int col25 = 26;
                public static int col26 = 27;
                public static int col27 = 28;
                public static int col28 = 29;
                public static int col29 = 30;
                public static int col30 = 31;
                public static int col31 = 32;
            }
        }

        private List<clsPhongBan_DTO> lsPhongBan;
        private frmPhongBan frm_PhongBan;
        private ucTienLuong ucTL;
        private bool _btnLuu = false;
       
        public bool BtnLuu
        {
          get { return _btnLuu; }
          set { _btnLuu = value; }
        }

        private bool _btnDong = false;

        public bool BtnDong
        {
            get { return _btnDong; }
            set { _btnDong = value; }
        }
        public frmBangChamCong()
        {
            InitializeComponent();    
        }
        
        public frmBangChamCong(Control sender ,List<clsPhongBan_DTO> lsPhongBan,ucTienLuong ucTL)
        {
            InitializeComponent();
            clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
            clsKyHieuChamCong_BUS BUKH = new clsKyHieuChamCong_BUS();
            
            this.lsPhongBan = lsPhongBan;
            frm_PhongBan = sender as frmPhongBan;
            this.ucTL = ucTL;


            int DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang); // Trả về tháng đó có bao nhiêu ngày
            for(var i = 1 ; i <= DayInMonth; i++)
            {
                var col = "col" + i; 
                dgvBangChamCong.Columns[col].Visible = true;
                DataGridViewComboBoxColumn dgvcbo = (DataGridViewComboBoxColumn)dgvBangChamCong.Columns[col];
                dgvcbo.DataSource = BUSKH.LayDanhSachKyHieu();
                dgvcbo.DisplayMember = "KYHIEU";
                dgvcbo.ValueMember = "KYHIEU";
            }
            
        }

        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
            
            dgvBangChamCong.AutoGenerateColumns = false;
            clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
            dgvBangChamCong.DataSource = BUSNV.LayDanhSachNhanVien(lsPhongBan);
            lblBangChamCong.Text = string.Format("Bảng chấm công tháng {0} năm {1}", ucTL.Thang, ucTL.Nam);
            
        }

        private void dgvBangChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu dữ liệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _btnLuu = true;
            this.Close();
            frm_PhongBan.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị hủy. Bản có muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
        
        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           ;
            if(dgvBangChamCong.Columns[e.ColumnIndex].Name == "colMaPB")
            {
                foreach (clsPhongBan_DTO pb in BUSPB.LayDanhSachPhongBan())
                {
                    if(dgvBangChamCong.Rows[e.RowIndex].Cells[3].Value.ToString() == pb.MAPB)
                    {
                        e.Value = pb.TENPB;
                        break;
                    }
                }
            }
        }

    }
}
