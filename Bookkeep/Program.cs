using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace Bookkeep
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                string sConfigFile = "Config.xml";
                XmlDocument xml = new XmlDocument();
                xml.Load(sConfigFile);
                XmlNodeList nodes = xml.GetElementsByTagName("add");
                foreach (XmlNode node in nodes)
                {
                    if (node.Attributes["name"].Value == "ConnectionString")
                        LocalAccess.l_ConnectionString = node.Attributes["value"].Value;
                }
            }
            catch { LocalAccess.l_ConnectionString = ""; }

            if (LocalAccess.l_ConnectionString == "")
            {
                MessageBox.Show("No connection is setted", "No Connection");
                return;
            }
            LocalAccess.l_Connection = new SqlConnection(LocalAccess.l_ConnectionString);
            LocalAccess.l_Connection.Open();

            Application.Run(new frmMain());
        }
    }
}
