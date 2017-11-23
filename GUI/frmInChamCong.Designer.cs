namespace GUI
{
    partial class frmInChamCong
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
            this.rptChamCong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptChamCong
            // 
            this.rptChamCong.AutoScroll = true;
            this.rptChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptChamCong.Location = new System.Drawing.Point(0, 0);
            this.rptChamCong.Name = "rptChamCong";
            this.rptChamCong.ShowPageNavigationControls = false;
            this.rptChamCong.Size = new System.Drawing.Size(1129, 608);
            this.rptChamCong.TabIndex = 0;
            // 
            // frmInChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1129, 608);
            this.Controls.Add(this.rptChamCong);
            this.Name = "frmInChamCong";
            this.Text = "In bảng chấm công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInChamCong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptChamCong;

    }
}