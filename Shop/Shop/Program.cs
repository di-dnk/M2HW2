using System;
using System.Linq;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.CatalogService.Instance.ShowCatalog();
            Service.BasketService.Instance.AddProduct();
            Service.NotificationService.Instance.MakeOrder();
            Service.NotificationService.Instance.PrintOrder();
        }
    }
}
