using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Chatroom : Chat
    {
        IDictionary<string, User> _users;

        public Chatroom()
        {
            _users = new Dictionary<string, User>();
        }

        public override void Register(User _user)
        {
            if (!_users.ContainsKey(_user.Name))
            {
                _users.Add(_user.Name, _user);
            }
        }
        //throug this mediator, user 1 and 2 can communicate without knowing each other, and the buttons "send", doesn't have to have the logic for showing the
        //messages on the listbox, and now the depend on a new class mediator, who does all the work. We could easily add a new user, and all we have to do in the 
        //buttons is change the receiver and the sender and this class will do all the work.
        public override void Send(string _message, User _to, User from)
        {
            Message msg = new Message();
            msg.From = from;
            msg.To = _to;
            msg.Text = _message;

            if(_users.ContainsKey(_to.Name)) 
            {
                _users[_to.Name].Receive(msg);
                _messages.Add(msg);
            }
        }
        
    }
}
