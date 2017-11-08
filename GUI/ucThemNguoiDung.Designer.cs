namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbPhanQuyen = new System.Windows.Forms.GroupBox();
            this.radAdministrator = new System.Windows.Forms.RadioButton();
            this.radTraCuu = new System.Windows.Forms.RadioButton();
            this.radNhanVienKeToan = new System.Windows.Forms.RadioButton();
            this.grbThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.colMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPhanQuyen.SuspendLayout();
            this.grbThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(970, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 46);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(744, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 46);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbPhanQuyen
            // 
            this.grbPhanQuyen.Controls.Add(this.radAdministrator);
            this.grbPhanQuyen.Controls.Add(this.radTraCuu);
            this.grbPhanQuyen.Controls.Add(this.radNhanVienKeToan);
            this.grbPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbPhanQuyen.ForeColor = System.Drawing.Color.Purple;
            this.grbPhanQuyen.Location = new System.Drawing.Point(443, 90);
            this.grbPhanQuyen.Name = "grbPhanQuyen";
            this.grbPhanQuyen.Size = new System.Drawing.Size(219, 153);
            this.grbPhanQuyen.TabIndex = 9;
            this.grbPhanQuyen.TabStop = false;
            this.grbPhanQuyen.Text = "Phân Quyền";
            // 
            // radAdministrator
            // 
            this.radAdministrator.AutoSize = true;
            this.radAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radAdministrator.ForeColor = System.Drawing.Color.Black;
            this.radAdministrator.Location = new System.Drawing.Point(12, 33);
            this.radAdministrator.Name = "radAdministrator";
            this.radAdministrator.Size = new System.Drawing.Size(113, 22);
            this.radAdministrator.TabIndex = 6;
            this.radAdministrator.Text = "Administrator";
            this.radAdministrator.UseVisualStyleBackColor = true;
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
            this.radTraCuu.TabIndex = 5;
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
            this.radNhanVienKeToan.TabIndex = 4;
            this.radNhanVienKeToan.Text = "Nhân viên kế toán";
            this.radNhanVienKeToan.UseVisualStyleBackColor = true;
            // 
            // grbThongTinTaiKhoan
            // 
            this.grbThongTinTaiKhoan.Controls.Add(this.txtMaNV);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtXacNhanMK);
            this.grbThongTinTaiKhoan.Controls.Add(this.label4);
            this.grbThongTinTaiKhoan.Controls.Add(this.label3);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtMatKhau);
            this.grbThongTinTaiKhoan.Controls.Add(this.label1);
            this.grbThongTinTaiKhoan.Controls.Add(this.label2);
            this.grbThongTinTaiKhoan.Controls.Add(this.txtTenDN);
            this.grbThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinTaiKhoan.ForeColor = System.Drawing.Color.Purple;
            this.grbThongTinTaiKhoan.Location = new System.Drawing.Point(682, 90);
            this.grbThongTinTaiKhoan.Name = "grbThongTinTaiKhoan";
            this.grbThongTinTaiKhoan.Size = new System.Drawing.Size(396, 222);
            this.grbThongTinTaiKhoan.TabIndex = 8;
            this.grbThongTinTaiKhoan.TabStop = false;
            this.grbThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(175, 168);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(215, 29);
            this.txtXacNhanMK.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 168);
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
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cấp cho nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(175, 124);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(215, 29);
            this.txtMatKhau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 81);
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
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDN.Location = new System.Drawing.Point(175, 81);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(215, 29);
            this.txtTenDN.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(857, 375);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 46);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Lưu lại";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(449, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "THÊM TÀI KHOẢN";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.colTrangThai});
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 90);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(398, 331);
            this.dgvNhanVien.TabIndex = 14;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(175, 38);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(215, 29);
            this.txtMaNV.TabIndex = 8;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTrangThai.ForeColor = System.Drawing.Color.Red;
            this.chkTrangThai.Location = new System.Drawing.Point(455, 270);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(190, 22);
            this.chkTrangThai.TabIndex = 15;
            this.chkTrangThai.Text = "Vô hiệu hóa tài khoản";
            this.chkTrangThai.UseVisualStyleBackColor = true;
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
            this.colMANV.Width = 75;
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
            // ucThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkTrangThai);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbPhanQuyen);
            this.Controls.Add(this.grbThongTinTaiKhoan);
            this.Name = "ucThemNguoiDung";
            this.Size = new System.Drawing.Size(1129, 562);
            this.Load += new System.EventHandler(this.ucThemNguoiDung_Load);
            this.grbPhanQuyen.ResumeLayout(false);
            this.grbPhanQuyen.PerformLayout();
            this.grbThongTinTaiKhoan.ResumeLayout(false);
            this.grbThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbPhanQuyen;
        private System.Windows.Forms.GroupBox grbThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.RadioButton radAdministrator;
        private System.Windows.Forms.RadioButton radTraCuu;
        private System.Windows.Forms.RadioButton radNhanVienKeToan;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
