using System;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmMain : Form
    {
        public frmMain()
        { InitializeComponent(); }

        private void Form_Load(object sender, EventArgs e)
        { }

        private void Form_Shown(object sender, EventArgs e)
        {
            mEntry.Visible = false;
            mSeperator1.Visible = false;
            mReports.Visible = false;
            mRecon.Visible = false;
            mSeperator2.Visible = false;
            UpdateCompany();
        }

        private void mEntry_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmEntryList")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                    //frmChild.Close();
            }
            frmLedgerList frm = new frmLedgerList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mReports_Click(object sender, EventArgs e)
        {
        }

        private void mRecon_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmRecon")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                //frmChild.Close();
            }
            frmRecon frm = new frmRecon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mAccount_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmAccountList")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                    //frmChild.Close();
            }
            frmAccountList frm = new frmAccountList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mCompany_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmCompanyList")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                    //frmChild.Close();
            }
            UpdateCompany();
            frmCompanyList frm = new frmCompanyList();
            frm.MdiParent = this;
            frm.Show();
        }
        public void UpdateCompany()
        {

            if (LocalAccess.l_CompanyCode == "")
            {
                mEntry.Visible = false;
                mSeperator1.Visible = false;
                mReports.Visible = false;
                mRecon.Visible = false;
                mSeperator2.Visible = false;
                this.Text = "Bookkeeping System";

                frmCompanyList frm = new frmCompanyList();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                mEntry.Visible = true;
                mSeperator1.Visible = true;
                mReports.Visible = true;
                mRecon.Visible = true;
                mSeperator2.Visible = true;
                this.Text = "Bookkeeping System - " + LocalAccess.l_CompanyName;
            }
        }

        private void mExit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void mRptLedger_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmRptLedger")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                //frmChild.Close();
            }
            frmRptLedger frm = new frmRptLedger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mRptTransaction_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmRptTransaction")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                //frmChild.Close();
            }
            frmRptTransaction frm = new frmRptTransaction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mRptGst_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmRptGst")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                //frmChild.Close();
            }
            frmRptGst frm = new frmRptGst();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mRptTB_Click(object sender, EventArgs e)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Name == "frmRptTB")
                {
                    frmChild.Activate();
                    return;
                }
                //else
                //frmChild.Close();
            }
            frmRptTB frm = new frmRptTB();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
