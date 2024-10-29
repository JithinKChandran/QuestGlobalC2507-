using ECommerceCartManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCartManagement.Services
{
    public class Cart
    {
        private List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            items.Add(item);
        }

        public void UpdateItem(string itemName, int newQuantity)
        {
            foreach (var item in items)
            {
                if (item.Name == itemName)
                {
                    item.Quantity = newQuantity;
                    break;
                }
            }
        }

        public void RemoveItem(string itemName)
        {
            items.RemoveAll(item => item.Name == itemName);
        }

        public List<CartItem> GetItems()
        {
            return items;
        }
    }

}
