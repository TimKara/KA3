using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecretAgentClientDB
{
    public partial class SecretAgent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFindAgent_Click(object sender, EventArgs e)
        {
            ListBoxRealName_Licenses.Items.Clear();
            if (TextBoxCodeName.Text.Equals(""))
            {
                ListBoxRealName_Licenses.Items.Add("Please type the agent code name");
            }
            else
            {
                try
                {
                    SecretAgentServiceEngland.SecretAgentService agentserviceobject = new SecretAgentServiceEngland.SecretAgentService();
                    SecretAgentServiceEngland.Agent a;
                    ClientAgent ca;
                    a = agentserviceobject.AgentInfo(TextBoxCodeName.Text);
                    ca = new ClientAgent(a);
                    TextBoxCodeName.Text = ca.codeName;
                    ListBoxRealName_Licenses.Items.Add(ca.ToString());
                    if (a.licenses != null)
                    {
                        ListBoxRealName_Licenses.Items.Add("List of licenses:");
                        foreach (string s in a.licenses)
                        {
                            ListBoxRealName_Licenses.Items.Add(s);
                        }
                    }
                    else
                    {
                        ListBoxRealName_Licenses.Items.Add("Without a license!");
                    }
                }
                catch
                {
                    ListBoxRealName_Licenses.Items.Add("Database is offline... Please try again later..");
                }
            }
            ListBoxRealName_Licenses.Focus();
        }
    }
}