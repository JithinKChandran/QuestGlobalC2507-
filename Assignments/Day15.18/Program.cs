using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15._18
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Product 1", Price = 50 },
                new Product { Name = "Product 2", Price = 150 },
                new Product { Name = "Product 3", Price = 200 }
            };

            var filterSort = products.Where(p => p.Price > 100).OrderBy(p => p.Price).ToList();
            foreach (var product in filterSort)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
