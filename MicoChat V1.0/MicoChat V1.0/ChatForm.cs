using MicoChat_V1._0.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicoChat_V1._0
{
    public partial class ChatForm : Form
    {

        UserEntry entry;
        public ChatForm(UserEntry entry)
        {
            InitializeComponent();
            this.entry = entry;
            //初始化
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
