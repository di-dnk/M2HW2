using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Basket
    {
        public Product[] Products;

        public void Add()
        {
            Catalog catalog = new Catalog();
            string name;
            List<Product> Input = new List<Product>();
            for (int i = 0; i < 10; i++)
            {                               
                name = Console.ReadLine();
                if (name == "0")
                    break;
                else
                    for (int j = 0; j < catalog.Products.Length; j++)
                    {
                        if (catalog.Products[j].Name == name)
                            Input.Add(catalog.Products[j]);
                    }                                   
            }
            Products = Input.ToArray();
        }                 
    }
}
