using System;

namespace ConsoleApp26
{
    class Node<T>
    {
        T Value;
        Node<T> Next;
        public Node(T value, Node<T> node)
        {
            this.Value = value;
            this.Next = node;
        }
        public Node(T value) : this(value, null)
        {

        }

        public Node()
        {
        }

        public T GetValue()
        {
            return this.Value;
        }
        public void SetValue(T value)
        {
            Value = value;
        }
        public Node<T> GetNext()
        {
            return Next;
        }
        public void SetNext(Node<T> next)
        {
            Next = next;
        }
    }
    internal class Program
    {
        static Node<T> RemoveFirstItem<T>(Node<T> h)
        {
            return h.GetNext();
        }
        static void RemoveItem<T>(Node<T> h, int index)
        {
            Node<T> temp = h;
            int count = 1;
            Node<T> previous = h;
            while (count < index)
            {
                previous = temp;
                temp = temp.GetNext();
                count++;
            }
            Node<T> Remove = temp.GetNext();
            previous.SetNext(Remove);

        }
        static void RemoveLastItem<T>(Node<T> h)
        {
            Node<T> previous = null;
            while (h.GetNext() != null)
            {
                previous = h;
                h = h.GetNext();
            }
            previous.SetNext(null);
        }
        static Node<T> AddToHead<T>(Node<T> h, Node<T> add)
        {
            add.SetNext(h);
            return add;
        }
        static Node<T> AddToMiddle<T>(Node<T> h, Node<T> add, int index)
        {
            Node<T> temp = h;
            Node<T> previous = h;
            int count = 1;
            while (count < index)
            {
                previous = temp;
                temp = temp.GetNext();
                count++;
            }
            Node<T> remove = temp;
            previous.SetNext(add);
            add.SetNext(remove);
            return h;
        }
        static void AddToLast<T>(Node<T> h, Node<T> add)
        {
            Node<T> temp = h;
            while (temp.GetNext() != null)
            {
                temp = temp.GetNext();
            }
            temp.SetNext(add);
        }
        static Node<int> AddToSortedList(Node<int> h, Node<int> add)
        {
            if (add.GetValue() <= h.GetValue())
            {
                return AddToHead<int>(h, add);
            }
            else
            {
                Node<int> temp = h;
                int count = 1;
                while (temp.GetNext() != null)
                {
                    if (temp.GetValue() <= add.GetValue() && temp.GetNext().GetValue() >= add.GetValue())
                    {
                        return AddToMiddle<int>(h, add, count + 1);
                    }
                    temp = temp.GetNext();
                    count++;
                }
                if (add.GetValue() > temp.GetValue())
                {
                    AddToLast(h, add);
                }
            }
            return h;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Node<int> head = new Node<int>(r.Next(1, 50));
            Node<int> previous = head;
            Node<int> current;
            for (int i = 0; i < 10; i++)
            {
                head = AddToSortedList(head, new Node<int>(r.Next(1, 11)));
                //current = new Node<int>(i);
                //previous.SetNext(current);
                //previous = current;
            }

            Node<int> temp = head;
            int count = 1;
            while (temp.GetNext() != null)
            {
                Console.Write(count + " ");
                Console.WriteLine(temp.GetValue());
                temp = temp.GetNext();
                count++;
            }
            Console.WriteLine(temp.GetValue());
            //AddToMiddle<int>(head, new Node<int>(100), 5);
            Console.WriteLine();
            Node<int> temp2 = head;
            while (temp2.GetNext() != null)
            {

                Console.WriteLine(temp2.GetValue());
                temp2 = temp2.GetNext();
            }
            Console.WriteLine(temp2.GetValue());
        }
    }
}
