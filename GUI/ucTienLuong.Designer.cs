namespace GUI
{
    partial class ucTienLuong
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
            this.tCtrl = new System.Windows.Forms.TabControl();
            this.tPChamCong = new System.Windows.Forms.TabPage();
            this.btnInChamCong = new System.Windows.Forms.Button();
            this.grbTaoBangChamCong = new System.Windows.Forms.GroupBox();
            this.btnTaoBangChamCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.colMaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBangChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCtrl.SuspendLayout();
            this.tPChamCong.SuspendLayout();
            this.grbTaoBangChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // tCtrl
            // 
            this.tCtrl.Controls.Add(this.tPChamCong);
            this.tCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tCtrl.Location = new System.Drawing.Point(0, 0);
            this.tCtrl.Name = "tCtrl";
            this.tCtrl.SelectedIndex = 0;
            this.tCtrl.Size = new System.Drawing.Size(1303, 680);
            this.tCtrl.TabIndex = 0;
            // 
            // tPChamCong
            // 
            this.tPChamCong.BackColor = System.Drawing.SystemColors.Control;
            this.tPChamCong.Controls.Add(this.btnInChamCong);
            this.tPChamCong.Controls.Add(this.grbTaoBangChamCong);
            this.tPChamCong.Controls.Add(this.label14);
            this.tPChamCong.Controls.Add(this.dgvChamCong);
            this.tPChamCong.Location = new System.Drawing.Point(4, 27);
            this.tPChamCong.Name = "tPChamCong";
            this.tPChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tPChamCong.Size = new System.Drawing.Size(1295, 649);
            this.tPChamCong.TabIndex = 0;
            this.tPChamCong.Text = "Chấm công";
            // 
            // btnInChamCong
            // 
            this.btnInChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInChamCong.Location = new System.Drawing.Point(1182, 597);
            this.btnInChamCong.Name = "btnInChamCong";
            this.btnInChamCong.Size = new System.Drawing.Size(107, 46);
            this.btnInChamCong.TabIndex = 17;
            this.btnInChamCong.Text = "In";
            this.btnInChamCong.UseVisualStyleBackColor = true;
            this.btnInChamCong.Click += new System.EventHandler(this.btnInChamCong_Click);
            // 
            // grbTaoBangChamCong
            // 
            this.grbTaoBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTaoBangChamCong.Controls.Add(this.btnTaoBangChamCong);
            this.grbTaoBangChamCong.Controls.Add(this.label3);
            this.grbTaoBangChamCong.Controls.Add(this.nudNam);
            this.grbTaoBangChamCong.Controls.Add(this.cboThang);
            this.grbTaoBangChamCong.Controls.Add(this.label1);
            this.grbTaoBangChamCong.Location = new System.Drawing.Point(6, 39);
            this.grbTaoBangChamCong.Name = "grbTaoBangChamCong";
            this.grbTaoBangChamCong.Size = new System.Drawing.Size(1283, 103);
            this.grbTaoBangChamCong.TabIndex = 7;
            this.grbTaoBangChamCong.TabStop = false;
            this.grbTaoBangChamCong.Text = "Tạo bảng chấm công";
            // 
            // btnTaoBangChamCong
            // 
            this.btnTaoBangChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaoBangChamCong.Location = new System.Drawing.Point(778, 23);
            this.btnTaoBangChamCong.Name = "btnTaoBangChamCong";
            this.btnTaoBangChamCong.Size = new System.Drawing.Size(107, 46);
            this.btnTaoBangChamCong.TabIndex = 8;
            this.btnTaoBangChamCong.Text = "Tạo bảng";
            this.btnTaoBangChamCong.UseVisualStyleBackColor = true;
            this.btnTaoBangChamCong.Click += new System.EventHandler(this.btnTaoBangChamCong_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm";
            // 
            // nudNam
            // 
            this.nudNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNam.Location = new System.Drawing.Point(647, 34);
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(85, 24);
            this.nudNam.TabIndex = 3;
            this.nudNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboThang
            // 
            this.cboThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboThang.Location = new System.Drawing.Point(472, 34);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(85, 26);
            this.cboThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(400, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(358, 31);
            this.label14.TabIndex = 6;
            this.label14.Text = "CHẤM CÔNG NHÂN VIÊN";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToResizeColumns = false;
            this.dgvChamCong.AllowUserToResizeRows = false;
            this.dgvChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChamCong,
            this.colThang,
            this.colNam,
            this.colTenBangChamCong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChamCong.EnableHeadersVisualStyles = false;
            this.dgvChamCong.Location = new System.Drawing.Point(6, 148);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(1286, 443);
            this.dgvChamCong.TabIndex = 0;
            this.dgvChamCong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellDoubleClick);
            this.dgvChamCong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChamCong_CellFormatting);
            // 
            // colMaChamCong
            // 
            this.colMaChamCong.DataPropertyName = "MACC";
            this.colMaChamCong.HeaderText = "Mã chấm công";
            this.colMaChamCong.Name = "colMaChamCong";
            this.colMaChamCong.ReadOnly = true;
            this.colMaChamCong.Width = 200;
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "THANG";
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            this.colThang.ReadOnly = true;
            this.colThang.Width = 200;
            // 
            // colNam
            // 
            this.colNam.DataPropertyName = "NAM";
            this.colNam.HeaderText = "Năm";
            this.colNam.Name = "colNam";
            this.colNam.ReadOnly = true;
            this.colNam.Width = 200;
            // 
            // colTenBangChamCong
            // 
            this.colTenBangChamCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenBangChamCong.DataPropertyName = "TENBANG";
            this.colTenBangChamCong.HeaderText = "Tên bảng chấm công";
            this.colTenBangChamCong.Name = "colTenBangChamCong";
            this.colTenBangChamCong.ReadOnly = true;
            // 
            // ucTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tCtrl);
            this.Name = "ucTienLuong";
            this.Size = new System.Drawing.Size(1303, 680);
            this.Load += new System.EventHandler(this.ucTienLuong_Load);
            this.tCtrl.ResumeLayout(false);
            this.tPChamCong.ResumeLayout(false);
            this.tPChamCong.PerformLayout();
            this.grbTaoBangChamCong.ResumeLayout(false);
            this.grbTaoBangChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCtrl;
        private System.Windows.Forms.TabPage tPChamCong;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grbTaoBangChamCong;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnTaoBangChamCong;
        private System.Windows.Forms.Button btnInChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBangChamCong;

    }
}
