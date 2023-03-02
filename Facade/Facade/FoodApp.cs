using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FoodApp
    {
        private DeliveryCompany _delivery;
        private Restaurant _restaurant;

        public FoodApp(DeliveryCompany delivery, Restaurant restaurant)
        {
            _delivery = delivery;
            _restaurant = restaurant;
        }
        public void MakeOrder()
        {
            _restaurant.PrepareOrder();
            _delivery.DeliverOrder();
        }
    }
}
