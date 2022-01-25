using System;
using System.Linq;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            Customer customer = new Customer();
            customer.Name = Console.ReadLine();
            
            Catalog catalog = new Catalog();
            
            catalog.Products.Add(new Product("Product1", 122.7, 0));
            catalog.Products.Add(new Product("Product1", 122.7, 1));
            catalog.Products.Add(new Product("Product1", 122.7, 2));
            catalog.Products.Add(new Product("Product1", 122.7, 3));
            catalog.Products.Add(new Product("Product1", 122.7, 4));
            catalog.Products.Add(new Product("Product1", 122.7, 5));
              
            foreach (Product product in catalog.Products)
                Console.WriteLine($"{product.Name} Price: {product.Price} Item number: {product.Id}");

            Console.WriteLine("Select products (Enter item number or -1 to to complete the purchase)");
            Basket basket = new Basket();

            for (int i = 0; i < 10; i++)
            {
                int index = int.Parse(Console.ReadLine());
                if(index == -1)
                    break;
                else
                    basket.Add(catalog.Products[index]);
            }

            Order order = basket.MakeOrder(customer);
            
            Console.WriteLine($"{customer.Name}, your code order {order.Id} in the amount of {order.TotalPrice} UAH");
        }
    }
}
