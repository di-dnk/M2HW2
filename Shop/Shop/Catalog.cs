using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Catalog
    {
        public Product[] Products = new Product[15];

        public Catalog()
        {
            Products[0] = new Product("Ice-cream", 30.9M);
            Products[1] = new Product("Apple", 12.5M);
            Products[2] = new Product("Cake", 300.0M);
            Products[3] = new Product("Carrot", 3.2M);
            Products[4] = new Product("Pear", 25.1M);
            Products[5] = new Product("Pineapple", 112.3M);
            Products[6] = new Product("Potato", 13.8M);
            Products[7] = new Product("Cucumber", 18.0M);
            Products[8] = new Product("Tomato", 9.6M);
            Products[9] = new Product("Cheesecake", 258.9M);
            Products[10] = new Product("Tiramisu", 347.6M);
            Products[11] = new Product("Yogurt", 22.2M); 
            Products[12] = new Product("Cheese", 159.7M);
            Products[13] = new Product("Persimmon", 24.5M);
            Products[14] = new Product("Peach", 33.3M);            
        }        
    }
}
