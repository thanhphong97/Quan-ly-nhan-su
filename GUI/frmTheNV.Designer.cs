﻿namespace GUI
{
    partial class frmTheNV
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
            this.rptTheNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptTheNV
            // 
            this.rptTheNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptTheNV.Location = new System.Drawing.Point(0, 0);
            this.rptTheNV.Name = "rptTheNV";
            this.rptTheNV.Size = new System.Drawing.Size(309, 448);
            this.rptTheNV.TabIndex = 0;
            // 
            // frmTheNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 448);
            this.Controls.Add(this.rptTheNV);
            this.Name = "frmTheNV";
            this.Text = "Thẻ nhân viên";
            this.Load += new System.EventHandler(this.frmTheNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTheNV;
    }
}