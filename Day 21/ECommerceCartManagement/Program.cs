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

            var billingService = new BillingService();

            IDiscountStrategy discountStrategy = new PercentageDiscount(10); // 10% discount
            decimal total = billingService.CalculateTotal(cart , discountStrategy);

            Console.WriteLine("Total with Discount: " + total);
        }
    }
}
