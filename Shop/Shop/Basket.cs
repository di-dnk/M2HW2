using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Basket
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void Add(string product)
        {
            Catalog catalog = new Catalog();
            for (int j = 0; j < catalog.Products.Length; j++)
            {
                if (catalog.Products[j].Name == product)
                    Products.Add(catalog.Products[j]);
            }           
        }                 
    }
}
