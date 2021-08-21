using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    public class Stack<T>
    {
        T[] stack = new T[1000];
        public int top;
        public T Peek()
        {
            T item;
            T temp = default(T);
            if(!(top <= 0))
            {
                return item = stack[top];
            }
            return temp;
        }
        public T Pop()
        {
            T removeditem;
            T temp = default(T);
            if (!(top <= 0))
            {
                removeditem = stack[top--];
                return removeditem;
            }
            return temp;
        }
        public void Push(T item)
        {
            if(top == stack.Length - 1)
            {
                Debug.WriteLine("no range");
            }
            else
            {
                stack[++top] = item;
            }
        }
    }
}
