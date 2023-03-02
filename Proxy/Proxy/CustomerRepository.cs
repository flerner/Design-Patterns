using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CustomerRepository : IRepository
    {
        private List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>();
        }
        public IList<Customer> GetAll()
        {
            return this._customerList;
        }

        public void Save(Customer customer)
        {
            this._customerList.Add(customer);
        }
    }
}
