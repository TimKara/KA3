using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace SecretAgentServiceDB
{
    public class Agent
    {
        public string codeName { set; get; }
        public string realName { set; get; }
        public ArrayList licenses { set; get; }
    }
}