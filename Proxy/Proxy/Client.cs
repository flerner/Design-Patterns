using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client
    {
        public void Save(IRepository repository, Customer customer)
        {
            repository.Save(customer);
        }
        public IList<Customer> GetAll(IRepository repository)
        {
            return repository.GetAll();
        }
    }
}
