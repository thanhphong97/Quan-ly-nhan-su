namespace GUI
{
    partial class frmBaoCaoBangLuong
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
            this.rptBangLuong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBangLuong
            // 
            this.rptBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBangLuong.Location = new System.Drawing.Point(0, 0);
            this.rptBangLuong.Name = "rptBangLuong";
            this.rptBangLuong.Size = new System.Drawing.Size(1049, 524);
            this.rptBangLuong.TabIndex = 0;
            // 
            // frmBaoCaoBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 524);
            this.Controls.Add(this.rptBangLuong);
            this.Name = "frmBaoCaoBangLuong";
            this.Text = "frmBaoCaoBangLuong";
            this.Load += new System.EventHandler(this.frmBaoCaoBangLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBangLuong;
    }
}