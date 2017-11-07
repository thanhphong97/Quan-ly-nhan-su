namespace GUI
{
    partial class frmPhongBan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colMaPB,
            this.colTenPB});
            this.dgvPhongBan.EnableHeadersVisualStyles = false;
            this.dgvPhongBan.Location = new System.Drawing.Point(13, 0);
            this.dgvPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(596, 235);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            // 
            // colChk
            // 
            this.colChk.HeaderText = "Chọn";
            this.colChk.Name = "colChk";
            this.colChk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMaPB
            // 
            this.colMaPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPB.DataPropertyName = "MAPB";
            this.colMaPB.HeaderText = "Mã phòng ban";
            this.colMaPB.Name = "colMaPB";
            this.colMaPB.ReadOnly = true;
            // 
            // colTenPB
            // 
            this.colTenPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenPB.DataPropertyName = "TENPB";
            this.colTenPB.HeaderText = "Tên phòng ban";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.ReadOnly = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongY.Location = new System.Drawing.Point(390, 242);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(107, 46);
            this.btnDongY.TabIndex = 13;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Location = new System.Drawing.Point(502, 242);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 46);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 300);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.dgvPhongBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công phòng ban";
            this.Load += new System.EventHandler(this.frmChamCongPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
    }
}