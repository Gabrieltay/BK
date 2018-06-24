namespace Bookkeep
{
    partial class frmRptGst
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.MaskedTextBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bookkeep.GST2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 100);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(945, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(185, 10);
            this.txtDateFrom.Mask = "0000-00-00";
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.PromptChar = ' ';
            this.txtDateFrom.Size = new System.Drawing.Size(130, 26);
            this.txtDateFrom.TabIndex = 6;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDateFrom.Location = new System.Drawing.Point(15, 10);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(170, 30);
            this.lblDateFrom.TabIndex = 5;
            this.lblDateFrom.Text = "Date From:";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(585, 10);
            this.txtDateTo.Mask = "0000-00-00";
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.PromptChar = ' ';
            this.txtDateTo.Size = new System.Drawing.Size(130, 26);
            this.txtDateTo.TabIndex = 8;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDateTo.Location = new System.Drawing.Point(415, 10);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(170, 30);
            this.lblDateTo.TabIndex = 7;
            this.lblDateTo.Text = "Date To:";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnLoad.Location = new System.Drawing.Point(864, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 40);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmRptGst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRptGst";
            this.Text = "GST";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox txtDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.MaskedTextBox txtDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnLoad;
    }
}