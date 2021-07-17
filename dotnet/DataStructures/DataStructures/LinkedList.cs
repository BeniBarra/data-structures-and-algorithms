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

    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;
      }
      Head = node;
      Console.WriteLine($"Node: {value} added");
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
