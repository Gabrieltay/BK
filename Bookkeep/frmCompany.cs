using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmCompany : Form
    {
        private bool _IsAdd = false;
        public string _ComapnyCode
        { get { return txtCode.Text.Trim(); } }
        public string _CompanyName
        { get { return txtName.Text.Trim(); } }

        public frmCompany()
        {
            InitializeComponent();
            this._IsAdd = true;
        }
        public frmCompany(Item item)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Company";
            txtCode.Enabled = false;
            txtCode.Text = item.Value;
            txtName.Text = item.Text;
            this._IsAdd = false;
            btnAdd.Text = "Save";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Layer.CompanyBL BL = new Layer.CompanyBL();
            BL.CompanyCode = txtCode.Text.Trim();
            BL.CompanyName = txtName.Text.Trim();
            if (BL.CompanyCode == "" || BL.CompanyName == "")
            {
                MessageBox.Show("Company Code/Name cannot be blank", "Add Company");
                return;
            }

            if (this._IsAdd)
            {
                if (BL.Exist())
                {
                    MessageBox.Show("Company Code already exist.", "Add Company");
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
