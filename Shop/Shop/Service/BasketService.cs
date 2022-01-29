using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class BasketService
    {
        private static readonly BasketService instance = new BasketService();
        private readonly Basket _basket = new Basket();
        
        public List<Product> AddedProducts => _basket.Products.ToList();
        
        static BasketService()
        {
        }

        private BasketService()
        {
        }

        public static BasketService Instance
        {
            get
            {
                return instance;
            }
        }       

        public void AddProduct()
        {
            Console.WriteLine("Select products (Enter the product name or 0 to complete the purchase)");
            
            for (int i = 0; i < 10; i++)
            {
                string product = Console.ReadLine();
                if (product == "0")
                    break;
                else
                    _basket.Add(product);
            }
        }
    }
}
