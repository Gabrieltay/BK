using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmCompanyList : Form
    {
        public frmCompanyList()
        { InitializeComponent(); }

        private void Form_Load(object sender, EventArgs e)
        { LoadCompany(); }
        private void LoadCompany()
        {
            lstCompany.Items.Clear();
            try
            {
                string sSql = "SELECT sCompanyCode, sCompanyName FROM [Company] ORDER BY sCompanyName";
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                        lstCompany.Items.Add(new Item("" + dr["sCompanyCode"], "" + dr["sCompanyName"]));
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }

            if (lstCompany.Items.Count > 0)
                lstCompany.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmCompany frm = new frmCompany())
            {
                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                    LoadCompany();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstCompany.SelectedIndex == -1)
                return;

            Item item = (Item)lstCompany.SelectedItem;
            using (frmCompany frm = new frmCompany(item))
            {
                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                    LoadCompany();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCompany.SelectedIndex == -1)
                return;

            Item item = (Item)lstCompany.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this company :" + Environment.NewLine + item.Value + " - " + item.Text, "Delete Comapny", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Layer.CompanyBL BL = new Layer.CompanyBL();
                BL.CompanyCode = item.Value;
                BL.DeleteByPK();
                LoadCompany();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCompany();
        }

        private void SelectCompany()
        {
            if (lstCompany.SelectedIndex == -1)
                return;

            Item item = (Item)lstCompany.SelectedItem;
            LocalAccess.l_CompanyCode = item.Value;
            LocalAccess.l_CompanyName = item.Text;

            frmMain frm = (frmMain)this.MdiParent;
            frm.UpdateCompany();
            this.Close();
        }

        private void lstCompany_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstCompany.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Item item = (Item)lstCompany.Items[index];
                LocalAccess.l_CompanyCode = item.Value;
                LocalAccess.l_CompanyName = item.Text;

                frmMain frm = (frmMain)this.MdiParent;
                frm.UpdateCompany();
                this.Close();
            }
        }
    }
}
