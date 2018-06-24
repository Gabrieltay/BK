using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmRecon : Form
    {
        public frmRecon()
        { InitializeComponent(); }

        private void frmRecon_Load(object sender, EventArgs e)
        {

        }

        private void frmAccountList_Load(object sender, EventArgs e)
        { LoadAccount(); }
        private void LoadAccount()
        {
            lstAccount.Items.Clear();
            try
            {
                string sSql = "SELECT sAccountCode, sAccountType, sAccountName FROM [Account] ORDER BY sAccountCode";
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        string sText = "" + dr["sAccountCode"];
                        if (sText.Length < 20)
                            sText = sText.PadRight(20 - sText.Length, ' ');
                        sText += "|" + dr["sAccountType"] + "|" + dr["sAccountName"];
                        lstAccount.Items.Add(new Item("" + dr["sAccountCode"], sText));
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }

            if (lstAccount.Items.Count > 0)
                lstAccount.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAccount frm = new frmAccount())
            {
                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                    LoadAccount();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstAccount.SelectedIndex == -1)
                return;

            Item item = (Item)lstAccount.SelectedItem;
            using (frmAccount frm = new frmAccount(item))
            {
                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                    LoadAccount();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstAccount.SelectedIndex == -1)
                return;

            Item item = (Item)lstAccount.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this account :" + Environment.NewLine + item.Text, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Layer.AccountBL BL = new Layer.AccountBL();
                BL.AccountCode = item.Value;
                BL.DeleteByPK();
                LoadAccount();
            }
        }

        private void lstAccount_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstAccount.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Item item = (Item)lstAccount.Items[index];
                using (frmAccount frm = new frmAccount(item))
                {
                    DialogResult result = frm.ShowDialog(this);
                    if (result == DialogResult.OK)
                        LoadAccount();
                }
            }
        }
    }
}
