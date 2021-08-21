using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usama_Project_2
{
    public class StudentLinkedList
    {
        private class Node
        {
            public Student? Data { get; set; }
            public Node? Next { get; set; }
        }
        private Node? head = null;
        //public Student First()
        //{

        //}
        public void Add(Student student)
        {
            if(head == null)
            {
                Node node = new Node() { Data = student, Next = null };
                head = node;
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    node = node.Next;
                }
                node.Next = new Node() { Data = student, Next = null };
            }
        }
    }
}
