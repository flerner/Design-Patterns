using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Form1 : Form
    {
        Chat _chat;
        User u1;
        User u2;
        public Form1()
        {
            InitializeComponent();
            _chat = new Chatroom();
            u1 = new User1("User 1");
            u2 = new User2("User 2");

            _chat.Register(u1);
            _chat.Register(u2);
        }

        private void btnUser1_Click(object sender, EventArgs e)
        {
            _chat.Send(txtBoxUser1.Text, u2, u1);
            ShowAllMessages();
            ShowMessagesU2();
        }

        private void ShowMessagesU2()
        {
            this.listBoxUser2.DataSource = null;
            this.listBoxUser2.DataSource = u2.Messages;
        }

        private void ShowAllMessages()
        {
            this.listBoxAllMessages.DataSource = null;
            this.listBoxAllMessages.DataSource = _chat.Messages;
        }
        public void ShowMessagesU1()
        {
            this.listBoxUser1.DataSource = null;
            this.listBoxUser1.DataSource = u1.Messages;
        }

        private void btnUser2_Click(object sender, EventArgs e)
        {
            _chat.Send(txtBoxUser2.Text, u1, u2);
            ShowAllMessages();
            ShowMessagesU1();
        }
    }
}
