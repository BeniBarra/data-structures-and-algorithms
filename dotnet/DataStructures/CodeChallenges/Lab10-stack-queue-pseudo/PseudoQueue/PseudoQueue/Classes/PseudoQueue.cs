using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoQueue.Classes
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
      if (!stack1.Peek()) throw new NullReferenceException();
      while (stack1.Peek())
      {
        stack2.Push(stack1.Pop());
      }
      T tempVal = stack2.Pop();
      while (stack2.Peek())
      {
        stack1.Push(stack2.Pop());
      }
      Console.WriteLine($"{tempVal} was popped off");
      return tempVal;
    }
  }
}
