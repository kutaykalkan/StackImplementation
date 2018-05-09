using System;

namespace StackImplementation
{
    /// <summary>
    /// Simple stack implementation with Array. This version does not reduce capacity as items get deleted.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        private T[] _stack;

        public Stack(int capacity = 8)
        {
            if(capacity <= 0)
                throw new ArgumentException("Capacity can not be 0");
            Capacity = capacity;
            _stack = new T[capacity];
        }

        public int Size { get; private set; }

        public int Capacity { get; private set; }

        public bool IsEmpty => Size == 0;

        public void Push(T item)
        {
            EnsureCapacity();
            _stack[Size++] = item;
        }

        public T Pop()
        {
            if(Size <= 0)
                throw new Exception("There are no items in the stack!");
            T returnVal = _stack[Size-1];
            _stack[Size-1] = default(T);
            Size--;

            return returnVal;
        }

        private void EnsureCapacity()
        {
            if (Size == Capacity)
            {
                var tmp = _stack;
                Capacity = Capacity * 2;
                _stack = new T[Capacity];
                Array.Copy(tmp, _stack, tmp.Length);
            }
        }
    }
}