using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmLedgerList : Form
    {
        public frmLedgerList()
        { InitializeComponent(); }

        private void frmEntryList_Load(object sender, EventArgs e)
        { LoadEntry(); }
        public void LoadEntry()
        {
            lstEntry.Items.Clear();
            try
            {
                string sSearch = txtSearch.Text.Trim();
                string sSql = "SELECT sLedgerId, dtLedgerDate, sLedgerDocu, sLedgerDesc FROM [Ledger]";
                sSql += Environment.NewLine + "WHERE sCompanyCode = '" + LocalAccess.l_CompanyCode + "'";
                if (sSearch != "")
                    sSql += Environment.NewLine + "AND (sLedgerDocu LIKE @search OR sLedgerDesc LIKE @search)";
                sSql += Environment.NewLine + "ORDER BY dtLedgerDate DESC, sLedgerDocu DESC";
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    cmd.Parameters.Add(new SqlParameter("search", "%" + sSearch + "%"));
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        string sText = Convert.ToDateTime(dr["dtLedgerDate"]).ToString("yyyy-MM-dd");
                        sText += "|" + dr["sLedgerDocu"];
                        sText = sText.PadRight(35) + "|" + dr["sLedgerDesc"];
                        lstEntry.Items.Add(new Item("" + dr["sLedgerId"], sText));
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }

            if (lstEntry.Items.Count > 0)
                lstEntry.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLedger frm = new frmLedger(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEntry.SelectedIndex == -1)
                return;

            Item item = (Item)lstEntry.SelectedItem;
            frmLedger frm = new frmLedger(this, item, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEntry.SelectedIndex == -1)
                return;

            Item item = (Item)lstEntry.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this account :" + Environment.NewLine + item.Text, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Layer.LedgerBL BL = new Layer.LedgerBL();
                BL.LedgerId = item.Value;
                BL.DeleteByPK();
                LoadEntry();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstEntry.SelectedIndex == -1)
                return;

            Item item = (Item)lstEntry.SelectedItem;
            frmLedger frm = new frmLedger(this, item, true);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void lstEntry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstEntry.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Item item = (Item)lstEntry.Items[index];
                frmLedger frm = new frmLedger(this, item, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void txtSearch_Validated(object sender, EventArgs e)
        {
            LoadEntry();
        }
    }
}
