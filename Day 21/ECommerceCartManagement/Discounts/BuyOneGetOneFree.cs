using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCartManagement.Discounts
{
    public class BuyOneGetOneFree : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total / 2;
        }
    }

}
