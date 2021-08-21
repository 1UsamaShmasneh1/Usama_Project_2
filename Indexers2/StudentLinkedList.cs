using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class StudentLinkedList
    {
        private class Node
        {
            public Student? Data { get; set; }
            public Node? Next { get; set; }
            public override string ToString()
            {
                return "Node " + Data.Name;
            }
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
        //public void GetStudentByName(StudentLinkedList list)
        //{
        //    if (head == null)
        //    {
        //        Debug.WriteLine("there are no students");
        //    }
        //    else
        //    {
        //        Node node = head;
        //        while (node != null)
        //        {
        //            node = node.Next;
        //        }
        //        node.Next = new Node() { Data = student, Next = null };
        //    }
        //}
    }
}
