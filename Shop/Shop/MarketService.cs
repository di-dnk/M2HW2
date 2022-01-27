using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class MarketService
    {
        private static readonly MarketService instance = new MarketService();

        static MarketService()
        {
        }

        private MarketService()
        {
        }

        public static MarketService Instance
        {
            get
            {
                return instance;
            }
        }

        private Basket basket;

        private Catalog catalog;

        public void Initialize()
        {
            basket = new Basket();
            
        }

        public void AddProduct(string product)
        {
            basket.Add(product);
        }
            
        public void ShowCatalog()
        {
            catalog=new Catalog();
            foreach (Product product in catalog.Products)
                Console.WriteLine($"{product.Name} Price: {product.Price}");
        }

        public void MakeOrder()
        {
            Order order = new Order(new Random().Next(0, 99999), basket.Products);

            Console.WriteLine($"Your code order {order.Id} in the amount of {order.TotalPrice} UAH");
        }

    }
}
