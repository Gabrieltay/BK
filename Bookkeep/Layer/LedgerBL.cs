using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep.Layer
{
    public class LedgerBL
    {
        private string sLedgerId = "";
        public string LedgerId
        {
            get { return sLedgerId; }
            set { sLedgerId = value; }
        }

        private string sCompanyCode = "";
        public string CompanyCode
        {
            get { return sCompanyCode; }
            set { sCompanyCode = value; }
        }

        private DateTime dtLedgerDate = new DateTime(1900, 1, 1);
        public DateTime LedgerDate
        {
            get { return dtLedgerDate; }
            set { dtLedgerDate = value; }
        }

        private string sLedgerDocu = "";
        public string LedgerDocu
        {
            get { return sLedgerDocu; }
            set { sLedgerDocu = value; }
        }

        private string sLedgerDesc = "";
        public string LedgerDesc
        {
            get { return sLedgerDesc; }
            set { sLedgerDesc = value; }
        }

        private string sLedgerRef = "";
        public string LedgerRef
        {
            get { return sLedgerRef; }
            set { sLedgerRef = value; }
        }

        public List<LedgerDtlBL> dtls = new List<LedgerDtlBL>();

        public bool Exist()
        { return Exist(sCompanyCode, sLedgerDocu); }
        public bool Exist(string company, string docu)
        {
            string sSql = "SELECT * FROM [Ledger] WHERE sCompanyCode = @company AND sLedgerDocu = @docu";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("company", company));
                cmd.Parameters.Add(new SqlParameter("docu", docu));
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        public void LoadByPK(string id)
        {
            string sSql = "SELECT * FROM [Ledger] WHERE sLedgerId = @id";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", id));
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.sLedgerId = "" + dt.Rows[0]["sLedgerId"];
                    this.sCompanyCode = "" + dt.Rows[0]["sCompanyCode"];
                    this.dtLedgerDate = Convert.ToDateTime(dt.Rows[0]["dtLedgerDate"]);
                    this.sLedgerDocu = "" + dt.Rows[0]["sLedgerDocu"];
                    this.sLedgerDesc = "" + dt.Rows[0]["sLedgerDesc"];
                    this.LedgerRef = "" + dt.Rows[0]["sLedgerRef"];
                    dtls = new List<LedgerDtlBL>();

                    sSql = "SELECT * FROM [LedgerDtl] WHERE sLedgerId = @id";
                    using (SqlCommand cmd2 = new SqlCommand(sSql, LocalAccess.l_Connection))
                    {
                        cmd2.Parameters.Add(new SqlParameter("id", id));
                        DataTable dt2 = new DataTable();
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd2))
                            adp.Fill(dt2);
                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            LedgerDtlBL dtl = new LedgerDtlBL();
                            dtl.LedgerId = "" + dr2["sLedgerId"];
                            dtl.AccountCode = "" + dr2["sAccountCode"];
                            dtl.LedgerDescription = "" + dr2["sLedgerDescription"];
                            dtl.LedgerDebit = Convert.ToDouble(dr2["nLedgerDebit"]);
                            dtl.LedgerCredit = Convert.ToDouble(dr2["nLedgerCredit"]);
                            dtl.LedgerAmount = Convert.ToDouble(dr2["nLedgerAmount"]);
                            dtls.Add(dtl);
                        }
                    }
                }
                else
                {
                    this.sLedgerId = "";
                    this.sCompanyCode = "";
                    this.dtLedgerDate = new DateTime(1900, 1, 1);
                    this.sLedgerDocu = "";
                    this.sLedgerDesc = "";
                    this.LedgerRef = "";
                    dtls = new List<LedgerDtlBL>();
                }
            }
        }

        public void Insert()
        {
            string sSql = "INSERT INTO [Ledger] (sLedgerId, sCompanyCode, dtLedgerDate, sLedgerDocu, sLedgerDesc, sLedgerRef) VALUES (@id, @company, @date, @docu, @desc, @ref)";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", this.sLedgerId));
                cmd.Parameters.Add(new SqlParameter("company", this.sCompanyCode));
                cmd.Parameters.Add(new SqlParameter("date", this.dtLedgerDate.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("docu", this.sLedgerDocu));
                cmd.Parameters.Add(new SqlParameter("desc", this.sLedgerDesc));
                cmd.Parameters.Add(new SqlParameter("ref", this.sLedgerRef));
                cmd.ExecuteNonQuery();
            }

            foreach (LedgerDtlBL dtl in this.dtls)
            {
                sSql = "INSERT INTO [LedgerDtl] (sLedgerId, sAccountCode, sLedgerDescription, nLedgerDebit, nLedgerCredit, nLedgerAmount) "
                    + "VALUES (@id, @account, @description, @debit, @credit, @amount)";
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    cmd.Parameters.Add(new SqlParameter("id", dtl.LedgerId));
                    cmd.Parameters.Add(new SqlParameter("account", dtl.AccountCode));
                    cmd.Parameters.Add(new SqlParameter("description", dtl.LedgerDescription));
                    cmd.Parameters.Add(new SqlParameter("debit", dtl.LedgerDebit));
                    cmd.Parameters.Add(new SqlParameter("credit", dtl.LedgerCredit));
                    cmd.Parameters.Add(new SqlParameter("amount", dtl.LedgerAmount));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateByPK()
        {
            string sSql = "UPDATE [Ledger] SET dtLedgerDate = @date, sLedgerDocu = @docu, sLedgerDesc = @desc, sLedgerRef = @ref WHERE sLedgerId = @id";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", this.sLedgerId));
                cmd.Parameters.Add(new SqlParameter("date", this.dtLedgerDate.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("docu", this.sLedgerDocu));
                cmd.Parameters.Add(new SqlParameter("desc", this.sLedgerDesc));
                cmd.Parameters.Add(new SqlParameter("ref", this.sLedgerRef));
                cmd.ExecuteNonQuery();
            }

            sSql = "DELETE FROM [LedgerDtl] WHERE sLedgerId = @id";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", this.sLedgerId));
                cmd.ExecuteNonQuery();
            }

            foreach (LedgerDtlBL dtl in this.dtls)
            {
                sSql = "INSERT INTO [LedgerDtl] (sLedgerId, sAccountCode, sLedgerDescription, nLedgerDebit, nLedgerCredit, nLedgerAmount) "
                    + "VALUES (@id, @account, @description, @debit, @credit, @amount)";
                using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
                {
                    cmd.Parameters.Add(new SqlParameter("id", dtl.LedgerId));
                    cmd.Parameters.Add(new SqlParameter("account", dtl.AccountCode));
                    cmd.Parameters.Add(new SqlParameter("description", dtl.LedgerDescription));
                    cmd.Parameters.Add(new SqlParameter("debit", dtl.LedgerDebit));
                    cmd.Parameters.Add(new SqlParameter("credit", dtl.LedgerCredit));
                    cmd.Parameters.Add(new SqlParameter("amount", dtl.LedgerAmount));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteByPK()
        {
            string sSql = "DELETE FROM [LedgerDtl] WHERE sLedgerId = @id";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", this.sLedgerId));
                cmd.ExecuteNonQuery();
            }
            sSql = "DELETE FROM [Ledger] WHERE sLedgerId = @id";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("id", this.sLedgerId));
                cmd.ExecuteNonQuery();
            }
        }

        public AutoCompleteStringCollection GetDescriptionList()
        {
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            string sSql = "SELECT DISTINCT [sLedgerDesc] FROM [Ledger] ORDER BY [sLedgerDesc]";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    stringCol.Add(Convert.ToString(row[0]));
            }
            return stringCol;
        }
    }

    public class LedgerDtlBL
    {
        private string sLedgerId = "";
        public string LedgerId
        {
            get { return sLedgerId; }
            set { sLedgerId = value; }
        }

        private string sAccountCode = "";
        public string AccountCode
        {
            get { return sAccountCode; }
            set { sAccountCode = value; }
        }

        private string sLedgerDescription = "";
        public string LedgerDescription
        {
            get { return sLedgerDescription; }
            set { sLedgerDescription = value; }
        }

        private double nLedgerDebit = 0;
        public double LedgerDebit
        {
            get { return nLedgerDebit; }
            set { nLedgerDebit = value; }
        }

        private double nLedgerCredit = 0;
        public double LedgerCredit
        {
            get { return nLedgerCredit; }
            set { nLedgerCredit = value; }
        }

        private double nLedgerAmount = 0;
        public double LedgerAmount
        {
            get { return nLedgerAmount; }
            set { nLedgerAmount = value; }
        }
    }
}
