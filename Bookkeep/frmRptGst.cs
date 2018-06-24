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
    public partial class frmRptGst : Form
    {
        public frmRptGst()
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
            string sSql = "SELECT a.dtLedgerDate AS LedgerDate, a.sLedgerDocu AS LedgerDocu, " +
                "b.sAccountCode AS LedgerAcc, c.sAccountName AS LedgerAccName, a.sLedgerDesc AS LedgerDesc, " +
                "(CASE WHEN b.nLedgerDebit - b.nLedgerCredit >= 0 THEN b.nLedgerAmount ELSE -b.nLedgerAmount END) AS LedgerAmount, b.nLedgerDebit - b.nLedgerCredit AS LedgerTax";

            sSql += Environment.NewLine + "FROM [Ledger] a";
            sSql += Environment.NewLine + "LEFT OUTER JOIN [LedgerDtl] b ON a.sLedgerId = b.sLedgerId";
            sSql += Environment.NewLine + "LEFT OUTER JOIN [Account] c ON b.sAccountCode = c.sAccountCode";

            sSql += Environment.NewLine + "WHERE a.sCompanyCode >= '" + LocalAccess.l_CompanyCode + "'";
            sSql += Environment.NewLine + "AND a.dtLedgerDate >= '" + txtDateFrom.Text + "'";
            sSql += Environment.NewLine + "AND a.dtLedgerDate <= '" + txtDateTo.Text + "'";
            //sSql += Environment.NewLine + "AND b.sAccountCode IN ('5600', '5605')";
            sSql += Environment.NewLine + "AND b.sAccountCode IN ('2031', '1132')";
            sSql += Environment.NewLine + "ORDER BY b.sAccountCode, a.dtLedgerDate, a.sLedgerDocu";
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
                p.Add(new ReportParameter("Title", "GST (" + txtDateFrom.Text + " to " + txtDateTo.Text + ")"));

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
