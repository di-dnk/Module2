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
        public List<Product> Products { get; private set; }

        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (Product product in Products)
                    totalPrice += product.Price;
                
                return totalPrice;
            }
        }

        public Order(int id, Customer customer, List<Product> products)
        {
            Id = id;
            Customer = customer;
            Products = products;
        }
    }
}
