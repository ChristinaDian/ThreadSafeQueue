using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeQueue
{
    class ImmutableQueue<T>
    {
        T data;
        ImmutableQueue<T>? next;

        public ImmutableQueue(T value)
        {
            data = value;
            next = null;
        }
        public ImmutableQueue<T> Enqueue(T value)
        {
            if (this.next != null)
            {
                this.next.Enqueue(value);
            }
            else
            {
                var newQueue = new ImmutableQueue<T>(value);
                this.next = newQueue;
            }
            return this;
        }
        public ImmutableQueue<T>? Dequeue(out T value)
        {
            value = data;
            return next;
        }
        public ImmutableQueue<T>? Peek(out T value)
        {
            value = data;
            return this;
        }
    }
}
