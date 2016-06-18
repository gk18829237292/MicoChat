using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MicoChat_V1._0.Entry
{
    /// <summary>
    /// 广播消息实体
    /// </summary>
    [Serializable]
    public class BrodecastEntry
    {
        public IPAddress ip { set; get; }
       public BrodecastEntry(string name, int flag)
        {
            this.UserName = name;
            this.flag = flag;
            
        }
        public String UserName { get; set; }

        /// <summary>
        ///  0 代表 为广播发送方
        ///  1 代表 为信息回执，即告诉我在线
        /// </summary>
        public int flag { get; set; }

        public override string ToString()
        {
            return String.Format("UserName:{0}; flag:{1}", UserName, flag);
        }
    }
}
