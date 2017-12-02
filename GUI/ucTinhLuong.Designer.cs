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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvTienLuong = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoNgayKP = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoNgayP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoGioCong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoNgayDiLam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayKhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayNghiCoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            // btnRefesh
            // 
            this.btnRefesh.Image = global::GUI.Properties.Resources._1396445209_Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(787, 196);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 39);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số ngày nghỉ không phép:";
            // 
            // lblSoNgayKP
            // 
            this.lblSoNgayKP.AutoSize = true;
            this.lblSoNgayKP.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayKP.Location = new System.Drawing.Point(1090, 98);
            this.lblSoNgayKP.Name = "lblSoNgayKP";
            this.lblSoNgayKP.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayKP.TabIndex = 11;
            this.lblSoNgayKP.Text = "XXX";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(620, 97);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(59, 24);
            this.txtMaPhong.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Phòng";
            // 
            // lblSoNgayP
            // 
            this.lblSoNgayP.AutoSize = true;
            this.lblSoNgayP.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayP.Location = new System.Drawing.Point(1090, 132);
            this.lblSoNgayP.Name = "lblSoNgayP";
            this.lblSoNgayP.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayP.TabIndex = 15;
            this.lblSoNgayP.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số ngày nghỉ có phép:";
            // 
            // lblSoGioCong
            // 
            this.lblSoGioCong.AutoSize = true;
            this.lblSoGioCong.ForeColor = System.Drawing.Color.Red;
            this.lblSoGioCong.Location = new System.Drawing.Point(1090, 165);
            this.lblSoGioCong.Name = "lblSoGioCong";
            this.lblSoGioCong.Size = new System.Drawing.Size(38, 18);
            this.lblSoGioCong.TabIndex = 17;
            this.lblSoGioCong.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(942, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng số giờ công:";
            // 
            // lblSoNgayDiLam
            // 
            this.lblSoNgayDiLam.AutoSize = true;
            this.lblSoNgayDiLam.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayDiLam.Location = new System.Drawing.Point(1092, 65);
            this.lblSoNgayDiLam.Name = "lblSoNgayDiLam";
            this.lblSoNgayDiLam.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayDiLam.TabIndex = 19;
            this.lblSoNgayDiLam.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(883, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số ngày đi làm trong tháng:\r\n";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.ForeColor = System.Drawing.Color.Red;
            this.lblLuong.Location = new System.Drawing.Point(1090, 196);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(41, 18);
            this.lblLuong.TabIndex = 21;
            this.lblLuong.Text = "XXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lương dự kiến:";
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
            // colMaNV
            // 
            this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaNV.DefaultCellStyle = dataGridViewCellStyle31;
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 78;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHoTen.DefaultCellStyle = dataGridViewCellStyle32;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colSoNgayDiLam
            // 
            this.colSoNgayDiLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayDiLam.DataPropertyName = "SoNgayDiLam";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayDiLam.DefaultCellStyle = dataGridViewCellStyle33;
            this.colSoNgayDiLam.HeaderText = "Số ngày đi làm";
            this.colSoNgayDiLam.Name = "colSoNgayDiLam";
            this.colSoNgayDiLam.Width = 130;
            // 
            // colSoNgayKhongPhep
            // 
            this.colSoNgayKhongPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayKhongPhep.DataPropertyName = "SoNgayNghiKhongPhep";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayKhongPhep.DefaultCellStyle = dataGridViewCellStyle34;
            this.colSoNgayKhongPhep.HeaderText = "Nghỉ không phép (Ngày)";
            this.colSoNgayKhongPhep.Name = "colSoNgayKhongPhep";
            this.colSoNgayKhongPhep.Width = 135;
            // 
            // colSoNgayNghiCoPhep
            // 
            this.colSoNgayNghiCoPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSoNgayNghiCoPhep.DataPropertyName = "SoNgayNghiCoPhep";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoNgayNghiCoPhep.DefaultCellStyle = dataGridViewCellStyle35;
            this.colSoNgayNghiCoPhep.HeaderText = "Nghỉ có phép (Ngày)";
            this.colSoNgayNghiCoPhep.Name = "colSoNgayNghiCoPhep";
            this.colSoNgayNghiCoPhep.Width = 114;
            // 
            // colTienLuong
            // 
            this.colTienLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTienLuong.DataPropertyName = "TienLuong";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "#,### VNĐ";
            this.colTienLuong.DefaultCellStyle = dataGridViewCellStyle36;
            this.colTienLuong.HeaderText = "Tiền lương";
            this.colTienLuong.Name = "colTienLuong";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(685, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "<-- (1)  PB2 để test KQ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(673, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "(2) Nhấn vô -->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Làm giùm t cái chọn \r\nmấy thông số hàm băng CBO\'";
            // 
            // ucTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoNgayDiLam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSoGioCong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSoNgayP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblSoNgayKP);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoNgayKP;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoNgayP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoGioCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoNgayDiLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
