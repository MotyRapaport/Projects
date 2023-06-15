
using System;

namespace NodePractice
{
    class Node
    {
        int Value;
        Node Next;
      public  Node(int value, Node node) 
        {
            this.Value = value;
            this.Next = node;
        }
       public Node(int value): this(value, null)
        {

        }

        public Node()
        {
        }

        public int GetValue()
        {
            return this.Value;
        }
        public void SetValue(int value)
        {
            Value = value;
        }
        public Node GetNext()
        {
            return Next;
        }
        public void SetNext(Node next)
        {
            Next = next;
        }
    }
    class Program
    {
        static void AddToEnd(Node h, int val)
        {
            Node NewNode = new Node(val);
            Node temp = h;
            while(temp.GetNext() != null)
            {
                temp = temp.GetNext();
            }
            temp.SetNext(NewNode);
        }
        static void  RemoveLast(Node h)
        {
            Node temp = h;
            Node previous = null;
            while(temp.GetNext() != null)
            {
                previous = temp;
                temp = temp.GetNext();
            }
            previous.SetNext(null);
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Node head = new Node(r.Next(1, 50));
            Node previous = head;
            Node current;
            for (int i = 0; i < r.Next(100, 500); i++)
            {
                current = new Node(r.Next(1, 30));
                previous.SetNext(current);
                previous = current;

            }
            AddToEnd(head, 999);
            RemoveLast(head);
            Node temp = head;
            while(temp.GetNext() != null)
            {
                
                Console.WriteLine(temp.GetValue());
                temp = temp.GetNext();
            }
            Console.WriteLine(temp.GetValue());
            
       
     



        }
    }
}
