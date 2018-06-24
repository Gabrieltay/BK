using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookkeep.Layer
{
    public class CompanyBL
    {
        private string sCompanyCode = "";
        public string CompanyCode
        {
            get { return sCompanyCode; }
            set { sCompanyCode = value; }
        }

        private string sCompanyName = "";
        public string CompanyName
        {
            get { return sCompanyName; }
            set { sCompanyName = value; }
        }

        public CompanyBL()
        { }

        public bool Exist()
        { return Exist(sCompanyCode); }
        public bool Exist(string code)
        {
            string sSql = "SELECT * FROM [Company] WHERE sCompanyCode = @code";
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
            string sSql = "SELECT * FROM [Company] WHERE sCompanyCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", code));
                DataTable dt = new DataTable();
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.sCompanyCode = "" + dt.Rows[0]["sCompanyCode"];
                    this.sCompanyName = "" + dt.Rows[0]["sCompanyName"];
                }
                else
                {
                    this.sCompanyCode = "";
                    this.sCompanyName = "";
                }
            }
        }        

        public void Insert()
        {
            string sSql = "INSERT INTO [Company] (sCompanyCode, sCompanyName) VALUES (@code, @name)";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.sCompanyCode));
                cmd.Parameters.Add(new SqlParameter("name", this.sCompanyName));
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateByPK()
        {
            string sSql = "UPDATE [Company] SET sCompanyName = @name WHERE sCompanyCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.sCompanyCode));
                cmd.Parameters.Add(new SqlParameter("name", this.sCompanyName));
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteByPK()
        {
            string sSql = "DELETE FROM [Company] WHERE sCompanyCode = @code";
            using (SqlCommand cmd = new SqlCommand(sSql, LocalAccess.l_Connection))
            {
                cmd.Parameters.Add(new SqlParameter("code", this.sCompanyCode));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
