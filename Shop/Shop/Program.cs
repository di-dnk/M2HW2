using System;
using System.Linq;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            Customer customer = new Customer();
            customer.Name = Console.ReadLine();
            
            Catalog catalog = new Catalog();                       
            foreach (Product product in catalog.Products)
                Console.WriteLine($"{product.Name} Price: {product.Price}");

            Console.WriteLine("Select products (Enter the product name or 0 to complete the purchase)");
            Basket basket = new Basket();
            basket.Add();
                        
            Notification notification = new Notification();
            Order order = notification.MakeOrder(customer, basket);
            
            Console.WriteLine($"{customer.Name}, your code order {order.Id} in the amount of {order.TotalPrice} UAH");
        }
    }
}
