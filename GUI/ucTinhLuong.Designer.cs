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
            this.label14 = new System.Windows.Forms.Label();
            this.dgvTienLuong = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoNgayKP = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoNgayP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoGioCong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoNgayDiLam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dgvTienLuong.Location = new System.Drawing.Point(32, 267);
            this.dgvTienLuong.Name = "dgvTienLuong";
            this.dgvTienLuong.Size = new System.Drawing.Size(1145, 279);
            this.dgvTienLuong.TabIndex = 8;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::GUI.Properties.Resources._1396445209_Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(785, 158);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 39);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số ngày nghỉ không phép:";
            // 
            // lblSoNgayKP
            // 
            this.lblSoNgayKP.AutoSize = true;
            this.lblSoNgayKP.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayKP.Location = new System.Drawing.Point(382, 130);
            this.lblSoNgayKP.Name = "lblSoNgayKP";
            this.lblSoNgayKP.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayKP.TabIndex = 11;
            this.lblSoNgayKP.Text = "XXX";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(237, 57);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(59, 24);
            this.txtMaNV.TabIndex = 12;
            this.txtMaNV.Text = "nv95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "MaNV";
            // 
            // lblSoNgayP
            // 
            this.lblSoNgayP.AutoSize = true;
            this.lblSoNgayP.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayP.Location = new System.Drawing.Point(382, 164);
            this.lblSoNgayP.Name = "lblSoNgayP";
            this.lblSoNgayP.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayP.TabIndex = 15;
            this.lblSoNgayP.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số ngày nghỉ có phép:";
            // 
            // lblSoGioCong
            // 
            this.lblSoGioCong.AutoSize = true;
            this.lblSoGioCong.ForeColor = System.Drawing.Color.Red;
            this.lblSoGioCong.Location = new System.Drawing.Point(382, 197);
            this.lblSoGioCong.Name = "lblSoGioCong";
            this.lblSoGioCong.Size = new System.Drawing.Size(38, 18);
            this.lblSoGioCong.TabIndex = 17;
            this.lblSoGioCong.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng số giờ công:";
            // 
            // lblSoNgayDiLam
            // 
            this.lblSoNgayDiLam.AutoSize = true;
            this.lblSoNgayDiLam.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayDiLam.Location = new System.Drawing.Point(384, 97);
            this.lblSoNgayDiLam.Name = "lblSoNgayDiLam";
            this.lblSoNgayDiLam.Size = new System.Drawing.Size(38, 18);
            this.lblSoNgayDiLam.TabIndex = 19;
            this.lblSoNgayDiLam.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 97);
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
            this.lblLuong.Location = new System.Drawing.Point(382, 228);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(41, 18);
            this.lblLuong.TabIndex = 21;
            this.lblLuong.Text = "XXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lương dự kiến:";
            // 
            // ucTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoNgayDiLam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSoGioCong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSoNgayP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
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
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoNgayP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoGioCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoNgayDiLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label label5;
    }
}
