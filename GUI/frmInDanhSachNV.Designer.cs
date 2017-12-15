namespace GUI
{
    partial class frmInDanhSachNV
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
            this.rptDanhSachNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptDanhSachNV
            // 
            this.rptDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDanhSachNV.Location = new System.Drawing.Point(0, 0);
            this.rptDanhSachNV.Name = "rptDanhSachNV";
            this.rptDanhSachNV.Size = new System.Drawing.Size(645, 380);
            this.rptDanhSachNV.TabIndex = 0;
            // 
            // frmInDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 380);
            this.Controls.Add(this.rptDanhSachNV);
            this.Name = "frmInDanhSachNV";
            this.Text = "In danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmInDanhSachNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptDanhSachNV;
    }
}