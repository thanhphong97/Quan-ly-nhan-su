namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnuMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.a = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbtnQuanTri = new System.Windows.Forms.ToolStripButton();
            this.tbtnNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tbtLuong = new System.Windows.Forms.ToolStripButton();
            this.tbtnQuyDInhLuong = new System.Windows.Forms.ToolStripButton();
            this.tbtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.btnTienLuong = new System.Windows.Forms.ToolStripButton();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 673);
            this.pnlMain.TabIndex = 2;
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuanTri,
            this.toolStripSeparator1,
            this.tbtnNhanVien,
            this.toolStripSeparator2,
            this.tbtLuong,
            this.toolStripSeparator3,
            this.tbtnQuyDInhLuong,
            this.tbtnDangXuat,
            this.a,
            this.toolStripSeparator4,
            this.lblNguoiDung,
            this.toolStripLabel1,
            this.btnTienLuong});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1264, 57);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // a
            // 
            this.a.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(113, 54);
            this.lblNguoiDung.Text = "Tên người dùng";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 54);
            this.toolStripLabel1.Text = "Xin chào:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbtnQuanTri
            // 
            this.tbtnQuanTri.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbtnQuanTri.Image = global::GUI.Properties.Resources.manager;
            this.tbtnQuanTri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuanTri.Name = "tbtnQuanTri";
            this.tbtnQuanTri.Size = new System.Drawing.Size(116, 54);
            this.tbtnQuanTri.Text = "Quản trị";
            this.tbtnQuanTri.Click += new System.EventHandler(this.tbtnQuanTri_Click);
            // 
            // tbtnNhanVien
            // 
            this.tbtnNhanVien.Image = global::GUI.Properties.Resources.employee;
            this.tbtnNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNhanVien.Name = "tbtnNhanVien";
            this.tbtnNhanVien.Size = new System.Drawing.Size(129, 54);
            this.tbtnNhanVien.Text = "Nhân viên";
            this.tbtnNhanVien.Click += new System.EventHandler(this.tbtnNhanVien_Click);
            // 
            // tbtLuong
            // 
            this.tbtLuong.Image = global::GUI.Properties.Resources.salary;
            this.tbtLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtLuong.Name = "tbtLuong";
            this.tbtLuong.Size = new System.Drawing.Size(138, 54);
            this.tbtLuong.Text = "Chấm công";
            this.tbtLuong.Click += new System.EventHandler(this.tbtLuong_Click);
            // 
            // tbtnQuyDInhLuong
            // 
            this.tbtnQuyDInhLuong.Image = global::GUI.Properties.Resources.school_material;
            this.tbtnQuyDInhLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuyDInhLuong.Name = "tbtnQuyDInhLuong";
            this.tbtnQuyDInhLuong.Size = new System.Drawing.Size(165, 54);
            this.tbtnQuyDInhLuong.Text = "Quy định lương";
            this.tbtnQuyDInhLuong.Click += new System.EventHandler(this.tbtnQuyDInhLuong_Click);
            // 
            // tbtnDangXuat
            // 
            this.tbtnDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDangXuat.Image = global::GUI.Properties.Resources.DangXuat;
            this.tbtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDangXuat.Name = "tbtnDangXuat";
            this.tbtnDangXuat.Size = new System.Drawing.Size(54, 54);
            this.tbtnDangXuat.Text = "Đăng xuất";
            this.tbtnDangXuat.Click += new System.EventHandler(this.tbtnDangXuat_Click);
            // 
            // btnTienLuong
            // 
            this.btnTienLuong.Image = global::GUI.Properties.Resources.invention1;
            this.btnTienLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTienLuong.Name = "btnTienLuong";
            this.btnTienLuong.Size = new System.Drawing.Size(137, 54);
            this.btnTienLuong.Text = "Tiền Lương";
            this.btnTienLuong.Click += new System.EventHandler(this.btnTienLuong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm mềm quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip mnuMain;
        private System.Windows.Forms.ToolStripButton tbtnQuanTri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtLuong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnQuyDInhLuong;
        private System.Windows.Forms.ToolStripButton tbtnDangXuat;
        private System.Windows.Forms.ToolStripSeparator a;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblNguoiDung;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnTienLuong;
    }
}

