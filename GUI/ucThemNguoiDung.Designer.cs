﻿namespace GUI
{
    partial class ucThemNguoiDung
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbQuanTri = new System.Windows.Forms.TabControl();
            this.tpThemNguoiDung = new System.Windows.Forms.TabPage();
            this.lblThongBao_TK = new System.Windows.Forms.Label();
            this.lblThongBao_MaNV = new System.Windows.Forms.Label();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grbThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbPhanQuyen = new System.Windows.Forms.GroupBox();
            this.radQuanLy = new System.Windows.Forms.RadioButton();
            this.radTraCuu = new System.Windows.Forms.RadioButton();
            this.radNhanVienKeToan = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.tpNhatKyTruyCap = new System.Windows.Forms.TabPage();
            this.grbSuKienNK = new System.Windows.Forms.GroupBox();
            this.dgvSuKienNK = new System.Windows.Forms.DataGridView();
            this.colMaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuanTri.SuspendLayout();
            this.tpThemNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grbThongTinTaiKhoan.SuspendLayout();
            this.grbPhanQuyen.SuspendLayout();
            this.tpNhatKyTruyCap.SuspendLayout();
            this.grbSuKienNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKienNK)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuanTri
            // 
            this.tbQuanTri.Controls.Add(this.tpThemNguoiDung);
            this.tbQuanTri.Controls.Add(this.tpNhatKyTruyCap);
            this.tbQuanTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuanTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbQuanTri.Location = new System.Drawing.Point(0, 0);
            this.tbQuanTri.Name = "tbQuanTri";
            this.tbQuanTri.SelectedIndex = 0;
            this.tbQuanTri.Size = new System.Drawing.Size(1303, 680);
            this.tbQuanTri.TabIndex = 0;
            this.tbQuanTri.SelectedIndexChanged += new System.EventHandler(this.tbQuanTri_SelectedIndexChanged);
            // 
            // tpThemNguoiDung
            // 
            this.tpThemNguoiDung.BackColor = System.Drawing.SystemColors.Control;
            this.tpThemNguoiDung.Controls.Add(this.lblThongBao_TK);
            this.tpThemNguoiDung.Controls.Add(this.lblThongBao_MaNV);
            this.tpThemNguoiDung.Controls.Add(this.chkTrangThai);
            this.tpThemNguoiDung.Controls.Add(this.dgvNhanVien);
            this.tpThemNguoiDung.Controls.Add(this.label5);
            this.tpThemNguoiDung.Controls.Add(this.btnCapNhat);
            this.tpThemNguoiDung.Controls.Add(this.grbThongTinTaiKhoan);
            this.tpThemNguoiDung.Controls.Add(this.btnThem);
            this.tpThemNguoiDung.Controls.Add(this.grbPhanQuyen);
            this.tpThemNguoiDung.Controls.Add(this.btnClear);
            this.tpThemNguoiDung.Location = new System.Drawing.Point(4, 27);
            this.tpThemNguoiDung.Name = "tpThemNguoiDung";
            this.tpThemNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tpThemNguoiDung.Size = new System.Drawing.Size(1295, 649);
            this.tpThemNguoiDung.TabIndex = 0;
            this.tpThemNguoiDung.Text = "Thêm người dùng";
            // 
            // lblThongBao_TK
            // 
            this.lblThongBao_TK.AutoSize = true;
            this.lblThongBao_TK.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao_TK.Location = new System.Drawing.Point(818, 505);
            this.lblThongBao_TK.Name = "lblThongBao_TK";
            this.lblThongBao_TK.Size = new System.Drawing.Size(218, 18);
            this.lblThongBao_TK.TabIndex = 25;
            this.lblThongBao_TK.Text = "Tên đăng nhập đã được sử dụng";
            // 
            // lblThongBao_MaNV
            // 
            this.lblThongBao_MaNV.AutoSize = true;
            this.lblThongBao_MaNV.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao_MaNV.Location = new System.Drawing.Point(818, 473);
            this.lblThongBao_MaNV.Name = "lblThongBao_MaNV";
            this.lblThongBao_MaNV.Size = new System.Drawing.Size(244, 18);
            this.lblThongBao_MaNV.TabIndex = 24;
            this.lblThongBao_MaNV.Text = "Mã nhân viên đã được cấp tài khoản";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTrangThai.ForeColor = System.Drawing.Color.Red;
            this.chkTrangThai.Location = new System.Drawing.Point(584, 335);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(231, 22);
            this.chkTrangThai.TabIndex = 23;
            this.chkTrangThai.Text = "Không cho phép đăng nhập";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMANV,
            this.colTenDN,
            this.colQuyen,
            this.colTrangThai,
            this.coMatKhau});
            this.dgvNhanVien.Location = new System.Drawing.Point(117, 159);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(398, 331);
            this.dgvNhanVien.TabIndex = 22;
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // colMANV
            // 
            this.colMANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMANV.DataPropertyName = "MANV";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colMANV.DefaultCellStyle = dataGridViewCellStyle10;
            this.colMANV.HeaderText = "Mã NV";
            this.colMANV.Name = "colMANV";
            this.colMANV.ReadOnly = true;
            this.colMANV.Width = 78;
            // 
            // colTenDN
            // 
            this.colTenDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDN.DataPropertyName = "TAIKHOAN";
            this.colTenDN.HeaderText = "Tên đăng nhập";
            this.colTenDN.Name = "colTenDN";
            this.colTenDN.ReadOnly = true;
            // 
            // colQuyen
            // 
            this.colQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuyen.DataPropertyName = "LOAIND";
            this.colQuyen.HeaderText = "Quyền";
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // coMatKhau
            // 
            this.coMatKhau.DataPropertyName = "MATKHAU";
            this.coMatKhau.HeaderText = "Mật Khẩu";
            this.coMatKhau.Name = "coMatKhau";
            this.coMatKhau.ReadOnly = true;
            this.coMatKhau.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(553, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "THÊM TÀI KHOẢN";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(995, 555);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 46);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Lưu lại";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grbThongTinTaiKhoan
            // 
            this.grbThongTinTaiKhoan.Controls.Add(this.cboNhanVien);
            this.grbThongTinTaiKhoan.Controls.Add(this.cboPhongBan);
            this.grbThongTinTaiKhoan.Controls.Add(this.label6);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtXacNhanMK);
            this.grbThongTinTaiKhoan.Controls.Add(this.label4);
            this.grbThongTinTaiKhoan.Controls.Add(this.label3);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtMatKhau);
            this.grbThongTinTaiKhoan.Controls.Add(this.label1);
            this.grbThongTinTaiKhoan.Controls.Add(this.label2);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtTenDN);
            this.grbThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinTaiKhoan.ForeColor = System.Drawing.Color.Purple;
            this.grbThongTinTaiKhoan.Location = new System.Drawing.Point(821, 159);
            this.grbThongTinTaiKhoan.Name = "grbThongTinTaiKhoan";
            this.grbThongTinTaiKhoan.Size = new System.Drawing.Size(412, 277);
            this.grbThongTinTaiKhoan.TabIndex = 16;
            this.grbThongTinTaiKhoan.TabStop = false;
            this.grbThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Enabled = false;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(180, 86);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(215, 28);
            this.cboNhanVien.TabIndex = 1;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.Enabled = false;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(180, 42);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(215, 28);
            this.cboPhongBan.TabIndex = 0;
            this.cboPhongBan.SelectedValueChanged += new System.EventHandler(this.cboPhongBan_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phòng ban";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(180, 218);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(215, 29);
            this.txtXacNhanMK.TabIndex = 4;
            this.txtXacNhanMK.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cấp cho nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(180, 174);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(215, 29);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDN.Location = new System.Drawing.Point(180, 130);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(215, 29);
            this.txtTenDN.TabIndex = 2;
            this.txtTenDN.TextChanged += new System.EventHandler(this.txtTenDN_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(882, 555);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 46);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbPhanQuyen
            // 
            this.grbPhanQuyen.Controls.Add(this.radQuanLy);
            this.grbPhanQuyen.Controls.Add(this.radTraCuu);
            this.grbPhanQuyen.Controls.Add(this.radNhanVienKeToan);
            this.grbPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbPhanQuyen.ForeColor = System.Drawing.Color.Purple;
            this.grbPhanQuyen.Location = new System.Drawing.Point(579, 159);
            this.grbPhanQuyen.Name = "grbPhanQuyen";
            this.grbPhanQuyen.Size = new System.Drawing.Size(219, 153);
            this.grbPhanQuyen.TabIndex = 17;
            this.grbPhanQuyen.TabStop = false;
            this.grbPhanQuyen.Text = "Phân Quyền";
            // 
            // radQuanLy
            // 
            this.radQuanLy.AutoSize = true;
            this.radQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radQuanLy.ForeColor = System.Drawing.Color.Black;
            this.radQuanLy.Location = new System.Drawing.Point(12, 33);
            this.radQuanLy.Name = "radQuanLy";
            this.radQuanLy.Size = new System.Drawing.Size(76, 22);
            this.radQuanLy.TabIndex = 5;
            this.radQuanLy.Text = "Quản lý";
            this.radQuanLy.UseVisualStyleBackColor = true;
            // 
            // radTraCuu
            // 
            this.radTraCuu.AutoSize = true;
            this.radTraCuu.Checked = true;
            this.radTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radTraCuu.ForeColor = System.Drawing.Color.Black;
            this.radTraCuu.Location = new System.Drawing.Point(12, 124);
            this.radTraCuu.Name = "radTraCuu";
            this.radTraCuu.Size = new System.Drawing.Size(76, 22);
            this.radTraCuu.TabIndex = 7;
            this.radTraCuu.TabStop = true;
            this.radTraCuu.Text = "Tra cứu";
            this.radTraCuu.UseVisualStyleBackColor = true;
            // 
            // radNhanVienKeToan
            // 
            this.radNhanVienKeToan.AutoSize = true;
            this.radNhanVienKeToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNhanVienKeToan.ForeColor = System.Drawing.Color.Black;
            this.radNhanVienKeToan.Location = new System.Drawing.Point(12, 79);
            this.radNhanVienKeToan.Name = "radNhanVienKeToan";
            this.radNhanVienKeToan.Size = new System.Drawing.Size(144, 22);
            this.radNhanVienKeToan.TabIndex = 6;
            this.radNhanVienKeToan.Text = "Nhân viên kế toán";
            this.radNhanVienKeToan.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Location = new System.Drawing.Point(1108, 555);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 46);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Làm lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tpNhatKyTruyCap
            // 
            this.tpNhatKyTruyCap.Controls.Add(this.grbSuKienNK);
            this.tpNhatKyTruyCap.Controls.Add(this.label7);
            this.tpNhatKyTruyCap.Location = new System.Drawing.Point(4, 27);
            this.tpNhatKyTruyCap.Name = "tpNhatKyTruyCap";
            this.tpNhatKyTruyCap.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhatKyTruyCap.Size = new System.Drawing.Size(1295, 649);
            this.tpNhatKyTruyCap.TabIndex = 3;
            this.tpNhatKyTruyCap.Text = "Nhật ký truy cập";
            this.tpNhatKyTruyCap.UseVisualStyleBackColor = true;
            // 
            // grbSuKienNK
            // 
            this.grbSuKienNK.Controls.Add(this.dgvSuKienNK);
            this.grbSuKienNK.Location = new System.Drawing.Point(57, 164);
            this.grbSuKienNK.Name = "grbSuKienNK";
            this.grbSuKienNK.Size = new System.Drawing.Size(1195, 441);
            this.grbSuKienNK.TabIndex = 23;
            this.grbSuKienNK.TabStop = false;
            this.grbSuKienNK.Text = "Sự kiện nhật ký";
            // 
            // dgvSuKienNK
            // 
            this.dgvSuKienNK.AllowUserToResizeColumns = false;
            this.dgvSuKienNK.AllowUserToResizeRows = false;
            this.dgvSuKienNK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuKienNK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSuKienNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuKienNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNK,
            this.colTaiKhoan,
            this.colThoiGian,
            this.colSuKien});
            this.dgvSuKienNK.EnableHeadersVisualStyles = false;
            this.dgvSuKienNK.Location = new System.Drawing.Point(26, 37);
            this.dgvSuKienNK.Name = "dgvSuKienNK";
            this.dgvSuKienNK.ReadOnly = true;
            this.dgvSuKienNK.RowHeadersVisible = false;
            this.dgvSuKienNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuKienNK.Size = new System.Drawing.Size(1147, 383);
            this.dgvSuKienNK.TabIndex = 0;
            // 
            // colMaNK
            // 
            this.colMaNK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNK.DataPropertyName = "MaNK";
            this.colMaNK.HeaderText = "Mã NK";
            this.colMaNK.Name = "colMaNK";
            this.colMaNK.ReadOnly = true;
            this.colMaNK.Visible = false;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTaiKhoan.DataPropertyName = "TaiKhoan";
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            this.colTaiKhoan.Width = 98;
            // 
            // colThoiGian
            // 
            this.colThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colThoiGian.DataPropertyName = "ThoiGian";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "dd/MM/yyyy HH:mm:ss";
            this.colThoiGian.DefaultCellStyle = dataGridViewCellStyle12;
            this.colThoiGian.HeaderText = "Thời gian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.ReadOnly = true;
            this.colThoiGian.Width = 93;
            // 
            // colSuKien
            // 
            this.colSuKien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuKien.DataPropertyName = "SuKien";
            this.colSuKien.HeaderText = "Sự kiện";
            this.colSuKien.Name = "colSuKien";
            this.colSuKien.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(597, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "NHẬT KÝ";
            // 
            // ucThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbQuanTri);
            this.Name = "ucThemNguoiDung";
            this.Size = new System.Drawing.Size(1303, 680);
            this.Load += new System.EventHandler(this.ucThemNguoiDung_Load);
            this.tbQuanTri.ResumeLayout(false);
            this.tpThemNguoiDung.ResumeLayout(false);
            this.tpThemNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grbThongTinTaiKhoan.ResumeLayout(false);
            this.grbThongTinTaiKhoan.PerformLayout();
            this.grbPhanQuyen.ResumeLayout(false);
            this.grbPhanQuyen.PerformLayout();
            this.tpNhatKyTruyCap.ResumeLayout(false);
            this.tpNhatKyTruyCap.PerformLayout();
            this.grbSuKienNK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKienNK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbQuanTri;
        private System.Windows.Forms.TabPage tpThemNguoiDung;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox grbThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbPhanQuyen;
        private System.Windows.Forms.RadioButton radQuanLy;
        private System.Windows.Forms.RadioButton radTraCuu;
        private System.Windows.Forms.RadioButton radNhanVienKeToan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tpNhatKyTruyCap;
        private System.Windows.Forms.Label lblThongBao_TK;
        private System.Windows.Forms.Label lblThongBao_MaNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSuKienNK;
        private System.Windows.Forms.GroupBox grbSuKienNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuKien;

    }
}
