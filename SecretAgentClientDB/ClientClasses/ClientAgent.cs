using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace SecretAgentClientDB
{
    public class ClientAgent
    {
        public string codeName { set; get; }
        public string realName { set; get; }
        
        public ClientAgent(SecretAgentServiceEngland.Agent a)
        {
            codeName = a.codeName;
            realName = a.realName;          
        }

        public override string ToString()
        {
            return "The real name of the agent is: "+ realName + ".";
        }
    }
}