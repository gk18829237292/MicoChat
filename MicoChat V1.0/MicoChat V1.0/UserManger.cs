using MicoChat_V1._0.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicoChat_V1._0
{
    class UserManger
    {
        public static String name { get; set; }

        private static List<UserEntry> userList { get; set; }

        public Dictionary<int, ChatForm> formManager = new Dictionary<int, ChatForm>();

        static UserManger()
        {
            userList = new List<UserEntry>();
        }

        public static void AddUser(UserEntry entry)
        {
            userList.Add(entry);
        }

        public static UserEntry GetUser(int index)
        {
            return userList[index];
        }

        public static void showFrom(int index)
        {
            //
        }

    }

}
