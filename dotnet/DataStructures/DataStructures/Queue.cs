using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }

    public Node<T> Back { get; set; }

    public T Peek()
    {
      if (EmptyQueue())
      {
        throw new Exception("No one is in the Queue");
      }
      return Front.Value;
    }

    public void Enqueue(T value)
    {
      Node<T> node = new(value);
      if (Front == null)
      {
        Front = node;
      }
      else
      {
        Back.Next = node;
      }
        Back = node;
    }

    public Node<T> Dequeue()
    {
      Node<T> currentFront = Front;

      Front = Front.Next;

      return currentFront;
    }

    public bool EmptyQueue()
    {
      return (Front == null);
    }
  }
}
