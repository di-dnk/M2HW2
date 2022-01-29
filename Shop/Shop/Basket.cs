using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Basket
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public List<Product> AddedProducts => Products.ToList();
        

        public void Add(string product)
        {
            Catalog catalog = new Catalog();
            for (int j = 0; j < catalog.Products.Length; j++)
            {
                if (catalog.Products[j].Name == product)
                {
                    Products.Add(catalog.Products[j]);
                    break;
                }
            }           
        }
        public void Remove(string product)
        {
            foreach (Product p in Products)
                if (p.Name == product)
                {
                    Products.Remove(p);
                    break;
                }            
        }
    }
}
