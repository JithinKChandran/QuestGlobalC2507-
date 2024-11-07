using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class StackUsingArray<T>
    {
        private T[] _items;
        private int _index = 0;
        public int Size => _items.Length;

        public StackUsingArray() => _items = new T[100];
        public StackUsingArray(int size) => _items = new T[size];
        
        public void Push(T item)
        {
            if (_index == Size)
            {
                throw new StackOverflowException();
            }
            _items[_index++] = item;
        }

        public T Pop()
        {
            if (_index == 0 )
            {
                throw new StackEmptyException();
            }
            return _items[-- _index];
        }
        public T Peek() => _items[_index - 1];
    }
}
