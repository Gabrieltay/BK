namespace Bookkeep
{
    partial class frmLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDocu = new System.Windows.Forms.Label();
            this.txtDocu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.grdDetail = new System.Windows.Forms.DataGridView();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.cAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Ledger";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocu
            // 
            this.lblDocu.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDocu.Location = new System.Drawing.Point(10, 100);
            this.lblDocu.Name = "lblDocu";
            this.lblDocu.Size = new System.Drawing.Size(170, 30);
            this.lblDocu.TabIndex = 6;
            this.lblDocu.Text = "Document :";
            this.lblDocu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocu
            // 
            this.txtDocu.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtDocu.Location = new System.Drawing.Point(180, 100);
            this.txtDocu.MaxLength = 50;
            this.txtDocu.Name = "txtDocu";
            this.txtDocu.Size = new System.Drawing.Size(250, 30);
            this.txtDocu.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnAdd.Location = new System.Drawing.Point(630, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnCancel.Location = new System.Drawing.Point(770, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDate.Location = new System.Drawing.Point(10, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 30);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.Location = new System.Drawing.Point(315, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "(YYYY-MM-DD)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(180, 55);
            this.txtDate.Mask = "0000-00-00";
            this.txtDate.Name = "txtDate";
            this.txtDate.PromptChar = ' ';
            this.txtDate.Size = new System.Drawing.Size(130, 30);
            this.txtDate.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDesc.Location = new System.Drawing.Point(10, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(170, 30);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Description :";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRef
            // 
            this.lblRef.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblRef.Location = new System.Drawing.Point(10, 190);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(170, 30);
            this.lblRef.TabIndex = 10;
            this.lblRef.Text = "Reference :";
            this.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDesc
            // 
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesc.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtDesc.Location = new System.Drawing.Point(180, 146);
            this.txtDesc.MaxLength = 1000;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(690, 30);
            this.txtDesc.TabIndex = 9;
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtRef.Location = new System.Drawing.Point(180, 191);
            this.txtRef.MaxLength = 1000;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(690, 30);
            this.txtRef.TabIndex = 11;
            // 
            // grdDetail
            // 
            this.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAccount,
            this.cDescription,
            this.cDebit,
            this.cCredit,
            this.cAmount});
            this.grdDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdDetail.Location = new System.Drawing.Point(15, 235);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RowTemplate.Height = 24;
            this.grdDetail.Size = new System.Drawing.Size(855, 260);
            this.grdDetail.TabIndex = 12;
            this.grdDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetail_CellEndEdit);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnAddRow.Location = new System.Drawing.Point(15, 500);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(40, 40);
            this.btnAddRow.TabIndex = 15;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnDelRow.Location = new System.Drawing.Point(80, 500);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(40, 40);
            this.btnDelRow.TabIndex = 16;
            this.btnDelRow.Text = "-";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // cAccount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.cAccount.DefaultCellStyle = dataGridViewCellStyle1;
            this.cAccount.HeaderText = "Account";
            this.cAccount.MaxInputLength = 20;
            this.cAccount.Name = "cAccount";
            this.cAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDescription.Width = 300;
            // 
            // cDebit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.cDebit.DefaultCellStyle = dataGridViewCellStyle2;
            this.cDebit.HeaderText = "Debit";
            this.cDebit.MaxInputLength = 20;
            this.cDebit.Name = "cDebit";
            this.cDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDebit.Width = 125;
            // 
            // cCredit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.cCredit.DefaultCellStyle = dataGridViewCellStyle3;
            this.cCredit.HeaderText = "Credit";
            this.cCredit.MaxInputLength = 20;
            this.cCredit.Name = "cCredit";
            this.cCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCredit.Width = 125;
            // 
            // cAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.cAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.cAmount.HeaderText = "Amount B/F Tax";
            this.cAmount.Name = "cAmount";
            this.cAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cAmount.Width = 125;
            // 
            // frmLedger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnDelRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.grdDetail);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDocu);
            this.Controls.Add(this.lblDocu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDocu;
        private System.Windows.Forms.TextBox txtDocu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.DataGridView grdDetail;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
    }
}