using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCartManagement.Discounts
{
    public class FlatDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;

        public FlatDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - _amount;
        }
    }

}
