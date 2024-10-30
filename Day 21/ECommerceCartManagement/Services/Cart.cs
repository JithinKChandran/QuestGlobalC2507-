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
        private readonly List<CartItem> _items = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _items.Add(item);
            }

        }

        public void UpdateItem(string itemName, int newQuantity)
        {
            foreach (var item in _items)
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
            _items.RemoveAll(item => item.Name == itemName);
        }

        public List<CartItem> GetItems() => _items;
    }

}
