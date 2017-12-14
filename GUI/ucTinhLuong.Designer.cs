namespace GUI
{
    partial class ucTinhLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvTienLuong = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayKhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayNghiCoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongThuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnInBangLuong = new System.Windows.Forms.Button();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(534, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 31);
            this.label14.TabIndex = 7;
            this.label14.Text = "TIỀN LƯƠNG";
            // 
            // dgvTienLuong
            // 
            this.dgvTienLuong.AllowUserToResizeColumns = false;
            this.dgvTienLuong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTienLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTienLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colSoNgayDiLam,
            this.colSoNgayKhongPhep,
            this.colSoNgayNghiCoPhep,
            this.colTongThuNhap,
            this.colBHXH,
            this.colBHYT,
            this.colBHTN,
            this.colTienLuong,
            this.colThang,
            this.colNam});
            this.dgvTienLuong.Location = new System.Drawing.Point(51, 193);
            this.dgvTienLuong.MultiSelect = false;
            this.dgvTienLuong.Name = "dgvTienLuong";
            this.dgvTienLuong.ReadOnly = true;
            this.dgvTienLuong.RowHeadersVisible = false;
            this.dgvTienLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTienLuong.Size = new System.Drawing.Size(1182, 362);
            this.dgvTienLuong.TabIndex = 8;
            // 
            // colMaNV
            // 
            this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Width = 54;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHoTen.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colSoNgayDiLam
            // 
            this.colSoNgayDiLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayDiLam.DataPropertyName = "SoNgayDiLam";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayDiLam.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSoNgayDiLam.HeaderText = "Số ngày đi làm";
            this.colSoNgayDiLam.Name = "colSoNgayDiLam";
            this.colSoNgayDiLam.ReadOnly = true;
            this.colSoNgayDiLam.Width = 97;
            // 
            // colSoNgayKhongPhep
            // 
            this.colSoNgayKhongPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayKhongPhep.DataPropertyName = "SoNgayNghiKhongPhep";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayKhongPhep.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSoNgayKhongPhep.HeaderText = "Nghỉ không phép (Ngày)";
            this.colSoNgayKhongPhep.Name = "colSoNgayKhongPhep";
            this.colSoNgayKhongPhep.ReadOnly = true;
            this.colSoNgayKhongPhep.Width = 135;
            // 
            // colSoNgayNghiCoPhep
            // 
            this.colSoNgayNghiCoPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayNghiCoPhep.DataPropertyName = "SoNgayNghiCoPhep";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayNghiCoPhep.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSoNgayNghiCoPhep.HeaderText = "Nghỉ có phép (Ngày)";
            this.colSoNgayNghiCoPhep.Name = "colSoNgayNghiCoPhep";
            this.colSoNgayNghiCoPhep.ReadOnly = true;
            this.colSoNgayNghiCoPhep.Width = 114;
            // 
            // colTongThuNhap
            // 
            this.colTongThuNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTongThuNhap.DataPropertyName = "TongThuNhap";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,###";
            this.colTongThuNhap.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTongThuNhap.HeaderText = "Tổng thu nhập (VNĐ)";
            this.colTongThuNhap.Name = "colTongThuNhap";
            this.colTongThuNhap.ReadOnly = true;
            // 
            // colBHXH
            // 
            this.colBHXH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBHXH.DataPropertyName = "BHXH";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,###";
            this.colBHXH.DefaultCellStyle = dataGridViewCellStyle8;
            this.colBHXH.HeaderText = "*BHXH (VNĐ)";
            this.colBHXH.Name = "colBHXH";
            this.colBHXH.ReadOnly = true;
            this.colBHXH.Width = 115;
            // 
            // colBHYT
            // 
            this.colBHYT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBHYT.DataPropertyName = "BHYT";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,###";
            this.colBHYT.DefaultCellStyle = dataGridViewCellStyle9;
            this.colBHYT.HeaderText = "*BHYT (VNĐ)";
            this.colBHYT.Name = "colBHYT";
            this.colBHYT.ReadOnly = true;
            this.colBHYT.Width = 113;
            // 
            // colBHTN
            // 
            this.colBHTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBHTN.DataPropertyName = "BHTN";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,###";
            this.colBHTN.DefaultCellStyle = dataGridViewCellStyle10;
            this.colBHTN.HeaderText = "*BHTN (VNĐ)";
            this.colBHTN.Name = "colBHTN";
            this.colBHTN.ReadOnly = true;
            this.colBHTN.Width = 114;
            // 
            // colTienLuong
            // 
            this.colTienLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTienLuong.DataPropertyName = "TienLuong";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,### VNĐ";
            this.colTienLuong.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTienLuong.HeaderText = "Tiền lương";
            this.colTienLuong.Name = "colTienLuong";
            this.colTienLuong.ReadOnly = true;
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "Thang";
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            this.colThang.ReadOnly = true;
            this.colThang.Visible = false;
            // 
            // colNam
            // 
            this.colNam.DataPropertyName = "Nam";
            this.colNam.HeaderText = "Năm";
            this.colNam.Name = "colNam";
            this.colNam.ReadOnly = true;
            this.colNam.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phòng ban:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(557, 103);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(168, 26);
            this.cboPhongBan.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(60, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "(*)Các khoản trích trừ vào lương: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(314, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "BHXH, BHYT, BHTN";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::GUI.Properties.Resources._1396445209_Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(816, 107);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 39);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnInBangLuong
            // 
            this.btnInBangLuong.Location = new System.Drawing.Point(1083, 595);
            this.btnInBangLuong.Name = "btnInBangLuong";
            this.btnInBangLuong.Size = new System.Drawing.Size(150, 45);
            this.btnInBangLuong.TabIndex = 32;
            this.btnInBangLuong.Text = "In bảng lương";
            this.btnInBangLuong.UseVisualStyleBackColor = true;
            this.btnInBangLuong.Click += new System.EventHandler(this.btnInBangLuong_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(557, 151);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.ShowUpDown = true;
            this.dtpThangNam.Size = new System.Drawing.Size(168, 24);
            this.dtpThangNam.TabIndex = 34;
            // 
            // ucTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.btnInBangLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.dgvTienLuong);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTinhLuong";
            this.Size = new System.Drawing.Size(1303, 680);
            this.Load += new System.EventHandler(this.ucTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvTienLuong;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayKhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayNghiCoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongThuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.Button btnInBangLuong;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
    }
}
