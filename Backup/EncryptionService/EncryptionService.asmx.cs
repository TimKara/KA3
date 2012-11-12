using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EncryptionService
{
    /// <summary>
    /// Summary description for EncryptionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EncryptionService : System.Web.Services.WebService
    {
        private CaesarCipher cc = new CaesarCipher();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Encrypt(string message, int key) // "Caesar Cipher" encryption.
        {            
            return cc.Encrypt(message, key);
        }

        [WebMethod]
        public string Decrypt(string message, int key) // "Caesar Cipher" decryption.
        {
            return cc.Encrypt(message, -key); // et minus(-) foran "key" bliver det til en decryption metode.
        }
    }
}
