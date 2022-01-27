using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {
        public int Id { get; private set; }
       
        public List<Product> Products { get; private set; }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0M;
                foreach (Product product in Products)
                    totalPrice += product.Price;
                
                return totalPrice;
            }
        }

        public Order(int id, List<Product> products)
        {
            Id = id;            
            Products = products;
        }
    }
}
