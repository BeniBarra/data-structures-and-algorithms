using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Stack<T> : IEnumerable<T>
  {
    public Stack stack { get; set; } = new Stack();
    public Node<T> Top { get; set; }

    public bool Peek()
    {
      //if (EmptyStack())
      //{
      //  throw new Exception("Someone forgot to make a stack");
      //}
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
      //if (EmptyStack())
      //{
      //  throw new Exception("Some one forgot to make a stack");
      //}
      Node<T> currentTop = Top;
      if (currentTop == null) throw new NullReferenceException();  
      Top = currentTop.Next;
      return currentTop.Value;
    }

    public bool EmptyStack()
    {
      return (Top == null);
    }

    public IEnumerator<Node<T>>GetEnumerator()
    {
      foreach (Node<T> node in stack)
      {
        yield return node;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return stack.GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }
}
