using ECommerceCartManagement.Discounts;
using ECommerceCartManagement.Models;
using ECommerceCartManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCartManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.AddItem(new CartItem { Name = "Item1", Quantity = 2, Price = 50 });
            cart.AddItem(new CartItem { Name = "Item2", Quantity = 1, Price = 30 });

            var discountStrategy = new PercentageDiscount();
            var billingService = new BillingService(discountStrategy);
            var totalAmount = billingService.CalculateTotalAmount(cart.GetItems());
            Console.WriteLine($"Total amount: {totalAmount}");
        }
    }
}
