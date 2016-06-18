using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MicoChat_V1._0.Entry
{
    [Serializable]
    public class UserEntry
    {
        public String Name { get; set; }

        public List<String> ChatHistory { get; set; }

        public IPAddress ip { get; set; }

        public UserEntry()
        {
            ChatHistory = new List<string>();
        }


    }
}
