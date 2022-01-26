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
        public Customer Customer { get; private set; }
        public Product[] Products { get; private set; }

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

        public Order(int id, Customer customer, Product[] products)
        {
            Id = id;
            Customer = customer;
            Products = products;
        }
    }
}
