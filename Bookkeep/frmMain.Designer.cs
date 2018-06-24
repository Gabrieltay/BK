namespace Bookkeep
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeperator1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mRptLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mRptTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mRptGst = new System.Windows.Forms.ToolStripMenuItem();
            this.mRptTB = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeperator2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeperator3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeperator4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mRecon = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEntry,
            this.mSeperator1,
            this.mReports,
            this.toolStripMenuItem1,
            this.mRecon,
            this.mSeperator2,
            this.mAccount,
            this.mSeperator3,
            this.mCompany,
            this.mSeperator4,
            this.mExit});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msMain.Size = new System.Drawing.Size(982, 27);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // mEntry
            // 
            this.mEntry.Name = "mEntry";
            this.mEntry.Size = new System.Drawing.Size(60, 21);
            this.mEntry.Text = "Entry";
            this.mEntry.Click += new System.EventHandler(this.mEntry_Click);
            // 
            // mSeperator1
            // 
            this.mSeperator1.Enabled = false;
            this.mSeperator1.Name = "mSeperator1";
            this.mSeperator1.Size = new System.Drawing.Size(28, 21);
            this.mSeperator1.Text = "|";
            // 
            // mReports
            // 
            this.mReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRptLedger,
            this.mRptTransaction,
            this.mRptGst,
            this.mRptTB});
            this.mReports.Name = "mReports";
            this.mReports.Size = new System.Drawing.Size(76, 21);
            this.mReports.Text = "Reports";
            // 
            // mRptLedger
            // 
            this.mRptLedger.Name = "mRptLedger";
            this.mRptLedger.Size = new System.Drawing.Size(188, 22);
            this.mRptLedger.Text = "Ledger Listing";
            this.mRptLedger.Click += new System.EventHandler(this.mRptLedger_Click);
            // 
            // mRptTransaction
            // 
            this.mRptTransaction.Name = "mRptTransaction";
            this.mRptTransaction.Size = new System.Drawing.Size(188, 22);
            this.mRptTransaction.Text = "Transactions";
            this.mRptTransaction.Click += new System.EventHandler(this.mRptTransaction_Click);
            // 
            // mRptGst
            // 
            this.mRptGst.Name = "mRptGst";
            this.mRptGst.Size = new System.Drawing.Size(188, 22);
            this.mRptGst.Text = "GST";
            this.mRptGst.Click += new System.EventHandler(this.mRptGst_Click);
            // 
            // mRptTB
            // 
            this.mRptTB.Name = "mRptTB";
            this.mRptTB.Size = new System.Drawing.Size(188, 22);
            this.mRptTB.Text = "Trial Balance";
            this.mRptTB.Click += new System.EventHandler(this.mRptTB_Click);
            // 
            // mSeperator2
            // 
            this.mSeperator2.Enabled = false;
            this.mSeperator2.Name = "mSeperator2";
            this.mSeperator2.Size = new System.Drawing.Size(28, 21);
            this.mSeperator2.Text = "|";
            // 
            // mAccount
            // 
            this.mAccount.Name = "mAccount";
            this.mAccount.Size = new System.Drawing.Size(76, 21);
            this.mAccount.Text = "Account";
            this.mAccount.Click += new System.EventHandler(this.mAccount_Click);
            // 
            // mSeperator3
            // 
            this.mSeperator3.Enabled = false;
            this.mSeperator3.Name = "mSeperator3";
            this.mSeperator3.Size = new System.Drawing.Size(28, 21);
            this.mSeperator3.Text = "|";
            // 
            // mCompany
            // 
            this.mCompany.Name = "mCompany";
            this.mCompany.Size = new System.Drawing.Size(76, 21);
            this.mCompany.Text = "Company";
            this.mCompany.Click += new System.EventHandler(this.mCompany_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(52, 21);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mSeperator4
            // 
            this.mSeperator4.Enabled = false;
            this.mSeperator4.Name = "mSeperator4";
            this.mSeperator4.Size = new System.Drawing.Size(28, 21);
            this.mSeperator4.Text = "|";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            this.toolStripMenuItem1.Text = "|";
            // 
            // mRecon
            // 
            this.mRecon.Name = "mRecon";
            this.mRecon.Size = new System.Drawing.Size(100, 21);
            this.mRecon.Text = "Bank Recon";
            this.mRecon.Click += new System.EventHandler(this.mRecon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mEntry;
        private System.Windows.Forms.ToolStripMenuItem mReports;
        private System.Windows.Forms.ToolStripMenuItem mCompany;
        private System.Windows.Forms.ToolStripMenuItem mSeperator1;
        private System.Windows.Forms.ToolStripMenuItem mSeperator2;
        private System.Windows.Forms.ToolStripMenuItem mAccount;
        private System.Windows.Forms.ToolStripMenuItem mSeperator3;
        private System.Windows.Forms.ToolStripMenuItem mRptLedger;
        private System.Windows.Forms.ToolStripMenuItem mRptTransaction;
        private System.Windows.Forms.ToolStripMenuItem mRptGst;
        private System.Windows.Forms.ToolStripMenuItem mRptTB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mRecon;
        private System.Windows.Forms.ToolStripMenuItem mSeperator4;
    }
}

