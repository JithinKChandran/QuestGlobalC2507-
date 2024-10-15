using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9._2.Inventory
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, object>> inventory = new Dictionary<string, Dictionary<string, object>>();

        static void AddProduct()
        {
            Console.WriteLine("Enter product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            var price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter product stock: ");
            var stock = int.Parse(Console.ReadLine());

            var productId = Guid.NewGuid().ToString();
            inventory[productId] = new Dictionary<string, object>
        {
            { "Name", name },
            { "Price", price },
            { "Stock", stock }
        };

            Console.WriteLine($"Product added successfully: {productId}");
        }

        static void UpdateStock()
        {
            Console.WriteLine("Enter product ID: ");
            var productId = Console.ReadLine();
            if (inventory.ContainsKey(productId))
            {
                Console.WriteLine("Enter new stock quantity: ");
                var stock = int.Parse(Console.ReadLine());
                inventory[productId]["Stock"] = stock;
                Console.WriteLine("Stock updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void GetProductDetails()
        {
            Console.WriteLine("Enter product ID: ");
            var productId = Console.ReadLine();
            if (inventory.ContainsKey(productId))
            {
                var product = inventory[productId];
                Console.WriteLine("Name: " + product["Name"]);
                Console.WriteLine("Price: " + product["Price"]);
                Console.WriteLine("Stock: " + product["Stock"]);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter the stock minimum limit: ");
            var limit = int.Parse(Console.ReadLine());
            foreach (var item in inventory)
            {
                var product = item.Value;
                if ((int)product["Stock"] < limit)
                {
                    Console.WriteLine("ID: " + item.Key);
                    Console.WriteLine("Name: " + product["Name"]);
                    Console.WriteLine("Price: " + product["Price"]);
                    Console.WriteLine("Stock: " + product["Stock"]);
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
