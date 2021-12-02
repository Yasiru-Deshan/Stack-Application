using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Exercise
{
    class Stack
    {
        private readonly List<object> items = new List<object>();
        public void Push(object obj)
        {
            if( obj == null)
                throw new InvalidOperationException("Items cannot be null");
          
            items.Add(obj);
        }
        public object Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("No items in the stack");

            var index = items.Count - 1;

            var remover = items[index];

            items.RemoveAt(index);

            return remover;
        }

        public void Clear()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("No items in the stack");

            items.Clear();

        }
    }
}
