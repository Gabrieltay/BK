using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookkeep
{
    public partial class frmRptTransaction : Form
    {
        public frmRptTransaction()
        {
            InitializeComponent();
            txtDateFrom.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtDateTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT a.dtLedgerDate AS LedgerDate, a.sLedgerDocu AS LedgerDocu, c.sAccountType AS LedgerCode, " +
                "b.sAccountCode AS LedgerAcc, (CASE WHEN b.sAccountCode = '2000' THEN a.sLedgerDesc ELSE c.sAccountName END) AS LedgerAccName, " + 
                "a.sLedgerDesc + (CASE WHEN b.sLedgerDescription = '' THEN '' ELSE ' - ' END) + b.sLedgerDescription AS LedgerDesc, a.sLedgerRef AS LedgerRef, " +
                "b.nLedgerDebit AS LedgerDebit, b.nLedgerCredit AS LedgerCredit, NULL AS LedgerBalance";

            sSql += Environment.NewLine + "FROM [Ledger] a";
            sSql += Environment.NewLine + "LEFT OUTER JOIN [LedgerDtl] b ON a.sLedgerId = b.sLedgerId";
            sSql += Environment.NewLine + "LEFT OUTER JOIN [Account] c ON b.sAccountCode = c.sAccountCode";

            sSql += Environment.NewLine + "WHERE a.sCompanyCode >= '" + LocalAccess.l_CompanyCode + "'";
            sSql += Environment.NewLine + "AND a.dtLedgerDate >= '" + txtDateFrom.Text + "'";
            sSql += Environment.NewLine + "AND a.dtLedgerDate <= '" + txtDateTo.Text + "'";
            if (txtCodeFrom.Text.Trim() != "")
                sSql += Environment.NewLine + "AND b.sAccountCode >= '" + txtCodeFrom.Text + "'";
            if (txtCodeTo.Text.Trim() != "")
                sSql += Environment.NewLine + "AND b.sAccountCode <= '" + txtCodeTo.Text + "'";

            sSql += Environment.NewLine + "ORDER BY a.dtLedgerDate, a.sLedgerDocu, b.sAccountCode";
            try
            {
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(dt);
                }
                reportViewer1.LocalReport.DataSources.Clear();

                List<ReportParameter> p = new List<ReportParameter>();
                p.Add(new ReportParameter("Company", LocalAccess.l_CompanyName));
                p.Add(new ReportParameter("Title", "Ledger Listing (" + txtDateFrom.Text + " to " + txtDateTo.Text + ")"));

                reportViewer1.LocalReport.SetParameters(p);
                ReportDataSource rprtDTSource = new ReportDataSource("Ledger", dt);
                reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
