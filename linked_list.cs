// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    class Node
    {
        public Object value;
        public Node next = null;

        public override string ToString()
        {
            return $"{value}";
        }
    }

    class LinkedList
    {
        Node head;
        
        public void Add(Object value)
        {
            if (head == null)
            {
                head = new Node();
                head.value = value;
                return ;
            }
            Node current = head;
            Node newItem = new Node();
            while(current.next != null)
            {
                current = current.next;
            }
            newItem.value = value;
            current.next = newItem;
            return ;
        }
        
        public void Remove()
        {
            Node current = head;
            while(current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
            return ;
        }
        
        public void Print()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write($"{current} -> ");
                current = current.next;
            }
        }
        
    }
    public static void Main(string[] args)
    {
        LinkedList haha = new LinkedList();
        haha.Add("4");
        haha.Add("5");
        haha.Add("4");
        haha.Add("4");
        haha.Add("4");
        haha.Add(4);
        haha.Remove();
        haha.Remove();
        haha.Print();
    }
}