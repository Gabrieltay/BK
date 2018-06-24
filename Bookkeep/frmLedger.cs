using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmLedger : Form
    {
        private bool _IsAdd = false;
        private string sLedgerId;
        private frmLedgerList frmList;

        public frmLedger(frmLedgerList frm)
        {
            InitializeComponent();
            this.frmList = frm;
            FormNew();
            this._IsAdd = true;
        }
        public frmLedger(frmLedgerList frm, Item item, bool copy)
        {
            InitializeComponent();
            this.frmList = frm;
            lblTitle.Text = "Edit Ledger";

            Layer.LedgerBL BL = new Layer.LedgerBL();
            BL.LoadByPK(item.Value);
            sLedgerId = BL.LedgerId;
            txtDate.Text = BL.LedgerDate.ToString("yyyyMMdd");
            txtDocu.Text = BL.LedgerDocu;
            txtDesc.Text = BL.LedgerDesc;
            txtRef.Text = BL.LedgerRef;

            foreach (Layer.LedgerDtlBL dtl in BL.dtls)
            {
                int i = grdDetail.Rows.Add();
                grdDetail.Rows[i].Cells["cAccount"].Value = dtl.AccountCode;
                grdDetail.Rows[i].Cells["cDescription"].Value = dtl.LedgerDescription;
                grdDetail.Rows[i].Cells["cDebit"].Value = dtl.LedgerDebit.ToString("#,##0.00");
                grdDetail.Rows[i].Cells["cCredit"].Value = dtl.LedgerCredit.ToString("#,##0.00");
                grdDetail.Rows[i].Cells["cAmount"].Value = dtl.LedgerAmount.ToString("#,##0.00");
            }
            LoadDescriptionList();

            if (!copy)
            {
                this._IsAdd = false;
                btnAdd.Text = "Save";
            }
        }

        private void FormNew()
        {
            txtDate.Focus();
            sLedgerId = "";
            txtDate.Text = "";
            txtDocu.Text = "";
            txtDesc.Text = "";
            txtRef.Text = "";
            grdDetail.Rows.Clear();
            LoadDescriptionList();
        }

        private bool ValidateEntry()
        {
            try
            { DateTime dtDate = Convert.ToDateTime(txtDate.Text); }
            catch
            {
                MessageBox.Show("Invalid Date", "Entry");
                return false;
            }

            if (this._IsAdd)
            {
                Layer.LedgerBL BL = new Layer.LedgerBL();
                BL.Exist(LocalAccess.l_CompanyCode, txtDocu.Text.Trim());
            }
            
            double nDebit = 0;
            double nCredit = 0;
            foreach (DataGridViewRow dr in grdDetail.Rows)
            {
                if (dr.IsNewRow)
                    continue;
                string sAccount = "" + dr.Cells["cAccount"].Value;
                Layer.AccountBL BL = new Layer.AccountBL();
                if (!BL.Exist(sAccount))
                {
                    MessageBox.Show("Account Code does not exist.", "Entry");
                    return false;
                }
                
                try { nDebit += Convert.ToDouble(dr.Cells["cDebit"].Value); }
                catch { }
                try { nCredit += Convert.ToDouble(dr.Cells["cCredit"].Value); }
                catch { }

                //nBalance = Math.Round(nBalance + nDebit - nCredit);
            }
            if (Math.Round(nDebit, 2) != Math.Round(nCredit, 2))
            {
                MessageBox.Show("Ledger Not Balance" + Environment.NewLine + "Debit: " + nDebit.ToString("#,##0.00") + Environment.NewLine + "Credit: " + nCredit.ToString("#,##0.00"), "Entry");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEntry())
                return;

            Layer.LedgerBL BL = new Layer.LedgerBL();

            if (this._IsAdd)
                BL.LedgerId = DateTime.Now.ToString("yyyyMMddHHmmss");
            else
                BL.LedgerId = this.sLedgerId;
            BL.CompanyCode = LocalAccess.l_CompanyCode;
            BL.LedgerDate = Convert.ToDateTime(txtDate.Text);
            BL.LedgerDocu = txtDocu.Text.Trim();
            BL.LedgerDesc = txtDesc.Text.Trim();
            BL.LedgerRef = txtRef.Text.Trim();

            BL.dtls = new List<Layer.LedgerDtlBL>();
            foreach (DataGridViewRow dr in grdDetail.Rows)
            {
                if (dr.IsNewRow)
                    continue;
                Layer.LedgerDtlBL dtl = new Layer.LedgerDtlBL();
                dtl.LedgerId = BL.LedgerId;
                dtl.AccountCode = "" + dr.Cells["cAccount"].Value;
                dtl.LedgerDescription = "" + dr.Cells["cDescription"].Value;
                dtl.LedgerDebit = 0;
                dtl.LedgerCredit = 0;
                dtl.LedgerAmount = 0;
                try { dtl.LedgerDebit = Convert.ToDouble(dr.Cells["cDebit"].Value); }
                catch { }
                try { dtl.LedgerCredit = Convert.ToDouble(dr.Cells["cCredit"].Value); }
                catch { }
                try { dtl.LedgerAmount = Convert.ToDouble(dr.Cells["cAmount"].Value); }
                catch { }
                BL.dtls.Add(dtl);
            }
            if (this._IsAdd)
            {
                if (BL.Exist())
                {
                    MessageBox.Show("Document already exist.", "Add Ledger");
                    return;
                }
                BL.Insert();
                frmList.LoadEntry();
                //FormNew();
                txtDate.Focus();
                LoadDescriptionList();
                MessageBox.Show("Record Saved");
            }
            else
            {
                BL.UpdateByPK();
                this.Close();
                frmList.LoadEntry();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmList.LoadEntry();
        }

        private void grdDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            string sCol = grdDetail.Columns[e.ColumnIndex].Name;

            if (sCol == "cDebit" || sCol == "cCredit" || sCol == "cAmount")
            {
                double nAmt = 0;
                try { nAmt = Convert.ToDouble(grdDetail.Rows[iRow].Cells[sCol].Value); }
                catch { }

                grdDetail.Rows[iRow].Cells[sCol].Value = nAmt.ToString("#,##0.00");
            }
        }        

        private void LoadDescriptionList()
        {
            Layer.LedgerBL BL = new Layer.LedgerBL();
            txtDesc.AutoCompleteCustomSource = BL.GetDescriptionList();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            int rowindex = grdDetail.SelectedCells[0].RowIndex;
            if (rowindex == grdDetail.NewRowIndex || rowindex < 0)
                return;
            grdDetail.Rows.Insert(rowindex, 1);
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            int rowindex = grdDetail.SelectedCells[0].RowIndex;
            if (rowindex == grdDetail.NewRowIndex || rowindex < 0)
                return;
            grdDetail.Rows.RemoveAt(rowindex);

        }
    }
}
