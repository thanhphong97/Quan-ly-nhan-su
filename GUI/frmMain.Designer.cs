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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLNghiPhep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNghiPhep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuyDnhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.grbThongTinUser = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnuMain.SuspendLayout();
            this.grbThongTinUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuNhanVien,
            this.mnuTinhLuong,
            this.mnuQuyDnhLuong});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1129, 84);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNV});
            this.mnuAdmin.Image = global::GUI.Properties.Resources.manage;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(176, 80);
            this.mnuAdmin.Text = "ADMINISTRATOR";
            // 
            // mnuThemNV
            // 
            this.mnuThemNV.Name = "mnuThemNV";
            this.mnuThemNV.Size = new System.Drawing.Size(180, 24);
            this.mnuThemNV.Text = "Thêm Nhân Viên";
            this.mnuThemNV.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSNhanVien,
            this.toolStripSeparator1,
            this.mnuQLNghiPhep,
            this.mnuDSNghiPhep});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(85, 80);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuDSNhanVien
            // 
            this.mnuDSNhanVien.Name = "mnuDSNhanVien";
            this.mnuDSNhanVien.Size = new System.Drawing.Size(211, 24);
            this.mnuDSNhanVien.Text = "Danh Sách Nhân Viên";
            this.mnuDSNhanVien.Click += new System.EventHandler(this.mnuDSNhanVien_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuQLNghiPhep
            // 
            this.mnuQLNghiPhep.Name = "mnuQLNghiPhep";
            this.mnuQLNghiPhep.Size = new System.Drawing.Size(211, 24);
            this.mnuQLNghiPhep.Text = "Quản Lý Nghỉ Phép";
            // 
            // mnuDSNghiPhep
            // 
            this.mnuDSNghiPhep.Name = "mnuDSNghiPhep";
            this.mnuDSNghiPhep.Size = new System.Drawing.Size(211, 24);
            this.mnuDSNghiPhep.Text = "Danh Sách Nghỉ Phép";
            // 
            // mnuTinhLuong
            // 
            this.mnuTinhLuong.Name = "mnuTinhLuong";
            this.mnuTinhLuong.Size = new System.Drawing.Size(90, 80);
            this.mnuTinhLuong.Text = "Tính Lương";
            // 
            // mnuQuyDnhLuong
            // 
            this.mnuQuyDnhLuong.Name = "mnuQuyDnhLuong";
            this.mnuQuyDnhLuong.Size = new System.Drawing.Size(123, 80);
            this.mnuQuyDnhLuong.Text = "Quy Định Lương";
            // 
            // grbThongTinUser
            // 
            this.grbThongTinUser.Controls.Add(this.btnDangXuat);
            this.grbThongTinUser.Controls.Add(this.lblTenNguoiDung);
            this.grbThongTinUser.Location = new System.Drawing.Point(910, 1);
            this.grbThongTinUser.Name = "grbThongTinUser";
            this.grbThongTinUser.Size = new System.Drawing.Size(218, 77);
            this.grbThongTinUser.TabIndex = 1;
            this.grbThongTinUser.TabStop = false;
            this.grbThongTinUser.Text = "User";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::GUI.Properties.Resources.DangXuat;
            this.btnDangXuat.Location = new System.Drawing.Point(164, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(48, 59);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Location = new System.Drawing.Point(6, 26);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(152, 21);
            this.lblTenNguoiDung.TabIndex = 0;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 84);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1129, 588);
            this.pnlMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 672);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.grbThongTinUser);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm mềm quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grbThongTinUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuyDnhLuong;
        private System.Windows.Forms.GroupBox grbThongTinUser;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuTinhLuong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNghiPhep;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNghiPhep;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNV;
    }
}

