using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class LinkedList<T> : Stack<T>
  {
    public Node<T> Head { get; set; }

    public LinkedList()
    {

    }

    public T kthFromEnd(int k)
    {
      int length = -1;
      Node<T> current =  Head;

      // Check is there is a list
      if (Head == null)
      {
        return (T)Convert.ChangeType(-2, typeof(T));
      }
      //Iterates over list and sets the length to a variabnle
      while (current != null)
      {
        length++;
        current = current.Next;
      }
      // Check if target node is with in range
      if (k > length | k < 0) return (T) Convert.ChangeType(-1, typeof(T));

      // resets current to Head
      current = Head;
      // Iterates over list until legnth - iterations equals the k target
      for (int i = length; i >= k; i--)
      {
        current = current.Next;
      }
      return current.Value;
    }

    public void Append(T value)
    {
      Node<T> node = new Node<T>(value);

      if (Head == null)
      {
        Head = node;
        return;
      }
    }

    public void InsertBefore(T target, T newVal)
    {
      Node<T> newNode = new Node<T>(newVal);
      Node<T> current = Head;

      if (current.Value.Equals(target))
      {
        Insert(newVal);
        return;
      }
      while (!current.Value.Equals(target))
      {
        // if current next value is equal to target
        if (current.Next.Value.Equals(target))
        {
          Node<T> oldNext = current.Next;
          // set current next to the new node
          current.Next = newNode;
          // set new node next to target (links the list back together)
          newNode.Next = oldNext;
          return;
        }
        current = current.Next; // keep searching until current is the target node
      }
      throw new Exception("Could not recognize given node value.");
    }

    public void InsertAfter(T target, T newVal)
    {
      Node<T> newNode = new Node<T>(newVal);
      Node<T> current = Head;
      bool end = false;
      // iterates over the linkedlist
      while(end == false)
      {
        // if current node is equal to target
        if (current.Value.Equals(target))
        {
          // Store original next value
          Node<T> oldNext = current.Next;
          // Set current Next value to the new Node
          current.Next = newNode;
          // Set the new Node's value to the original next value of target, to contiue linked list
          newNode.Next = oldNext;
          return;
        }
        else if (current.Next == null)
        {
          end = true;
        }
      current = current.Next;
      }
      throw new Exception("Could not recognize given node value.");
    }

    public void Insert(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head != null)
      {
        node.Next = Head;
      }
      Head = node;
      //Console.WriteLine($"Node: {value} added");
    }

    public bool Includes(T value)
    {
      Node<T> current = Head;
      Console.WriteLine($"Head = {Head.Value}");

      while (current != null)
      {
        if (value.Equals(current.Value))
        {
          Console.WriteLine($"The current value is: {current.Value}");
          return true;
        }
        current = current.Next;
      }
      Console.WriteLine($"Sorry, I did not recognize: \"{value}\" as a value");
      return false;
    }

    public T Print()
    {
      Node<T> current = Head;
       string list = "";

      while (current != null)
      {
        list = list + $"({current.Value}) -> ";
        current = current.Next;
      }
      list = list + "NULL";
      Console.Write(list);
      return (T) Convert.ChangeType(list, typeof(T));
    }
  }
}
