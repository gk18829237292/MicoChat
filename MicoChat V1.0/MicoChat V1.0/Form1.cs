using MicoChat_V1._0.Entry;
using MicoChat_V1._0.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicoChat_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        ///  发送上线通知
        ///  启动监听线程1
        ///  启动监听线程2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            BrodcastUtils.SendBrodcast(new BrodecastEntry("hua", 0));
            BrodcastUtils.StartRecive();
            BrodcastUtils.recive += BrodcastUtils_recive;
        }

        private void BrodcastUtils_recive(Entry.BrodecastEntry entry)
        {
            UserEntry ue = new UserEntry();
            ue.ip = entry.ip;
            ue.Name = entry.UserName;
            UserManger.AddUser(ue);
            lb_UserList.Items.Add(entry.UserName);
            //throw new NotImplementedException();
        }

        private void lb_UserList_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(lb_UserList.SelectedIndex);
            //Console.WriteLine(sender);
            UserManger.showFrom(lb_UserList.SelectedIndex);
        }
    }
}
