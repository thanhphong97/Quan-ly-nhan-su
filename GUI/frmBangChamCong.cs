﻿using System;
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
        private List<clsPhongBan_DTO> lsPhongBan;
        private frmPhongBan frm_PhongBan;
        private ucTienLuong ucTL;
        private clsPhongBan_BUS BUSPB;
        private bool _btnLuu = false;
        private List<clsPhongBan_DTO> lsPhongBan2; 
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
            BUSPB = new clsPhongBan_BUS(); // Lấy tất cả các phòng ban để hiển thị tên phòng bang ở sự kiện dgvBangChamCong_CellFormatting
            lsPhongBan2 = BUSPB.LayDanhSachPhongBan();

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

            ChamCongTuDong();
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
        
        
        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvBangChamCong.Columns[e.ColumnIndex].Name == "colMaPB")
            {
                foreach (clsPhongBan_DTO pb in lsPhongBan2)
                {
                    if(dgvBangChamCong.Rows[e.RowIndex].Cells[3].Value.ToString() == pb.MAPB)
                    {
                        e.Value = pb.TENPB;
                        break;
                    }
                }
                
            }
        }

        private void ChamCongTuDong()
        {
            for(int indexcolumn = 0 ; indexcolumn < dgvBangChamCong.Columns.Count; indexcolumn++)
            {
                if(dgvBangChamCong.Columns[indexcolumn].Name != "colMaNV" && dgvBangChamCong.Columns[indexcolumn].Name != "ColHo" && dgvBangChamCong.Columns[indexcolumn].Name != "colTen" && dgvBangChamCong.Columns[indexcolumn].Name != "colMaPB")
                {
                    int Ngay = Convert.ToInt32((dgvBangChamCong.Columns[indexcolumn].Name).Replace("col", "")); // Lấy ra ngày trong tháng
                    DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
                    for( int indexrow = 0;  indexrow < dgvBangChamCong.Rows.Count; indexrow++)
                    {
                        if(dt.DayOfWeek== 0) // Nếu là ngày chủ nhật
                            (dgvBangChamCong.Rows[indexrow].Cells[indexcolumn] as DataGridViewComboBoxCell).Value = "CN";
                        else
                            (dgvBangChamCong.Rows[indexrow].Cells[indexcolumn] as DataGridViewComboBoxCell).Value = "8";
                    }
                }
            }
        }

        

    }
}
