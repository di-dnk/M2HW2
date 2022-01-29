using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Service;

namespace Shop
{
    public class MakeOrder
    {
        public void GenereteOrder()
        {
            Order order = new Order(new Random().Next(0, 99999), BasketService.Instance.AddedProducts);

            Console.WriteLine($"Your code order {order.Id} in the amount of {order.TotalPrice} UAH");
        }
        public void PrintOrder()
        {
            foreach(Product p in BasketService.Instance.AddedProducts)
                Console.WriteLine(p.Name);
        }
    }
}
