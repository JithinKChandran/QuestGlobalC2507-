using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingList
{
    public class StackUsingList<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new StackEmptyException();
            }

            int lastIndex = _items.Count - 1;
            T item = _items[lastIndex];
            _items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new StackEmptyException();
            }

            return _items[_items.Count - 1];
        }

        public int Count => _items.Count;
    }
}