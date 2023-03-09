using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class User
    {
        List<Message> _messages;
        string _name;

        public User(string name)
        {
            this._name = name;
            this._messages = new List<Message>();
        }

        public Message[] Messages
        {
            get
            {
                return _messages.ToArray();
            }
        }
        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return _name;
        }
        public Chat Chat { get; set; }

        public void Send(string _message, User _receiver)
        {
            Chat.Send(_message, _receiver, this);
        }
        public void Receive(Message msg)
        {
            _messages.Add(msg);
        }
    }
}
