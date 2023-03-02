using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Customer
    {
        private string _name;
        public string Name { get { return _name;}}
        public Customer(string name) 
        {
            this._name = name;
        }

    }
}
