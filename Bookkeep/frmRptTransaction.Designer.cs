﻿namespace Bookkeep
{
    partial class frmRptTransaction
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
            this.txtCodeFrom = new System.Windows.Forms.TextBox();
            this.lblCodeTo = new System.Windows.Forms.Label();
            this.lblCodeFrom = new System.Windows.Forms.Label();
            this.txtCodeTo = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bookkeep.Transaction.rdlc";
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
            this.txtDateFrom.Size = new System.Drawing.Size(130, 30);
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
            this.txtDateTo.Size = new System.Drawing.Size(130, 30);
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
            // txtCodeFrom
            // 
            this.txtCodeFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodeFrom.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtCodeFrom.Location = new System.Drawing.Point(185, 55);
            this.txtCodeFrom.MaxLength = 20;
            this.txtCodeFrom.Name = "txtCodeFrom";
            this.txtCodeFrom.Size = new System.Drawing.Size(200, 30);
            this.txtCodeFrom.TabIndex = 10;
            // 
            // lblCodeTo
            // 
            this.lblCodeTo.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblCodeTo.Location = new System.Drawing.Point(415, 55);
            this.lblCodeTo.Name = "lblCodeTo";
            this.lblCodeTo.Size = new System.Drawing.Size(170, 30);
            this.lblCodeTo.TabIndex = 12;
            this.lblCodeTo.Text = "Code To:";
            this.lblCodeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodeFrom
            // 
            this.lblCodeFrom.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblCodeFrom.Location = new System.Drawing.Point(15, 55);
            this.lblCodeFrom.Name = "lblCodeFrom";
            this.lblCodeFrom.Size = new System.Drawing.Size(170, 30);
            this.lblCodeFrom.TabIndex = 11;
            this.lblCodeFrom.Text = "Code From:";
            this.lblCodeFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodeTo
            // 
            this.txtCodeTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodeTo.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtCodeTo.Location = new System.Drawing.Point(585, 55);
            this.txtCodeTo.MaxLength = 20;
            this.txtCodeTo.Name = "txtCodeTo";
            this.txtCodeTo.Size = new System.Drawing.Size(200, 30);
            this.txtCodeTo.TabIndex = 13;
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
            // frmRptTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCodeTo);
            this.Controls.Add(this.lblCodeTo);
            this.Controls.Add(this.lblCodeFrom);
            this.Controls.Add(this.txtCodeFrom);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRptTransaction";
            this.Text = "Transaction";
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
        private System.Windows.Forms.TextBox txtCodeFrom;
        private System.Windows.Forms.Label lblCodeTo;
        private System.Windows.Forms.Label lblCodeFrom;
        private System.Windows.Forms.TextBox txtCodeTo;
        private System.Windows.Forms.Button btnLoad;
    }
}