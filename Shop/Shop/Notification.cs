using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Notification
    {        
        public Order MakeOrder(Customer customer, Basket basket)
        {
            Order order = new Order(new Random().Next(0, 99999), customer, basket.Products);

            return order;
        }
    }
}
