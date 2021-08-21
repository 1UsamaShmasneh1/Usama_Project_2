using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    public class Queue<T>
    {
        T[] queue = new T[1000];
        public int top;
        public T Dequeue()
        {
            T removeditem;
            int count = 0;
            T temp = default(T);
            if (!(top < 0))
            {
                removeditem = queue[0];
                for(int i = 1; i < queue.Length; i++)
                {
                    queue[count++] = queue[i];
                }
            }
            return temp;
        }
        public void Enqueue(T item)
        {
            if (top == queue.Length - 1)
            {
                Debug.WriteLine("no range");
            }
            else
            {
                queue[++top] = item;
            }
        }
    }
}
