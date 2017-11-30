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
        private ucTienLuong ucTL;
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
            //InitializeComponent();
            //clsKyHieuChamCong_BUS BUSKH = new clsKyHieuChamCong_BUS();
            //clsKyHieuChamCong_BUS BUKH = new clsKyHieuChamCong_BUS();
            //BUSPB = new clsPhongBan_BUS();
            //lsPhongBan2 = BUSPB.LayDanhSachPhongBan(); // Lấy tất cả các phòng ban để hiển thị tên phòng bang ở sự kiện dgvBangChamCong_CellFormatting
            //this.lsPhongBan = lsPhongBan;
            //frm_PhongBan = sender as frmPhongBan;
            //this.ucTL = ucTL;
            //DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang); // Trả về tháng đó có bao nhiêu ngày
            //for (var i = 1; i <= DayInMonth; i++)
            //{
            //    var col = "col" + i;
            //    dgvBangChamCong.Columns[col].Visible = true;
                
            //}
            //for (var i = DateTime.Now.Day + 1; i <= DayInMonth; i++)
            //{
            //    var col = "col" + i;
            //    dgvBangChamCong.Columns[col].ReadOnly = true;
            //}
        }

        public frmBangChamCong(ucTienLuong ucTL)
        {
            InitializeComponent();
            this.ucTL = ucTL;
            dgvBangChamCong.AutoGenerateColumns = false;
            clsPhongBan_BUS BUSPB = new clsPhongBan_BUS();
            List<clsPhongBan_DTO> lsPhongBan = new List<clsPhongBan_DTO>();
            DayInMonth = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang); // Trả về tháng đó có bao nhiêu ngày
            if (ucTL.Nam == DateTime.Now.Year && ucTL.Thang == DateTime.Now.Month)
            {
                for (var i = 1; i <= DayInMonth; i++)
                {
                    var col = "col" + i;
                    dgvBangChamCong.Columns[col].Visible = true;
                    dgvBangChamCong.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                for (var i = DateTime.Now.Day + 1; i <= DayInMonth; i++)
                {
                    var col = "col" + i;
                    dgvBangChamCong.Columns[col].ReadOnly = true;
                }
            }
            else if(ucTL.Nam == DateTime.Now.Year && ucTL.Thang < DateTime.Now.Month)
            {
                for (var i = 1; i <= DayInMonth; i++)
                {
                    var col = "col" + i;
                    dgvBangChamCong.Columns[col].Visible = true;
                    dgvBangChamCong.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                
            }
            lblBangChamCong.Text = string.Format("Bảng chấm công tháng {0} năm {1}", ucTL.Thang, ucTL.Nam);
            clsChiTietChamCong_BUS BUSCTCC = new clsChiTietChamCong_BUS();
            List<clsChiTietChamCong_DTO> lsChiTiet = BUSCTCC.LayChiTiet(ucTL.MaCC);
            for(int i = 0 ; i < lsChiTiet.Count; i++)
            {             
                string Ho = lsChiTiet[i].NhanVien.Ho;
                string Ten = lsChiTiet[i].NhanVien.Ten;
                string MaNV = lsChiTiet[i].NhanVien.MaNV;
                string PB = lsChiTiet[i].NhanVien.PhongBan;
                dgvBangChamCong.Rows.Add(ucTL.MaCC ,Ho, Ten, MaNV, PB, lsChiTiet[i].D1, lsChiTiet[i].D2, lsChiTiet[i].D3, lsChiTiet[i].D4, lsChiTiet[i].D5, lsChiTiet[i].D6, lsChiTiet[i].D7, lsChiTiet[i].D8, lsChiTiet[i].D9, lsChiTiet[i].D10, lsChiTiet[i].D11, lsChiTiet[i].D12, lsChiTiet[i].D13, lsChiTiet[i].D14, lsChiTiet[i].D15, lsChiTiet[i].D16, lsChiTiet[i].D17, lsChiTiet[i].D18, lsChiTiet[i].D19, lsChiTiet[i].D20, lsChiTiet[i].D21, lsChiTiet[i].D22, lsChiTiet[i].D23, lsChiTiet[i].D24, lsChiTiet[i].D25, lsChiTiet[i].D26, lsChiTiet[i].D27, lsChiTiet[i].D28, lsChiTiet[i].D29, lsChiTiet[i].D30, lsChiTiet[i].D31 );
            }
            // Chấm công tự động cho ngày chủ nhật
            ChamCongTuDong();
        }

        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
            //dgvBangChamCong.AutoGenerateColumns = false;
            //clsNhanVien_BUS BUSNV = new clsNhanVien_BUS();
            //dgvBangChamCong.DataSource = BUSNV.LayDanhSachNhanVien(lsPhongBan);
            //lblBangChamCong.Text = string.Format("Bảng chấm công tháng {0} năm {1}", ucTL.Thang, ucTL.Nam);
            //ChamCongTuDong();
           
        }


        private void btnDong_Click(object sender, EventArgs e)
        {

            if  (_btnLuu == true) 
                this.Close();
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();

            }
        }


        private void ChamCongTuDong() // Tự động chấm công CN cho ngày chủ nhật
        {
            if (ucTL.Nam == DateTime.Now.Year && ucTL.Thang == DateTime.Now.Month) 
            {
                for (int indexcolumn = 1; indexcolumn <= DateTime.Now.Day; indexcolumn++)
                {
                    DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, indexcolumn);
                    for (int indexrow = 0; indexrow < dgvBangChamCong.Rows.Count; indexrow++)
                    {
                        if (dt.DayOfWeek == 0) // Nếu là ngày chủ nhật
                            dgvBangChamCong.Rows[indexrow].Cells["col" + indexcolumn].Value = "CN";
                    }
                }
            }
            else if(ucTL.Nam == DateTime.Now.Year && ucTL.Thang < DateTime.Now.Month)// Năm chọn bằng với năm hiện tại và tháng chọn nhỏ hơn tháng hiện tại
            {
                for (int indexcolumn = 1; indexcolumn <= DayInMonth; indexcolumn++)
                {
                    DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, indexcolumn);
                    for (int indexrow = 0; indexrow < dgvBangChamCong.Rows.Count; indexrow++)
                    {
                        if (dt.DayOfWeek == 0) // Nếu là ngày chủ nhật
                            dgvBangChamCong.Rows[indexrow].Cells["col" + indexcolumn].Value = "CN";
                    }
                }
            }
        }



        // Sử dụng Autocomplete cho DatagriviewTextboxColumn. Dành cho khi ký hiệu chấm công có từ 2 ký hiệu trở lên
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
                        if (Convert.ToDouble(KyHieu) <= 24) //Thời gian làm phải nhỏ hơn hoặc bằng 24 tiếng
                        {
                            Flag = true;
                        }
                    }
                }
                if (Flag == false) //Ký hiệu chấm công sai 
                {
                    r.Cells[e.ColumnIndex].Value = null;
                }
            }
            catch { }
        }

       
        // Chấm công nhanh cho theo ngày. Xác định ngày hiện tại và chấm công cho tất cả nhân viên trong ngày đó với thời gian làm mặc định là 8 tiếng 1 ngày
        private void mnuChamCongNhanh_Click(object sender, EventArgs e)
        {
            //int IndexCol = dgvBangChamCong.CurrentRow.Cells["col" + DateTime.Now.Day];
            DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, DateTime.Now.Day);
                for(int i = 0 ; i < dgvBangChamCong.Rows.Count; i++)
                {

                    if (dgvBangChamCong.Rows[i].Cells["col" + DateTime.Now.Day].Value == null && dt.DayOfWeek != 0)
                    {
                        dgvBangChamCong.Rows[i].Cells["col" + DateTime.Now.Day].Value = "8";
                    }
                }
        
        }

        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (dgvBangChamCong.Columns[e.ColumnIndex].Name != "colMaNV" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "ColHo" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "colTen" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "colMaPB" && dgvBangChamCong.Columns[e.ColumnIndex].Name != "colMaCC")
            {
                int Ngay = Convert.ToInt32(dgvBangChamCong.Columns[e.ColumnIndex].Name.ToString().Replace("col", ""));
                DateTime dt = new DateTime(ucTL.Nam, ucTL.Thang, Ngay);
                if (dgvBangChamCong.Columns[e.ColumnIndex].ReadOnly == true)
                {
                    dgvBangChamCong.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
                if (dt.DayOfWeek == 0 && dgvBangChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBangChamCong.Columns[e.ColumnIndex].DefaultCellStyle.ForeColor = Color.Red;
                    dgvBangChamCong.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Honeydew;
                }

                if (dt.DayOfWeek != 0 &&  dgvBangChamCong.Columns[e.ColumnIndex].ReadOnly == false)   
                {
                    // Nếu nghỉ có phép hoặc không phép
                    if (Convert.ToString(e.Value) == "P" || Convert.ToString(e.Value) == "K" || Convert.ToString(e.Value) == "") 
                    {
                        dgvBangChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                        dgvBangChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    } 
                    Regex invalidCharsRegex = new Regex(@"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )");
                    if (invalidCharsRegex.IsMatch(Convert.ToString(e.Value)))
                    {
                        dgvBangChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                        dgvBangChamCong.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void dgvBangChamCong_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mnuChamCong.Show(Cursor.Position); // Hiển thị mnuChamCong ngay vị trí chuột
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool Flag = true; // Kiểm tra đã chấm công đủ chưa
            foreach (DataGridViewRow rw in this.dgvBangChamCong.Rows)
            {
                for (int i = 1; i <= DateTime.Now.Day; i++)
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
                if (Flag == false)
                    break;
            }
            if (Flag == true) // Đã chấm công đủ
            {
                //List<clsChiTietChamCong_BUS> lsChamCong = new List<clsChiTietChamCong_BUS>();
                //string sql = "UPDATE CHITIETCHAMCONG SET";
                //for (int i = 0; i < dgvBangChamCong.Rows.Count; i++)
                //{                
                //    clsChiTietChamCong_DTO ChiTietCC = new clsChiTietChamCong_DTO();
                //    for(int j = 1; i <= DateTime.Now.Day; j++)
                //    {
                //        
                //    }
                //    string SoGio = dgvBangChamCong.Rows[i].Cells["col" + DateTime.Now.Day].Value.ToString();
                //    string MaNV = dgvBangChamCong.Rows[i].Cells["colMaNV"].Value.ToString();
                //    string Ngay = DateTime.Now.Day.ToString();
                //    string MaCC = ucTL.MaCC;
                //}
                //MessageBox.Show("Đã lưu dữ liệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
                //BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Đã lưu dữ liệu chấm công có mã {0} cho ngày {1} của tháng {2} năm {3}", ucTL.MaCC, DateTime.Now.Day.ToString(), ucTL.Thang, ucTL.Nam));
                //_btnLuu = true;

                clsChiTietChamCong_BUS BUSCTCC = new clsChiTietChamCong_BUS();
                for(int i = 0 ; i < dgvBangChamCong.Rows.Count; i++)
                {
                    string sql = "UPDATE CHITIETCHAMCONG SET ";
                    for(int j = 1 ; j <= DateTime.Now.Day; j++)
                    {
                        sql += string.Format("D{0} = '{1}',",j,dgvBangChamCong.Rows[i].Cells["col"+j].Value);
                    }
                    int ViTri = sql.LastIndexOf(",");
                    sql = sql.Substring(0, ViTri);
                    sql += string.Format(" WHERE MACC = '{0}' AND MANV = '{1}'",ucTL.MaCC,dgvBangChamCong.Rows[i].Cells["colMaNV"].Value);
                    BUSCTCC.CapNhatChamCong(sql);
                }
                _btnLuu = true;
            }

            //List<clsChiTietChamCong_DTO> lsChamCong = new List<clsChiTietChamCong_DTO>();
            //bool Flag = true; // Kiểm tra đã chấm công đủ chưa
            //int Days = DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang);
            //foreach (DataGridViewRow rw in this.dgvBangChamCong.Rows)
            //{

            //    for (int i = 1; i <= DateTime.Now.Day; i++)
            //    {
            //        if (rw.Cells["col" + i].Value == null || rw.Cells["col" + i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells["col" + i].Value.ToString()))
            //        {
            //            Flag = false;
            //            string Ngay = dgvBangChamCong.Columns[rw.Cells["col" + i].ColumnIndex].Name.Replace("col", "");
            //            string NV = rw.Cells["colMaNV"].Value.ToString();
            //            MessageBox.Show(string.Format("Lỗi: Chưa chấm công ngày {0} cho nhân viên {1}", Ngay, NV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            rw.Selected = true;
            //            dgvBangChamCong.CurrentRow.Selected = false;
            //            break;
            //        }
            //    }
            //    if (Flag == false)
            //        break;
            //}



            //if (Flag)
            //{
            //    for (int i = 0; i < dgvBangChamCong.Rows.Count; i++)
            //    {
            //        clsChiTietChamCong_DTO ChamCong = new clsChiTietChamCong_DTO();
            //        ChamCong.MaNV = dgvBangChamCong.Rows[i].Cells["colMaNV"].Value.ToString();
            //        ChamCong.Thang = ucTL.Thang;
            //        ChamCong.Nam = ucTL.Nam;
            //        ChamCong.D1 = dgvBangChamCong.Rows[i].Cells["col1"].Value.ToString();
            //        ChamCong.D2 = dgvBangChamCong.Rows[i].Cells["col2"].Value.ToString();
            //        ChamCong.D3 = dgvBangChamCong.Rows[i].Cells["col3"].Value.ToString();
            //        ChamCong.D4 = dgvBangChamCong.Rows[i].Cells["col4"].Value.ToString();
            //        ChamCong.D5 = dgvBangChamCong.Rows[i].Cells["col5"].Value.ToString();
            //        ChamCong.D6 = dgvBangChamCong.Rows[i].Cells["col6"].Value.ToString();
            //        ChamCong.D7 = dgvBangChamCong.Rows[i].Cells["col7"].Value.ToString();
            //        ChamCong.D8 = dgvBangChamCong.Rows[i].Cells["col8"].Value.ToString();
            //        ChamCong.D9 = dgvBangChamCong.Rows[i].Cells["col9"].Value.ToString();
            //        ChamCong.D10 = dgvBangChamCong.Rows[i].Cells["col10"].Value.ToString();
            //        ChamCong.D11 = dgvBangChamCong.Rows[i].Cells["col11"].Value.ToString();
            //        ChamCong.D12 = dgvBangChamCong.Rows[i].Cells["col12"].Value.ToString();
            //        ChamCong.D13 = dgvBangChamCong.Rows[i].Cells["col13"].Value.ToString();
            //        ChamCong.D14 = dgvBangChamCong.Rows[i].Cells["col14"].Value.ToString();
            //        ChamCong.D15 = dgvBangChamCong.Rows[i].Cells["col15"].Value.ToString();
            //        ChamCong.D16 = dgvBangChamCong.Rows[i].Cells["col16"].Value.ToString();
            //        ChamCong.D17 = dgvBangChamCong.Rows[i].Cells["col17"].Value.ToString();
            //        ChamCong.D18 = dgvBangChamCong.Rows[i].Cells["col18"].Value.ToString();
            //        ChamCong.D19 = dgvBangChamCong.Rows[i].Cells["col19"].Value.ToString();
            //        ChamCong.D20 = dgvBangChamCong.Rows[i].Cells["col20"].Value.ToString();
            //        ChamCong.D21 = dgvBangChamCong.Rows[i].Cells["col21"].Value.ToString();
            //        ChamCong.D22 = dgvBangChamCong.Rows[i].Cells["col22"].Value.ToString();
            //        ChamCong.D23 = dgvBangChamCong.Rows[i].Cells["col23"].Value.ToString();
            //        ChamCong.D24 = dgvBangChamCong.Rows[i].Cells["col24"].Value.ToString();
            //        ChamCong.D25 = dgvBangChamCong.Rows[i].Cells["col25"].Value.ToString();
            //        ChamCong.D26 = dgvBangChamCong.Rows[i].Cells["col26"].Value.ToString();
            //        ChamCong.D27 = dgvBangChamCong.Rows[i].Cells["col27"].Value.ToString();
            //        if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 28)
            //        {
            //            ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
            //        }
            //        else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 29)
            //        {
            //            ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
            //            ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
            //        }
            //        else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 30)
            //        {
            //            ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
            //            ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
            //            ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
            //        }
            //        else if (DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang) == 31)
            //        {
            //            ChamCong.D28 = dgvBangChamCong.Rows[i].Cells["col28"].Value.ToString();
            //            ChamCong.D29 = dgvBangChamCong.Rows[i].Cells["col29"].Value.ToString();
            //            ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col30"].Value.ToString();
            //            ChamCong.D30 = dgvBangChamCong.Rows[i].Cells["col31"].Value.ToString();
            //        }
            //        ChamCong.Thang = ucTL.Thang;
            //        ChamCong.Nam = ucTL.Nam;
            //        lsChamCong.Add(ChamCong);
            //    }
            //    clsChiTietChamCong_BUS BUS = new clsChiTietChamCong_BUS();
            //    if (BUS.ThemBangChamCong(DateTime.DaysInMonth(ucTL.Nam, ucTL.Thang), lsChamCong))
            //    {
            //        MessageBox.Show("Đã lưu dữ liệu chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        clsNhatKy_BUS BUSNK = new clsNhatKy_BUS();
            //        int SoLuongCC = BUS.LaySoLuong();
            //        BUSNK.ThemNhatKy(Program.NhanVien_Login.TaiKhoan, DateTime.Now, string.Format("Tạo bảng chấm công có mã CC{0} tháng {1} năm {2}", SoLuongCC, ucTL.Thang, ucTL.Nam));
            //        _btnLuu = true;
            //        this.Hide();
            //        frm_PhongBan.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }


        // Tính năng này sẽ được hiển thị khi ký hiệu chấm công có từ 2 ký tự trở lên
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
    }
}
