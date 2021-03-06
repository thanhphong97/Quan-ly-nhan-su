﻿namespace GUI
{
    partial class ucQuanTri
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbQuanTri = new System.Windows.Forms.TabControl();
            this.tpThemNguoiDung = new System.Windows.Forms.TabPage();
            this.lblThongBao_MatKhau = new System.Windows.Forms.Label();
            this.lblThanhCong = new System.Windows.Forms.Label();
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
            this.radNhanVienKeToan = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.tpNhatKyTruyCap = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXemNhatKy = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.grbSuKienNK = new System.Windows.Forms.GroupBox();
            this.dgvSuKienNK = new System.Windows.Forms.DataGridView();
            this.colMaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.bk = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuongDanBAK = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timer_ThanhCong = new System.Windows.Forms.Timer(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tbQuanTri.SuspendLayout();
            this.tpThemNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grbThongTinTaiKhoan.SuspendLayout();
            this.grbPhanQuyen.SuspendLayout();
            this.tpNhatKyTruyCap.SuspendLayout();
            this.grbSuKienNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKienNK)).BeginInit();
            this.bk.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuanTri
            // 
            this.tbQuanTri.Controls.Add(this.tpThemNguoiDung);
            this.tbQuanTri.Controls.Add(this.tpNhatKyTruyCap);
            this.tbQuanTri.Controls.Add(this.bk);
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
            this.tpThemNguoiDung.Controls.Add(this.lblThongBao_MatKhau);
            this.tpThemNguoiDung.Controls.Add(this.lblThanhCong);
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
            // lblThongBao_MatKhau
            // 
            this.lblThongBao_MatKhau.AutoSize = true;
            this.lblThongBao_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao_MatKhau.Location = new System.Drawing.Point(818, 491);
            this.lblThongBao_MatKhau.Name = "lblThongBao_MatKhau";
            this.lblThongBao_MatKhau.Size = new System.Drawing.Size(188, 18);
            this.lblThongBao_MatKhau.TabIndex = 27;
            this.lblThongBao_MatKhau.Text = "Mật khẩu không trùng khớp";
            this.lblThongBao_MatKhau.Visible = false;
            // 
            // lblThanhCong
            // 
            this.lblThanhCong.AutoSize = true;
            this.lblThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThanhCong.Location = new System.Drawing.Point(586, 465);
            this.lblThanhCong.Name = "lblThanhCong";
            this.lblThanhCong.Size = new System.Drawing.Size(165, 25);
            this.lblThanhCong.TabIndex = 26;
            this.lblThanhCong.Text = "Thêm thành công";
            this.lblThanhCong.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
            // 
            // colMANV
            // 
            this.colMANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMANV.DataPropertyName = "MANV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colMANV.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.label5.Location = new System.Drawing.Point(556, 16);
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
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(180, 86);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(215, 28);
            this.cboNhanVien.TabIndex = 1;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            this.cboNhanVien.Leave += new System.EventHandler(this.cboNhanVien_Leave);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.grbPhanQuyen.Controls.Add(this.radNhanVienKeToan);
            this.grbPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbPhanQuyen.ForeColor = System.Drawing.Color.Purple;
            this.grbPhanQuyen.Location = new System.Drawing.Point(579, 159);
            this.grbPhanQuyen.Name = "grbPhanQuyen";
            this.grbPhanQuyen.Size = new System.Drawing.Size(219, 123);
            this.grbPhanQuyen.TabIndex = 17;
            this.grbPhanQuyen.TabStop = false;
            this.grbPhanQuyen.Text = "Cấp quyền";
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
            // radNhanVienKeToan
            // 
            this.radNhanVienKeToan.AutoSize = true;
            this.radNhanVienKeToan.Checked = true;
            this.radNhanVienKeToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNhanVienKeToan.ForeColor = System.Drawing.Color.Black;
            this.radNhanVienKeToan.Location = new System.Drawing.Point(12, 79);
            this.radNhanVienKeToan.Name = "radNhanVienKeToan";
            this.radNhanVienKeToan.Size = new System.Drawing.Size(144, 22);
            this.radNhanVienKeToan.TabIndex = 6;
            this.radNhanVienKeToan.TabStop = true;
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
            this.tpNhatKyTruyCap.BackColor = System.Drawing.SystemColors.Control;
            this.tpNhatKyTruyCap.Controls.Add(this.label13);
            this.tpNhatKyTruyCap.Controls.Add(this.label12);
            this.tpNhatKyTruyCap.Controls.Add(this.btnXemNhatKy);
            this.tpNhatKyTruyCap.Controls.Add(this.dtpNgayKetThuc);
            this.tpNhatKyTruyCap.Controls.Add(this.dtpNgayBatDau);
            this.tpNhatKyTruyCap.Controls.Add(this.grbSuKienNK);
            this.tpNhatKyTruyCap.Controls.Add(this.label7);
            this.tpNhatKyTruyCap.Location = new System.Drawing.Point(4, 27);
            this.tpNhatKyTruyCap.Name = "tpNhatKyTruyCap";
            this.tpNhatKyTruyCap.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhatKyTruyCap.Size = new System.Drawing.Size(1295, 649);
            this.tpNhatKyTruyCap.TabIndex = 3;
            this.tpNhatKyTruyCap.Text = "Nhật ký truy cập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 88;
            this.label13.Text = "Ngày kết thúc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "Ngày bắt đầu";
            // 
            // btnXemNhatKy
            // 
            this.btnXemNhatKy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXemNhatKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemNhatKy.Location = new System.Drawing.Point(908, 98);
            this.btnXemNhatKy.Name = "btnXemNhatKy";
            this.btnXemNhatKy.Size = new System.Drawing.Size(130, 43);
            this.btnXemNhatKy.TabIndex = 86;
            this.btnXemNhatKy.Text = "Xem nhật ký";
            this.btnXemNhatKy.UseVisualStyleBackColor = true;
            this.btnXemNhatKy.Click += new System.EventHandler(this.btnXemNhatKy_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(695, 108);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(187, 24);
            this.dtpNgayKetThuc.TabIndex = 85;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(384, 108);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(187, 24);
            this.dtpNgayBatDau.TabIndex = 84;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuKienNK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.colMaNK.Width = 60;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm:ss";
            this.colThoiGian.DefaultCellStyle = dataGridViewCellStyle4;
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
            // bk
            // 
            this.bk.BackColor = System.Drawing.SystemColors.Control;
            this.bk.Controls.Add(this.label11);
            this.bk.Controls.Add(this.groupBox2);
            this.bk.Controls.Add(this.groupBox1);
            this.bk.Location = new System.Drawing.Point(4, 27);
            this.bk.Name = "bk";
            this.bk.Padding = new System.Windows.Forms.Padding(3);
            this.bk.Size = new System.Drawing.Size(1295, 649);
            this.bk.TabIndex = 4;
            this.bk.Text = "Sao lưu & Khôi phục CSDL";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(337, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(578, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = "SAO LƯU VÀ KHÔI PHỤC CƠ SỞ DỮ LIỆU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Location = new System.Drawing.Point(219, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 36);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sao lưu dữ liệu thường xuyên để \r\nchúng được an toàn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDuongDanBAK);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Location = new System.Drawing.Point(479, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(16, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(519, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "*Lưu ý: Bạn có thể bị mất một số dữ liệu nếu chúng không có trong file sao lưu";
            // 
            // txtDuongDanBAK
            // 
            this.txtDuongDanBAK.Location = new System.Drawing.Point(265, 33);
            this.txtDuongDanBAK.Name = "txtDuongDanBAK";
            this.txtDuongDanBAK.Size = new System.Drawing.Size(243, 24);
            this.txtDuongDanBAK.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(514, 33);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(34, 24);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chọn đường dẫn chứa file sao lưu";
            // 
            // timer_ThanhCong
            // 
            this.timer_ThanhCong.Tick += new System.EventHandler(this.timer_ThanhCong_Tick);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBackup.ForeColor = System.Drawing.Color.Green;
            this.btnBackup.Image = global::GUI.Properties.Resources.backup_data_database_32;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(55, 133);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(126, 39);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRestore.ForeColor = System.Drawing.Color.Red;
            this.btnRestore.Image = global::GUI.Properties.Resources.restore_data_database_32;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(419, 133);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(129, 39);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Khôi phục";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ucQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbQuanTri);
            this.Name = "ucQuanTri";
            this.Size = new System.Drawing.Size(1303, 680);
            this.Load += new System.EventHandler(this.ucQuanTri_Load);
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
            this.bk.ResumeLayout(false);
            this.bk.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage bk;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtDuongDanBAK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThanhCong;
        private System.Windows.Forms.Timer timer_ThanhCong;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXemNhatKy;
        private System.Windows.Forms.Label lblThongBao_MatKhau;

    }
}
