using System.Collections.Generic;

namespace Mediator
{
    public abstract class Chat
    {
        protected List<Message> _messages;

        public Chat() 
        { 
            _messages = new List<Message>(); 
        }

        public Message[] Messages
        {
            get
            {
                return _messages.ToArray();
            }
        }

        public abstract void Send(string _message, User _to, User from);
        public abstract void Register(User _user);



    }
}