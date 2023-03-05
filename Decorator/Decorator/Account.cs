using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Account
    {
        private string _client;
        private string _id;
        public string Client
        {
            get { return _client; }
        }
        public Account() { }   
        public Account(string client, string id)
        {
            _client = client;
            _id = id;
        }
        

    }
}
