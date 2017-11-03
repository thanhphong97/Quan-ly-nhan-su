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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDSNghiPhep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuyDnhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôiPhụcDữLieu65ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.Image = global::GUI.Properties.Resources.DangXuat;
            this.btnDangXuat.Location = new System.Drawing.Point(1052, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(74, 61);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 61);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1129, 576);
            this.pnlMain.TabIndex = 2;
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNguoiDung,
            this.saoLưuDữLiệuToolStripMenuItem,
            this.khôiPhụcDữLieu65ToolStripMenuItem});
            this.mnuAdmin.Image = global::GUI.Properties.Resources._1396445934_users_business;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(137, 57);
            this.mnuAdmin.Text = "Quản Trị";
            // 
            // mnuThemNguoiDung
            // 
            this.mnuThemNguoiDung.Name = "mnuThemNguoiDung";
            this.mnuThemNguoiDung.Size = new System.Drawing.Size(209, 26);
            this.mnuThemNguoiDung.Text = "Thêm Người Dùng";
            this.mnuThemNguoiDung.Click += new System.EventHandler(this.mnuThemNguoiDung_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNhanVien,
            this.toolStripSeparator1,
            this.mnuDSNghiPhep,
            this.toolStripSeparator2});
            this.mnuNhanVien.Image = global::GUI.Properties.Resources.man_user_male_human_people_32;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(150, 71);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuThemNhanVien
            // 
            this.mnuThemNhanVien.Name = "mnuThemNhanVien";
            this.mnuThemNhanVien.Size = new System.Drawing.Size(234, 26);
            this.mnuThemNhanVien.Text = "Danh Sách Nhân Viên";
            this.mnuThemNhanVien.Click += new System.EventHandler(this.mnuThemNhanVien_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuDSNghiPhep
            // 
            this.mnuDSNghiPhep.Name = "mnuDSNghiPhep";
            this.mnuDSNghiPhep.Size = new System.Drawing.Size(234, 26);
            this.mnuDSNghiPhep.Text = "Danh Sách Thân Nhân";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuTinhLuong
            // 
            this.mnuTinhLuong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chấmCôngToolStripMenuItem});
            this.mnuTinhLuong.Image = global::GUI.Properties.Resources.inventory_box_shipment_product_32;
            this.mnuTinhLuong.Name = "mnuTinhLuong";
            this.mnuTinhLuong.Size = new System.Drawing.Size(155, 71);
            this.mnuTinhLuong.Text = "Tiền Lương";
            // 
            // mnuQuyDnhLuong
            // 
            this.mnuQuyDnhLuong.Image = global::GUI.Properties.Resources.phongban1;
            this.mnuQuyDnhLuong.Name = "mnuQuyDnhLuong";
            this.mnuQuyDnhLuong.Size = new System.Drawing.Size(192, 71);
            this.mnuQuyDnhLuong.Text = "Quy Định Lương";
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuNhanVien,
            this.mnuTinhLuong,
            this.mnuQuyDnhLuong});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1129, 61);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.chấmCôngToolStripMenuItem.Text = "Chấm Công";
            // 
            // saoLưuDữLiệuToolStripMenuItem
            // 
            this.saoLưuDữLiệuToolStripMenuItem.Name = "saoLưuDữLiệuToolStripMenuItem";
            this.saoLưuDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.saoLưuDữLiệuToolStripMenuItem.Text = "Sao Lưu Dữ Liệu";
            // 
            // khôiPhụcDữLieu65ToolStripMenuItem
            // 
            this.khôiPhụcDữLieu65ToolStripMenuItem.Name = "khôiPhụcDữLieu65ToolStripMenuItem";
            this.khôiPhụcDữLieu65ToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.khôiPhụcDữLieu65ToolStripMenuItem.Text = "Khôi Phục Dữ Liệu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 637);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm mềm quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNghiPhep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuTinhLuong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuyDnhLuong;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcDữLieu65ToolStripMenuItem;
    }
}

