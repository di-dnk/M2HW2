using System;
using System.Linq;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            MarketService.Instance.ShowCatalog();
            Console.WriteLine("Select products (Enter the product name or 0 to complete the purchase)");
            MarketService.Instance.Initialize();
            for (int i = 0; i < 10; i++)
            {
                string product = Console.ReadLine();
                if (product == "0")
                    break;
                else
                    MarketService.Instance.AddProduct(product);
            }
            MarketService.Instance.MakeOrder();           
        }
    }
}
