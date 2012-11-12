using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Data.OleDb;
using System.Collections;



namespace SecretAgentServiceDB
{
    /// <summary>
    /// Summary description for SecretAgentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    
    public class SecretAgentService : System.Web.Services.WebService
    {
        [WebMethod]
        [XmlInclude(typeof(Agent))]
        public Agent AgentInfo(string name)
        {
            Agent a = new Agent();

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data source = " + Server.MapPath("~/App_Data/KA3_Secret_Agent_DB.mdb"));
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Real_Name from CODE_NAMES where Code_Name = '" + name + "'";
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                a.codeName = name;
                a.realName = rdr["Real_Name"].ToString();
                rdr.Close();
                cmd.CommandText = @"select Licenses from AGENT_LICENSES where Real_Name = '" + a.realName + "'";
                rdr = cmd.ExecuteReader();
                ArrayList licenses = new ArrayList(); 
                while (rdr.Read())
                {
                    licenses.Add(rdr["Licenses"].ToString());
                }
                a.licenses = licenses;
            }
            else
            {
                a.codeName = name;
                a.realName = "Unknown and was not found in the system database";
            }
            rdr.Close();

            return a;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
