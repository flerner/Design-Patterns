using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        private CustomerRepository _real;

        public CustomerRepositoryProxy(CustomerRepository real)
        {
            _real = real;
        }

        public IList<Customer> GetAll()
        {
            if (Session.CanAcces)
            {
                return _real.GetAll();
            }
            else
            {
                throw new AccessViolationException();
            }
        }

        public void Save(Customer customer)
        {
            if (Session.CanSave)
            {
                _real.Save(customer);
            }
            else
            {
                throw new AccessViolationException();
            }
        }
    }
}
