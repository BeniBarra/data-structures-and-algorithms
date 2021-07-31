using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class PseudoQueue<T>
  {
    Stack<T> stack1 = new Stack<T>();
    Stack<T> stack2 = new Stack<T>();

    public void Enqueue(T val)
    {
      stack1.Push(val);
      Console.WriteLine($"{val} was pushed to stack 1");
    }

    public T Dequeue()
    {
      if (stack1.Peek() == null) throw new NullReferenceException();
      while (stack1.Peek() != null)
      {
        stack2.Push(stack1.Pop());
      }
      T tempVal = stack2.Pop();
      while (stack2.Peek() != null)
      {
        stack1.Push(stack2.Pop());
      }
      Console.WriteLine($"{tempVal} was popped off");
      return tempVal;
    }
  }
}
