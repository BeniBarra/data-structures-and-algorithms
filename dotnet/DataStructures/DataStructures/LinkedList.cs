using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {

    }

    public int kthFromEnd(int k)
    {
      int length = -1;
      Node current = Head;

      // Check is there is a list
      if (Head == null) return -2;
      //Iterates over list and sets the length to a variabnle
      while (current != null)
      {
        length++;
        current = current.Next;
      }
      // Check if target node is with in range
      if (k > length | k < 0) return -1;

      // resets current to Head
      current = Head;
      // Iterates over list until legnth - iterations equals the k target
      for (int i = length; i >= k; i--)
      {
        current = current.Next;
      }
      return current.Value;
    }

    public void Append(int value)
    {
      Node node = new Node(value);

      if (Head == null)
      {
        Head = node;
        return;
      }
    }

    public void InsertBefore(int target, int newVal)
    {
      Node newNode = new Node(newVal);
      Node current = Head;

      if (current.Value == target)
      {
        Insert(newVal);
        return;
      }
      while (current.Value != target)
      {
        // if current next value is equal to target
        if (current.Next.Value == target)
        {
          Node oldNext = current.Next;
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

    public void InsertAfter(int target, int newVal)
    {
      Node newNode = new Node(newVal);
      Node current = Head;
      bool end = false;
      // iterates over the linkedlist
      while(end == false)
      {
        // if current node is equal to target
        if (current.Value == target)
        {
          // Store original next value
          Node oldNext = current.Next;
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

    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;
      }
      Head = node;
      //Console.WriteLine($"Node: {value} added");
    }

    public bool Includes(int value)
    {
      Node current = Head;
      Console.WriteLine($"Head = {Head.Value}");

      while (current != null)
      {
        if (value == current.Value)
        {
          Console.WriteLine($"The current value is: {current.Value}");
          return true;
        }
        current = current.Next;
      }
      Console.WriteLine($"Sorry, I did not recognize: \"{value}\" as a value");
      return false;
    }

    public string Print()
    {
      Node current = Head;
      string list = "";

      while (current != null)
      {
        list = list + $"({current.Value}) -> ";
        current = current.Next;
      }
      list = list + "NULL";
      Console.Write(list);
      return list;
    }
  }
}
