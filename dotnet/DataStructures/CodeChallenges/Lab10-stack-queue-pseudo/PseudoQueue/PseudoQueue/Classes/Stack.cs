using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoQueue.Classes
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }

    public bool Peek()
    {
      if (Top != null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Top;
      Top = node;
    }

    public T Pop()
    {
      Node<T> currentTop = Top;
      if (currentTop == null) throw new NullReferenceException();
      Top = currentTop.Next;
      return currentTop.Value;
    }

    public bool EmptyStack()
    {
      return (Top == null);
    }
  }
}
