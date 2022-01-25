using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Basket
    {
        private List<Product> Products { get; set; } = new List<Product>();
        
        public void Add(Product product) => 
            Products.Add(product);

        public Order MakeOrder(Customer customer)
        {
            Order order = new Order(new Random().Next(0, 99999), customer, Products.ToList());

            return order;
        }
    }
}
