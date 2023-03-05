using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CompanyInvoker
    {
        public List<OrderCommand> Orders = new List<OrderCommand>();

        public void TakeOrder(OrderCommand command)
        {
            Orders.Add(command);
        }
        public void ProcessOrders()
        {
            foreach(OrderCommand command in Orders)
            {
                command.Execute();
            }
        }
    }
}
