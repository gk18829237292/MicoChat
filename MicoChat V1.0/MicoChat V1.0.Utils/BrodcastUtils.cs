using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MicoChat_V1._0.Entry;

namespace MicoChat_V1._0.Utils
{
    public class BrodcastUtils
    {

        public delegate void Recive(BrodecastEntry entry);
        public static event Recive recive;

        /// <summary>
        /// 发送广播
        /// </summary>
        /// <param name="entry"></param>
        public static void SendBrodcast(BrodecastEntry entry)
        {
           
        }

     

        /// <summary>
        /// 要使用线程，最后把接受到的实体，调用recive(entry)；
        /// </summary>
        public static void StartRecive()
        {
            BrodecastEntry entry = new BrodecastEntry();
            //TODO 在这里实现 线程接受，注意这个线程要一直存活且唯一，每接收到一个，调用 recive(entry); 去返回。
            // tips.这块可以去写，如果不会的话，可以写一下 怎么去实现 线程一直存活 且唯一，就是 即使我调用多次 这个函数，也要保证  线程唯一。
            // 收到消息之后，判断消息的flag,如果是 1 则 不需要 回执，0 需要回执。
            
            recive(entry);
        }

       


    }
}
