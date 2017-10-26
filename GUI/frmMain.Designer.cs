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
            this.mnuTinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuyDnhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.grbThongTinUser = new System.Windows.Forms.GroupBox();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLNghiPhep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNghiPhep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.grbThongTinUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackColor = System.Drawing.SystemColors.Menu;
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
            // mnuTinhLuong
            // 
            this.mnuTinhLuong.Image = global::GUI.Properties.Resources.inventory_box_shipment_product_32;
            this.mnuTinhLuong.Name = "mnuTinhLuong";
            this.mnuTinhLuong.Size = new System.Drawing.Size(139, 80);
            this.mnuTinhLuong.Text = "Tiền Lương";
            // 
            // mnuQuyDnhLuong
            // 
            this.mnuQuyDnhLuong.Image = global::GUI.Properties.Resources.sua;
            this.mnuQuyDnhLuong.Name = "mnuQuyDnhLuong";
            this.mnuQuyDnhLuong.Size = new System.Drawing.Size(173, 80);
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
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNguoiDung});
            this.mnuAdmin.Image = global::GUI.Properties.Resources._1396445934_users_business;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(176, 80);
            this.mnuAdmin.Text = "ADMINISTRATOR";
            // 
            // mnuThemNguoiDung
            // 
            this.mnuThemNguoiDung.Name = "mnuThemNguoiDung";
            this.mnuThemNguoiDung.Size = new System.Drawing.Size(191, 24);
            this.mnuThemNguoiDung.Text = "Thêm Người Dùng";
            this.mnuThemNguoiDung.Click += new System.EventHandler(this.mnuThemNguoiDung_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSNhanVien,
            this.toolStripSeparator1,
            this.mnuQLNghiPhep,
            this.mnuDSNghiPhep,
            this.toolStripSeparator2,
            this.tToolStripMenuItem});
            this.mnuNhanVien.Image = global::GUI.Properties.Resources.man_user_male_human_people_32;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(135, 80);
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
            this.mnuDSNghiPhep.Click += new System.EventHandler(this.mnuDSNghiPhep_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.tToolStripMenuItem.Text = "Thêm Nhân Viên";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem mnuThemNguoiDung;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
    }
}

