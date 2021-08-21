using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class GeneralLinkedList<T> where T: Student
    {
       
        private class Node
        {
            public T Data { get; set; }
            public Node? Next { get; set; }
            public override string ToString()
            {
                return "Node ";
            }
        }
        private Node? head = null;
        //public Student First()
        //{

        //}
        public void Add(T data)
        {
            if(head == null)
            {
                Node node = new Node() { Data = data, Next = null };
                head = node;
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    node = node.Next;
                }
                node.Next = new Node() { Data = data, Next = null };
            }
        }
        public T GetById(int id)
        {
            Node node = head;
            while (node.Next != null)
            {
                if(node.Data.Id == id)
                {
                    return node.Data;
                }
            }
            return null;
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
