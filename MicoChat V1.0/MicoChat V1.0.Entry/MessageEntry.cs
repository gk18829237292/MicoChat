using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicoChat_V1._0.Entry
{
    /// <summary>
    /// 发送消息实体
    /// </summary>
    public class MessageEntry
    {
        //发送者 姓名
        public String UserName { get; set; }

        //发送的内容
        public String Content { get; set; }

    }
}
