using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep.Layer
{
    public class AccountBL
    {
        private string sAccountCode = "";
        public string AccountCode
        {
            get { return sAccountCode; }
            set { sAccountCode = value; }
        }

        private string sAccountType = "";
        public string AccountType
        {
            get { return sAccountType; }
            set { sAccountType = value; }
        }

        private string sAccountName = "";
        public string AccountName
        {
            get { return sAccountName; }
            set { sAccountName = value; }
        }

        public AccountBL()
        { }

        public bool Exist()
        { return Exist(sAccountCode); }
        public bool Exist(string code)
        {
            string sSql = "SELECT * FROM [Account] WHERE sAccountCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", code));
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        public void LoadByPK(string code)
        {
            string sSql = "SELECT * FROM [Account] WHERE sAccountCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", code));
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.sAccountCode = "" + dt.Rows[0]["sAccountCode"];
                    this.sAccountType = "" + dt.Rows[0]["sAccountType"];
                    this.sAccountName = "" + dt.Rows[0]["sAccountName"];
                }
                else
                {
                    this.sAccountCode = "";
                    this.sAccountType = "";
                    this.sAccountName = "";
                }
            }
        }

        public void Insert()
        {
            string sSql = "INSERT INTO [Account] (sAccountCode, sAccountType, sAccountName) VALUES (@code, @type, @name)";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.sAccountCode));
                cmd.Parameters.Add(new SqlParameter("type", this.sAccountType));
                cmd.Parameters.Add(new SqlParameter("name", this.sAccountName));
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateByPK()
        {
            string sSql = "UPDATE [Account] SET sAccountType = @type, sAccountName = @name WHERE sAccountCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.sAccountCode));
                cmd.Parameters.Add(new SqlParameter("type", this.sAccountType));
                cmd.Parameters.Add(new SqlParameter("name", this.sAccountName));
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteByPK()
        {
            string sSql = "DELETE FROM [Account] WHERE sAccountCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.AccountCode));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
