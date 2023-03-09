using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Message
    {
        private DateTime _date;

        public Message()
        {
            _date = DateTime.Now;
        }

        public User From { get; set; }
        public User To { get; set; }
        public string Text { get; set; }
        public DateTime Date { get { return _date;} }

        public override string ToString()
        {
            return $"Message at {Date.ToShortDateString()} from {From} to {To} ---> {Text}";
        }
    }
}
