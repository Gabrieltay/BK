using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmAccount : Form
    {
        private bool _IsAdd = false;

        public frmAccount()
        {
            InitializeComponent();
            this._IsAdd = true;
        }
        public frmAccount(Item item)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Account";
            txtCode.Enabled = false;

            Layer.AccountBL BL = new Layer.AccountBL();
            BL.LoadByPK(item.Value);

            txtCode.Text = BL.AccountCode;
            txtType.Text = BL.AccountType;
            txtName.Text = BL.AccountName;
            
            this._IsAdd = false;
            btnAdd.Text = "Save";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Layer.AccountBL BL = new Layer.AccountBL();
            BL.AccountCode = txtCode.Text.Trim();
            BL.AccountType = txtType.Text.Trim();
            BL.AccountName = txtName.Text.Trim();

            if (BL.AccountCode == "" || BL.AccountType == "" || BL.AccountName == "")
            {
                MessageBox.Show("Account Code/Type/Name cannot be blank", "Add Account");
                return;
            }
            //if (BL.AccountType == "BS" || BL.AccountType == "PL" || BL.AccountType == "TD" || BL.AccountType == "TC")
            //{}
            //else
            //{
            //    MessageBox.Show("Invalid Account Type", "Add Account");
            //    return;
            //}

            if (this._IsAdd)
            {
                if (BL.Exist())
                {
                    MessageBox.Show("Account Code already exist.", "Add Account");
                    return;
                }
                BL.Insert();
            }
            else
            {
                BL.UpdateByPK();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
