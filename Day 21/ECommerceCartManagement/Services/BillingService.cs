using ECommerceCartManagement.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCartManagement.Services
{
    public class BillingService
    {
        public decimal CalculateTotal(Cart cart, IDiscountStrategy discountStrategy)
        {
            decimal total = 0;
            foreach (var item in cart.GetItems())
            {
                total += item.Price * item.Quantity;
            }
            return discountStrategy.ApplyDiscount(total);
        }
    }

}
