using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicoChat_V1._0.Entry
{
    public class UserEntry
    {
        public String Name { get; set; }

        public List<String> ChatHistory { get; set; }

        public UserEntry()
        {
            ChatHistory = new List<string>();
        }


    }
}
