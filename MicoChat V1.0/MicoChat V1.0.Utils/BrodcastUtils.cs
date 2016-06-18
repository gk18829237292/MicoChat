using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;

using MicoChat_V1._0.Entry;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

namespace MicoChat_V1._0.Utils
{
    public class BrodcastUtils
    {

        public delegate void Recive(BrodecastEntry entry);
        public static event Recive recive;


        private static Socket send = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private static Socket rec = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        /// <summary>
        /// 发送广播
        /// </summary>
        /// <param name="entry"></param>
        public static void SendBrodcast(BrodecastEntry entry)
        {
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 9050);
            send.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            send.SendTo(ObjectTobyte(entry), iep1);
            Console.WriteLine("send: {0} to: {1}", entry.ToString(), iep1.ToString());
            send.Close();
        }

        private static Thread thread  = new Thread(NewMethod);

        /// <summary>
        /// 要使用线程，最后把接受到的实体，调用recive(entry)；
        /// </summary>
        public static void StartRecive()
        {
            if (thread.IsAlive) return;
            thread.Start();
        }

        private static void NewMethod()
        {
            byte[] data = new byte[1024];
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            BrodecastEntry entry = null;
            rec.Bind(iep);
            while (true)
            {

                //TODO 在这里实现 线程接受，注意这个线程要一直存活且唯一，每接收到一个，调用 recive(entry); 去返回。
                // tips.这块可以去写，如果不会的话，可以写一下 怎么去实现 线程一直存活 且唯一，就是 即使我调用多次 这个函数，也要保证  线程唯一。
                // 收到消息之后，判断消息的flag,如果是 1 则 不需要 回执，0 需要回执。


                EndPoint ep = (EndPoint)iep; //获取发送广播主机的确切通信ip


                int recv = rec.ReceiveFrom(data, ref ep);  //同步调用，此处会被阻塞.

                entry = (BrodecastEntry)byteToObject(data);
                Console.WriteLine("received: {0} from: {1}", entry.ToString(), ep.ToString());
                IPEndPoint riep = (IPEndPoint)ep;
                entry.ip = riep.Address;
                recive(entry);
                if (entry.flag == 1)
                {
                    continue;
                }
                //string stringData = Encoding.Default.GetString(data, 0, recv);
                //Messenger msg = CommonTools.Deserialize<Messenger>(new Messenger(), data);
                //msg.IP = ep.ToString();

                //Console.WriteLine("received: {0} from: {1}", msg.HostName, msg.IP);
                BrodecastEntry en = new BrodecastEntry("lu", 1);
                //9050

                
                riep.Port = 9050;
                Socket rsend = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                rsend.SendTo(ObjectTobyte(en), riep);
                Console.WriteLine("rsend: {0} to: {1}", en.ToString(), ep.ToString());
                rsend.Close();


            }
            rec.Close(); //关闭连接
        }

        public static byte[] ObjectTobyte(object obj)//对象转字节数组
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter serilaze = new BinaryFormatter();
            serilaze.Serialize(memStream, obj);
            return memStream.ToArray();
        }
        public static object byteToObject(byte[] data)//对象转字节数组
        {
           var memory = new MemoryStream(data) {Position = 0};  
            var formatter = new BinaryFormatter();  
            object newOjb = formatter.Deserialize(memory);
            return newOjb;
        }


    }
}
