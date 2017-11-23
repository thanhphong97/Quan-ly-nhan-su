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
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class frmBangChamCong : Form
    {

        // Thiết lập Tên cột và chỉ số cho dgvBangChamCong
        private List<clsPhongBan_DTO> lsPhongBan;
        private frmPhongBan frm_PhongBan;
        private ucTienLuong ucTL;
        private clsPhongBan_BUS BUSPB;
        private List<clsPhongBan_DTO> lsPhongBan2;
        private bool _btnLuu = false;
        //fix bug ngay thang
        private static int DayInMonth;
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

        public frmBangChamCong(Control sender, List<clsPhongBan_DTO> lsPhongBan, ucTienLuong ucTL)
        {
            InitializeComponent();
            clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
            clsKyHieuChamCong_BUS BUKH = new clsKyHieuChamCong_BUS();
            BUSPB = new clsPhongBan_BUS();
            lsPhongBan2 = BUSPB.LayDanhSachPhongBan(); // Lấy tất cả các phòng ban để hiển thị tên phòng bang ở sự kiện dgvBangChamCong_CellFormatting
            this.lsPhongBan = lsPhongBan;
            frm_PhongBan = sender as frmPhongBan;
            this.ucTL = ucTL;
            DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang); // Trả về tháng đó có bao nhiêu ngày
            for (var i = 1; i <= DayInMonth; i++)
            {
                var col = "col" + i;
                dgvBangChamCong.Columns[col].Visible = true;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<clsChamCong_DTO> lsChamCong = new List<clsChamCong_DTO>();
            bool Flag = true; // Kiểm tra đã chấm công đủ chưa
            int Days = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang);
            foreach (DataGridViewRow rw in this.dgvBangChamCong.Rows)
            {
                
                for (int i = 1; i <= Days; i++)
                {
                    if (rw.Cells["col" + i].Value == null || rw.Cells["col" + i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells["col" + i].Value.ToString()))
                    {
                        Flag = false;
                        string Ngay = dgvBangChamCong.Columns[rw.Cells["col" + i].ColumnIndex].Name.Replace("col", "");
                        string NV = rw.Cells["colMaNV"].Value.ToString();
                        MessageBox.Show(string.Format("Lỗi: Chưa chấm công ngày {0} cho nhân viên {1}", Ngay, NV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rw.Selected = true;
                        dgvBangChamCong.CurrentRow.Selected = false;
                        break;
                    }
                }
                if(Flag == false)
                    break;
            }



            if (Flag)
            {
                for (int i = 0; i < dgvBangChamCong.Rows.Count; i++)
                {
                    clsChamCong_DTO ChamCong = new clsChamCong_DTO();
                    ChamCong.MaNV = dgvBangChamCong.Rows[i].Cells["colMaNV"].Value.ToString();
                    ChamCong.Thang = ucTL.Thang;
                    ChamCong.Nam = ucTL.Nam;
                    ChamCong.D1 = dgvBangChamCong.Rows[i].Cells["col1"].Value.ToString();
                    ChamCong.D2 = dgvBangChamCong.Rows[i].Cells["col2"].Value.ToString();
                    ChamCong.D3 = dgvBangChamCong.Rows[i].Cells["col3"].Value.ToString();
                    ChamCong.D4 = dgvBangChamCong.Rows[i].Cells["col4"].Value.ToString();
                    ChamCong.D5 = dgvBangChamCong.Rows[i].Cells["col5"].Value.ToString();
                    ChamCong.D6 = dgvBangChamCong.Rows[i].Cells["col6"].Value.ToString();
                    ChamCong.D7 = dgvBangChamCong.Rows[i].Cells["col7"].Value.ToString();
                    ChamCong.D8 = dgvBangChamCong.Rows[i].Cells["col8"].Value.ToString();
                    ChamCong.D9 = dgvBangChamCong.Rows[i].Cells["col9"].Value.ToString();
                    ChamCong.D10 = dgvBangChamCong.Rows[i].Cells["col10"].Value.ToString();
                    ChamCong.D11 = dgvBangChamCong.Rows[i].Cells["col11"].Value.ToString();
                    ChamCong.D12 = dgvBangChamCong.Rows[i].Cells["col12"].Value.ToString();
                    ChamCong.D13 = dgvBangChamCong.Rows[i].Cells["col13"].Value.ToString();
                    ChamCong.D14 = dgvBangChamCong.Rows[i].Cells["col14"].Value.ToString();
                    ChamCong.D15 = dgvBangChamCong.Rows[i].Cells["col15"].Value.ToString();
                    ChamCong.D16 = dgvBangChamCong.Rows[i].Cells["col16"].Value.ToString();
                    ChamCong.D17 = dgvBangChamCong.Rows[i].Cells["col17"].Value.ToString();
                    ChamCong.D18 = dgvBangChamCong.Rows[i].Cells["col18"].Value.ToString();
                    ChamCong.D19 = dgvBangChamCong.Rows[i].Cells["col19"].Value.ToString();
                    ChamCong.D20 = dgvBangChamCong.Rows[i].Cells["col20"].Value.ToString();
                    ChamCong.D21 = dgvBangChamCong.Rows[i].Cells["col21"].Value.ToString();
                    ChamCong.D22 = dgvBangChamCong.Rows[i].Cells["col22"].Value.ToString();
                    ChamCong.D23 = dgvBangChamCong.Rows[i].Cells["col23"].Value.ToString();
                    ChamCong.D24 = dgvBangChamCong.Rows[i].Cells["col24"].Value.ToString();
                    ChamCong.D25 = dgvBangChamCong.Rows[i].Cells["col25"].Value.ToString();
                    ChamCong.D26 = dgvBangChamCong.Rows[i].Cells["col26"].Value.ToString();
                    ChamCong.D27 = dgvBangChamCong.Rows[i].Cells["col27"].Value.ToString();
                    if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 28)
                    {
                        ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                    }
                    else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 29)
                    {
                        ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                        ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                    }
                    else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 30)
                    {
                        ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                        ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                        ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
                    }
                    else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 31)
                    {
                        ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
                        ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
                        ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
                        ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col31"].Value.ToString();
                    }
                    ChamCong.Thang = ucTL.Thang;
                    ChamCong.Nam = ucTL.Nam;
                    lsChamCong.Add(ChamCong);
                }
                clsChamCong_BUS BUS = new clsChamCong_BUS();
                if (BUS.ThemBangChamCong(DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang), lsChamCong))
                {
                    MessageBox.Show("Đã lưu dữ liệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                    int SoLuongCC = BUS.LaySoLuong();
                    BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Tạo bảng chấm công có mã CC{0} tháng {1} năm {2}", SoLuongCC, ucTL.Thang, ucTL.Nam));
                    _btnLuu = true;
                    this.Hide();
                    frm_PhongBan.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị hủy. Bản có muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvBangChamCong.Columns[e.ColumnIndex].Name == "colMaPB")
            {
                foreach (clsPhongBan_DTO pb in lsPhongBan2)
                {
                    if (dgvBangChamCong.Rows[e.RowIndex].Cells[3].Value.ToString() == pb.MAPB)
                    {
                        e.Value = pb.TENPB; // Hiển thị Tên phòng ban ở colMaPB
                        break;
                    }
                }
            }

            if (dgvBangChamCong.Columns[e.ColumnIndex].Name != "colMaNV" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "ColHo" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "colTen" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "colMaPB")
            {
                int Ngay = Convert.ToInt32(dgvBangChamCong.Columns[e.ColumnIndex].Name.ToString().Replace("col", ""));
                DateTime dt = new DateTime(ucTL.Nam,ucTL.Thang,Ngay);
                if(dt.DayOfWeek == 0)
                {
                    dgvBangChamCong.Columns[e.ColumnIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            dgvBangChamCong.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ChamCongTuDong() // Tự động chấm công CN cho ngày chủ nhật
        {
           // int col = dgvBangChamCong.Columns.Count;

            for (int indexcolumn = 0; indexcolumn < (DayInMonth + 4); indexcolumn++)
            {
                if (dgvBangChamCong.Columns[indexcolumn].Name != "colMaNV" && dgvBangChamCong.Columns[indexcolumn].Name != "ColHo" && dgvBangChamCong.Columns[indexcolumn].Name != "colTen" && dgvBangChamCong.Columns[indexcolumn].Name != "colMaPB")
                {
                    int Ngay = Convert.ToInt32((dgvBangChamCong.Columns[indexcolumn].Name).Replace("col", "")); // Lấy ra ngày trong tháng
                    DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
                    for (int indexrow = 0; indexrow < dgvBangChamCong.Rows.Count; indexrow++)
                    {
                        if (dt.DayOfWeek == 0) // Nếu là ngày chủ nhật
                            dgvBangChamCong.Rows[indexrow].Cells[indexcolumn].Value = "CN";
                    }
                }
            }
        }

        private void dgvBangChamCong_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int IndexCol = dgvBangChamCong.CurrentCell.ColumnIndex;
            int Ngay = Convert.ToInt32(dgvBangChamCong.Columns[IndexCol].HeaderText);
            DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
            TextBox autoText = e.Control as TextBox;
            if (autoText != null && dt.DayOfWeek != 0) // Không phải là ngày chủ nhật thì loại bỏ ký hiệu chấm công CN
            {
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                addItems(DataCollection);
                DataCollection.Remove("CN"); 
                autoText.AutoCompleteCustomSource = DataCollection;
            }
            else
            {
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                addItems(DataCollection);
                autoText.AutoCompleteCustomSource = DataCollection;
            }
        }

        // Sử dụng Autocomplete cho DatagriviewTextboxColumn
        public void addItems(AutoCompleteStringCollection col)
        {
            clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
            List<clsKyHieuChamCong_DTO> lsKH = BUSKH.LayDanhSachKyHieu();
            for (int i = 0; i < lsKH.Count; i++)
            {
                col.Add(lsKH[i].KyHieu); 
            }  
        }

        private void dgvBangChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvBangChamCong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvBangChamCong_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dgvBangChamCong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvBangChamCong.CurrentRow;
                r.Cells[e.ColumnIndex].Value = r.Cells[e.ColumnIndex].Value.ToString().ToUpper();
                string KyHieu = r.Cells[e.ColumnIndex].Value.ToString();
                clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
                List<clsKyHieuChamCong_DTO> lsKH = new List<clsKyHieuChamCong_DTO>();
                lsKH = BUSKH.LayDanhSachKyHieu();
                bool Flag = false; // Ký hiệu chấm công sai

                int Ngay = Convert.ToInt32(dgvBangChamCong.Columns[e.ColumnIndex].Name.ToString().Replace("col", ""));
                DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
                if (dt.DayOfWeek != 0)
                {
                    for (int i = 0; i < lsKH.Count; i++)
                    {
                        if (lsKH[i].KyHieu == "CN")
                        {
                            lsKH.RemoveAt(i); //Xóa ký hiệu CN ở những ngày thường
                            break;
                        }

                    }
                }
                foreach (clsKyHieuChamCong_DTO KH in lsKH)
                {

                    if (KyHieu == KH.KyHieu)
                    {
                        Flag = true; // Ký hiệu chấm công vừa nhập là phù hợp
                    }
                }
                if (Flag == false)
                {
                    // Cho phép số và dấu chấm (Số lẻ)
                    Regex invalidCharsRegex = new Regex(@"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )"); 
                    if (invalidCharsRegex.IsMatch(KyHieu))
                    {
                        foreach (clsPhongBan_DTO PB in lsPhongBan)
                        {
                            if (Convert.ToDouble(KyHieu) <= 8 && PB.MAPB == "PB1") // Là phòng nhân sự
                            {
                                Flag = true;
                                break;
                            }
                            else if (KyHieu.All(char.IsDigit) && Convert.ToDouble(KyHieu) <= 12 && PB.MAPB != "PB1")
                            {
                                Flag = true;
                                break;
                            }
                        }

                    }
                }
                if (Flag == false) //Ký hiệu chấm công sai 
                {
                    MessageBox.Show("Lỗi ký hiệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Cells[e.ColumnIndex].Value = "";
                }
            }
            catch { }
        }

        private void dgvBangChamCong_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvBangChamCong_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mnuChamCong.Show(Cursor.Position); // Hiển thị mnuChamCong ngay vị trí chuột
            }
        }

        private void dgvBangChamCong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void mnuChamCongNhanh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvBangChamCong.CurrentRow;
            int DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) ; // Trả về tháng đó có bao nhiêu ngày
            for (int i = 1; i <= DayInMonth; i++)
            {
                DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, i);
                    if (dt.DayOfWeek != 0) // Không phải ngày chủ nhật
                        r.Cells["col"+i].Value = "8";    
        }


    }
}
