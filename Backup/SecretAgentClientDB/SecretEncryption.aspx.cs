using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecretAgentClientDB
{
    public partial class SecretEncryption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (TextBoxMessage.Text.Equals(""))
            {
                TextBoxMessage.Text = "Please type the message here!";
            }
            else
            {
                EncryptionServiceRome.EncryptionService encryptionserviceobject = new EncryptionServiceRome.EncryptionService();
                try
                {
                    TextBoxMessage.Text = encryptionserviceobject.Encrypt(TextBoxMessage.Text, Convert.ToInt32(TextBoxKey.Text));
                }
                catch (Exception ex)
                {
                    if (ex.TargetSite.Name.Equals("StringToNumber"))
                    {
                        TextBoxMessage.Text = "Error: Encryption Key must be a numeric value! Please enter a valid Encryption Key!";
                    }
                    else if (ex.TargetSite.Name.Equals("GetRequestStream"))
                    {
                        TextBoxMessage.Text = "Database is offline... Please try again later..";
                    }
                    else
                    {
                        TextBoxMessage.Text = "Unknown Error!";
                    }
                }
            }
        }

        protected void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (TextBoxMessage.Text.Equals(""))
            {
                TextBoxMessage.Text = "Please type the message here!";
            }
            else
            {
                EncryptionServiceRome.EncryptionService encryptionserviceobject = new EncryptionServiceRome.EncryptionService();
                try
                {
                    TextBoxMessage.Text = encryptionserviceobject.Decrypt(TextBoxMessage.Text, Convert.ToInt32(TextBoxKey.Text));
                }
                catch (Exception ex)
                {
                    if (ex.TargetSite.Name.Equals("StringToNumber"))
                    {
                        TextBoxMessage.Text = "Error: Encryption Key must be a numeric value! Please enter a valid Encryption Key!";
                    }
                    else if (ex.TargetSite.Name.Equals("GetRequestStream"))
                    {
                        TextBoxMessage.Text = "Database is offline... Please try again later..";
                    }
                    else
                    {
                        TextBoxMessage.Text = "Unknown Error!";
                    }
                }
            }
        }
    }
}