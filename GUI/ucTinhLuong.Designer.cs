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
            this.label14 = new System.Windows.Forms.Label();
            this.dgvTienLuong = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayKhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayNghiCoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
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
            this.label14.Size = new System.Drawing.Size(193, 31);
            this.label14.TabIndex = 7;
            this.label14.Text = "TÍNH LƯƠNG";
            // 
            // dgvTienLuong
            // 
            this.dgvTienLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colSoNgayDiLam,
            this.colSoNgayKhongPhep,
            this.colSoNgayNghiCoPhep,
            this.colTienLuong});
            this.dgvTienLuong.Location = new System.Drawing.Point(129, 271);
            this.dgvTienLuong.Name = "dgvTienLuong";
            this.dgvTienLuong.RowHeadersVisible = false;
            this.dgvTienLuong.Size = new System.Drawing.Size(853, 279);
            this.dgvTienLuong.TabIndex = 8;
            // 
            // colMaNV
            // 
            this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaNV.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 54;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHoTen.DefaultCellStyle = dataGridViewCellStyle2;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colSoNgayDiLam
            // 
            this.colSoNgayDiLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayDiLam.DataPropertyName = "SoNgayDiLam";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayDiLam.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSoNgayDiLam.HeaderText = "Số ngày đi làm";
            this.colSoNgayDiLam.Name = "colSoNgayDiLam";
            this.colSoNgayDiLam.Width = 97;
            // 
            // colSoNgayKhongPhep
            // 
            this.colSoNgayKhongPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayKhongPhep.DataPropertyName = "SoNgayNghiKhongPhep";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayKhongPhep.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSoNgayKhongPhep.HeaderText = "Nghỉ không phép (Ngày)";
            this.colSoNgayKhongPhep.Name = "colSoNgayKhongPhep";
            this.colSoNgayKhongPhep.Width = 135;
            // 
            // colSoNgayNghiCoPhep
            // 
            this.colSoNgayNghiCoPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayNghiCoPhep.DataPropertyName = "SoNgayNghiCoPhep";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayNghiCoPhep.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSoNgayNghiCoPhep.HeaderText = "Nghỉ có phép (Ngày)";
            this.colSoNgayNghiCoPhep.Name = "colSoNgayNghiCoPhep";
            this.colSoNgayNghiCoPhep.Width = 114;
            // 
            // colTienLuong
            // 
            this.colTienLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTienLuong.DataPropertyName = "TienLuong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,### VNĐ";
            this.colTienLuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTienLuong.HeaderText = "Tiền lương";
            this.colTienLuong.Name = "colTienLuong";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::GUI.Properties.Resources._1396445209_Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(734, 119);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 39);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phòng ban:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tháng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Năm:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(343, 100);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(168, 26);
            this.cboPhongBan.TabIndex = 25;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(343, 137);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(168, 26);
            this.cboThang.TabIndex = 26;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(343, 174);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(168, 24);
            this.txtNam.TabIndex = 27;
            // 
            // ucTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayKhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayNghiCoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienLuong;
    }
}
